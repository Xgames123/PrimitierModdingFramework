using Cocona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Commands
{
	public class UpdatePmfCommand
	{
		[PrimaryCommand]
		public void UpdatePmf(
			[Argument(Description = "The version to update to")]
			string newVersion,
			[Argument(Description ="The path to project directory of the mod you want to update")]
			string path = "") 
		{

			string targetVersion = ValidateNewVersion(newVersion);


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

			var projectPathInfo = new DirectoryInfo(projectPath);

			DirectoryInfo? pmfLib = null;
			string? oldVersion = null;
			FileInfo? csprojFile = null;
			foreach (var file in projectPathInfo.GetFiles())
			{
				if (file.Extension == ".csproj")
				{
					csprojFile = file;
					break;
				}

			}
			foreach (var dir in projectPathInfo.GetDirectories())
			{
				if (dir.Name.StartsWith("PMFLibV"))
				{
					pmfLib = dir;
					oldVersion = pmfLib.Name.Substring(7);
					break;
				}

			}

			if (csprojFile == null)
			{
				ConsoleWriter.WriteLineError("Could not find a *.csproj file");
				return;
			}

			if(pmfLib == null)
			{
				ConsoleWriter.WriteLineError("Could not find PMFLibV* directory. \nThis could be because the project is not setup using the template or it is an old project");
				return;
			}

			PmfUpdater.Update(projectPathInfo, csprojFile, pmfLib, targetVersion);


			


		}

		private static string ValidateNewVersion(ReadOnlySpan<char> input)
		{
			StringBuilder sb = new StringBuilder();
			foreach (var character in input)
			{
				if (character == ' ')
				{
					continue;
				}

				char append = char.ToLower(character);


				sb.Append(append);

			}

			if (sb[0] != 'v')
			{
				sb.Insert(0, 'v');
			}


			return sb.ToString();
		}


	}
}
