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
	public class OpenVRInterop // TypeDefIndex: 6673
	{
		// Constructors
		public OpenVRInterop(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType); // 0x000000018091A6F0-0x000000018091A780
		internal static extern uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, in string pStartupInfo); // 0x000000018091A630-0x000000018091A6F0
		internal static extern void ShutdownInternal(); // 0x000000018091A990-0x000000018091AA00
		internal static extern bool IsHmdPresent(); // 0x000000018091A780-0x000000018091A7F0
		internal static extern bool IsRuntimeInstalled(); // 0x000000018091A890-0x000000018091A900
		internal static extern string RuntimePath(); // 0x000000018091A900-0x000000018091A990
		internal static extern bool GetRuntimePath(StringBuilder pchPathBuffer, uint unBufferSize, ref uint punRequiredBufferSize); // 0x000000018091A4E0-0x000000018091A5B0
		internal static extern IntPtr GetStringForHmdError(EVRInitError error); // 0x000000018091A5B0-0x000000018091A630
		internal static extern IntPtr GetGenericInterface(in string pchInterfaceVersion, ref EVRInitError peError); // 0x000000018091A3C0-0x000000018091A470
		internal static extern bool IsInterfaceVersionValid(in string pchInterfaceVersion); // 0x000000018091A7F0-0x000000018091A890
		internal static extern uint GetInitToken(); // 0x000000018091A470-0x000000018091A4E0
	}
}
