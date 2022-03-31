using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocona;
using PMFTool.ProjectGeneration;

namespace PMFTool.Commands
{
	public class NewModCommand
	{

		[PrimaryCommand()]
		public void Mod(
			[Argument(Description = "name of your mod")]
			string name,
			[Option(Description = "authors of your mod")]
			string? authors=null,
			[Option(Description = "description of your mod")]
			string? description=null
			)
		{
			var match = TemplateFiles.ModNameRegex.Match(name);
			if (match.Length != name.Length)
			{
				ConsoleWriter.WriteLineError($"'{name}' is not a valid mod name");
				return;
			}

			if (authors == null)
			{
				authors = ConsoleWriter.AskForString("Witch are the authors of your mod (use ; to as a separator)", (string? awnser) => 
				{
					if (awnser == null || awnser.Length == 0)
					{
						return false;
					}

				
					return true;
				});
			}
			if (description == null)
			{
				description = ConsoleWriter.AskForString("What is the description of your mod?");
			}



			string modDir = Path.Combine(Environment.CurrentDirectory, name);
			Directory.CreateDirectory(modDir);

			//EntryPoint.cs
			ConsoleWriter.WriteLineStatus("Writing entry point file");
			File.WriteAllText(Path.Combine(modDir, name+".cs"), TemplateFiles.ModEntryPointCs.Replace("$$MODNAME$$", name));
			

			var propertiesDir = Path.Combine(modDir, "Properties");
			Directory.CreateDirectory(propertiesDir);

			//AssemblyInfo.cs
			ConsoleWriter.WriteLineStatus("Writing AssemblyInfo.cs");
			File.WriteAllText(Path.Combine(propertiesDir, "AssemblyInfo.cs"), TemplateFiles.AssemblyInfoCs.Replace("$$MODNAME$$", name).Replace("$$MODVERSION$$", "1.0").Replace("$$MODDESCRIPTION$$", description).Replace("$$MODAUTHORS$$", authors));


		}


	}
}
