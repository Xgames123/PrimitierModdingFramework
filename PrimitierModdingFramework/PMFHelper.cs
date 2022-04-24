using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
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
			SystemTransform = GameObject.Find("System").transform;

			CameraRig = GameObject.Find("[CameraRig]").transform;
			LHand = GameObject.Find("LeftHand").transform;
			RHand = GameObject.Find("RightHand").transform;

			PlayerMovement = CameraRig.GetComponent<PlayerMovement>();

			MenuWindowL = GameObject.Find("MenuWindowL/Window").transform;

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
				if (type.IsAssignableFrom(typeof(ICustomCubeBehaviour)))
				{
					ClassInjector.RegisterTypeInIl2CppWithInterfaces(type, true, typeof(ICustomCubeBehaviour));
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
			

			PMFLog.Message("Scanning assemblies");
			foreach (var assembly in assemblies)
			{
				AutoInject(assembly.GetExportedTypes());
			}
		}
	

	}
}
