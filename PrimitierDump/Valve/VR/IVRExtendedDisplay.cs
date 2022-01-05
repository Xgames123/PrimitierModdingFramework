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
	public struct IVRExtendedDisplay // TypeDefIndex: 6294
	{
		// Fields
		internal _GetWindowBounds GetWindowBounds; // 0x00
		internal _GetEyeOutputViewport GetEyeOutputViewport; // 0x08
		internal _GetDXGIOutputInfo GetDXGIOutputInfo; // 0x10
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6291; 0x00000001809380B0-0x00000001809383D0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6292; 0x000000018092C9A0-0x000000018092CD50
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex); // TypeDefIndex: 6293; 0x000000018092B720-0x000000018092B9F0
	}
}
