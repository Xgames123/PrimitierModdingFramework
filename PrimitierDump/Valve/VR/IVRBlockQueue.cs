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
	public struct IVRBlockQueue // TypeDefIndex: 6638
	{
		// Fields
		internal _Create Create; // 0x00
		internal _Connect Connect; // 0x08
		internal _Destroy Destroy; // 0x10
		internal _AcquireWriteOnlyBlock AcquireWriteOnlyBlock; // 0x18
		internal _ReleaseWriteOnlyBlock ReleaseWriteOnlyBlock; // 0x20
		internal _WaitAndAcquireReadOnlyBlock WaitAndAcquireReadOnlyBlock; // 0x28
		internal _AcquireReadOnlyBlock AcquireReadOnlyBlock; // 0x30
		internal _ReleaseReadOnlyBlock ReleaseReadOnlyBlock; // 0x38
		internal _QueueHasReader QueueHasReader; // 0x40
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _Create(ref ulong pulQueueHandle, IntPtr pchPath, uint unBlockDataSize, uint unBlockHeaderSize, uint unBlockCount); // TypeDefIndex: 6629; 0x0000000180921C30-0x0000000180921F90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _Connect(ref ulong pulQueueHandle, IntPtr pchPath); // TypeDefIndex: 6630; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _Destroy(ulong ulQueueHandle); // TypeDefIndex: 6631; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _AcquireWriteOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer); // TypeDefIndex: 6632; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _ReleaseWriteOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle); // TypeDefIndex: 6633; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _WaitAndAcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType, uint unTimeoutMs); // TypeDefIndex: 6634; 0x0000000180943DB0-0x0000000180944110
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _AcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType); // TypeDefIndex: 6635; 0x000000018091DF40-0x000000018091E280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _ReleaseReadOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle); // TypeDefIndex: 6636; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EBlockQueueError _QueueHasReader(ulong ulQueueHandle, ref bool pbHasReaders); // TypeDefIndex: 6637; 0x0000000180921410-0x00000001809216F0
	}
}
