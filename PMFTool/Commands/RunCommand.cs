using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocona;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Security.Cryptography;

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
			RunMode mode=RunMode.Debug,
			[Option(Description = "Enables the fly cam")]
			bool novr=false,
			[Option(Description = "The slot to start the game in set to -1 to start in menu")]
			int startSlot = -1,
			[Option(Description = "Disables rebuilding the project before running it")]
			bool nobuild=false,
			[Option(Description = "If set don't attach to the Primitier process")]
			bool detach=false)
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

			if (!nobuild)
			{
				ModBuilder.StartBuild(projectPath, config, mode);
			}
			

			var modsDirectory = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "Mods"));

			if (!modsDirectory.Exists)
			{
				ConsoleWriter.WriteLineError($"'{modsDirectory.FullName}' doesn't exist. This could be because MelonLoader is not installed properly");
				return;
			}


			if (!nobuild)
			{
				ModBuilder.WaitForBuildDone();
			}
			


			ConsoleWriter.WriteLineStatus("=== Copying new files ===");

			List<string> copiedFileNames = new List<string>();
			ConsoleWriter.WriteLineStatus($"Checking files (This could take a while if the files are the same size)");

			var files = Directory.GetFiles(binPath);
			var max = files.Length;
			ConsoleWriter.WriteCount(0, max);

			foreach (var file in files)
			{
				if (!file.EndsWith(".dll"))
				{
					continue;
				}

				
				var destFileName = Path.Combine(modsDirectory.FullName, Path.GetFileName(file));
				copiedFileNames.Add(Path.GetFileName(destFileName));

				ConsoleWriter.WriteCount(copiedFileNames.Count, max);
				if (File.Exists(destFileName))
				{
					
					try
					{
						if (FileCompare.FilesAreEqual(new FileInfo(destFileName), new FileInfo(file)))
						{
							continue;
						}
					}catch(Exception e)
					{
						ConsoleWriter.WriteLineError($"Could not read file '{destFileName}' or/and '{file}'", e);
					}
					

				}


				ConsoleWriter.WriteLineStatus($"Copying '{file}'");
				try
				{
					File.Copy(file, destFileName, true);
				}
				catch (Exception e)
				{
					ConsoleWriter.WriteLineError($"Can not copy '{file}' to {destFileName}", e);
				}

			}

			if (copiedFileNames.Count == 0)
			{
				ConsoleWriter.WriteLineError("There are no files to copied (You are probably in the wrong directory)");
			}

			ConsoleWriter.WriteLineStatus("=== Deleting old files ===");
			foreach (var file in modsDirectory.GetFiles())
			{
				if (!copiedFileNames.Contains(file.Name))
				{
					try
					{
						ConsoleWriter.WriteLineStatus($"Deleting {file.FullName}");
						file.Delete();
					}catch(Exception e)
					{
						ConsoleWriter.WriteLineError($"Could not delete file '{file.FullName}' ", e);
					}
					
				}

			}


			ConsoleWriter.WriteLineStatus("=== Starting Primitier ===");


			StringBuilder args = new StringBuilder();
			if (mode == RunMode.Debug)
			{
				args.Append(" --melonloader.debug ");
			}
			if (novr)
			{
				args.Append(" --pmf.flycam ");
			}
			if (startSlot != -1)
			{
				args.Append(" --pmf.start-slot:" + startSlot);
			}

			Process? primitierProcess = null;
			try
			{
				primitierProcess = Process.Start(new ProcessStartInfo()
				{
					Arguments = args.ToString(),
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

			if (detach)
			{
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
