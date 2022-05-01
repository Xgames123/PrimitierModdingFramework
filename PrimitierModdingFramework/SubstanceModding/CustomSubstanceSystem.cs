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
		public static bool IsEnabled { get; private set; } = false;

		private static Dictionary<string, Material> s_customMats = new Dictionary<string, Material>();

		internal static Dictionary<string, CustomSubstanceSettings> CustomSubstanceSettings = new Dictionary<string, CustomSubstanceSettings>();

		public override void OnSystemEnabled()
		{
			IsEnabled = true;
		}
		public override void OnSystemDisabled()
		{
			IsEnabled = false;
		}


		/// <summary>
		/// Gets the loaded custom material by name
		/// </summary>
		/// <param name="name">The name of the custom material</param>
		/// <returns></returns>
		public static Material GetCustomMaterial(string name)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSubstanceSystem));

			if(s_customMats.TryGetValue(name, out var outMat))
			{
				return outMat;
			}

			return null;
		}


		/// <summary>
		/// Loads the custom substance in the game.
		/// </summary>
		/// <param name="substance"></param>
		/// <param name="settings"></param>
		public static void LoadCustomSubstance(SubstanceParameters.Param substance, CustomSubstanceSettings settings=null)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSubstanceSystem));

			if (SubstanceManager.instance == null)
			{
				SubstanceManager.instance = Resources.Load<SubstanceParameters>(SubstanceManager.scriptableObjectPath);
			}

			if (settings != null)
			{
				CustomSubstanceSettings.Add(substance.displayNameKey, settings);

				PMFLocalizer.AddJpEntry(substance.displayNameKey, settings.JpName);
				PMFLocalizer.AddEnEntry(substance.displayNameKey, settings.EnName);
			}

			SubstanceManager.instance.param.Add(substance);
			PMFLocalizer.ReloadLocalizations();
		}

		/// <summary>
		/// Gets the substance form its enum value
		/// </summary>
		/// <param name="substance"></param>
		/// <returns></returns>
		public static SubstanceParameters.Param GetSubstance(Substance substance)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSubstanceSystem));
			return SubstanceManager.GetParameter(substance);
		}



		/// <summary>
		/// Creates a custom substance from a base substance.
		/// </summary>
		/// <param name="baseSubstace"></param>
		public static SubstanceParameters.Param CreateCustomSubstance(Substance baseSubstace)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSubstanceSystem));

			if (SubstanceManager.instance == null)
			{
				SubstanceManager.instance = Resources.Load<SubstanceParameters>(SubstanceManager.scriptableObjectPath);
			}

			return SubstanceManager.GetParameter(baseSubstace).MemberwiseClone().Cast<SubstanceParameters.Param>();

		}

		/// <summary>
		/// Creates a custom material from a base material.
		/// </summary>
		/// <param name="baseMaterial"></param>
		/// <returns></returns>
		public static Material CreateCustomMaterial(string baseMaterial)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSubstanceSystem));

			var baseMat = SubstanceManager.GetMaterial(baseMaterial);

			var outputMat = new Material(baseMat);

			return outputMat;
		}

		/// <summary>
		/// Gets a loaded Material from its name
		/// </summary>
		/// <param name="materialName"></param>
		/// <returns></returns>
		public static Material GetMaterial(string materialName)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSubstanceSystem));

			return SubstanceManager.GetMaterial(materialName);
		}


		/// <summary>
		/// Loads the custom material in the game.
		/// </summary>
		public static void LoadCustomMaterial(Material material)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSubstanceSystem));

			s_customMats.Add(material.name, material);
		}



		/// <summary>
		/// Gets the Substance enum form the name of the substance.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static Substance GetSubstanceByName(string name)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSubstanceSystem));

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
