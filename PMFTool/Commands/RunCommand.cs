using BetterConsole;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Commands
{
	public enum RunMode
	{
		Debug,
		Release

	}

	public class RunCommand : Command
	{
		public override string Name => "run";

		public override string Discription => "Runs the mod";

		public override ArgumentDescriptor[] ArgDescriptors => new ArgumentDescriptor[] {new ArgumentDescriptor("Path", "The path to the directory with the dll files of the mod you want to run"), new ArgumentDescriptor("PMFToolConfig", "The path to the PMFToolConfig.json file", "PMFToolConfig.json"), new ArgumentDescriptor("Mode", "The mode to run in (Debug/Release)", "Debug") };

		protected override void OnExecute(Argument[] args)
		{
			string path = args[0].Value;
			string pmfToolConfigFile = args[1].Value;
			RunMode mode = Enum.Parse<RunMode>(args[2].Value);

			var config = ConfigFileLoader.Load(pmfToolConfigFile);
			if (config == null)
			{
				return;
			}

			if (!Directory.Exists(path))
			{
				ConsoleWriter.WriteLineError($"The path '{path}' is invalid");
				return;
			}

			ConsoleWriter.WriteLineStatus("=== Clearing mods directory ===");
			var modsDirectory = Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "Mods");
			foreach (var file in Directory.GetFiles(modsDirectory))
			{
				ConsoleWriter.WriteLineStatus($"Deleting '{file}'");
				
			}

			ConsoleWriter.WriteLineStatus("=== Copying new files ===");

			foreach (var file in Directory.GetFiles(path))
			{
				if (!file.EndsWith(".dll"))
				{
					continue;
				}

				var destFileName = Path.Combine(modsDirectory, Path.GetFileName(file));
				ConsoleWriter.WriteLineStatus($"Copying '{file}' to {destFileName}");
				//try
				//{
				//	File.Copy(file, destFileName);
				//}
				//catch (Exception e)
				//{
				//	ConsoleWriter.WriteLineError($"Can not copy '{file}' to {destFileName}", e);
				//}

			}

			ConsoleWriter.WriteLineStatus("=== Starting Primitier ===");
			
		}
	}
}
