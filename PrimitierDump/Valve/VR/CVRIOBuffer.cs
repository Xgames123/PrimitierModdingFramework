/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRIOBuffer // TypeDefIndex: 6667
	{
		// Fields
		private IVRIOBuffer FnTable; // 0x10
	
		// Constructors
		internal CVRIOBuffer(IntPtr pInterface); // 0x0000000180909CD0-0x0000000180909DF0
	
		// Methods
		public EIOBufferError Open(string pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer); // 0x0000000180909B60-0x0000000180909C50
		public EIOBufferError Close(ulong ulBuffer); // 0x0000000180909B20-0x0000000180909B40
		public EIOBufferError Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead); // 0x0000000180909C70-0x0000000180909CA0
		public EIOBufferError Write(ulong ulBuffer, IntPtr pSrc, uint unBytes); // 0x0000000180909CA0-0x0000000180909CD0
		public ulong PropertyContainer(ulong ulBuffer); // 0x0000000180909C50-0x0000000180909C70
		public bool HasReaders(ulong ulBuffer); // 0x0000000180909B40-0x0000000180909B60
	}
}
