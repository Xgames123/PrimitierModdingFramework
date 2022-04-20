using PMFTool.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool
{
	public static class Validator
	{

		public static string? ValidateBinPath(ConfigFile config, string projectPath, RunMode mode, bool log=true)
		{
			string? binPath = null;
			if (mode == RunMode.Debug)
			{
				binPath = config.DebugBinPath;
			}
			else if (mode == RunMode.Release)
			{
				binPath = config.ReleaseBinPath;
			}


			if (string.IsNullOrEmpty(binPath))
			{
				if (log)
					ConsoleWriter.WriteLineError($"No bin path for mode '{mode}' specified in a config file");
				return null;
			}
			binPath = Path.Combine(projectPath, binPath);
			try
			{
				Directory.CreateDirectory(binPath);
			}
			catch (Exception e)
			{
				ConsoleWriter.WriteLineError($"Could not create bin directory '{binPath}'", e);
				return null;
			}

			return binPath;
		}


		public static string? ValidateProjectPath(string projectPath, bool log=true)
		{
			if (string.IsNullOrWhiteSpace(projectPath))
			{
				projectPath = Environment.CurrentDirectory;
			}

			projectPath = Path.GetFullPath(projectPath);

			var projectPathInfo = new DirectoryInfo(projectPath);
			if (!projectPathInfo.Exists)
			{
				if (log)
					ConsoleWriter.WriteLineError($"projectPath '{projectPath}' doesn't exist or isn't a directory");
				return null;
			}

			bool foundcsproj = false;
			foreach (var file in projectPathInfo.EnumerateFiles())
			{
				if (file.Extension == ".csproj")
				{
					foundcsproj = true;
					break;
				}

			}
			if (!foundcsproj)
			{
				if (log)
					ConsoleWriter.WriteLineError($"projectPath '{projectPath}' doesn't contain a *.csproj file.\nAre you sure you are in the right directory?");
				return null;
			}


			return projectPath;
		}
	}
}
