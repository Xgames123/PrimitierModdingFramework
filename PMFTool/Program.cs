using BetterConsole;
using Cocona;
using PMFTool.Commands;

Command[] commands = new Command[] { new RunCommand() };

Command.RunCommand(args, new HelpCommand(commands), commands);

var appBuilder = CoconaApp.CreateBuilder();

var app = appBuilder.Build();
app.AddCommand("run",()=>
{
	


});