using PMFTool.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool
{
	public static class ModBuilder
	{
		private static Process? _dotnetBuild = null;
		private static bool _log = true;



		public static void StartBuild(string csprojDir, RunMode mode, bool log=true)
		{
			_log = log;

			if (_log)
				ConsoleWriter.WriteLineStatus("== Starting dotnet build ==");
			
			try
			{
				_dotnetBuild = Process.Start(new ProcessStartInfo()
				{
					WorkingDirectory = csprojDir,
					FileName = "dotnet",
					Arguments = $"build -c {mode}",
					RedirectStandardError = true,
					RedirectStandardOutput = true,
				});
			}
			catch (Exception e)
			{
				if (_log)
					ConsoleWriter.WriteLineError("Error starting dotnet build", e);
			}
		}

		public static void WaitForBuildDone()
		{
			WaitForDotnetBuild();




		}

		private static void WaitForDotnetBuild()
		{
			if (_dotnetBuild == null)
			{
				return;
			}

			if (_log)
				ConsoleWriter.WriteLineStatus("=== Waiting for dotnet build ===");
			if (_log)
				Console.Write('\n');
			while (true)
			{
				if (_log)
					Console.Write(_dotnetBuild?.StandardOutput.ReadToEnd());
				if (_dotnetBuild.HasExited)
				{
					var exitCode = _dotnetBuild.ExitCode;

					if (exitCode != 0)
					{
						if (_log)
							ConsoleWriter.WriteLineError($"dotnet build exited with non zero exit code: {exitCode}");
						if (_log)
							Console.WriteLine("If this looks something like this 'Could not locate the assembly \"Assembly name\"' Try running 'PMFTool update-dlls'");
						return;
					}

					break;
				}

				Thread.Sleep(400);
			}
			_dotnetBuild.Dispose();
			_dotnetBuild = null;
		}

	}
}
