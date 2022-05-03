using Cocona;
using PMFTool;
using PMFTool.Commands;
using System.Diagnostics;

CoconaLiteApp.Run<App>();

[HasSubCommands(typeof(RunCommand), "run", Description = "Copies mod files to mods directory and starts primitier")]
[HasSubCommands(typeof(PackCommand), "pack", Description = "Generates a mod package")]
[HasSubCommands(typeof(UpdateDllsCommand), "update-dlls", Description = "Copies the latest proxy dlls to the folder specified by path or .pmftoolconfig")]
[HasSubCommands(typeof(UpdateDllsCommand), "update-pmf", Description = "Updates your project to a newer version of pmf")]
public class App
{

}




