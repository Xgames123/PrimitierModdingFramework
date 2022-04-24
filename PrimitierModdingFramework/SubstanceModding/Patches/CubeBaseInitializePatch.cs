using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.SubstanceModding.Patches
{
	[HarmonyPatch(typeof(CubeBase), nameof(CubeBase.Initialize))]
	public class CubeBaseInitializePatch
	{
		private static void Postfix(CubeBase __instance, Substance substance)
		{
			

			if (!CustomSubstanceSystem.IsEnabled)
			{
				return;
			}
			if (!CustomSubstanceSystem.CustomSubstanceSettings.TryGetValue(CustomSubstanceSystem.GetSubstance(substance).displayNameKey, out CustomSubstanceSettings settings))
			{
				return;
			}

			settings.OnSubstanceInitialize?.Invoke(__instance);

		}

	}
}
