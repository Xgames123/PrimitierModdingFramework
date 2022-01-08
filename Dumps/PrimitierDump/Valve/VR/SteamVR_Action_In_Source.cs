/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public abstract class SteamVR_Action_In_Source : SteamVR_Action_Source, ISteamVR_Action_In_Source // TypeDefIndex: 7176
	{
		// Fields
		protected static uint inputOriginInfo_size; // 0x00
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _isUpdating_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _updateTime_k__BackingField; // 0x2C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _changedTime_k__BackingField; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private int _lastOriginGetFrame_k__BackingField; // 0x34
		protected InputOriginInfo_t inputOriginInfo; // 0x38
		protected InputOriginInfo_t lastInputOriginInfo; // 0xC8
	
		// Properties
		public bool isUpdating { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018030F470-0x000000018030F480 0x000000018030F6F0-0x000000018030F700
		public float updateTime { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x000000018036B0F0-0x000000018036B100 0x000000018036B5F0-0x000000018036B600
		public abstract ulong activeOrigin { get; }
		public abstract ulong lastActiveOrigin { get; }
		public abstract bool changed { get; protected set; }
		public abstract bool lastChanged { get; protected set; }
		public SteamVR_Input_Sources activeDevice { get; } // 0x00000001803E5B00-0x00000001803E5B60 
		public uint trackedDeviceIndex { get; } // 0x00000001803E5C80-0x00000001803E5CA0 
		public string renderModelComponentName { get; } // 0x00000001803E5C60-0x00000001803E5C80 
		public string localizedOriginName { get; } // 0x00000001803E5B60-0x00000001803E5C60 
		public float changedTime { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803496C0-0x00000001803496D0 0x000000018036B200-0x000000018036B210
		protected int lastOriginGetFrame { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018030D190-0x000000018030D1A0 0x000000018030D1D0-0x000000018030D1E0
	
		// Constructors
		protected SteamVR_Action_In_Source(); // 0x00000001802650F0-0x0000000180265100
		static SteamVR_Action_In_Source(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public abstract void UpdateValue();
		public override void Initialize(); // 0x00000001803E5340-0x00000001803E54B0
		protected void UpdateOriginTrackedDeviceInfo(); // 0x00000001803E54B0-0x00000001803E5B00
		public string GetLocalizedOriginPart(params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts); // 0x00000001803E51A0-0x00000001803E5250
		public string GetLocalizedOrigin(); // 0x00000001803E5250-0x00000001803E5340
	}
}
