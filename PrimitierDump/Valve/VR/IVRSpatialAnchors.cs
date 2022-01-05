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
	public struct IVRSpatialAnchors // TypeDefIndex: 6613
	{
		// Fields
		internal _CreateSpatialAnchorFromDescriptor CreateSpatialAnchorFromDescriptor; // 0x00
		internal _CreateSpatialAnchorFromPose CreateSpatialAnchorFromPose; // 0x08
		internal _GetSpatialAnchorPose GetSpatialAnchorPose; // 0x10
		internal _GetSpatialAnchorDescriptor GetSpatialAnchorDescriptor; // 0x18
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRSpatialAnchorError _CreateSpatialAnchorFromDescriptor(IntPtr pchDescriptor, ref uint pHandleOut); // TypeDefIndex: 6609; 0x0000000180921410-0x00000001809216F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRSpatialAnchorError _CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut); // TypeDefIndex: 6610; 0x00000001809217E0-0x0000000180921B20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRSpatialAnchorError _GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut); // TypeDefIndex: 6611; 0x000000018092E590-0x000000018092E880
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRSpatialAnchorError _GetSpatialAnchorDescriptor(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut); // TypeDefIndex: 6612; 0x000000018092EA90-0x000000018092ED80
	}
}
