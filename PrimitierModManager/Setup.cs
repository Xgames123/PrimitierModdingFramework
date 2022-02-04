using PrimitierModManager.MelonLoader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace PrimitierModManager
{
	public static class Setup
	{
		public static string UninstallError = "";

		public static string SetupPrimitierExeError = "";

		public static void SetupPrimitierExe(string primitierExeFilePath)
		{
			SetupPrimitierExeError = "";

			if (!File.Exists(primitierExeFilePath))
			{
				SetupPrimitierExeError = $"Non existing file dragged '{primitierExeFilePath}'";
				return;
			}

			if (Path.GetFileName(primitierExeFilePath) != "Primitier.exe")
			{
				SetupPrimitierExeError = "The file was not Primitier.exe";
				return;
			}


			if (ConfigFile.Config == null)
			{
				ConfigFile.Config = new ConfigFile();
			}
			ConfigFile.Config.PrimitierInstallPath = Path.GetDirectoryName(primitierExeFilePath);


			InstallMelonLoader(primitierExeFilePath, true);
			Thread.Sleep(2000);

			SetupPrimitierExeError = "";
		}

		private static void InstallMelonLoader(string primitierExePath, bool showPopup)
		{
			Task.Factory.StartNew(() => MelonInstaller.Install(Path.GetDirectoryName(primitierExePath), MelonLoaderVersions.V0_5_3, false, false)).ContinueWith(t =>
			{
				if (!showPopup)
				{
					return;
				}

				Dispatcher.CurrentDispatcher.Invoke(() => 
				{
					if (MelonInstaller.Error != "")
					{
						var result = MessageBox.Show($"Fatal error installing MelonLoader:\n{MelonInstaller.Error}\n Retry?", "Fatal error", MessageBoxButton.YesNo);

						if (result == MessageBoxResult.Yes)
						{
							InstallMelonLoader(primitierExePath, showPopup);
						}
					}

				});
			});


			

		}

		private static void UninstallMelonLoader(string primitierExePath, bool showPopup)
		{
			Task.Factory.StartNew(() => MelonInstaller.Uninstall(Path.GetDirectoryName(primitierExePath))).ContinueWith(t =>
			{
				if (!showPopup)
				{
					return;
				}

				Dispatcher.CurrentDispatcher.Invoke(() =>
				{
					if (MelonInstaller.Error != "")
					{
						var result = MessageBox.Show($"Fatal error uninstalling MelonLoader:\n{MelonInstaller.Error}\n Retry?", "Fatal error", MessageBoxButton.YesNo);

						if (result == MessageBoxResult.Yes)
						{
							InstallMelonLoader(primitierExePath, showPopup);
						}
					}

				});

			});

			

		}

		public static void Uninstall()
		{
			UninstallError = "";

			if (ConfigFile.Config == null)
			{
				ConfigFile.Load();
			}
			if (ConfigFile.Config == null)
			{
				UninstallError = "No config file found";
				return;
			}

			UninstallMelonLoader(Path.Combine(ConfigFile.Config.PrimitierInstallPath, "Primitier.exe"), false);

			try
			{
				Directory.Delete(ConfigFile.PMFDirPath, true);
			}catch (Exception e)
			{
				UninstallError = "Can delete mods folder";
				return;
			}


		}

		


	}
}
