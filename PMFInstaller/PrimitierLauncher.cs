using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PMFInstaller
{
	public static class PrimitierLauncher
	{
		public static void LaunchAndExit()
		{
			if (ConfigFile.Config == null)
			{
				ErrorHandeler.ShowError("Config.json not loaded");
				return;
			}

			Process.Start(Path.Combine(ConfigFile.Config.PrimitierPath, "Primitier.exe"));

			App.MainWindow.Close();
		}

	}
}
