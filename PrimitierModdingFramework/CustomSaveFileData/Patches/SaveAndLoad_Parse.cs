using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace PrimitierModdingFramework.CustomSaveFileData.Patches
{
	[HarmonyPatch(typeof(SaveAndLoad), nameof(SaveAndLoad.Parse))]
	public class SaveAndLoad_Parse
	{
		
		public static void Postfix(int slot)
		{
			CustomSaveFileSystem.LastParsedSaveSlot = slot;
		}
	}
}
