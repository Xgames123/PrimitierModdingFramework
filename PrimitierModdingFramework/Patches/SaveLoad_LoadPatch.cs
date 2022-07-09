using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace PrimitierModdingFramework.Patches
{
	[HarmonyPatch(nameof(SaveAndLoad), nameof(SaveAndLoad.Load))]
	public class SaveLoad_LoadPatch
	{

		public static void Postfix(SaveAndLoad.SaveData data)
		{
			if (CustomWorldDataSystem.IsEnabled)
			{
				CustomWorldDataSystem.CustomCubeBehaviourData.Clear();
			}

		}
	}
}
