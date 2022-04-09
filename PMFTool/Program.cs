using Cocona;
using PMFTool;
using PMFTool.Commands;
using System.Diagnostics;

CoconaLiteApp.Run<App>();

[HasSubCommands(typeof(RunCommand), "run", Description = "Copies mod files to mods directory and starts primitier")]
[HasSubCommands(typeof(PackCommand), "pack", Description = "Generates a mod package")]
[HasSubCommands(typeof(UpdateDllsCommand), "update-dlls", Description = "Updates the dlls in the dlls folder to the latest version of Primitier")]
public class App
{

}




