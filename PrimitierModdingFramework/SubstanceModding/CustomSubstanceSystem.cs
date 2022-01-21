using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.SubstanceModding
{
	/// <summary>
	/// System used to load custom substances in to the game
	/// </summary>
	public class CustomSubstanceSystem : PMFSystem
	{

		/// <summary>
		/// Loads the custom substance in the game.
		/// </summary>
		/// <param name="substance"></param>
		public static void LoadCustomSubstance(SubstanceParameters.Param substance)
		{
			if (SubstanceManager.instance == null)
			{
				SubstanceManager.instance = Resources.Load<SubstanceParameters>(SubstanceManager.scriptableObjectPath);

			}

			SubstanceManager.instance.param.Add(substance);
		}


	}
}
