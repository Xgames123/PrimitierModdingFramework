using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PMFInstaller
{
	public static class ModManager
	{

		public static List<Mod> LoadedMods = new List<Mod>();

		public static event Action OnModsReloaded;

		public static void ReloadMods()
		{
			
			LoadedMods.Clear();

			ConfigFile.RebuildDirectorySturcture();

			foreach (var modPath in Directory.GetFiles(ConfigFile.ModsDirPath))
			{
				var mod = Mod.FromFile(modPath);
				if (mod != null)
				{
					LoadedMods.Add(mod);
				}
				

			}
			OnModsReloaded?.Invoke();
		}
	}
}
