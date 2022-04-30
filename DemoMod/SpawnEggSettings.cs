using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;

namespace DemoMod
{
	public static class SpawnEggSettings
	{
		public static MelonPreferences_Entry<bool> AutoHatchEntry;


		private static MelonPreferences_Category _spawnEggSettingsCategory = null;


		public static void LoadFromMelonPreferences()
		{
			// Note: this loads data from the MelonPreferences not from the save file
			// (If you change your save file this will not change)
			if (_spawnEggSettingsCategory == null)
			{
				_spawnEggSettingsCategory = MelonPreferences.CreateCategory("SpawnEggSettings");
				AutoHatchEntry = _spawnEggSettingsCategory.CreateEntry("AutoHatch", false);
			}

			

			
		}



	}
}
