using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocona;
using PMFTool.ProjectGeneration;

namespace PMFTool.Commands
{
	public class UpdateDllsCommand
	{

		[PrimaryCommand()]
		public void Mod(
			[Argument(Description ="The path to the dlls folder")]
			string path="")
		{

			var config = ConfigFileLoader.LoadMergedConfig();

			if (!File.Exists(config.PrimitierPath))
			{
				ConsoleWriter.WriteLineError($"Could not find primitier exe'{config.PrimitierPath}'");
				return;
			}


			if (path == "")
			{
				if(ConsoleWriter.AskForYesNo("no valid path was given. Would you like to search for the folder") == true)
				{
					var dirs = SearchForDllsFolder();
					if (dirs.Count == 0)
					{
						ConsoleWriter.WriteLineError("There were no directories found");
						return;
					}

					foreach (var foundDir in dirs)
					{
						if(ConsoleWriter.AskForYesNo($"Found directory '{foundDir}'. Would you like to use this one"))
						{
							path = foundDir.FullName;
							break;
						}

					}

				}
				else
				{
					return;
				}

			}


			if (!Path.IsPathRooted(path))
			{
				path = Path.Combine(Environment.CurrentDirectory, path);
			}

			if (!Directory.Exists(path))
			{
				ConsoleWriter.WriteLineError($"Directory {path} doesn't exist");
			}



			var fileCount = Directory.GetFiles(path).Length;
			if (fileCount < 4)
			{
				if(!ConsoleWriter.AskForYesNo($"There are only {fileCount} files in this directory. Are you sure this is the right one"))
				{
					return;
				}
			}


		}


		private static IReadOnlyList<DirectoryInfo> SearchForDllsFolder()
		{
			List<DirectoryInfo> foundPaths = new List<DirectoryInfo>();
			var workingDir = new DirectoryInfo(Environment.CurrentDirectory);


			SearchDir(workingDir, foundPaths);

			SearchDir(workingDir.Parent, foundPaths);


			return foundPaths;
		}

		private static void SearchDir(DirectoryInfo dir, List<DirectoryInfo> pathsList)
		{
			ConsoleWriter.WriteLineStatus($"Searching {dir.Name}");
			if (!dir.Exists)
			{
				return;
			}

			foreach (var folder in dir.GetDirectories())
			{
				var name = folder.Name.ToLower();

				if (name.Contains("dll"))
				{
					pathsList.Add(folder);
				}

			}

			return;
		}



	}
}
