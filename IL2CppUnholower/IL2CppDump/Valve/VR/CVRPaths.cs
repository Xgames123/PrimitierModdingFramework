/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRPaths // TypeDefIndex: 6671
	{
		// Fields
		private IVRPaths FnTable; // 0x10
	
		// Constructors
		internal CVRPaths(IntPtr pInterface); // 0x000000018090CFB0-0x000000018090D0C0
	
		// Methods
		public ETrackedPropertyError ReadPathBatch(ulong ulRootHandle, ref PathRead_t pBatch, uint unBatchEntryCount); // 0x000000018090CE80-0x000000018090CEB0
		public ETrackedPropertyError WritePathBatch(ulong ulRootHandle, ref PathWrite_t pBatch, uint unBatchEntryCount); // 0x000000018090CF80-0x000000018090CFB0
		public ETrackedPropertyError StringToHandle(ref ulong pHandle, string pchPath); // 0x000000018090CEB0-0x000000018090CF80
		public ETrackedPropertyError HandleToString(ulong pHandle, string pchBuffer, uint unBufferSize, ref uint punBufferSizeUsed); // 0x000000018090CE50-0x000000018090CE80
	}
}
