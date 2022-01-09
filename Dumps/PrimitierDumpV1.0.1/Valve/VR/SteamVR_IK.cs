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
	public class SteamVR_IK : MonoBehaviour // TypeDefIndex: 7352
	{
		// Fields
		public Transform target; // 0x18
		public Transform start; // 0x20
		public Transform joint; // 0x28
		public Transform end; // 0x30
		public Transform poleVector; // 0x38
		public Transform upVector; // 0x40
		public float blendPct; // 0x48
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Transform startXform; // 0x50
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Transform jointXform; // 0x58
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Transform endXform; // 0x60
	
		// Constructors
		public SteamVR_IK(); // 0x0000000180328CD0-0x0000000180328CE0
	
		// Methods
		private void LateUpdate(); // 0x0000000180327AE0-0x00000001803287D0
		public static bool Solve(Vector3 start, Vector3 end, Vector3 poleVector, float jointDist, float targetDist, ref Vector3 result, out Vector3 forward, out Vector3 up); // 0x00000001803287D0-0x0000000180328CD0
	}
}
