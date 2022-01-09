/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRExtendedDisplay // TypeDefIndex: 6647
	{
		// Fields
		private IVRExtendedDisplay FnTable; // 0x10
	
		// Constructors
		internal CVRExtendedDisplay(IntPtr pInterface); // 0x00000001809091C0-0x00000001809092D0
	
		// Methods
		public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight); // 0x0000000180909180-0x00000001809091C0
		public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight); // 0x0000000180909140-0x0000000180909180
		public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex); // 0x0000000180909110-0x0000000180909140
	}
}
