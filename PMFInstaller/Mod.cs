using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PMFInstaller
{
	[Serializable]
	public class Mod
	{
		[JsonProperty(Required = Required.Always)]
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

		public static Mod? FromFile(string pmfmFile)
		{
			if (!File.Exists(pmfmFile))
			{
				ErrorHandeler.ShowError($"Can not find mod '{pmfmFile}'");
				return null;
			}

			ZipArchive zip = new ZipArchive(File.OpenRead(pmfmFile), ZipArchiveMode.Read, false);

			var modjsonEntry = FindEntryZip("Mod.json", zip);
			if (modjsonEntry == null)
			{
				ErrorHandeler.ShowError($"Can not load mod '{pmfmFile}' can not find Mod.json");
				return null;
			}

			Mod mod = null;
			var bytes = ReadEntryZipBytes(modjsonEntry);
			try
			{
				mod = JsonConvert.DeserializeObject<Mod>(Encoding.ASCII.GetString(bytes));
			}
			catch (Exception e)
			{
				ErrorHandeler.ShowError($"Can not load mod '{pmfmFile}' invalid Mod.json");
				return null;
			}

			var headerEntry = FindEntryZip("Header.png", zip);
			if (headerEntry != null)
			{
				throw new NotImplementedException();
			}


			return mod;
		}


		private static ZipArchiveEntry? FindEntryZip(string filePath, ZipArchive zip)
		{
			foreach (var entry in zip.Entries)
			{
				if (entry.FullName == filePath)
				{
					return entry;
				}

			}

			return null;
		}

		private static byte[] ReadEntryZipBytes(ZipArchiveEntry entry)
		{
			var stream = entry.Open();

			byte[] bytes = new byte[stream.Length];
			stream.Read(bytes, 0, bytes.Length);

			stream.Close();
			return bytes;
		}


	}
}
