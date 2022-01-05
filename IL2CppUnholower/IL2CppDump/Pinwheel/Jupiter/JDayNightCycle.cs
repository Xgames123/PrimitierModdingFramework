/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace Pinwheel.Jupiter
{
	[ExecuteInEditMode] // 0x0000000180014D50-0x0000000180014D60
	public class JDayNightCycle : MonoBehaviour // TypeDefIndex: 8731
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private JDayNightCycleProfile profile; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private JSky sky; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool useSunPivot; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform sunOrbitPivot; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool useMoonPivot; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform moonOrbitPivot; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float startTime; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float timeIncrement; // 0x4C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool autoTimeIncrement; // 0x50
		private float time; // 0x54
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool shouldUpdateEnvironmentReflection; // 0x58
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int environmentReflectionResolution; // 0x5C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private ReflectionProbeTimeSlicingMode environmentReflectionTimeSlicingMode; // 0x60
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private ReflectionProbe environmentProbe; // 0x68
		private Cubemap environmentReflection; // 0x70
		private int probeRenderId; // 0x78
	
		// Properties
		public JDayNightCycleProfile Profile { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public JSky Sky { get; set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public bool UseSunPivot { get; set; } // 0x000000018030F470-0x000000018030F480 0x000000018030F6F0-0x000000018030F700
		public Transform SunOrbitPivot { get; set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		public bool UseMoonPivot { get; set; } // 0x000000018030F460-0x000000018030F470 0x000000018030F6E0-0x000000018030F6F0
		public Transform MoonOrbitPivot { get; set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		public float StartTime { get; set; } // 0x000000018030F430-0x000000018030F440 0x000000018030F660-0x000000018030F690
		public float TimeIncrement { get; set; } // 0x000000018026BD40-0x000000018026BD50 0x000000018030F690-0x000000018030F6B0
		public bool AutoTimeIncrement { get; set; } // 0x00000001802AF7D0-0x00000001802AF7E0 0x00000001802AF7F0-0x00000001802AF800
		public float Time { get; set; } // 0x000000018030F440-0x000000018030F460 0x000000018030F6B0-0x000000018030F6E0
		public bool ShouldUpdateEnvironmentReflection { get; set; } // 0x000000018030F420-0x000000018030F430 0x000000018030F650-0x000000018030F660
		public int EnvironmentReflectionResolution { get; set; } // 0x000000018030F320-0x000000018030F330 0x000000018030F480-0x000000018030F640
		public ReflectionProbeTimeSlicingMode EnvironmentReflectionTimeSlicingMode { get; set; } // 0x000000018030F330-0x000000018030F340 0x000000018030F640-0x000000018030F650
		private ReflectionProbe EnvironmentProbe { get; } // 0x000000018030F060-0x000000018030F320 
		private Cubemap EnvironmentReflection { get; } // 0x000000018030F340-0x000000018030F420 
		private float DeltaTime { get; } // 0x000000018030F030-0x000000018030F060 
	
		// Constructors
		public JDayNightCycle(); // 0x000000018030F020-0x000000018030F030
	
		// Methods
		private void Reset(); // 0x000000018030ED90-0x000000018030EE20
		private void OnEnable(); // 0x000000018030EC30-0x000000018030ED90
		private void OnDisable(); // 0x000000018030EAD0-0x000000018030EC30
		private void OnCameraPreCull(Camera cam); // 0x000000018030EA80-0x000000018030EAD0
		private void OnBeginFrameRenderingSRP(ScriptableRenderContext context, Camera[] cameras); // 0x000000018030EA80-0x000000018030EAD0
		private void CleanUp(); // 0x000000018030E8B0-0x000000018030EA80
		private void Update(); // 0x000000018030EFF0-0x000000018030F020
		private void AnimateSky(); // 0x000000018030E070-0x000000018030E8B0
		private void UpdateEnvironmentReflection(); // 0x000000018030EE20-0x000000018030EFF0
	}
}
