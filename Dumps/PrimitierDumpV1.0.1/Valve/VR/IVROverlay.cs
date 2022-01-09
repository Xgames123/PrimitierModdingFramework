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
	public struct IVROverlay // TypeDefIndex: 6502
	{
		// Fields
		internal _FindOverlay FindOverlay; // 0x00
		internal _CreateOverlay CreateOverlay; // 0x08
		internal _DestroyOverlay DestroyOverlay; // 0x10
		internal _GetOverlayKey GetOverlayKey; // 0x18
		internal _GetOverlayName GetOverlayName; // 0x20
		internal _SetOverlayName SetOverlayName; // 0x28
		internal _GetOverlayImageData GetOverlayImageData; // 0x30
		internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum; // 0x38
		internal _SetOverlayRenderingPid SetOverlayRenderingPid; // 0x40
		internal _GetOverlayRenderingPid GetOverlayRenderingPid; // 0x48
		internal _SetOverlayFlag SetOverlayFlag; // 0x50
		internal _GetOverlayFlag GetOverlayFlag; // 0x58
		internal _GetOverlayFlags GetOverlayFlags; // 0x60
		internal _SetOverlayColor SetOverlayColor; // 0x68
		internal _GetOverlayColor GetOverlayColor; // 0x70
		internal _SetOverlayAlpha SetOverlayAlpha; // 0x78
		internal _GetOverlayAlpha GetOverlayAlpha; // 0x80
		internal _SetOverlayTexelAspect SetOverlayTexelAspect; // 0x88
		internal _GetOverlayTexelAspect GetOverlayTexelAspect; // 0x90
		internal _SetOverlaySortOrder SetOverlaySortOrder; // 0x98
		internal _GetOverlaySortOrder GetOverlaySortOrder; // 0xA0
		internal _SetOverlayWidthInMeters SetOverlayWidthInMeters; // 0xA8
		internal _GetOverlayWidthInMeters GetOverlayWidthInMeters; // 0xB0
		internal _SetOverlayCurvature SetOverlayCurvature; // 0xB8
		internal _GetOverlayCurvature GetOverlayCurvature; // 0xC0
		internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace; // 0xC8
		internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace; // 0xD0
		internal _SetOverlayTextureBounds SetOverlayTextureBounds; // 0xD8
		internal _GetOverlayTextureBounds GetOverlayTextureBounds; // 0xE0
		internal _GetOverlayTransformType GetOverlayTransformType; // 0xE8
		internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute; // 0xF0
		internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute; // 0xF8
		internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative; // 0x100
		internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative; // 0x108
		internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent; // 0x110
		internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent; // 0x118
		internal _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative; // 0x120
		internal _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative; // 0x128
		internal _SetOverlayTransformCursor SetOverlayTransformCursor; // 0x130
		internal _GetOverlayTransformCursor GetOverlayTransformCursor; // 0x138
		internal _ShowOverlay ShowOverlay; // 0x140
		internal _HideOverlay HideOverlay; // 0x148
		internal _IsOverlayVisible IsOverlayVisible; // 0x150
		internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates; // 0x158
		internal _PollNextOverlayEvent PollNextOverlayEvent; // 0x160
		internal _GetOverlayInputMethod GetOverlayInputMethod; // 0x168
		internal _SetOverlayInputMethod SetOverlayInputMethod; // 0x170
		internal _GetOverlayMouseScale GetOverlayMouseScale; // 0x178
		internal _SetOverlayMouseScale SetOverlayMouseScale; // 0x180
		internal _ComputeOverlayIntersection ComputeOverlayIntersection; // 0x188
		internal _IsHoverTargetOverlay IsHoverTargetOverlay; // 0x190
		internal _SetOverlayIntersectionMask SetOverlayIntersectionMask; // 0x198
		internal _TriggerLaserMouseHapticVibration TriggerLaserMouseHapticVibration; // 0x1A0
		internal _SetOverlayCursor SetOverlayCursor; // 0x1A8
		internal _SetOverlayCursorPositionOverride SetOverlayCursorPositionOverride; // 0x1B0
		internal _ClearOverlayCursorPositionOverride ClearOverlayCursorPositionOverride; // 0x1B8
		internal _SetOverlayTexture SetOverlayTexture; // 0x1C0
		internal _ClearOverlayTexture ClearOverlayTexture; // 0x1C8
		internal _SetOverlayRaw SetOverlayRaw; // 0x1D0
		internal _SetOverlayFromFile SetOverlayFromFile; // 0x1D8
		internal _GetOverlayTexture GetOverlayTexture; // 0x1E0
		internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle; // 0x1E8
		internal _GetOverlayTextureSize GetOverlayTextureSize; // 0x1F0
		internal _CreateDashboardOverlay CreateDashboardOverlay; // 0x1F8
		internal _IsDashboardVisible IsDashboardVisible; // 0x200
		internal _IsActiveDashboardOverlay IsActiveDashboardOverlay; // 0x208
		internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess; // 0x210
		internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess; // 0x218
		internal _ShowDashboard ShowDashboard; // 0x220
		internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice; // 0x228
		internal _ShowKeyboard ShowKeyboard; // 0x230
		internal _ShowKeyboardForOverlay ShowKeyboardForOverlay; // 0x238
		internal _GetKeyboardText GetKeyboardText; // 0x240
		internal _HideKeyboard HideKeyboard; // 0x248
		internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute; // 0x250
		internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay; // 0x258
		internal _ShowMessageOverlay ShowMessageOverlay; // 0x260
		internal _CloseMessageOverlay CloseMessageOverlay; // 0x268
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _FindOverlay(IntPtr pchOverlayKey, ref ulong pOverlayHandle); // TypeDefIndex: 6424; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _CreateOverlay(IntPtr pchOverlayKey, IntPtr pchOverlayName, ref ulong pOverlayHandle); // TypeDefIndex: 6425; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6426; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError); // TypeDefIndex: 6427; 0x0000000180931660-0x0000000180931870
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError); // TypeDefIndex: 6428; 0x0000000180931660-0x0000000180931870
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayName(ulong ulOverlayHandle, IntPtr pchName); // TypeDefIndex: 6429; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight); // TypeDefIndex: 6430; 0x0000000180931170-0x00000001809314D0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error); // TypeDefIndex: 6431; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID); // TypeDefIndex: 6432; 0x000000018093BAB0-0x000000018093BC60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle); // TypeDefIndex: 6433; 0x000000018091F310-0x000000018091F5E0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled); // TypeDefIndex: 6434; 0x000000018093F100-0x000000018093F400
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled); // TypeDefIndex: 6435; 0x0000000180930CC0-0x0000000180930FB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags); // TypeDefIndex: 6436; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue); // TypeDefIndex: 6437; 0x000000018093EC20-0x000000018093EE50
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue); // TypeDefIndex: 6438; 0x0000000180920A10-0x0000000180920D50
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha); // TypeDefIndex: 6439; 0x000000018093E970-0x000000018093EB40
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha); // TypeDefIndex: 6440; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect); // TypeDefIndex: 6441; 0x000000018093E970-0x000000018093EB40
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect); // TypeDefIndex: 6442; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder); // TypeDefIndex: 6443; 0x000000018093BAB0-0x000000018093BC60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder); // TypeDefIndex: 6444; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters); // TypeDefIndex: 6445; 0x000000018093E970-0x000000018093EB40
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters); // TypeDefIndex: 6446; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayCurvature(ulong ulOverlayHandle, float fCurvature); // TypeDefIndex: 6447; 0x000000018093E970-0x000000018093EB40
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayCurvature(ulong ulOverlayHandle, ref float pfCurvature); // TypeDefIndex: 6448; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace); // TypeDefIndex: 6449; 0x000000018093BAB0-0x000000018093BC60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace); // TypeDefIndex: 6450; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds); // TypeDefIndex: 6451; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds); // TypeDefIndex: 6452; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType); // TypeDefIndex: 6453; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform); // TypeDefIndex: 6454; 0x0000000180930CC0-0x0000000180930FB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform); // TypeDefIndex: 6455; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform); // TypeDefIndex: 6456; 0x0000000180930CC0-0x0000000180930FB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform); // TypeDefIndex: 6457; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, IntPtr pchComponentName); // TypeDefIndex: 6458; 0x0000000180930CC0-0x0000000180930FB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize); // TypeDefIndex: 6459; 0x000000018091DF40-0x000000018091E280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform); // TypeDefIndex: 6460; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform); // TypeDefIndex: 6461; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTransformCursor(ulong ulCursorOverlayHandle, ref HmdVector2_t pvHotspot); // TypeDefIndex: 6462; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTransformCursor(ulong ulOverlayHandle, ref HmdVector2_t pvHotspot); // TypeDefIndex: 6463; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6464; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6465; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle); // TypeDefIndex: 6466; 0x000000018091F660-0x000000018091F800
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform); // TypeDefIndex: 6467; 0x0000000180936830-0x0000000180936B70
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent); // TypeDefIndex: 6468; 0x000000018093AC10-0x000000018093AF00
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod); // TypeDefIndex: 6469; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod); // TypeDefIndex: 6470; 0x000000018093BAB0-0x000000018093BC60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale); // TypeDefIndex: 6471; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale); // TypeDefIndex: 6472; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults); // TypeDefIndex: 6473; 0x00000001809203E0-0x00000001809206D0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6474; 0x000000018091F660-0x000000018091F800
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize); // TypeDefIndex: 6475; 0x0000000180930160-0x00000001809304A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _TriggerLaserMouseHapticVibration(ulong ulOverlayHandle, float fDurationSeconds, float fFrequency, float fAmplitude); // TypeDefIndex: 6476; 0x000000018093EC20-0x000000018093EE50
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayCursor(ulong ulOverlayHandle, ulong ulCursorHandle); // TypeDefIndex: 6477; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayCursorPositionOverride(ulong ulOverlayHandle, ref HmdVector2_t pvCursor); // TypeDefIndex: 6478; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _ClearOverlayCursorPositionOverride(ulong ulOverlayHandle); // TypeDefIndex: 6479; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture); // TypeDefIndex: 6480; 0x0000000180921410-0x00000001809216F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle); // TypeDefIndex: 6481; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unBytesPerPixel); // TypeDefIndex: 6482; 0x0000000180921C30-0x0000000180921F90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, IntPtr pchFilePath); // TypeDefIndex: 6483; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds); // TypeDefIndex: 6484; 0x0000000180932000-0x0000000180932490
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle); // TypeDefIndex: 6485; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight); // TypeDefIndex: 6486; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _CreateDashboardOverlay(IntPtr pchOverlayKey, IntPtr pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle); // TypeDefIndex: 6487; 0x0000000180920A10-0x0000000180920D50
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsDashboardVisible(); // TypeDefIndex: 6488; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle); // TypeDefIndex: 6489; 0x000000018091F660-0x000000018091F800
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId); // TypeDefIndex: 6490; 0x000000018093BAB0-0x000000018093BC60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId); // TypeDefIndex: 6491; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ShowDashboard(IntPtr pchOverlayToShow); // TypeDefIndex: 6492; 0x0000000180923710-0x00000001809238A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetPrimaryDashboardDevice(); // TypeDefIndex: 6493; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, uint unFlags, IntPtr pchDescription, uint unCharMax, IntPtr pchExistingText, ulong uUserValue); // TypeDefIndex: 6494; 0x00000001809417C0-0x0000000180941BB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, uint unFlags, IntPtr pchDescription, uint unCharMax, IntPtr pchExistingText, ulong uUserValue); // TypeDefIndex: 6495; 0x0000000180941250-0x0000000180941690
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetKeyboardText(StringBuilder pchText, uint cchText); // TypeDefIndex: 6496; 0x0000000180924500-0x0000000180924760
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _HideKeyboard(); // TypeDefIndex: 6497; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform); // TypeDefIndex: 6498; 0x0000000180840C20-0x0000000180840F10
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect); // TypeDefIndex: 6499; 0x000000018093E530-0x000000018093E820
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate VRMessageOverlayResponse _ShowMessageOverlay(IntPtr pchText, IntPtr pchCaption, IntPtr pchButton0Text, IntPtr pchButton1Text, IntPtr pchButton2Text, IntPtr pchButton3Text); // TypeDefIndex: 6500; 0x0000000180941CC0-0x0000000180942070
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _CloseMessageOverlay(); // TypeDefIndex: 6501; 0x000000018070FF10-0x0000000180710080
	}
}
