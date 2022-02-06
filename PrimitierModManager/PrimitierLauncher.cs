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

namespace PrimitierModManager
{
	public static class PrimitierLauncher
	{
		public static void LaunchWithSelectedMods()
		{
			Thread.Sleep(2000);

			if (ConfigFile.Config == null)
			{
				ConfigFile.Load();
			}

			CleanMelonModsDirectory();
			CopyProxyDllsList();

			foreach (var mod in ModManager.ActiveMods)
			{
				ExtractModFiles(mod);
			}

			Process.Start(Path.Combine(ConfigFile.Config.PrimitierInstallPath, "Primitier.exe"));

			
		}

		private static void CleanMelonModsDirectory()
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
					PopupManager.ShowError($"Can not delete '{fileSystemEntry}'");
				}

			}


		}


		private static void CopyProxyDllsList()
		{
			var proxyDllsPath = Path.Combine(ConfigFile.Config.PrimitierInstallPath, "MelonLoader", "Managed");
			var melonModsDir = Path.Combine(ConfigFile.Config.PrimitierInstallPath, "Mods");

			foreach (var proxyDll in Directory.GetFiles(proxyDllsPath))
			{
				try
				{
					File.Copy(proxyDll, Path.Combine(melonModsDir, Path.GetFileName(proxyDll)));
				}catch(Exception e)
				{
					continue;
				}

			}


		}


		private static void ExtractModFiles(Mod mod)
		{
			var zip = ZipFile.OpenRead(mod.FileName);

			string melonModsDir = Path.Combine(ConfigFile.Config.PrimitierInstallPath, "Mods");
			
			zip.ExtractToDirectory(melonModsDir, true);


			zip.Dispose();
		}


	}
}
