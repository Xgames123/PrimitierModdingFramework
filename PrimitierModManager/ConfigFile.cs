using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModManager
{
	[Serializable]
	public class ConfigFile
	{
		[JsonIgnore] public static ConfigFile? Config;
		[JsonIgnore] public static string PMFDirPath  = null;
		[JsonIgnore] public static string PMFModsDirPath = null;
		[JsonIgnore] public static string ConfigFilePath = null;

		[JsonProperty(Required = Required.Always)]
		public string PrimitierInstallPath;

		[JsonProperty(Required = Required.DisallowNull)]
		public string[] ActiveMods = new string[0];

		public static void RebuildDirectorySturcture()
		{
			try
			{
				PMFDirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal, Environment.SpecialFolderOption.Create), "PrimitierModdingFramework");
				Directory.CreateDirectory(PMFDirPath);

				PMFModsDirPath = Path.Combine(PMFDirPath, "Mods");
				Directory.CreateDirectory(PMFModsDirPath);

				ConfigFilePath = Path.Combine(PMFDirPath, "PMFInstallerConfig.json");
			}
			catch (Exception e)
			{
				PopupManager.ShowError("Can not rebuild directory structure");
			}
		


		}


		public static void Load()
		{
			if (Config != null)
			{
				return;
			}

			RebuildDirectorySturcture();
			try
			{
				Config = JsonConvert.DeserializeObject<ConfigFile>(File.ReadAllText(ConfigFilePath));
			}catch(Exception e)
			{
				Config = null;
				if (App.MainWindow != null)
				{
					App.MainWindow.SwitchMenu(1);
				}
				
			}
			
		}
		public static void Save()
		{
			if (Config == null)
			{
				return;
			}

			File.WriteAllText(ConfigFilePath, JsonConvert.SerializeObject(Config));

		}


	}
}
