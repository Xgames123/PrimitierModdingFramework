using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.SubstanceModding
{
	/// <summary>
	/// System used to load custom substances in to the game
	/// </summary>
	public class CustomSubstanceSystem : PMFSystem
	{
		private static List<SubstanceParameters.Param> SubstanceLoadQueue = new List<SubstanceParameters.Param>();

		/// <summary>
		/// Loads the custom substance in the game.
		/// </summary>
		/// <param name="substance"></param>
		/// <param name="id">the index in the Substance enum of the loaded substance</param>
		public static void LoadCustomSubstance(SubstanceParameters.Param substance)
		{
			if (SubstanceManager.instance != null)
			{
				SubstanceManager.instance.param.Add(substance);
				return;
			}


			SubstanceLoadQueue.Add(substance);

		}

		public override void OnApplicationLateStart()
		{
			for (int i = 0; i < SubstanceLoadQueue.Count; i++)
			{
				SubstanceManager.instance.param.Add(SubstanceLoadQueue[i]);
			}

			base.OnApplicationLateStart();
		}


	}
}
