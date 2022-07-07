using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using TMPro;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace PrimitierModdingFramework
{
	public class PMFHelper : PMFSystem
	{
		public static bool IsEnabled { get; private set; } = false;

		public static Transform LHand;
		public static Transform RHand;
		public static Transform CameraRig;
		public static PlayerMovement PlayerMovement;
		public static PlayerLife PlayerLife;

		public static Transform MenuWindowL;

		public static TMP_FontAsset PrimitierDefaultFont = null;


		/// <summary>
		/// The system transform is used to store gameobjects that don't require saving (Custom objects that are not Cubes)
		/// </summary>
		public static Transform SystemTransform;

		public override void OnSystemEnabled()
		{
			IsEnabled = true;
			base.OnSystemEnabled();
		}
		public override void OnSystemDisabled()
		{
			IsEnabled = false;
			base.OnSystemDisabled();
		}


		public override void OnStart()
		{

			base.OnStart();
			EnableSystem<PMFLog>();
			
		}

		public override void OnSceneLoad()
		{
			SystemTransform = SafeTransformFind("System");

			CameraRig = SafeTransformFind("[CameraRig]");

			LHand = SafeTransformFind("LeftHand");
			RHand = SafeTransformFind("RightHand");

			if (CameraRig != null)
			{
				PlayerMovement = CameraRig.GetComponent<PlayerMovement>();
			}
			else
			{
				PMFLog.Error("Could not find 'PlayerMovement' component");
			}

			MenuWindowL = SafeTransformFind("MenuWindowL/Window", "MenuWindowL/Windows");




			PrimitierDefaultFont = FindPrimitierDefaultFont();

		}
		private static TMP_FontAsset FindPrimitierDefaultFont()
		{

			var fonts = GameObject.FindObjectsOfTypeIncludingAssets(UnhollowerRuntimeLib.Il2CppType.Of<TMP_FontAsset>());
			foreach (var font in fonts)
			{
				if (font.name == "mplus-1p-black SDF")
				{
					var castedFont = font.TryCast<TMP_FontAsset>();
					if (castedFont == null)
						continue;

					return castedFont;
				}

			}

			return null;
		}



		private Transform SafeTransformFind(params string[] names)
		{
			GameObject gameobject = null;
			foreach (var name in names)
			{
				var foundGameObject = GameObject.Find(name);
				if (foundGameObject != null)
				{
					gameobject = foundGameObject;
					break;
				}

			}
			if (gameobject == null)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("Gameobject and alternates are not found (");
				foreach (var name in names)
				{
					sb.Append(name);
					sb.Append(", ");
				}
				sb.Append(')');

				PMFLog.Error(sb.ToString());
				return null;
			}
			else
			{
				return gameobject.transform;
			}

			
			

		}


		/// <summary>
		/// Finds the types that have to be injected and injects them
		/// </summary>
		public static void AutoInject(params Type[] types)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(nameof(PMFHelper));

			foreach (var type in types)
			{
				if (type.GetInterface("ICustomCubeBehaviour") != null)
				{
					PMFLog.Message($"PMF: Injecting {type.FullName} ...");
					ClassInjector.RegisterTypeInIl2CppWithInterfaces(type, true, typeof(ICubeBehavior));
				}
				if (type.BaseType == typeof(CustomSubstanceBuilder))
				{
					PMFLog.Message($"PMF: Building {type.FullName} ...");
					CustomSubstanceBuilder.RegisterBuilder(type);
				}

			}
		}

		/// <summary>
		/// Scans the specified assembly's for classes to inject and injects them
		/// </summary>
		public static void AutoInject(params Assembly[] assemblies)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(nameof(PMFHelper));
			

			PMFLog.Message("PMF: Scanning assemblies");
			foreach (var assembly in assemblies)
			{
				AutoInject(assembly.GetExportedTypes());
			}
		}
	

	}
}
