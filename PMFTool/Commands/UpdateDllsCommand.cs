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

			DirectoryInfo dllDir = null;

			var config  = ConfigFileLoader.LoadMergedConfig();

			if (!File.Exists(config.PrimitierPath))
			{
				ConsoleWriter.WriteLineError($"Could not find primitier exe'{config.PrimitierPath}'");
				return;
			}


			path = Path.GetFullPath(path);


			if (!Directory.Exists(path))
			{
				ConsoleWriter.WriteLineError($"Directory {path} doesn't exist");

				if (path == "")
				{
					if (ConsoleWriter.AskForYesNo("Would you like to search for the folder") == true)
					{
						var dirs = SearchForDllsFolder();
						if (dirs.Count == 0)
						{
							ConsoleWriter.WriteLineError("There were no directories found");
							return;
						}

						foreach (var foundDir in dirs)
						{
							if (ConsoleWriter.AskForYesNo($"Found directory '{foundDir}'. Would you like to use this one"))
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
			}

			dllDir = new DirectoryInfo(path);


			int dllFileCount = dllDir.GetFiles().Count((FileInfo file) => { return file.Extension == ".dll"; });
			if (dllFileCount < 150)
			{
				if(!ConsoleWriter.AskForYesNo($"There are only {dllFileCount} dll files in this directory. Are you sure this is the right one"))
				{
					return;
				}
			}

			var proxyDllDir = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "MelonLoader", "Managed"));

			if (!proxyDllDir.Exists)
			{
				ConsoleWriter.WriteLineError($"'{proxyDllDir.FullName}' doesn't exist. This could be because MelonLoader is not installed properly");
				return;
			}


			foreach (var file in proxyDllDir.GetFiles())
			{
				if (file.Extension == ".dll" || file.Extension == ".xml")
				{
					ConsoleWriter.WriteLineStatus($"Copying '{file.FullName}' to '{dllDir.FullName}'");
					file.CopyTo(dllDir.FullName, true);
					
				}

			}

			ConsoleWriter.WriteLineStatus("Copying MelonLoader.dll");
			var melonloaderDll = new FileInfo(Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "MelonLoader", "MelonLoader.dll"));
			melonloaderDll.CopyTo(dllDir.FullName, true);

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
