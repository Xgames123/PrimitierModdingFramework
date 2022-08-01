using HarmonyLib;
using Il2CppSystem;
using System.Reflection;
using UnityEngine;

namespace PrimitierModdingFramework.CustomSaveFileData.Patches
{
	[HarmonyPatch(typeof(SaveAndLoad), nameof(SaveAndLoad.Save))]
	public class SaveAndLoad_Save
	{
		public static void Postfix(int slot)
		{
			if (!CustomSaveFileSystem.IsEnabled)
				return;

			CustomSaveFileSystem.WriteSaveMetadata(slot);
		}

	}
}
