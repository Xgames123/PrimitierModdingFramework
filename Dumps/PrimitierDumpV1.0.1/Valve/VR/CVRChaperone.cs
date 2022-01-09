/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRChaperone // TypeDefIndex: 6650
	{
		// Fields
		private IVRChaperone FnTable; // 0x10
	
		// Constructors
		internal CVRChaperone(IntPtr pInterface); // 0x0000000180905A60-0x0000000180905B90
	
		// Methods
		public ChaperoneCalibrationState GetCalibrationState(); // 0x00000001809056A0-0x0000000180905830
		public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ); // 0x0000000180905850-0x0000000180905880
		public bool GetPlayAreaRect(ref HmdQuad_t rect); // 0x0000000180905830-0x0000000180905850
		public void ReloadInfo(); // 0x0000000180905880-0x0000000180905A10
		public void SetSceneColor(HmdColor_t color); // 0x0000000180905A30-0x0000000180905A60
		public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor); // 0x0000000180905670-0x00000001809056A0
		public bool AreBoundsVisible(); // 0x0000000180905330-0x00000001809054C0
		public void ForceBoundsVisible(bool bForce); // 0x00000001809054C0-0x0000000180905670
		public void ResetZeroPose(ETrackingUniverseOrigin eTrackingUniverseOrigin); // 0x0000000180905A10-0x0000000180905A30
	}
}
