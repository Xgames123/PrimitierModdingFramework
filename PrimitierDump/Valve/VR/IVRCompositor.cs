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
	public struct IVRCompositor // TypeDefIndex: 6423
	{
		// Fields
		internal _SetTrackingSpace SetTrackingSpace; // 0x00
		internal _GetTrackingSpace GetTrackingSpace; // 0x08
		internal _WaitGetPoses WaitGetPoses; // 0x10
		internal _GetLastPoses GetLastPoses; // 0x18
		internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex; // 0x20
		internal _Submit Submit; // 0x28
		internal _ClearLastSubmittedFrame ClearLastSubmittedFrame; // 0x30
		internal _PostPresentHandoff PostPresentHandoff; // 0x38
		internal _GetFrameTiming GetFrameTiming; // 0x40
		internal _GetFrameTimings GetFrameTimings; // 0x48
		internal _GetFrameTimeRemaining GetFrameTimeRemaining; // 0x50
		internal _GetCumulativeStats GetCumulativeStats; // 0x58
		internal _FadeToColor FadeToColor; // 0x60
		internal _GetCurrentFadeColor GetCurrentFadeColor; // 0x68
		internal _FadeGrid FadeGrid; // 0x70
		internal _GetCurrentGridAlpha GetCurrentGridAlpha; // 0x78
		internal _SetSkyboxOverride SetSkyboxOverride; // 0x80
		internal _ClearSkyboxOverride ClearSkyboxOverride; // 0x88
		internal _CompositorBringToFront CompositorBringToFront; // 0x90
		internal _CompositorGoToBack CompositorGoToBack; // 0x98
		internal _CompositorQuit CompositorQuit; // 0xA0
		internal _IsFullscreen IsFullscreen; // 0xA8
		internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess; // 0xB0
		internal _GetLastFrameRenderer GetLastFrameRenderer; // 0xB8
		internal _CanRenderScene CanRenderScene; // 0xC0
		internal _ShowMirrorWindow ShowMirrorWindow; // 0xC8
		internal _HideMirrorWindow HideMirrorWindow; // 0xD0
		internal _IsMirrorWindowVisible IsMirrorWindowVisible; // 0xD8
		internal _CompositorDumpImages CompositorDumpImages; // 0xE0
		internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources; // 0xE8
		internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn; // 0xF0
		internal _ForceReconnectProcess ForceReconnectProcess; // 0xF8
		internal _SuspendRendering SuspendRendering; // 0x100
		internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11; // 0x108
		internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11; // 0x110
		internal _GetMirrorTextureGL GetMirrorTextureGL; // 0x118
		internal _ReleaseSharedGLTexture ReleaseSharedGLTexture; // 0x120
		internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess; // 0x128
		internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess; // 0x130
		internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired; // 0x138
		internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired; // 0x140
		internal _SetExplicitTimingMode SetExplicitTimingMode; // 0x148
		internal _SubmitExplicitTimingData SubmitExplicitTimingData; // 0x150
		internal _IsMotionSmoothingEnabled IsMotionSmoothingEnabled; // 0x158
		internal _IsMotionSmoothingSupported IsMotionSmoothingSupported; // 0x160
		internal _IsCurrentSceneFocusAppLoading IsCurrentSceneFocusAppLoading; // 0x168
		internal _SetStageOverride_Async SetStageOverride_Async; // 0x170
		internal _ClearStageOverride ClearStageOverride; // 0x178
		internal _GetCompositorBenchmarkResults GetCompositorBenchmarkResults; // 0x180
		internal _GetLastPosePredictionIDs GetLastPosePredictionIDs; // 0x188
		internal _GetPosesForFrame GetPosesForFrame; // 0x190
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin); // TypeDefIndex: 6372; 0x000000018093BE00-0x000000018093BF90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackingUniverseOrigin _GetTrackingSpace(); // TypeDefIndex: 6373; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _WaitGetPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount); // TypeDefIndex: 6374; 0x000000018092EEE0-0x000000018092F0E0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _GetLastPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount); // TypeDefIndex: 6375; 0x000000018092EEE0-0x000000018092F0E0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose); // TypeDefIndex: 6376; 0x000000018092EA90-0x000000018092ED80
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags); // TypeDefIndex: 6377; 0x0000000180942390-0x0000000180942700
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ClearLastSubmittedFrame(); // TypeDefIndex: 6378; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _PostPresentHandoff(); // TypeDefIndex: 6379; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo); // TypeDefIndex: 6380; 0x0000000180929AB0-0x0000000180929D80
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetFrameTimings([In, Out] Compositor_FrameTiming[] pTiming, uint nFrames); // TypeDefIndex: 6381; 0x000000018092DA40-0x000000018092DD00
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate float _GetFrameTimeRemaining(); // TypeDefIndex: 6382; 0x000000018092B1C0-0x000000018092B340
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes); // TypeDefIndex: 6383; 0x000000018092AB50-0x000000018092AE10
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground); // TypeDefIndex: 6384; 0x0000000180923070-0x0000000180923440
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate HmdColor_t _GetCurrentFadeColor(bool bBackground); // TypeDefIndex: 6385; 0x000000018092AE90-0x000000018092B1C0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _FadeGrid(float fSeconds, bool bFadeIn); // TypeDefIndex: 6386; 0x000000018054A650-0x000000018054A930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate float _GetCurrentGridAlpha(); // TypeDefIndex: 6387; 0x000000018092B1C0-0x000000018092B340
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _SetSkyboxOverride([In, Out] Texture_t[] pTextures, uint unTextureCount); // TypeDefIndex: 6388; 0x000000018092DA40-0x000000018092DD00
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ClearSkyboxOverride(); // TypeDefIndex: 6389; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _CompositorBringToFront(); // TypeDefIndex: 6390; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _CompositorGoToBack(); // TypeDefIndex: 6391; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _CompositorQuit(); // TypeDefIndex: 6392; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsFullscreen(); // TypeDefIndex: 6393; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetCurrentSceneFocusProcess(); // TypeDefIndex: 6394; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetLastFrameRenderer(); // TypeDefIndex: 6395; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _CanRenderScene(); // TypeDefIndex: 6396; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ShowMirrorWindow(); // TypeDefIndex: 6397; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _HideMirrorWindow(); // TypeDefIndex: 6398; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsMirrorWindowVisible(); // TypeDefIndex: 6399; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _CompositorDumpImages(); // TypeDefIndex: 6400; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _ShouldAppRenderWithLowResources(); // TypeDefIndex: 6401; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ForceInterleavedReprojectionOn(bool bOverride); // TypeDefIndex: 6402; 0x000000018028FC80-0x000000018028FE10
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ForceReconnectProcess(); // TypeDefIndex: 6403; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SuspendRendering(bool bSuspend); // TypeDefIndex: 6404; 0x000000018028FC80-0x000000018028FE10
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView); // TypeDefIndex: 6405; 0x000000018092FA90-0x000000018092FC80
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView); // TypeDefIndex: 6406; 0x0000000180923710-0x00000001809238A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle); // TypeDefIndex: 6407; 0x000000018092FD50-0x0000000180930080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle); // TypeDefIndex: 6408; 0x000000018093B730-0x000000018093BA10
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle); // TypeDefIndex: 6409; 0x0000000180923710-0x00000001809238A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle); // TypeDefIndex: 6410; 0x0000000180923710-0x00000001809238A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 6411; 0x0000000180924500-0x0000000180924760
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 6412; 0x0000000180925F10-0x00000001809260E0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode); // TypeDefIndex: 6413; 0x000000018093BE00-0x000000018093BF90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _SubmitExplicitTimingData(); // TypeDefIndex: 6414; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsMotionSmoothingEnabled(); // TypeDefIndex: 6415; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsMotionSmoothingSupported(); // TypeDefIndex: 6416; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsCurrentSceneFocusAppLoading(); // TypeDefIndex: 6417; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _SetStageOverride_Async(IntPtr pchRenderModelPath, ref HmdMatrix34_t pTransform, ref Compositor_StageRenderSettings pRenderSettings, uint nSizeOfRenderSettings); // TypeDefIndex: 6418; 0x000000018091DF40-0x000000018091E280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ClearStageOverride(); // TypeDefIndex: 6419; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetCompositorBenchmarkResults(ref Compositor_BenchmarkResults pBenchmarkResults, uint nSizeOfBenchmarkResults); // TypeDefIndex: 6420; 0x0000000180929AB0-0x0000000180929D80
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _GetLastPosePredictionIDs(ref uint pRenderPosePredictionID, ref uint pGamePosePredictionID); // TypeDefIndex: 6421; 0x0000000180921410-0x00000001809216F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRCompositorError _GetPosesForFrame(uint unPosePredictionID, [In, Out] TrackedDevicePose_t[] pPoseArray, uint unPoseArrayCount); // TypeDefIndex: 6422; 0x0000000180933370-0x0000000180933660
	}
}
