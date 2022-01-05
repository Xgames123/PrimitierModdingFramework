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
	public class CVRSystem // TypeDefIndex: 6646
	{
		// Fields
		private IVRSystem FnTable; // 0x10
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _PollNextEventPacked(ref VREvent_t_Packed pEvent, uint uncbVREvent); // TypeDefIndex: 6640; 0x0000000180929AB0-0x0000000180929D80
	
		private struct PollNextEventUnion // TypeDefIndex: 6641
		{
			// Fields
			public IVRSystem._PollNextEvent pPollNextEvent; // 0x00
			public _PollNextEventPacked pPollNextEventPacked; // 0x00
		}
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetControllerStatePacked(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize); // TypeDefIndex: 6642; 0x000000018092A0D0-0x000000018092A3C0
	
		private struct GetControllerStateUnion // TypeDefIndex: 6643
		{
			// Fields
			public IVRSystem._GetControllerState pGetControllerState; // 0x00
			public _GetControllerStatePacked pGetControllerStatePacked; // 0x00
		}
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetControllerStateWithPosePacked(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 6644; 0x000000018092A4E0-0x000000018092A8A0
	
		private struct GetControllerStateWithPoseUnion // TypeDefIndex: 6645
		{
			// Fields
			public IVRSystem._GetControllerStateWithPose pGetControllerStateWithPose; // 0x00
			public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked; // 0x00
		}
	
		// Constructors
		internal CVRSystem(IntPtr pInterface); // 0x00000001809117E0-0x0000000180911980
	
		// Methods
		public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight); // 0x00000001809109B0-0x0000000180910B70
		public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ); // 0x0000000180910830-0x00000001809108A0
		public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom); // 0x00000001809108A0-0x00000001809108E0
		public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates); // 0x000000018090FDA0-0x000000018090FDD0
		public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye); // 0x00000001809106B0-0x0000000180910700
		public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter); // 0x0000000180910CA0-0x0000000180910CD0
		public int GetD3D9AdapterIndex(); // 0x0000000180910430-0x00000001809105C0
		public void GetDXGIOutputInfo(ref int pnAdapterIndex); // 0x00000001809105C0-0x00000001809105F0
		public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance); // 0x0000000180910800-0x0000000180910830
		public bool IsDisplayOnDesktop(); // 0x0000000180910D90-0x0000000180910F20
		public bool SetDisplayVisibility(bool bIsVisibleOnDesktop); // 0x0000000180911470-0x0000000180911490
		public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray); // 0x00000001809105F0-0x0000000180910630
		public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose(); // 0x0000000180910BE0-0x0000000180910C30
		public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose(); // 0x0000000180910960-0x00000001809109B0
		public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, uint[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex); // 0x0000000180910C30-0x0000000180910C70
		public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId); // 0x0000000180910CD0-0x0000000180910D00
		public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform); // 0x000000018090FD70-0x000000018090FDA0
		public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType); // 0x0000000180910D30-0x0000000180910D60
		public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex); // 0x000000018090FF60-0x000000018090FF90
		public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex); // 0x0000000180910D00-0x0000000180910D30
		public bool IsTrackedDeviceConnected(uint unDeviceIndex); // 0x0000000180911240-0x0000000180911270
		public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // 0x000000018090FE30-0x000000018090FE60
		public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // 0x0000000180910700-0x0000000180910730
		public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // 0x0000000180910770-0x00000001809107A0
		public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // 0x0000000180910D60-0x0000000180910D90
		public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // 0x00000001809107A0-0x0000000180910800
		public uint GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError); // 0x000000018090FE00-0x000000018090FE30
		public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError); // 0x0000000180910C70-0x0000000180910CA0
		public string GetPropErrorNameFromEnum(ETrackedPropertyError error); // 0x00000001809108E0-0x0000000180910960
		public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent); // 0x00000001809112D0-0x0000000180911470
		public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose); // 0x00000001809112A0-0x00000001809112D0
		public string GetEventTypeNameFromEnum(EVREventType eType); // 0x0000000180910630-0x00000001809106B0
		public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type); // 0x0000000180910730-0x0000000180910770
		public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize); // 0x00000001809101F0-0x0000000180910430
		public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose); // 0x000000018090FF90-0x00000001809101F0
		public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec); // 0x00000001809117B0-0x00000001809117E0
		public string GetButtonIdNameFromEnum(EVRButtonId eButtonId); // 0x000000018090FE60-0x000000018090FEE0
		public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType); // 0x000000018090FEE0-0x000000018090FF60
		public bool IsInputAvailable(); // 0x0000000180910F20-0x00000001809110B0
		public bool IsSteamVRDrawingControllers(); // 0x00000001809110B0-0x0000000180911240
		public bool ShouldApplicationPause(); // 0x0000000180911490-0x0000000180911620
		public bool ShouldApplicationReduceRenderingWork(); // 0x0000000180911620-0x00000001809117B0
		public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex); // 0x0000000180911270-0x00000001809112A0
		public void AcknowledgeQuit_Exiting(); // 0x000000018090FBE0-0x000000018090FD70
		public uint GetAppContainerFilePaths(StringBuilder pchBuffer, uint unBufferSize); // 0x000000018090FDD0-0x000000018090FE00
		public string GetRuntimeVersion(); // 0x0000000180910B70-0x0000000180910BE0
	}
}
