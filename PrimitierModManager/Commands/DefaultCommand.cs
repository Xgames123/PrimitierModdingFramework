using BetterConsole;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModManager.Commands
{
	public class DefaultCommand : Command
	{
		public override string Name => "Start";

		public override string Discription => "Starts PMF installer as normal";

		public override ArgumentDescriptor[] ArgDescriptors => Array.Empty<ArgumentDescriptor>();

		protected override void OnExecute(Argument[] args)
		{

			new MainWindow();
			App.MainWindow.Show();

			ConfigFile.Load();

			var IsAlreadyRunning = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count() > 1;

			if (IsAlreadyRunning)
			{
				App.Current.Shutdown();
				return;
			}

			Setup.CheckForUpdates();

		}


	}
}
