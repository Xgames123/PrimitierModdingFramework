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
	public class CVRChaperoneSetup // TypeDefIndex: 6651
	{
		// Fields
		private IVRChaperoneSetup FnTable; // 0x10
	
		// Constructors
		internal CVRChaperoneSetup(IntPtr pInterface); // 0x00000001809051D0-0x0000000180905330
	
		// Methods
		public bool CommitWorkingCopy(EChaperoneConfigFile configFile); // 0x00000001809047B0-0x00000001809047D0
		public void RevertWorkingCopy(); // 0x0000000180904C60-0x0000000180904DF0
		public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ); // 0x0000000180904970-0x00000001809049A0
		public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect); // 0x0000000180904950-0x0000000180904970
		public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer); // 0x00000001809048C0-0x0000000180904950
		public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer); // 0x0000000180904800-0x0000000180904890
		public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose); // 0x00000001809049A0-0x00000001809049C0
		public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose); // 0x00000001809049C0-0x00000001809049E0
		public void SetWorkingPlayAreaSize(float sizeX, float sizeZ); // 0x0000000180904FE0-0x0000000180905000
		public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer); // 0x0000000180904F80-0x0000000180904FB0
		public void SetWorkingPerimeter(HmdVector2_t[] pPointBuffer); // 0x0000000180904FB0-0x0000000180904FE0
		public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose); // 0x0000000180905000-0x0000000180905020
		public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose); // 0x0000000180905020-0x0000000180905040
		public void ReloadFromDisk(EChaperoneConfigFile configFile); // 0x0000000180904C40-0x0000000180904C60
		public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose); // 0x0000000180904890-0x00000001809048C0
		public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength); // 0x00000001809047D0-0x0000000180904800
		public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags); // 0x0000000180904B70-0x0000000180904C40
		public void ShowWorkingSetPreview(); // 0x0000000180905040-0x00000001809051D0
		public void HideWorkingSetPreview(); // 0x00000001809049E0-0x0000000180904B70
		public void RoomSetupStarting(); // 0x0000000180904DF0-0x0000000180904F80
	}
}
