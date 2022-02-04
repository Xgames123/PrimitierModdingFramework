using BetterConsole;
using PrimitierModManager.Commands;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PrimitierModManager
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static MainWindow MainWindow = null;
		
		private void ParseCommandLine()
		{
			var commandLine = Environment.GetCommandLineArgs();

			if (commandLine.Length == 0)
			{
				new DefaultCommand().Execute(null);
				return;
			}

			var args = new string[commandLine.Length - 1];
			Array.Copy(commandLine, 1, args, 0, args.Length);

			if (args.Length > 0)
			{
				if (File.Exists(args[0]))
				{
					new DefaultCommand().Execute(null);
					ModManager.AddMod(args[0]);
					return;
				}

			}


			Command.RunCommand(args, new DefaultCommand(), new UninstallCommand());
		}


		private void Application_Startup(object sender, StartupEventArgs e)
		{
			ParseCommandLine();

		}

		private void Application_Exit(object sender, ExitEventArgs e)
		{
			if (ConfigFile.Config != null)
			{
				ConfigFile.Save();
			}


		}
	}
}
