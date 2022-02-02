using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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


			InstallMelonLoader(primitierExeFilePath);
			Thread.Sleep(2000);

			SetupPrimitierExeError = "";
		}

		private static void InstallMelonLoader(string PrimitierExePath)
		{


		}

		private static void UninstallMelonLoader(string PrimitierExePath)
		{
			



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

			UninstallMelonLoader(Path.Combine(ConfigFile.Config.PrimitierInstallPath, "Primitier.exe"));

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
