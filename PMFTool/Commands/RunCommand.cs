using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocona;
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
			[Argument(Description = "The path to the project directory of the mod you want to run")] 
			string path="",

			[Option(Description = "The mode to run in")]
			RunMode mode=RunMode.Debug)
		{

			var projectPath = Validator.ValidateProjectPath(path);
			if (projectPath == null)
			{
				return;
			}

			var config = ConfigFileLoader.LoadMergedConfig(projectPath);
			if (config == null)
			{
				return;
			}

			string? binPath = Validator.ValidateBinPath(config, projectPath, mode);
			if (binPath == null)
			{ 
				return; 
			}

			ModBuilder.StartBuild(projectPath, mode);


			ConsoleWriter.WriteLineStatus("=== Clearing mods directory ===");
			var modsDirectory = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "Mods"));

			if (!modsDirectory.Exists)
			{
				ConsoleWriter.WriteLineError($"'{modsDirectory.FullName}' doesn't exist. This could be because MelonLoader is not installed properly");
				return;
			}


			foreach (var file in modsDirectory.GetFiles())
			{
				ConsoleWriter.WriteLineStatus($"Deleting '{file.FullName}'");

				file.Delete();
			}


			ModBuilder.WaitForBuildDone();



			ConsoleWriter.WriteLineStatus("=== Copying new files ===");

			int copiedFileCount = 0;
			foreach (var file in Directory.GetFiles(binPath))
			{
				if (!file.EndsWith(".dll"))
				{
					continue;
				}

				var destFileName = Path.Combine(modsDirectory.FullName, Path.GetFileName(file));
				ConsoleWriter.WriteLineStatus($"Copying '{file}'");
				try
				{
					File.Copy(file, destFileName);
					copiedFileCount++;
				}
				catch (Exception e)
				{
					ConsoleWriter.WriteLineError($"Can not copy '{file}' to {destFileName}", e);
				}

			}
			if (copiedFileCount == 0)
			{
				ConsoleWriter.WriteLineError("There are no files to copied (You are probably in the wrong directory)");
			}

			ConsoleWriter.WriteLineStatus("=== Starting Primitier ===");

			string args = "";
			if (mode == RunMode.Debug)
			{
				args = "--melonloader.debug";
			}

			Process? primitierProcess = null;
			try
			{
				primitierProcess = Process.Start(new ProcessStartInfo()
				{
					Arguments = args,
					FileName = config.PrimitierPath,
					RedirectStandardError = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
				});
			}
			catch (Exception e)
			{
				ConsoleWriter.WriteLineError("Can not start primitier", e);
				return;
			}
			
			if (primitierProcess == null)
			{
				ConsoleWriter.WriteLineError("Can not start primitier");
				return;
			}

			while (!primitierProcess.HasExited)
			{
				Console.Write(primitierProcess.StandardOutput.ReadToEnd());
				Console.Write(primitierProcess.StandardError.ReadToEnd());

				Thread.Sleep(100);
			}
			
		}

			

	}
}
