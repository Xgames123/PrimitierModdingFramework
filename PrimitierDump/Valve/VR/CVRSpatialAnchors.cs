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
	public class CVRSpatialAnchors // TypeDefIndex: 6668
	{
		// Fields
		private IVRSpatialAnchors FnTable; // 0x10
	
		// Constructors
		internal CVRSpatialAnchors(IntPtr pInterface); // 0x000000018090FAD0-0x000000018090FBE0
	
		// Methods
		public EVRSpatialAnchorError CreateSpatialAnchorFromDescriptor(string pchDescriptor, ref uint pHandleOut); // 0x000000018090F970-0x000000018090FA40
		public EVRSpatialAnchorError CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut); // 0x000000018090FA40-0x000000018090FA70
		public EVRSpatialAnchorError GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut); // 0x000000018090FAA0-0x000000018090FAD0
		public EVRSpatialAnchorError GetSpatialAnchorDescriptor(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut); // 0x000000018090FA70-0x000000018090FAA0
	}
}
