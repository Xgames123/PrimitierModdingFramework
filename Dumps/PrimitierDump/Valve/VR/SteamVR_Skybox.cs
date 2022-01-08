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
	public class SteamVR_Skybox : MonoBehaviour // TypeDefIndex: 7373
	{
		// Fields
		public Texture front; // 0x18
		public Texture back; // 0x20
		public Texture left; // 0x28
		public Texture right; // 0x30
		public Texture top; // 0x38
		public Texture bottom; // 0x40
		public CellSize StereoCellSize; // 0x48
		public float StereoIpdMm; // 0x4C
	
		// Nested types
		public enum CellSize // TypeDefIndex: 7372
		{
			x1024 = 0,
			x64 = 1,
			x32 = 2,
			x16 = 3,
			x8 = 4
		}
	
		// Constructors
		public SteamVR_Skybox(); // 0x0000000180C73790-0x0000000180C737B0
	
		// Methods
		public void SetTextureByIndex(int i, Texture t); // 0x0000000180C73730-0x0000000180C73790
		public Texture GetTextureByIndex(int i); // 0x0000000180C73140-0x0000000180C731A0
		public static void SetOverride(Texture front = null, Texture back = null, Texture left = null, Texture right = null, Texture top = null, Texture bottom = null); // 0x0000000180C731E0-0x0000000180C73730
		public static void ClearOverride(); // 0x0000000180C730E0-0x0000000180C73140
		private void OnEnable(); // 0x0000000180C731A0-0x0000000180C731E0
		private void OnDisable(); // 0x0000000180C730E0-0x0000000180C73140
	}
}
