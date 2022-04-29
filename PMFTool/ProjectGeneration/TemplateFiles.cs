using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PMFTool.ProjectGeneration
{
	public static class TemplateFiles
	{
		public static readonly Regex ModNameRegex = new Regex("[A-Za-z_]+");


		public static string AssemblyInfoCs =
@"using MelonLoader;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle(BuildInfo.Name)]
[assembly: AssemblyDescription(BuildInfo.Description)]
[assembly: AssemblyConfiguration("""")]
[assembly: AssemblyCompany(BuildInfo.Authors)]
[assembly: AssemblyProduct(BuildInfo.Name)]
[assembly: AssemblyCopyright(""Copyright ©  2022"")]
[assembly: AssemblyTrademark("""")]
[assembly: AssemblyCulture("""")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion(BuildInfo.Version)]

[assembly: AssemblyVersion(BuildInfo.Version)]
[assembly: AssemblyFileVersion(BuildInfo.Version)]
[assembly: MelonInfo(typeof($$MODNAME$$.$$MODNAME$$), BuildInfo.Description, BuildInfo.Version, BuildInfo.Authors)]
[assembly: MelonGame(""PrimitierDev"", ""Primitier"")]

internal class BuildInfo
{
	public const string Name = ""$$MODNAME$$""
	public const string Version = ""$$MODVERSION$$"";
	public const string Description = ""$$MODDESCRIPTION$$"";
	public const string Authors = ""$$MODAUTHORS$$"";
}";

		public static string ModEntryPointCs =
@"using Il2CppSystem;
using PrimitierModdingFramework;
using UnityEngine;

namespace $$MODNAME$$
{

	public class $$MODNAME$$ : PrimitierMod
    {


		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{

			base.OnSceneWasLoaded(buildIndex, sceneName);

		}


		public override void OnApplicationStart()
		{
			base.OnApplicationStart();

			PMFSystem.EnableSystem<PMFHelper>();
		}

		public override void OnUpdate()
		{
			base.OnUpdate();

		}

		public override void OnFixedUpdate()
		{
			base.OnFixedUpdate();

		}
	}
}
";

	}
}
