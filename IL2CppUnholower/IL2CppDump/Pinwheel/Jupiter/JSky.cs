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
	public class JSky : MonoBehaviour // TypeDefIndex: 8726
	{
		// Fields
		public static readonly Vector3 DefaultSunDirection; // 0x00
		public static readonly Vector3 DefaultMoonDirection; // 0x0C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private JSkyProfile profile; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Light sunLightSource; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Light moonLightSource; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JDayNightCycle _DNC_k__BackingField; // 0x30
		private static Mesh sphereMesh; // 0x18
	
		// Properties
		public JSkyProfile Profile { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public Light SunLightSource { get; set; } // 0x0000000180268FF0-0x0000000180269000 0x0000000180315D40-0x0000000180315DE0
		public Light MoonLightSource { get; set; } // 0x0000000180268FD0-0x0000000180268FE0 0x0000000180315CA0-0x0000000180315D40
		public JDayNightCycle DNC { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		private static Mesh SphereMesh { get; } // 0x0000000180315B70-0x0000000180315CA0 
	
		// Constructors
		public JSky(); // 0x0000000180265240-0x0000000180265250
		static JSky(); // 0x0000000180315AF0-0x0000000180315B70
	
		// Methods
		private void OnEnable(); // 0x0000000180314400-0x0000000180314550
		private void OnDisable(); // 0x0000000180314290-0x0000000180314400
		private void OnDestroy(); // 0x0000000180314260-0x0000000180314290
		private void Reset(); // 0x0000000180314A80-0x0000000180314B70
		private void OnCameraPreCull(Camera cam); // 0x0000000180314220-0x0000000180314260
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam); // 0x00000001803141E0-0x0000000180314220
		private void SetupSkyMaterial(); // 0x0000000180314B70-0x0000000180315900
		private void SyncFog(); // 0x0000000180315900-0x0000000180315AF0
		private void RenderShadow(Camera cam); // 0x0000000180314550-0x0000000180314A80
	}
}
