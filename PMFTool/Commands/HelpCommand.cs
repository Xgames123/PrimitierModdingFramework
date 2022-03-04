using BetterConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Commands
{
	public class HelpCommand : Command
	{
		public override string Name => "help";

		public override string Discription => "PMF Tool is a tool for building and running pmf mods";

		public override ArgumentDescriptor[] ArgDescriptors => Array.Empty<ArgumentDescriptor>();

		private Command[] _commands;

		public HelpCommand(params Command[] commands)
		{
			_commands = commands;
		}


		private void CommandToHelp(Command command, StringBuilder stringBuilder)
		{
			
			stringBuilder.Append(command.Name);
			stringBuilder.Append(" ");
			foreach (var argDescriptor in command.ArgDescriptors)
			{

				stringBuilder.Append("{");
				stringBuilder.Append(argDescriptor.Name);
				if (argDescriptor.DefaultValue != "")
				{
					stringBuilder.Append(":'");
					stringBuilder.Append(argDescriptor.DefaultValue);
					stringBuilder.Append("' ");
				}
				stringBuilder.Append("} ");
			}
			stringBuilder.AppendLine(command.Discription);

			foreach (var argDescriptor in command.ArgDescriptors)
			{
				stringBuilder.Append("  ");
				stringBuilder.Append(argDescriptor.Name);
				if (argDescriptor.DefaultValue != "")
				{
					stringBuilder.Append(":'");
					stringBuilder.Append(argDescriptor.DefaultValue);
					stringBuilder.Append("' ");
				}
				else
				{
					stringBuilder.Append(": ");

				}
				
				stringBuilder.Append(argDescriptor.Description);
				stringBuilder.Append("\n");
			}

		}


		protected override void OnExecute(Argument[] args)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(Discription);
			sb.AppendLine("=== Commands ===");
			foreach (var command in _commands)
			{
				CommandToHelp(command, sb);
			}

			Console.WriteLine(sb.ToString());

		}
	}
}
