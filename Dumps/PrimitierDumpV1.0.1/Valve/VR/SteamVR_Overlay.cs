/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Overlay : MonoBehaviour // TypeDefIndex: 7357
	{
		// Fields
		public Texture texture; // 0x18
		[Tooltip] // 0x0000000180024280-0x00000001800242B0
		public float scale; // 0x20
		[Tooltip] // 0x00000001800242B0-0x00000001800242E0
		public float distance; // 0x24
		[Range] // 0x00000001800242E0-0x0000000180024340
		[Tooltip] // 0x00000001800242E0-0x0000000180024340
		public float alpha; // 0x28
		public Vector4 uvOffset; // 0x2C
		public Vector2 mouseScale; // 0x3C
		public VROverlayInputMethod inputMethod; // 0x44
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static SteamVR_Overlay _instance_k__BackingField; // 0x00
		private ulong handle; // 0x48
	
		// Properties
		public static SteamVR_Overlay instance { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180C69C70-0x0000000180C69CB0 0x0000000180C69D20-0x0000000180C69D60
		public static string key { get; } // 0x0000000180C69CB0-0x0000000180C69D20 
	
		// Nested types
		public struct IntersectionResults // TypeDefIndex: 7356
		{
			// Fields
			public Vector3 point; // 0x00
			public Vector3 normal; // 0x0C
			public Vector2 UVs; // 0x18
			public float distance; // 0x20
		}
	
		// Constructors
		public SteamVR_Overlay(); // 0x0000000180C69BF0-0x0000000180C69C70
	
		// Methods
		private void OnEnable(); // 0x0000000180C694C0-0x0000000180C69630
		private void OnDisable(); // 0x0000000180C69410-0x0000000180C694C0
		public void UpdateOverlay(); // 0x0000000180C69760-0x0000000180C69BF0
		public bool PollNextEvent(ref VREvent_t pEvent); // 0x0000000180C69630-0x0000000180C69760
		public bool ComputeIntersection(Vector3 source, Vector3 direction, ref IntersectionResults results); // 0x0000000180C691B0-0x0000000180C69410
	}
}
