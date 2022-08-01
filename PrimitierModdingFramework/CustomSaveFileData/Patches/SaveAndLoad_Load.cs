using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Threading.Tasks;
using System.Reflection;
using UnityEngine;

namespace PrimitierModdingFramework.CustomSaveFileData.Patches
{
	[HarmonyPatch(typeof(SaveAndLoad), nameof(SaveAndLoad.Load))]
	public class SaveAndLoad_Load
	{
		public static void Prefix(ref SaveAndLoad.SaveData saveData)
		{
			if (!CustomSaveFileSystem.IsEnabled)
				return;

			saveData = CustomSaveFileSystem.ReadMetaDataFile(CustomSaveFileSystem.LastParsedSaveSlot, saveData);
		}

	}
}
