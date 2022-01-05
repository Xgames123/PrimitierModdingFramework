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
	[ExecuteInEditMode] // 0x00000001800241A0-0x0000000180024230
	[RequireComponent] // 0x00000001800241A0-0x0000000180024230
	public class SteamVR_Frustum : MonoBehaviour // TypeDefIndex: 7351
	{
		// Fields
		public SteamVR_TrackedObject.EIndex index; // 0x18
		public float fovLeft; // 0x1C
		public float fovRight; // 0x20
		public float fovTop; // 0x24
		public float fovBottom; // 0x28
		public float nearZ; // 0x2C
		public float farZ; // 0x30
	
		// Constructors
		public SteamVR_Frustum(); // 0x0000000180326C80-0x0000000180326CC0
	
		// Methods
		public void UpdateModel(); // 0x0000000180326270-0x0000000180326C80
		private void OnDeviceConnected(int i, bool connected); // 0x0000000180325E60-0x0000000180326030
		private void OnEnable(); // 0x0000000180326150-0x0000000180326270
		private void OnDisable(); // 0x0000000180326030-0x0000000180326150
	}
}
