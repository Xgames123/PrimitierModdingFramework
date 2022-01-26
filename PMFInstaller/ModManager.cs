using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PMFInstaller
{
	public static class ModManager
	{

		public static List<Mod> LoadedMods = new List<Mod>();
		public static List<Mod> ActiveMods = new List<Mod>();

		public static event Action OnModListsUpdate;


		public static void EnableMod(Mod mod)
		{
			if (ActiveMods.Contains(mod))
			{
				return;
			}
			if (!LoadedMods.Contains(mod))
			{
				return;
			}

			LoadedMods.Remove(mod);
			ActiveMods.Add(mod);

			OnModListsUpdate?.Invoke();
		}
		public static void DisableMod(Mod mod)
		{
			if (!ActiveMods.Contains(mod))
			{
				return;
			}

			ActiveMods.Remove(mod);
			if (!LoadedMods.Contains(mod))
			{
				LoadedMods.Add(mod);
			}
			

			OnModListsUpdate?.Invoke();
		}
		


		public static void ReloadMods()
		{
			
			LoadedMods.Clear();

			ConfigFile.RebuildDirectorySturcture();

			foreach (var modPath in Directory.GetFiles(ConfigFile.PMFModsDirPath))
			{
				var mod = LoadModFromFile(modPath);
				if (mod != null)
				{
					if (LoadedMods.Contains(mod))
					{
						ErrorHandeler.ShowError("Found 2 or more mods with the same Hash");
						continue;
					}

					
					if (!ActiveMods.Contains(mod))
					{
						LoadedMods.Add(mod);
					}

				}

			}



			OnModListsUpdate?.Invoke();
		}


		public static void DeleteMod(Mod mod)
		{
			if (!File.Exists(mod.FileName))
			{
				return;
			}

			File.Delete(mod.FileName);


			ReloadMods();
		}
		public static void AddMod(string file)
		{
			if (!ValidateModFile(file, true))
			{
				return;
			}

			try
			{
				File.Copy(file, Path.Combine(ConfigFile.PMFModsDirPath, Path.GetFileName(file)), true);
			}catch (Exception e)
			{
				ErrorHandeler.ShowError("Can not copy mod files");

			}

			ReloadMods();
		}


		public static Mod? LoadModFromFile(string file)
		{
			
			var zipStream = File.OpenRead(file);
			ZipArchive zip = new ZipArchive(zipStream, ZipArchiveMode.Read, true);

			var modjsonEntry = FindEntryZip("Mod.json", zip);
			if (modjsonEntry == null)
			{
				//TODO create a Mod.json file in the zip file
				ErrorHandeler.ShowError($"Can not load mod '{file}' can not find Mod.json");
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
				ErrorHandeler.ShowError($"Can not load mod '{file}' invalid Mod.json");
				return null;
			}

			var headerEntry = FindEntryZip("Header.png", zip);
			if (headerEntry != null)
			{
				throw new NotImplementedException();
			}

			zipStream.Close();
			mod.InitUI();
			mod.FileName = file;
			return mod;
		}

		private static bool ValidateModFile(string file, bool displayErrors=false)
		{
			if (!File.Exists(file))
			{
				if (displayErrors)
					ErrorHandeler.ShowError($"Can not find mod '{file}'");
				return false;
			}

			if (Path.GetExtension(file) != ".pmfm" && Path.GetExtension(file) != ".zip")
			{
				if (displayErrors)
					ErrorHandeler.ShowError($"Mod '{file}' is not the right file type");
				return false;
			}

			ZipArchive zip=null;
			FileStream zipStream=null;
			try
			{
				zipStream = File.OpenRead(file);
				zip = new ZipArchive(zipStream, ZipArchiveMode.Read, true);
			}catch(Exception e)
			{
				if (displayErrors)
					ErrorHandeler.ShowError($"Can't read '{file}'");
				return false;
			}
			

			zipStream?.Close();
			return true;
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

			byte[] bytes = new byte[entry.Length];
			stream.Read(bytes, 0, bytes.Length);

			stream.Close();
			return bytes;
		}

	}
}
