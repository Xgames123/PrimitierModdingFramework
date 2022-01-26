using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace PMFInstaller
{
	public static class PrimitierLauncher
	{
		public static void LaunchWithSelectedMods()
		{
			Thread.Sleep(2000);

			if (ConfigFile.Config == null)
			{
				ErrorHandeler.ShowError("Config.json not loaded");
				return;
			}

			CleanMelonModsDirectory();


			foreach (var mod in ModManager.ActiveMods)
			{
				ExtractModFiles(mod);
			}

			Process.Start(Path.Combine(ConfigFile.Config.PrimitierInstallPath, "Primitier.exe"));

			
		}

		public static void CleanMelonModsDirectory()
		{
			string melonModsDir = Path.Combine(ConfigFile.Config.PrimitierInstallPath, "Mods");

			foreach (var fileSystemEntry in Directory.GetFileSystemEntries(melonModsDir))
			{
				try
				{
					if (File.Exists(fileSystemEntry))
					{
						File.Delete(fileSystemEntry);
					}
					else
					{
						Directory.Delete(fileSystemEntry, true);
					}
				}catch(Exception e)
				{
					ErrorHandeler.ShowError($"Can not delete '{fileSystemEntry}'");
				}

			}


		}


		public static void ExtractModFiles(Mod mod)
		{
			var zip = ZipFile.OpenRead(mod.FileName);

			string melonModsDir = Path.Combine(ConfigFile.Config.PrimitierInstallPath, "Mods");
			
			zip.ExtractToDirectory(melonModsDir, true);


			zip.Dispose();
		}


	}
}
