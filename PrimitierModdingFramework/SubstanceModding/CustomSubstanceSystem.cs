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

		/// <summary>
		/// Creates a custom substance from a base substance.
		/// </summary>
		/// <param name="baseSubstace"></param>
		public static SubstanceParameters.Param CreateCustomSubstance(Substance baseSubstace)
		{
			if (SubstanceManager.instance == null)
			{
				SubstanceManager.instance = Resources.Load<SubstanceParameters>(SubstanceManager.scriptableObjectPath);
			}


			return SubstanceManager.GetParameter(baseSubstace).MemberwiseClone().Cast<SubstanceParameters.Param>();

		}

		/// <summary>
		/// Gets the Substance enum form the name of the substance.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static Substance GetSubstanceByName(string name)
		{
			if (SubstanceManager.instance == null)
			{
				SubstanceManager.instance = Resources.Load<SubstanceParameters>(SubstanceManager.scriptableObjectPath);
			}

			for (int i = 0; i < SubstanceManager.instance.param.Count; i++)
			{
				if (SubstanceManager.instance.param[i].displayNameKey == name)
				{
					return (Substance)i;
				}

			}

			return (Substance)(-1);
		}


	}
}
