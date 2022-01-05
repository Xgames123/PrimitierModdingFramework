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
	public struct IVRSystem // TypeDefIndex: 6290
	{
		// Fields
		internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize; // 0x00
		internal _GetProjectionMatrix GetProjectionMatrix; // 0x08
		internal _GetProjectionRaw GetProjectionRaw; // 0x10
		internal _ComputeDistortion ComputeDistortion; // 0x18
		internal _GetEyeToHeadTransform GetEyeToHeadTransform; // 0x20
		internal _GetTimeSinceLastVsync GetTimeSinceLastVsync; // 0x28
		internal _GetD3D9AdapterIndex GetD3D9AdapterIndex; // 0x30
		internal _GetDXGIOutputInfo GetDXGIOutputInfo; // 0x38
		internal _GetOutputDevice GetOutputDevice; // 0x40
		internal _IsDisplayOnDesktop IsDisplayOnDesktop; // 0x48
		internal _SetDisplayVisibility SetDisplayVisibility; // 0x50
		internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose; // 0x58
		internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose; // 0x60
		internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose; // 0x68
		internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass; // 0x70
		internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel; // 0x78
		internal _ApplyTransform ApplyTransform; // 0x80
		internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole; // 0x88
		internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex; // 0x90
		internal _GetTrackedDeviceClass GetTrackedDeviceClass; // 0x98
		internal _IsTrackedDeviceConnected IsTrackedDeviceConnected; // 0xA0
		internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty; // 0xA8
		internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty; // 0xB0
		internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty; // 0xB8
		internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty; // 0xC0
		internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty; // 0xC8
		internal _GetArrayTrackedDeviceProperty GetArrayTrackedDeviceProperty; // 0xD0
		internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty; // 0xD8
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum; // 0xE0
		internal _PollNextEvent PollNextEvent; // 0xE8
		internal _PollNextEventWithPose PollNextEventWithPose; // 0xF0
		internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum; // 0xF8
		internal _GetHiddenAreaMesh GetHiddenAreaMesh; // 0x100
		internal _GetControllerState GetControllerState; // 0x108
		internal _GetControllerStateWithPose GetControllerStateWithPose; // 0x110
		internal _TriggerHapticPulse TriggerHapticPulse; // 0x118
		internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum; // 0x120
		internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum; // 0x128
		internal _IsInputAvailable IsInputAvailable; // 0x130
		internal _IsSteamVRDrawingControllers IsSteamVRDrawingControllers; // 0x138
		internal _ShouldApplicationPause ShouldApplicationPause; // 0x140
		internal _ShouldApplicationReduceRenderingWork ShouldApplicationReduceRenderingWork; // 0x148
		internal _PerformFirmwareUpdate PerformFirmwareUpdate; // 0x150
		internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting; // 0x158
		internal _GetAppContainerFilePaths GetAppContainerFilePaths; // 0x160
		internal _GetRuntimeVersion GetRuntimeVersion; // 0x168
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6244; 0x000000018092DE40-0x000000018092DFE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ); // TypeDefIndex: 6245; 0x0000000180933770-0x0000000180933B30
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom); // TypeDefIndex: 6246; 0x000000018092C9A0-0x000000018092CD50
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates); // TypeDefIndex: 6247; 0x000000018091FF50-0x00000001809202D0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye); // TypeDefIndex: 6248; 0x000000018092CE20-0x000000018092D150
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter); // TypeDefIndex: 6249; 0x0000000180936020-0x0000000180936300
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate int _GetD3D9AdapterIndex(); // TypeDefIndex: 6250; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex); // TypeDefIndex: 6251; 0x000000018092B470-0x000000018092B720
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance); // TypeDefIndex: 6252; 0x0000000180930640-0x0000000180930920
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsDisplayOnDesktop(); // TypeDefIndex: 6253; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop); // TypeDefIndex: 6254; 0x000000018093D1B0-0x000000018093D470
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In, Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount); // TypeDefIndex: 6255; 0x000000018092BC30-0x000000018092BF90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose(); // TypeDefIndex: 6256; 0x0000000180933D40-0x0000000180933F40
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose(); // TypeDefIndex: 6257; 0x0000000180933D40-0x0000000180933F40
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In, Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex); // TypeDefIndex: 6258; 0x0000000180935110-0x0000000180935480
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId); // TypeDefIndex: 6259; 0x0000000180929E80-0x000000018092A010
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform); // TypeDefIndex: 6260; 0x000000018091EE30-0x000000018091F100
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType); // TypeDefIndex: 6261; 0x0000000180936480-0x0000000180936740
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex); // TypeDefIndex: 6262; 0x0000000180929E80-0x000000018092A010
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex); // TypeDefIndex: 6263; 0x0000000180929E80-0x000000018092A010
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex); // TypeDefIndex: 6264; 0x0000000180938F60-0x00000001809390F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6265; 0x0000000180926FB0-0x00000001809272A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6266; 0x000000018092D260-0x000000018092D550
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6267; 0x000000018092E590-0x000000018092E880
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6268; 0x0000000180936C40-0x0000000180936F30
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 6269; 0x000000018092F670-0x000000018092F9D0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError); // TypeDefIndex: 6270; 0x0000000180926220-0x00000001809265C0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError); // TypeDefIndex: 6271; 0x0000000180934510-0x0000000180934750
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error); // TypeDefIndex: 6272; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent); // TypeDefIndex: 6273; 0x0000000180929AB0-0x0000000180929D80
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 6274; 0x000000018093A710-0x000000018093AA90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType); // TypeDefIndex: 6275; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type); // TypeDefIndex: 6276; 0x000000018092E080-0x000000018092E410
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize); // TypeDefIndex: 6277; 0x000000018092A0D0-0x000000018092A3C0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 6278; 0x000000018092A4E0-0x000000018092A8A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec); // TypeDefIndex: 6279; 0x0000000180942C50-0x0000000180942F60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId); // TypeDefIndex: 6280; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType); // TypeDefIndex: 6281; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsInputAvailable(); // TypeDefIndex: 6282; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsSteamVRDrawingControllers(); // TypeDefIndex: 6283; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _ShouldApplicationPause(); // TypeDefIndex: 6284; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _ShouldApplicationReduceRenderingWork(); // TypeDefIndex: 6285; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex); // TypeDefIndex: 6286; 0x0000000180929E80-0x000000018092A010
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _AcknowledgeQuit_Exiting(); // TypeDefIndex: 6287; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetAppContainerFilePaths(StringBuilder pchBuffer, uint unBufferSize); // TypeDefIndex: 6288; 0x0000000180924500-0x0000000180924760
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetRuntimeVersion(); // TypeDefIndex: 6289; 0x00000001808A3FC0-0x00000001808A4260
	}
}
