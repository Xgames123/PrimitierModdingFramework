/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct VRControllerState_t_Packed // TypeDefIndex: 6813
	{
		// Fields
		public uint unPacketNum; // 0x00
		public ulong ulButtonPressed; // 0x04
		public ulong ulButtonTouched; // 0x0C
		public VRControllerAxis_t rAxis0; // 0x14
		public VRControllerAxis_t rAxis1; // 0x1C
		public VRControllerAxis_t rAxis2; // 0x24
		public VRControllerAxis_t rAxis3; // 0x2C
		public VRControllerAxis_t rAxis4; // 0x34
	
		// Constructors
		public VRControllerState_t_Packed(VRControllerState_t unpacked); // 0x000000018091DB60-0x000000018091DC00
	
		// Methods
		public void Unpack(ref VRControllerState_t unpacked); // 0x000000018091DAE0-0x000000018091DB60
	}
}
