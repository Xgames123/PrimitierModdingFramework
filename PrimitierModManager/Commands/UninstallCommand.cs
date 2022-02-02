using BetterConsole;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModManager.Commands
{
	public class UninstallCommand : Command
	{
		public override string Name => "Uninstall";

		public override string Discription => "Uninstalls PMF installer";

		public override ArgumentDescriptor[] ArgDescriptors => new ArgumentDescriptor[] { };

		protected override void OnExecute(Argument[] args)
		{
			ConfigFile.Load();
			
			Setup.Uninstall();

			ConfigFile.Config = null;

			App.Current.Shutdown();

		}
	}
}
