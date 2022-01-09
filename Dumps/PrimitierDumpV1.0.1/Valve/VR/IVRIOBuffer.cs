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
	public struct IVRIOBuffer // TypeDefIndex: 6608
	{
		// Fields
		internal _Open Open; // 0x00
		internal _Close Close; // 0x08
		internal _Read Read; // 0x10
		internal _Write Write; // 0x18
		internal _PropertyContainer PropertyContainer; // 0x20
		internal _HasReaders HasReaders; // 0x28
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EIOBufferError _Open(IntPtr pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer); // TypeDefIndex: 6602; 0x000000018093A100-0x000000018093A460
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EIOBufferError _Close(ulong ulBuffer); // TypeDefIndex: 6603; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EIOBufferError _Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead); // TypeDefIndex: 6604; 0x0000000180924130-0x0000000180924470
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EIOBufferError _Write(ulong ulBuffer, IntPtr pSrc, uint unBytes); // TypeDefIndex: 6605; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ulong _PropertyContainer(ulong ulBuffer); // TypeDefIndex: 6606; 0x000000018092C460-0x000000018092C730
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _HasReaders(ulong ulBuffer); // TypeDefIndex: 6607; 0x000000018091F660-0x000000018091F800
	}
}
