using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocona;
using PMFTool.Validators;
using System.Diagnostics;

namespace PMFTool.Commands
{
	public enum RunMode
	{
		Debug,
		Release

	}

	public partial class RunCommand
	{
		
		[PrimaryCommand]
		public void Run(
			[Argument(Description = "The path to the directory with the dll files of the mod you want to run or an alias if you have setup one")] 
			string path,

			[Option(Description = "The path to the PMFToolConfig.json file")]
			string config="PMFToolConfig.json",

			[Option(Description = "The mode to run in")]
			RunMode mode=RunMode.Debug)
		{

			path = path.Trim();

			var configClass = ConfigFileLoader.Load(config);
			if (configClass == null)
			{
				return;
			}

			path = AliasSolver.Solve(path, mode, configClass);


			if (!Directory.Exists(path))
			{
				ConsoleWriter.WriteLineError($"The path or alias '{path}' is invalid");
				return;
			}

			ConsoleWriter.WriteLineStatus("=== Clearing mods directory ===");
			var modsDirectory = Path.Combine(Path.GetDirectoryName(configClass.PrimitierPath), "Mods");
			foreach (var file in Directory.GetFiles(modsDirectory))
			{
				ConsoleWriter.WriteLineStatus($"Deleting '{file}'");

				File.Delete(file);
			}

			ConsoleWriter.WriteLineStatus("=== Copying new files ===");

			foreach (var file in Directory.GetFiles(path))
			{
				if (!file.EndsWith(".dll"))
				{
					continue;
				}

				var destFileName = Path.Combine(modsDirectory, Path.GetFileName(file));
				ConsoleWriter.WriteLineStatus($"Copying '{file}'");
				try
				{
					File.Copy(file, destFileName);
				}
				catch (Exception e)
				{
					ConsoleWriter.WriteLineError($"Can not copy '{file}' to {destFileName}", e);
				}

			}

			ConsoleWriter.WriteLineStatus("=== Starting Primitier ===");

			string args = "";
			if (mode == RunMode.Debug)
			{
				args = "--melonloader.debug";
			}

			Process process = null;
			try
			{
				process = Process.Start(new ProcessStartInfo()
				{
					Arguments = args,
					FileName = configClass.PrimitierPath,
					RedirectStandardError = true,
					RedirectStandardOutput = true,
				});
			}
			catch (Exception e)
			{
				ConsoleWriter.WriteLineError("Can not start primitier", e);
				return;
			}
			
			if (process == null)
			{
				ConsoleWriter.WriteLineError("Can not start primitier");
				return;
			}

			while (!process.HasExited)
			{
				Console.Write(process.StandardOutput.ReadToEnd());
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(process.StandardError.ReadToEnd());
				Console.ForegroundColor = ConsoleColor.White;

				Thread.Sleep(100);
			}
			
		}

			

	}
}
