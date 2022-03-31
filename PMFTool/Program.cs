using Cocona;
using PMFTool;
using PMFTool.Commands;
using System.Diagnostics;

CoconaLiteApp.Run<App>();

[HasSubCommands(typeof(RunCommand), "run", Description = "Copies mod files to mods directory and starts primitier")]
[HasSubCommands(typeof(PackCommand), "pack", Description = "Generates a mod package")]
[HasSubCommands(typeof(NewModCommand), "new-mod", Description = "Generates a template cs project for a pmf mod (if you are using vs run it in the solution directory)")]
public class App
{

}




