/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRBlockQueue // TypeDefIndex: 6672
	{
		// Fields
		private IVRBlockQueue FnTable; // 0x10
	
		// Constructors
		internal CVRBlockQueue(IntPtr pInterface); // 0x0000000180904680-0x00000001809047B0
	
		// Methods
		public EBlockQueueError Create(ref ulong pulQueueHandle, string pchPath, uint unBlockDataSize, uint unBlockHeaderSize, uint unBlockCount); // 0x00000001809044C0-0x00000001809045C0
		public EBlockQueueError Connect(ref ulong pulQueueHandle, string pchPath); // 0x00000001809043F0-0x00000001809044C0
		public EBlockQueueError Destroy(ulong ulQueueHandle); // 0x00000001809045C0-0x00000001809045E0
		public EBlockQueueError AcquireWriteOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer); // 0x00000001809043C0-0x00000001809043F0
		public EBlockQueueError ReleaseWriteOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle); // 0x0000000180904630-0x0000000180904650
		public EBlockQueueError WaitAndAcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType, uint unTimeoutMs); // 0x0000000180904650-0x0000000180904680
		public EBlockQueueError AcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType); // 0x0000000180904390-0x00000001809043C0
		public EBlockQueueError ReleaseReadOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle); // 0x0000000180904610-0x0000000180904630
		public EBlockQueueError QueueHasReader(ulong ulQueueHandle, ref bool pbHasReaders); // 0x00000001809045E0-0x0000000180904610
	}
}
