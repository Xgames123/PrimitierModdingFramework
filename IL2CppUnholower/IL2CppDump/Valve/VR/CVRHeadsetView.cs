/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRHeadsetView // TypeDefIndex: 6657
	{
		// Fields
		private IVRHeadsetView FnTable; // 0x10
	
		// Constructors
		internal CVRHeadsetView(IntPtr pInterface); // 0x00000001809099F0-0x0000000180909B20
	
		// Methods
		public void SetHeadsetViewSize(uint nWidth, uint nHeight); // 0x00000001809099D0-0x00000001809099F0
		public void GetHeadsetViewSize(ref uint pnWidth, ref uint pnHeight); // 0x0000000180909620-0x00000001809097E0
		public void SetHeadsetViewMode(uint eHeadsetViewMode); // 0x00000001809099B0-0x00000001809099D0
		public uint GetHeadsetViewMode(); // 0x0000000180902C50-0x0000000180902DE0
		public void SetHeadsetViewCropped(bool bCropped); // 0x0000000180909800-0x00000001809099B0
		public bool GetHeadsetViewCropped(); // 0x0000000180909490-0x0000000180909620
		public float GetHeadsetViewAspectRatio(); // 0x00000001809092D0-0x0000000180909460
		public void SetHeadsetViewBlendRange(float flStartPct, float flEndPct); // 0x00000001809097E0-0x0000000180909800
		public void GetHeadsetViewBlendRange(ref float pStartPct, ref float pEndPct); // 0x0000000180909460-0x0000000180909490
	}
}
