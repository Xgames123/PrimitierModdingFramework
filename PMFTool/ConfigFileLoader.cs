using BetterConsole.UI;
using Newtonsoft.Json;
using Sini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool
{



	public class ConfigFile
	{
		public string PrimitierPath = "";
		public string DebugBinPath = "";
		public string ReleaseBinPath = "";


	}



	public static class ConfigFileLoader
	{
		public static readonly string EmptyConfigTemplate =
@"; configuration file from pmf tool

; REQUIRED change this to the full path of Primitier.exe
PrimitierPath=

; OPTIONAL relative path to the working directory to pull the files from when packing a mod in debug mode
;DebugBinPath=/bin/Debug
; OPTIONAL relative path to the working directory to pull the files from when packing a mod in release mode
;ReleaseBinPath=/bin/Release
";


		public static ConfigFile LoadConfig(string file, ConfigFile populate=null, bool generateIfNotExist=false)
		{

			if (populate == null)
			{
				populate = new ConfigFile();
			}

			if (File.Exists(file))
			{
				try
				{
					IniFile.ToObject<ConfigFile>(ref populate, new IniFile(file), null, flags: IniFile.ParseObjectFlags.AllowMissingFields);
				}catch(FormatException e)
				{
					ConsoleWriter.WriteLineError(e.Message);
				}
				
			}
			else
			{
				if (generateIfNotExist)
				{
					File.WriteAllText(file, EmptyConfigTemplate);
				}
				
			}

			return populate;

		}

		public static ConfigFile LoadGlobalConfig()
		{
			var globalPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".pmftoolconfig");

			return LoadConfig(globalPath, generateIfNotExist:true);
		}



		public static ConfigFile LoadMergedConfig()
		{
			var config = LoadGlobalConfig();

			return LoadConfig(".pmftoolconfig", config);
		}


	}
}
