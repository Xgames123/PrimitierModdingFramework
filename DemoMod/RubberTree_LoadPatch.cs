//For testing if the Load of the rubber tree is called
#if false
using HarmonyLib;
using PrimitierModdingFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod
{
	[HarmonyPatch(typeof(RubberTree), nameof(RubberTree.Load))]
	public class RubberTree_LoadPatch
	{
		public static void Postfix(string json)
		{
			PMFLog.Message("rubber tree load " + json);
			
		}

	}
}
#endif