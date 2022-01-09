/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct IVRDriverManager // TypeDefIndex: 6568
	{
		// Fields
		internal _GetDriverCount GetDriverCount; // 0x00
		internal _GetDriverName GetDriverName; // 0x08
		internal _GetDriverHandle GetDriverHandle; // 0x10
		internal _IsEnabled IsEnabled; // 0x18
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetDriverCount(); // TypeDefIndex: 6564; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 6565; 0x0000000180924A00-0x0000000180924BD0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ulong _GetDriverHandle(IntPtr pchDriverName); // TypeDefIndex: 6566; 0x000000018092C460-0x000000018092C730
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsEnabled(uint nDriver); // TypeDefIndex: 6567; 0x0000000180938F60-0x00000001809390F0
	}
}
