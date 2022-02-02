using BetterConsole;
using System;
using System.Collections.Generic;
using System.Linq;
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
		}
	}
}
