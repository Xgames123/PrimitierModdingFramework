using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.SubstanceModding.Patches
{
	[HarmonyPatch(typeof(Localizer), nameof(Localizer.OnLocaleChanged))]
	public class LocalizerOnLocaleChangedPatch
	{
		private static void Postfix()
		{

			CustomSubstanceSystem.ReloadLocalizations();
		}
	}
}
