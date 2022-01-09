/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRTrackedCamera // TypeDefIndex: 6648
	{
		// Fields
		private IVRTrackedCamera FnTable; // 0x10
	
		// Constructors
		internal CVRTrackedCamera(IntPtr pInterface); // 0x0000000180911DC0-0x0000000180911F00
	
		// Methods
		public string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError); // 0x00000001809119B0-0x0000000180911A30
		public EVRTrackedCameraError HasCamera(uint nDeviceIndex, ref bool pHasCamera); // 0x0000000180911D30-0x0000000180911D60
		public EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize); // 0x0000000180911A30-0x0000000180911A70
		public EVRTrackedCameraError GetCameraIntrinsics(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter); // 0x0000000180911A70-0x0000000180911AA0
		public EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection); // 0x0000000180911AA0-0x0000000180911AD0
		public EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle); // 0x0000000180911980-0x00000001809119B0
		public EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera); // 0x0000000180911D80-0x0000000180911DA0
		public EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // 0x0000000180911C60-0x0000000180911C90
		public EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight); // 0x0000000180911CF0-0x0000000180911D30
		public EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // 0x0000000180911C90-0x0000000180911CC0
		public EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // 0x0000000180911CC0-0x0000000180911CF0
		public EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId); // 0x0000000180911D60-0x0000000180911D80
		public void SetCameraTrackingSpace(ETrackingUniverseOrigin eUniverse); // 0x0000000180911DA0-0x0000000180911DC0
		public ETrackingUniverseOrigin GetCameraTrackingSpace(); // 0x0000000180911AD0-0x0000000180911C60
	}
}
