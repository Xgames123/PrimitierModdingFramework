/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct IVRProperties // TypeDefIndex: 6623
	{
		// Fields
		internal _ReadPropertyBatch ReadPropertyBatch; // 0x00
		internal _WritePropertyBatch WritePropertyBatch; // 0x08
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum; // 0x10
		internal _TrackedDeviceToPropertyContainer TrackedDeviceToPropertyContainer; // 0x18
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackedPropertyError _ReadPropertyBatch(ulong ulContainerHandle, ref PropertyRead_t pBatch, uint unBatchEntryCount); // TypeDefIndex: 6619; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackedPropertyError _WritePropertyBatch(ulong ulContainerHandle, ref PropertyWrite_t pBatch, uint unBatchEntryCount); // TypeDefIndex: 6620; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error); // TypeDefIndex: 6621; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ulong _TrackedDeviceToPropertyContainer(uint nDevice); // TypeDefIndex: 6622; 0x00000001809428C0-0x0000000180942B90
	}
}
