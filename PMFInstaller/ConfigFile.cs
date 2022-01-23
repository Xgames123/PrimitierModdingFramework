using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFInstaller
{
	[Serializable]
	public class ConfigFile
	{
		[JsonIgnore]
		public static ConfigFile Config;
		[JsonIgnore]
		public static string PMFDirPath  = null;
		public static string ModsDirPath = null;
		public static string ConfigFilePath = null;

		[JsonProperty(Required =Required.Always)]
		public string ModsDirectory;
		[JsonProperty(Required = Required.Always)]
		public string PrimitierPath;


		public static void RebuildDirectorySturcture()
		{
			try
			{
				PMFDirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal, Environment.SpecialFolderOption.Create), "PrimitierModdingFramework");
				Directory.CreateDirectory(PMFDirPath);

				ModsDirPath = Path.Combine(PMFDirPath, "Mods");
				Directory.CreateDirectory(ModsDirPath);

				ConfigFilePath = Path.Combine(PMFDirPath, "PMFInstallerConfig.json");
			}
			catch (Exception e)
			{
				ErrorHandeler.ShowError("Can not rebuild directory structure");
			}
		


		}


		public static void Load()
		{
			RebuildDirectorySturcture();
			try
			{
				Config = JsonConvert.DeserializeObject<ConfigFile>(File.ReadAllText(ConfigFilePath));
			}catch(Exception e)
			{
				Config = null;
			}
			
		}
		public static void Save()
		{
			File.WriteAllText(ConfigFilePath, JsonConvert.SerializeObject(Config));

		}


	}
}
