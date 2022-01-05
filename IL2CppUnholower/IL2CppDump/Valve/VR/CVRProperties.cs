/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRProperties // TypeDefIndex: 6670
	{
		// Fields
		private IVRProperties FnTable; // 0x10
	
		// Constructors
		internal CVRProperties(IntPtr pInterface); // 0x000000018090D160-0x000000018090D270
	
		// Methods
		public ETrackedPropertyError ReadPropertyBatch(ulong ulContainerHandle, ref PropertyRead_t pBatch, uint unBatchEntryCount); // 0x000000018090CE80-0x000000018090CEB0
		public ETrackedPropertyError WritePropertyBatch(ulong ulContainerHandle, ref PropertyWrite_t pBatch, uint unBatchEntryCount); // 0x000000018090CF80-0x000000018090CFB0
		public string GetPropErrorNameFromEnum(ETrackedPropertyError error); // 0x000000018090D0C0-0x000000018090D140
		public ulong TrackedDeviceToPropertyContainer(uint nDevice); // 0x000000018090D140-0x000000018090D160
	}
}
