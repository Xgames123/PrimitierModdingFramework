/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRDebug // TypeDefIndex: 6669
	{
		// Fields
		private IVRDebug FnTable; // 0x10
	
		// Constructors
		internal CVRDebug(IntPtr pInterface); // 0x0000000180908DE0-0x0000000180908EF0
	
		// Methods
		public EVRDebugError EmitVrProfilerEvent(string pchMessage); // 0x0000000180908C50-0x0000000180908D10
		public EVRDebugError BeginVrProfilerEvent(ref ulong pHandleOut); // 0x0000000180908B40-0x0000000180908B70
		public EVRDebugError FinishVrProfilerEvent(ulong hHandle, string pchMessage); // 0x0000000180908D10-0x0000000180908DE0
		public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize); // 0x0000000180908B70-0x0000000180908C50
	}
}
