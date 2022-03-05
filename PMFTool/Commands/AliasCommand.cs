using Cocona;
using PMFTool.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Commands
{
	public class AliasCommand
	{

		[Command(Description ="Creates a new alias")]
		public void Create(
			[Argument(Description ="The name of the alias")]
			string name,

			[Argument(Description = "The value of the alias")]
			string value,

			[Option(Description = "The runMode for the alias to be active or null for all runModes")]
			RunMode? mode=null,

			[Option(Description = "The path to the PMFToolConfig.json file to add the alias into")]
			string config="PMFToolConfig.json")
		{
			var configClass = ConfigFileLoader.Load(config);

			var newAlias = new Alias(name, value, mode);

			for (int i = 0; i < configClass.Aliases.Count; i++)
			{
				Alias alias = configClass.Aliases[i];
				if (alias.Name == name && alias.RunMode == mode)
				{
					configClass.Aliases[i] = newAlias;
					ConfigFileLoader.SaveConfig(config, configClass);
					return;
				}

			}
			
			configClass.Aliases.Add(newAlias);

			ConfigFileLoader.SaveConfig(config, configClass);
		}

		[Command(Description = "Creates a new alias")]
		public void Remove(
			[Argument(Description ="The name of the alias")]
			string name,
			[Option(Description = "The runMode the alias is created in or null for all runModes")]
			RunMode? mode=null,
			[Option(Description = "The path to the PMFToolConfig.json file to remove the alias from")]
			string config="PMFToolConfig.json")
		{
			var configClass = ConfigFileLoader.Load(config);

			for (int i = 0; i < configClass.Aliases.Count; i++)
			{
				Alias alias = configClass.Aliases[i];
				if (alias.Name == name && alias.RunMode == mode)
				{
					configClass.Aliases.Remove(alias);
					break;
				}
			}

			ConfigFileLoader.SaveConfig(config, configClass);
		}

		[Command(Description = "Lists all aliases")]
		public void List(
			[Option(Description = "The path to the PMFToolConfig.json where to list the aliases from")]
			string config="PMFToolConfig.json")
		{
			var configClass = ConfigFileLoader.Load(config);

			Console.WriteLine();
			foreach (var alias in configClass.Aliases)
			{
				if (alias.RunMode != null)
				{
					Console.Write($"(RunMode: {alias.RunMode}) ");
				}

				Console.Write(alias.Name);
				Console.Write(" => ");
				Console.Write("'"+alias.Value+"'\n");
			}

		}

	}
}
