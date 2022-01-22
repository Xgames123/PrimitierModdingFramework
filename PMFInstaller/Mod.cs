using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PMFInstaller
{
	[Serializable]
	public class Mod
	{
		[JsonProperty(Required=Required.Always)]
		public string DisplayName { get; set; }
		[JsonProperty(Required = Required.DisallowNull)]
		public string Author { get; set; } = "";
		[JsonProperty(Required = Required.DisallowNull)]
		public string Description { get; set; } = "";
		[JsonProperty(Required = Required.DisallowNull)]
		public string Version { get; set; } = "v1.0";

		[JsonIgnore]
		public BitmapImage Image { get; private set; }


		public Mod()
		{

		}

		public static Mod? FromFile(string modDirectory)
		{
			if (!Directory.Exists(modDirectory))
			{
				return null;
			}
			
			var modJsonPath = Path.Combine(modDirectory, "Mod.json");
			var headerImagePath = Path.Combine(modDirectory, "Header.png");

			if (!File.Exists(modJsonPath))
			{
				return null;
			}

			var mod = JsonConvert.DeserializeObject<Mod>(File.ReadAllText(modJsonPath));
			if (mod == null)
			{
				return null;
			}
			if (File.Exists(headerImagePath))
			{
				mod.Image = new BitmapImage(new Uri(headerImagePath, UriKind.Absolute));
			}


			return mod;
		}

	}
}
