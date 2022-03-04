using BetterConsole;
using PMFTool.Commands;

Command[] commands = new Command[] { new RunCommand() };

Command.RunCommand(args, new HelpCommand(commands), commands);