using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Cocona;

namespace PMFTool.Commands
{
	public class UpdateDllsCommand
	{

		[PrimaryCommand()]
		public void UpdateDlls(
			[Argument(Description ="The path to project directory of the mod you want to update the dlls for")]
			string path="",
			[Option(Description = "Answers yes to all prompts")]
			bool noprompts=false)
		{



			var projectPath = Validator.ValidateProjectPath(path, out string csprojFilePath);
			if (projectPath == null)
			{
				return;
			}

			var config  = ConfigFileLoader.LoadMergedConfig(projectPath);
			if (config == null)
			{
				return;
			}

			DirectLinkCsProjFixer.LogWarning(config);

			if (config.DirectDllLink)
			{
				
				var dllDirectory = new DirectoryInfo(config.DllPath);

				if (Directory.Exists(dllDirectory.FullName))
				{
					if (noprompts)
					{
						ConsoleWriter.WriteLineWarning("There still exist a old Dlls folder run 'pmftool update-dlls' whiteout the --noprompts flag to delete it");
					}
					else
					{
						if (ConsoleWriter.AskForYesNo($"There still exist a old Dlls folder whould you like to delete it?\nHere is the full path: {dllDirectory.FullName}"))
						{
							dllDirectory.Delete(true);
						}
					}

				}

				
				

				ConsoleWriter.WriteLineStatus("Fixing .csproj file");
				DirectLinkCsProjFixer.Fix(csprojFilePath, config);
				return;
			}

			
			if (string.IsNullOrWhiteSpace(config.DllPath))
			{
				ConsoleWriter.WriteLineError("No dll path found. You can give one by creating a .pmftoolconfig or passing it as an argument into this command");
				return;
			}


			DirectoryInfo dllDir = null;

			dllDir = new DirectoryInfo(config.DllPath);

			if (!dllDir.Exists)
			{
				if (!noprompts)
				{
					if (!ConsoleWriter.AskForYesNo($"Directory '{dllDir.FullName}' doesn't exist.\nDo you want to create it?"))
					{
						return;
					}
				}
				
				Directory.CreateDirectory(dllDir.FullName);
			}

			var dllFiles = dllDir.GetFiles();

			int dllFileCount = dllFiles.Count((FileInfo file) => { return file.Extension == ".dll"; });
			if (dllFileCount < 150)
			{
				if (!noprompts)
				{
					if (!ConsoleWriter.AskForYesNo($"There are only {dllFileCount} dll files in directory '{dllDir.FullName}'. Are you sure this is the right one?"))
					{
						return;
					}
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
					file.CopyTo(Path.Combine(dllDir.FullName, file.Name), true);
					
				}

			}

			ConsoleWriter.WriteLineStatus("Copying MelonLoader.dll");
			var melonloaderDll = new FileInfo(Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "MelonLoader", "MelonLoader.dll"));
			melonloaderDll.CopyTo(Path.Combine(dllDir.FullName, "MelonLoader.dll"), true);


			DirectLinkCsProjFixer.LogWarning(config);
		}





	}
}
