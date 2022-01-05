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
	public class CVROverlay // TypeDefIndex: 6655
	{
		// Fields
		private IVROverlay FnTable; // 0x10
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _PollNextOverlayEventPacked(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent); // TypeDefIndex: 6653; 0x000000018093AC10-0x000000018093AF00
	
		private struct PollNextOverlayEventUnion // TypeDefIndex: 6654
		{
			// Fields
			public IVROverlay._PollNextOverlayEvent pPollNextOverlayEvent; // 0x00
			public _PollNextOverlayEventPacked pPollNextOverlayEventPacked; // 0x00
		}
	
		// Constructors
		internal CVROverlay(IntPtr pInterface); // 0x000000018090CCB0-0x000000018090CE50
	
		// Methods
		public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle); // 0x000000018090B1C0-0x000000018090B290
		public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle); // 0x000000018090B0C0-0x000000018090B1C0
		public EVROverlayError DestroyOverlay(ulong ulOverlayHandle); // 0x00000001809045C0-0x00000001809045E0
		public uint GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError); // 0x000000018090B4B0-0x000000018090B4E0
		public uint GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError); // 0x000000018090B510-0x000000018090B540
		public EVROverlayError SetOverlayName(ulong ulOverlayHandle, string pchName); // 0x000000018090C260-0x000000018090C330
		public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight); // 0x000000018090B440-0x000000018090B480
		public string GetOverlayErrorNameFromEnum(EVROverlayError error); // 0x000000018090B390-0x000000018090B410
		public EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID); // 0x000000018090C360-0x000000018090C380
		public uint GetOverlayRenderingPid(ulong ulOverlayHandle); // 0x000000018090B540-0x000000018090B560
		public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled); // 0x000000018090C0D0-0x000000018090C100
		public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled); // 0x000000018090B410-0x000000018090B440
		public EVROverlayError GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags); // 0x000000018090A0B0-0x000000018090A0E0
		public EVROverlayError SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue); // 0x000000018090C010-0x000000018090C040
		public EVROverlayError GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue); // 0x000000018090B320-0x000000018090B360
		public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha); // 0x000000018090BFE0-0x000000018090C010
		public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha); // 0x000000018090B2F0-0x000000018090B320
		public EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect); // 0x000000018090C3B0-0x000000018090C3E0
		public EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect); // 0x000000018090B590-0x000000018090B5C0
		public EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder); // 0x000000018090C380-0x000000018090C3B0
		public EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder); // 0x000000018090B560-0x000000018090B590
		public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters); // 0x000000018090C610-0x000000018090C640
		public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters); // 0x000000018090B790-0x000000018090B7C0
		public EVROverlayError SetOverlayCurvature(ulong ulOverlayHandle, float fCurvature); // 0x000000018090C0A0-0x000000018090C0D0
		public EVROverlayError GetOverlayCurvature(ulong ulOverlayHandle, ref float pfCurvature); // 0x000000018090B360-0x000000018090B390
		public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace); // 0x000000018090C410-0x000000018090C440
		public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace); // 0x000000018090A760-0x000000018090A790
		public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds); // 0x000000018090C3E0-0x000000018090C410
		public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds); // 0x000000018090B5C0-0x000000018090B5F0
		public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType); // 0x000000018090B760-0x000000018090B790
		public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform); // 0x000000018090C470-0x000000018090C4A0
		public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform); // 0x000000018090B670-0x000000018090B6A0
		public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform); // 0x000000018090C5E0-0x000000018090C610
		public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform); // 0x000000018090B730-0x000000018090B760
		public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName); // 0x000000018090C500-0x000000018090C5E0
		public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize); // 0x000000018090B700-0x000000018090B730
		public EVROverlayError GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform); // 0x000000018090B6D0-0x000000018090B700
		public EVROverlayError SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform); // 0x000000018090C4D0-0x000000018090C500
		public EVROverlayError SetOverlayTransformCursor(ulong ulCursorOverlayHandle, ref HmdVector2_t pvHotspot); // 0x000000018090C4A0-0x000000018090C4D0
		public EVROverlayError GetOverlayTransformCursor(ulong ulOverlayHandle, ref HmdVector2_t pvHotspot); // 0x000000018090B6A0-0x000000018090B6D0
		public EVROverlayError ShowOverlay(ulong ulOverlayHandle); // 0x000000018090CC50-0x000000018090CC80
		public EVROverlayError HideOverlay(ulong ulOverlayHandle); // 0x000000018090BB10-0x000000018090BB40
		public bool IsOverlayVisible(ulong ulOverlayHandle); // 0x000000018090BD30-0x000000018090BD60
		public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform); // 0x000000018090B950-0x000000018090B980
		public bool PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent); // 0x000000018090BD60-0x000000018090BF10
		public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod); // 0x000000018090B480-0x000000018090B4B0
		public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod); // 0x000000018090C1D0-0x000000018090C200
		public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale); // 0x000000018090B4E0-0x000000018090B510
		public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale); // 0x000000018090C230-0x000000018090C260
		public bool ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults); // 0x000000018090AF80-0x000000018090AFB0
		public bool IsHoverTargetOverlay(ulong ulOverlayHandle); // 0x000000018090BD00-0x000000018090BD30
		public EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize); // 0x000000018090C200-0x000000018090C230
		public EVROverlayError TriggerLaserMouseHapticVibration(ulong ulOverlayHandle, float fDurationSeconds, float fFrequency, float fAmplitude); // 0x000000018090CC80-0x000000018090CCB0
		public EVROverlayError SetOverlayCursor(ulong ulOverlayHandle, ulong ulCursorHandle); // 0x000000018090C070-0x000000018090C0A0
		public EVROverlayError SetOverlayCursorPositionOverride(ulong ulOverlayHandle, ref HmdVector2_t pvCursor); // 0x000000018090C040-0x000000018090C070
		public EVROverlayError ClearOverlayCursorPositionOverride(ulong ulOverlayHandle); // 0x000000018090AD90-0x000000018090ADC0
		public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture); // 0x000000018090C440-0x000000018090C470
		public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle); // 0x000000018090ADC0-0x000000018090ADF0
		public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unBytesPerPixel); // 0x000000018090C330-0x000000018090C360
		public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath); // 0x000000018090C100-0x000000018090C1D0
		public EVROverlayError GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds); // 0x000000018090B620-0x000000018090B670
		public EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle); // 0x000000018090BF10-0x000000018090BF40
		public EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight); // 0x000000018090B5F0-0x000000018090B620
		public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle); // 0x000000018090AFB0-0x000000018090B0C0
		public bool IsDashboardVisible(); // 0x000000018090BB70-0x000000018090BD00
		public bool IsActiveDashboardOverlay(ulong ulOverlayHandle); // 0x000000018090BB40-0x000000018090BB70
		public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId); // 0x000000018090BF40-0x000000018090BF70
		public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId); // 0x000000018090B290-0x000000018090B2C0
		public void ShowDashboard(string pchOverlayToShow); // 0x000000018090C640-0x000000018090C850
		public uint GetPrimaryDashboardDevice(); // 0x000000018090B7C0-0x000000018090B950
		public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, uint unFlags, string pchDescription, uint unCharMax, string pchExistingText, ulong uUserValue); // 0x000000018090C990-0x000000018090CAC0
		public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, uint unFlags, string pchDescription, uint unCharMax, string pchExistingText, ulong uUserValue); // 0x000000018090C850-0x000000018090C990
		public uint GetKeyboardText(StringBuilder pchText, uint cchText); // 0x000000018090B2C0-0x000000018090B2F0
		public void HideKeyboard(); // 0x000000018090B980-0x000000018090BB10
		public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform); // 0x000000018090BFB0-0x000000018090BFE0
		public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect); // 0x000000018090BF70-0x000000018090BFB0
		public VRMessageOverlayResponse ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text); // 0x000000018090CAC0-0x000000018090CC50
		public void CloseMessageOverlay(); // 0x000000018090ADF0-0x000000018090AF80
	}
}
