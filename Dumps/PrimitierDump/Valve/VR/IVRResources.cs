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
	public struct IVRResources // TypeDefIndex: 6563
	{
		// Fields
		internal _LoadSharedResource LoadSharedResource; // 0x00
		internal _GetResourceFullPath GetResourceFullPath; // 0x08
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _LoadSharedResource(IntPtr pchResourceName, string pchBuffer, uint unBufferLen); // TypeDefIndex: 6561; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetResourceFullPath(IntPtr pchResourceName, IntPtr pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen); // TypeDefIndex: 6562; 0x0000000180928C10-0x0000000180928E20
	}
}
