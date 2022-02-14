using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.SubstanceModding.Patches
{
	/// <summary>
	/// A patch for the SubstanceManager.GetMaterial method
	/// </summary>
	[HarmonyPatch(typeof(SubstanceManager), nameof(SubstanceManager.GetMaterial), new Type[] { typeof(string) })]
	public static class SubstanceManagerGetMaterialPatch
	{

		static bool Prefix(ref Material __result, string materialName)
		{

			//TODO fix
			PMFLog.Message("patch");

			var customMat = CustomSubstanceSystem.GetCustomMaterial(materialName);
			if (customMat != null)
			{
				__result = customMat;
				return false;
			}



			__result = null;
			return false;
		}


	}
}
