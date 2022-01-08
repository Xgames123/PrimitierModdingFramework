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
	public class SteamVR_TrackedObject : MonoBehaviour // TypeDefIndex: 7379
	{
		// Fields
		public EIndex index; // 0x18
		[Tooltip] // 0x0000000180023A30-0x0000000180023A60
		public Transform origin; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _isValid_k__BackingField; // 0x28
		private SteamVR_Events.Action newPosesAction; // 0x30
	
		// Properties
		public bool isValid { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018030F470-0x000000018030F480 0x000000018030F6F0-0x000000018030F700
	
		// Nested types
		public enum EIndex // TypeDefIndex: 7378
		{
			None = -1,
			Hmd = 0,
			Device1 = 1,
			Device2 = 2,
			Device3 = 3,
			Device4 = 4,
			Device5 = 5,
			Device6 = 6,
			Device7 = 7,
			Device8 = 8,
			Device9 = 9,
			Device10 = 10,
			Device11 = 11,
			Device12 = 12,
			Device13 = 13,
			Device14 = 14,
			Device15 = 15,
			Device16 = 16
		}
	
		// Constructors
		private SteamVR_TrackedObject(); // 0x0000000180C75200-0x0000000180C752C0
	
		// Methods
		private void OnNewPoses(TrackedDevicePose_t[] poses); // 0x0000000180C74E90-0x0000000180C75110
		private void Awake(); // 0x0000000180C74D80-0x0000000180C74E60
		private void OnEnable(); // 0x0000000180C74D80-0x0000000180C74E60
		private void OnDisable(); // 0x0000000180C74E60-0x0000000180C74E90
		public void SetDeviceIndex(int index); // 0x0000000180C75110-0x0000000180C75200
	}
}
