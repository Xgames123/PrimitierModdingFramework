using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.SubstanceModding.Patches
{
	[HarmonyPatch(typeof(CubeBase), nameof(CubeBase.Initialize))]
	public class CubeBaseInitializePatch
	{
		private static void Prefix(CubeBase __instance, Substance substance)
		{

			if (!CustomSubstanceSystem.IsEnabled)
			{
				return;
			}
			var sub = CustomSubstanceSystem.GetSubstance(substance);
			if (sub == null || !CustomSubstanceSystem.CustomSubstanceSettings.TryGetValue(sub.displayNameKey, out CustomSubstanceSettings settings))
			{
				return;
			}

			settings.OnEarlySubstanceInitialize?.Invoke(__instance);
		}



		private static void Postfix(CubeBase __instance, Substance substance)
		{
			

			if (!CustomSubstanceSystem.IsEnabled)
			{
				return;
			}
			var sub = CustomSubstanceSystem.GetSubstance(substance);
			if (sub == null || !CustomSubstanceSystem.CustomSubstanceSettings.TryGetValue(sub.displayNameKey, out CustomSubstanceSettings settings))
			{
				return;
			}

			settings.OnSubstanceInitialize?.Invoke(__instance);

			var subBehaviour = settings.AddCustomCubeBehaviour?.Invoke(__instance);
			__instance.substanceBehavior = (Component)subBehaviour;
		}

	}
}
