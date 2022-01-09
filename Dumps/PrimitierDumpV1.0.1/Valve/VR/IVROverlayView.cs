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
	public struct IVROverlayView // TypeDefIndex: 6507
	{
		// Fields
		internal _AcquireOverlayView AcquireOverlayView; // 0x00
		internal _ReleaseOverlayView ReleaseOverlayView; // 0x08
		internal _PostOverlayEvent PostOverlayEvent; // 0x10
		internal _IsViewingPermitted IsViewingPermitted; // 0x18
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _AcquireOverlayView(ulong ulOverlayHandle, ref VRNativeDevice_t pNativeDevice, ref VROverlayView_t pOverlayView, uint unOverlayViewSize); // TypeDefIndex: 6503; 0x000000018091DF40-0x000000018091E280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _ReleaseOverlayView(ref VROverlayView_t pOverlayView); // TypeDefIndex: 6504; 0x000000018092C110-0x000000018092C3E0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _PostOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pvrEvent); // TypeDefIndex: 6505; 0x000000018092B720-0x000000018092B9F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsViewingPermitted(ulong ulOverlayHandle); // TypeDefIndex: 6506; 0x000000018091F660-0x000000018091F800
	}
}
