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
	public struct IVRPaths // TypeDefIndex: 6628
	{
		// Fields
		internal _ReadPathBatch ReadPathBatch; // 0x00
		internal _WritePathBatch WritePathBatch; // 0x08
		internal _StringToHandle StringToHandle; // 0x10
		internal _HandleToString HandleToString; // 0x18
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackedPropertyError _ReadPathBatch(ulong ulRootHandle, ref PathRead_t pBatch, uint unBatchEntryCount); // TypeDefIndex: 6624; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackedPropertyError _WritePathBatch(ulong ulRootHandle, ref PathWrite_t pBatch, uint unBatchEntryCount); // TypeDefIndex: 6625; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackedPropertyError _StringToHandle(ref ulong pHandle, IntPtr pchPath); // TypeDefIndex: 6626; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackedPropertyError _HandleToString(ulong pHandle, string pchBuffer, uint unBufferSize, ref uint punBufferSizeUsed); // TypeDefIndex: 6627; 0x0000000180924130-0x0000000180924470
	}
}
