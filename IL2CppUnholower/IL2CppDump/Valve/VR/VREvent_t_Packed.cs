/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct VREvent_t_Packed // TypeDefIndex: 6808
	{
		// Fields
		public uint eventType; // 0x00
		public uint trackedDeviceIndex; // 0x04
		public float eventAgeSeconds; // 0x08
		public VREvent_Data_t data; // 0x0C
	
		// Constructors
		public VREvent_t_Packed(VREvent_t unpacked); // 0x000000018091DDC0-0x000000018091DE00
	
		// Methods
		public void Unpack(ref VREvent_t unpacked); // 0x000000018091DD90-0x000000018091DDC0
	}
}
