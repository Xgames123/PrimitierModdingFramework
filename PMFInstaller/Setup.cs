using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PMFInstaller
{
	public static class Setup
	{

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

			
			SetupPrimitierExeError = "";
		}

		private static void InstallMelonLoader(string PrimitierExePath)
		{


		}

	}
}
