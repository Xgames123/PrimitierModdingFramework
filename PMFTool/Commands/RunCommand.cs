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
			[Argument(Description = "The path to the directory of the mod you want to run")] 
			string path="",

			[Option(Description = "The mode to run in")]
			RunMode mode=RunMode.Debug)
		{

			var config = ConfigFileLoader.LoadMergedConfig();

			if (!File.Exists(config.PrimitierPath))
			{
				ConsoleWriter.WriteLineError($"Could not find primitier exe'{config.PrimitierPath}'");
				return;
			}

			if (path == "")
			{
				path = Environment.CurrentDirectory;
			}
			path = Path.GetFullPath(path);

			var projPath = (string)path.Clone();

			if (mode == RunMode.Debug)
			{
				if (config.DebugBinPath != "")
				{
					path = Path.Combine(path, config.DebugBinPath);
				}
			}
			else if (mode == RunMode.Release)
			{
				if (config.ReleaseBinPath != "")
				{
					path = Path.Combine(path, config.ReleaseBinPath);
				}
			}

			if (!Directory.Exists(path))
			{
				ConsoleWriter.WriteLineError($"The directory '{path}' doesn't exist");
				return;
			}

			ConsoleWriter.WriteLineStatus("== Starting dotnet build ==");
			Process? dotnetBuild = null;
			try
			{
				dotnetBuild = Process.Start(new ProcessStartInfo()
				{
					WorkingDirectory = projPath,
					FileName = "dotnet",
					Arguments = $"build -c {mode}",
					RedirectStandardError = true,
					RedirectStandardOutput = true,
				});
			}catch(Exception e)
			{
				ConsoleWriter.WriteLineError("Error starting dotnet build", e);
			}


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


			ConsoleWriter.WriteLineStatus("=== Waiting for dotnet build ===");
			Console.Write('\n');
			while (true)
			{
				Console.Write(dotnetBuild?.StandardOutput.ReadToEnd());
				if (dotnetBuild.HasExited)
				{
					var exitCode = dotnetBuild.ExitCode;

					if(exitCode != 0)
					{
						ConsoleWriter.WriteLineError($"dotnet build exited with non zero exit code: {exitCode}");
						Console.WriteLine("If this looks something like this 'Could not locate the assembly \"Assembly name\"' Try running 'PMFTool update-dlls'");
						return;
					}
					
					break;
				}

				Thread.Sleep(400);
			}
			dotnetBuild.Dispose();



			ConsoleWriter.WriteLineStatus("=== Copying new files ===");

			int copiedFileCount = 0;
			foreach (var file in Directory.GetFiles(path))
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

			Process? process = null;
			try
			{
				process = Process.Start(new ProcessStartInfo()
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
