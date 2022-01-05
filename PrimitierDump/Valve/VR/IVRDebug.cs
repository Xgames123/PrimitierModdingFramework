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
	public struct IVRDebug // TypeDefIndex: 6618
	{
		// Fields
		internal _EmitVrProfilerEvent EmitVrProfilerEvent; // 0x00
		internal _BeginVrProfilerEvent BeginVrProfilerEvent; // 0x08
		internal _FinishVrProfilerEvent FinishVrProfilerEvent; // 0x10
		internal _DriverDebugRequest DriverDebugRequest; // 0x18
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRDebugError _EmitVrProfilerEvent(IntPtr pchMessage); // TypeDefIndex: 6614; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRDebugError _BeginVrProfilerEvent(ref ulong pHandleOut); // TypeDefIndex: 6615; 0x000000018091F310-0x000000018091F5E0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRDebugError _FinishVrProfilerEvent(ulong hHandle, IntPtr pchMessage); // TypeDefIndex: 6616; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _DriverDebugRequest(uint unDeviceIndex, IntPtr pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize); // TypeDefIndex: 6617; 0x00000001809225C0-0x0000000180922900
	}
}
