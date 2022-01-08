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
	[RequireComponent] // 0x0000000180024110-0x0000000180024160
	public class SteamVR_Ears : MonoBehaviour // TypeDefIndex: 7333
	{
		// Fields
		public SteamVR_Camera vrcam; // 0x18
		private bool usingSpeakers; // 0x20
		private Quaternion offset; // 0x24
	
		// Constructors
		public SteamVR_Ears(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void OnNewPosesApplied(); // 0x0000000180321A30-0x0000000180321B50
		private void OnEnable(); // 0x0000000180321890-0x0000000180321A30
		private void OnDisable(); // 0x00000001803217C0-0x0000000180321890
	}
}
