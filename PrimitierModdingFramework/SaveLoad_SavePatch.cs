using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace PrimitierModdingFramework
{
	[HarmonyPatch(nameof(SaveAndLoad), nameof(SaveAndLoad.Save))]
	public class SaveLoad_SavePatch
	{

		public static void Postfix(int slot)
		{
			if (CustomWorldDataSystem.IsEnabled)
			{
				CustomWorldDataSystem.WriteCubeBehavioursDataToSaveFile();

			}

		}

	}
}
