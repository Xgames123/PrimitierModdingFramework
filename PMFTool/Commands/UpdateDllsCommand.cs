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
		public void UpdateDlls(
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

			if (path == "")
			{
				path = config.DllPath;
			}

			if (path == "")
			{
				path = Environment.CurrentDirectory;
			}
			path = Path.GetFullPath(path);


			if (!Directory.Exists(path))
			{
				ConsoleWriter.WriteLineError($"Directory {path} doesn't exist");
			}


			dllDir = new DirectoryInfo(path);

			if (!dllDir.Exists)
			{
				if (!ConsoleWriter.AskForYesNo($"Directory '{path}' doesn't exist. Do you want to create it?"))
				{
					return;
				}
				Directory.CreateDirectory(path);
			}


			int dllFileCount = dllDir.GetFiles().Count((FileInfo file) => { return file.Extension == ".dll"; });
			if (dllFileCount < 150)
			{
				if(!ConsoleWriter.AskForYesNo($"There are only {dllFileCount} dll files in directory '{path}'. Are you sure this is the right one?"))
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
					file.CopyTo(Path.Combine(dllDir.FullName, file.Name), true);
					
				}

			}

			ConsoleWriter.WriteLineStatus("Copying MelonLoader.dll");
			var melonloaderDll = new FileInfo(Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "MelonLoader", "MelonLoader.dll"));
			melonloaderDll.CopyTo(Path.Combine(dllDir.FullName, "MelonLoader.dll"), true);

		}





	}
}
