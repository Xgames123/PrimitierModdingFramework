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
	public class CVRCompositor // TypeDefIndex: 6652
	{
		// Fields
		private IVRCompositor FnTable; // 0x10
	
		// Constructors
		internal CVRCompositor(IntPtr pInterface); // 0x00000001809089D0-0x0000000180908B40
	
		// Methods
		public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin); // 0x0000000180908130-0x0000000180908150
		public ETrackingUniverseOrigin GetTrackingSpace(); // 0x0000000180906F70-0x0000000180907100
		public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray); // 0x0000000180908990-0x00000001809089D0
		public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray); // 0x0000000180906E90-0x0000000180906ED0
		public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose); // 0x0000000180906E30-0x0000000180906E60
		public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags); // 0x0000000180908600-0x0000000180908630
		public void ClearLastSubmittedFrame(); // 0x0000000180905D20-0x0000000180905EB0
		public void PostPresentHandoff(); // 0x0000000180907C70-0x0000000180907E00
		public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo); // 0x0000000180906C50-0x0000000180906C70
		public uint GetFrameTimings(Compositor_FrameTiming[] pTiming); // 0x0000000180906C70-0x0000000180906CA0
		public float GetFrameTimeRemaining(); // 0x0000000180906AC0-0x0000000180906C50
		public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes); // 0x0000000180906740-0x0000000180906760
		public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground); // 0x0000000180906390-0x00000001809063D0
		public HmdColor_t GetCurrentFadeColor(bool bBackground); // 0x0000000180906760-0x00000001809067A0
		public void FadeGrid(float fSeconds, bool bFadeIn); // 0x0000000180906360-0x0000000180906390
		public float GetCurrentGridAlpha(); // 0x00000001809067A0-0x0000000180906930
		public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures); // 0x0000000180908010-0x0000000180908040
		public void ClearSkyboxOverride(); // 0x0000000180905040-0x00000001809051D0
		public void CompositorBringToFront(); // 0x00000001809049E0-0x0000000180904B70
		public void CompositorGoToBack(); // 0x0000000180904DF0-0x0000000180904F80
		public void CompositorQuit(); // 0x00000001809061D0-0x0000000180906360
		public bool IsFullscreen(); // 0x0000000180907480-0x0000000180907610
		public uint GetCurrentSceneFocusProcess(); // 0x0000000180906930-0x0000000180906AC0
		public uint GetLastFrameRenderer(); // 0x0000000180906CA0-0x0000000180906E30
		public bool CanRenderScene(); // 0x0000000180905B90-0x0000000180905D20
		public void ShowMirrorWindow(); // 0x00000001809082E0-0x0000000180908470
		public void HideMirrorWindow(); // 0x0000000180907160-0x00000001809072F0
		public bool IsMirrorWindowVisible(); // 0x0000000180907610-0x00000001809077A0
		public void CompositorDumpImages(); // 0x0000000180906040-0x00000001809061D0
		public bool ShouldAppRenderWithLowResources(); // 0x0000000180908150-0x00000001809082E0
		public void ForceInterleavedReprojectionOn(bool bOverride); // 0x00000001809063D0-0x0000000180906580
		public void ForceReconnectProcess(); // 0x0000000180906580-0x0000000180906710
		public void SuspendRendering(bool bSuspend); // 0x0000000180908630-0x00000001809087E0
		public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView); // 0x0000000180906ED0-0x0000000180906F00
		public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView); // 0x0000000180907E00-0x0000000180907FB0
		public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle); // 0x0000000180906F00-0x0000000180906F30
		public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle); // 0x0000000180907FB0-0x0000000180907FE0
		public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle); // 0x0000000180907AC0-0x0000000180907C70
		public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle); // 0x00000001809087E0-0x0000000180908990
		public uint GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize); // 0x0000000180907130-0x0000000180907160
		public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize); // 0x0000000180907100-0x0000000180907130
		public void SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode); // 0x0000000180907FE0-0x0000000180908010
		public EVRCompositorError SubmitExplicitTimingData(); // 0x0000000180908470-0x0000000180908600
		public bool IsMotionSmoothingEnabled(); // 0x00000001809077A0-0x0000000180907930
		public bool IsMotionSmoothingSupported(); // 0x0000000180907930-0x0000000180907AC0
		public bool IsCurrentSceneFocusAppLoading(); // 0x00000001809072F0-0x0000000180907480
		public EVRCompositorError SetStageOverride_Async(string pchRenderModelPath, ref HmdMatrix34_t pTransform, ref Compositor_StageRenderSettings pRenderSettings, uint nSizeOfRenderSettings); // 0x0000000180908040-0x0000000180908130
		public void ClearStageOverride(); // 0x0000000180905EB0-0x0000000180906040
		public bool GetCompositorBenchmarkResults(ref Compositor_BenchmarkResults pBenchmarkResults, uint nSizeOfBenchmarkResults); // 0x0000000180906710-0x0000000180906740
		public EVRCompositorError GetLastPosePredictionIDs(ref uint pRenderPosePredictionID, ref uint pGamePosePredictionID); // 0x0000000180906E60-0x0000000180906E90
		public EVRCompositorError GetPosesForFrame(uint unPosePredictionID, TrackedDevicePose_t[] pPoseArray); // 0x0000000180906F30-0x0000000180906F70
	}
}
