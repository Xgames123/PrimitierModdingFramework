/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVROverlayView // TypeDefIndex: 6656
	{
		// Fields
		private IVROverlayView FnTable; // 0x10
	
		// Constructors
		internal CVROverlayView(IntPtr pInterface); // 0x000000018090AC80-0x000000018090AD90
	
		// Methods
		public EVROverlayError AcquireOverlayView(ulong ulOverlayHandle, ref VRNativeDevice_t pNativeDevice, ref VROverlayView_t pOverlayView, uint unOverlayViewSize); // 0x000000018090ABF0-0x000000018090AC20
		public EVROverlayError ReleaseOverlayView(ref VROverlayView_t pOverlayView); // 0x000000018090AC60-0x000000018090AC80
		public void PostOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pvrEvent); // 0x000000018090AC40-0x000000018090AC60
		public bool IsViewingPermitted(ulong ulOverlayHandle); // 0x000000018090AC20-0x000000018090AC40
	}
}
