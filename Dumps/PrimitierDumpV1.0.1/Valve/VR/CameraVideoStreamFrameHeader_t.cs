/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct CameraVideoStreamFrameHeader_t // TypeDefIndex: 6815
	{
		// Fields
		public EVRTrackedCameraFrameType eFrameType; // 0x00
		public uint nWidth; // 0x04
		public uint nHeight; // 0x08
		public uint nBytesPerPixel; // 0x0C
		public uint nFrameSequence; // 0x10
		public TrackedDevicePose_t trackedDevicePose; // 0x14
		public ulong ulFrameExposureTime; // 0x68
	}
}
