using Cocona;
using PMFTool;
using PMFTool.Commands;
using System.Diagnostics;

App.Run();
[HasSubCommands(typeof(AliasCommand), "alias", Description = " 'alias create MyMod F:/Source/Repos/MyMod/MyMod/bin/Debug' and than you can type MyMod in a path and it will be replaced by the path")]
[HasSubCommands(typeof(RunCommand), "run", Description = "Copies mod files to mods directory and starts primitier")]
public class App
{

	public static void Run()
	{
		CoconaLiteApp.Run<App>();
	}


}




