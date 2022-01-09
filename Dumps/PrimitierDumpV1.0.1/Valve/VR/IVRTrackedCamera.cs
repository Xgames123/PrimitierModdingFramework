/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct IVRTrackedCamera // TypeDefIndex: 6309
	{
		// Fields
		internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum; // 0x00
		internal _HasCamera HasCamera; // 0x08
		internal _GetCameraFrameSize GetCameraFrameSize; // 0x10
		internal _GetCameraIntrinsics GetCameraIntrinsics; // 0x18
		internal _GetCameraProjection GetCameraProjection; // 0x20
		internal _AcquireVideoStreamingService AcquireVideoStreamingService; // 0x28
		internal _ReleaseVideoStreamingService ReleaseVideoStreamingService; // 0x30
		internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer; // 0x38
		internal _GetVideoStreamTextureSize GetVideoStreamTextureSize; // 0x40
		internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11; // 0x48
		internal _GetVideoStreamTextureGL GetVideoStreamTextureGL; // 0x50
		internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL; // 0x58
		internal _SetCameraTrackingSpace SetCameraTrackingSpace; // 0x60
		internal _GetCameraTrackingSpace GetCameraTrackingSpace; // 0x68
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError); // TypeDefIndex: 6295; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, ref bool pHasCamera); // TypeDefIndex: 6296; 0x000000018091E450-0x000000018091E730
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize); // TypeDefIndex: 6297; 0x00000001809279D0-0x0000000180927D20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _GetCameraIntrinsics(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter); // TypeDefIndex: 6298; 0x0000000180927E30-0x0000000180928180
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, uint nCameraIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection); // TypeDefIndex: 6299; 0x00000001809282C0-0x0000000180928670
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle); // TypeDefIndex: 6300; 0x000000018091E450-0x000000018091E730
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera); // TypeDefIndex: 6301; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 6302; 0x0000000180937070-0x0000000180937410
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6303; 0x00000001809279D0-0x0000000180927D20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 6304; 0x0000000180937550-0x00000001809378F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 6305; 0x0000000180937A10-0x0000000180937D70
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId); // TypeDefIndex: 6306; 0x000000018093BAB0-0x000000018093BC60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetCameraTrackingSpace(ETrackingUniverseOrigin eUniverse); // TypeDefIndex: 6307; 0x000000018093BE00-0x000000018093BF90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ETrackingUniverseOrigin _GetCameraTrackingSpace(); // TypeDefIndex: 6308; 0x00000001809247E0-0x0000000180924960
	}
}
