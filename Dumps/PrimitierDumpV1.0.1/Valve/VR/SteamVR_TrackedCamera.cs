/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_TrackedCamera // TypeDefIndex: 7377
	{
		// Fields
		private static VideoStreamTexture[] distorted; // 0x00
		private static VideoStreamTexture[] undistorted; // 0x08
		private static VideoStream[] videostreams; // 0x10
	
		// Nested types
		public class VideoStreamTexture // TypeDefIndex: 7375
		{
			// Fields
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private bool _undistorted_k__BackingField; // 0x10
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private VRTextureBounds_t _frameBounds_k__BackingField; // 0x14
			private Texture2D _texture; // 0x28
			private int prevFrameCount; // 0x30
			private uint glTextureId; // 0x34
			private VideoStream videostream; // 0x38
			private CameraVideoStreamFrameHeader_t header; // 0x40
	
			// Properties
			public bool undistorted { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802A2940-0x00000001802A2950 0x00000001802A29C0-0x00000001802A29D0
			public uint deviceIndex { get; } // 0x00000001802A2810-0x00000001802A2830 
			public bool hasCamera { get; } // 0x00000001802A2870-0x00000001802A2890 
			public bool hasTracking { get; } // 0x00000001802A2890-0x00000001802A28B0 
			public uint frameId { get; } // 0x00000001802A2840-0x00000001802A2860 
			public VRTextureBounds_t frameBounds { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802A2830-0x00000001802A2840 0x00000001802A29B0-0x00000001802A29C0
			public EVRTrackedCameraFrameType frameType { get; } // 0x00000001802A2860-0x00000001802A2870 
			public Texture2D texture { get; } // 0x00000001802A28B0-0x00000001802A28D0 
			public SteamVR_Utils.RigidTransform transform { get; } // 0x00000001802A28D0-0x00000001802A2940 
			public Vector3 velocity { get; } // 0x00000001802A2950-0x00000001802A29B0 
			public Vector3 angularVelocity { get; } // 0x00000001802A27B0-0x00000001802A2810 
	
			// Constructors
			public VideoStreamTexture(uint deviceIndex, bool undistorted); // 0x00000001802A2760-0x00000001802A27B0
	
			// Methods
			public TrackedDevicePose_t GetPose(); // 0x00000001802A2170-0x00000001802A21D0
			public ulong Acquire(); // 0x00000001802A20D0-0x00000001802A2170
			public ulong Release(); // 0x00000001802A21D0-0x00000001802A22E0
			private void Update(); // 0x00000001802A22E0-0x00000001802A2760
		}
	
		private class VideoStream // TypeDefIndex: 7376
		{
			// Fields
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private uint _deviceIndex_k__BackingField; // 0x10
			private ulong _handle; // 0x18
			private bool _hasCamera; // 0x20
			private ulong refCount; // 0x28
	
			// Properties
			public uint deviceIndex { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180260E80-0x0000000180260F00 0x00000001802A2B90-0x00000001802A2BA0
			public ulong handle { get; } // 0x0000000180268C10-0x0000000180268C20 
			public bool hasCamera { get; } // 0x00000001802A2B80-0x00000001802A2B90 
	
			// Constructors
			public VideoStream(uint deviceIndex); // 0x00000001802A2B00-0x00000001802A2B80
	
			// Methods
			public ulong Acquire(); // 0x00000001802A29D0-0x00000001802A2A60
			public ulong Release(); // 0x00000001802A2A60-0x00000001802A2B00
		}
	
		// Constructors
		public SteamVR_TrackedCamera(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static VideoStreamTexture Distorted(int deviceIndex = 0 /* Metadata: 0x003A5921 */); // 0x0000000180C74640-0x0000000180C747B0
		public static VideoStreamTexture Undistorted(int deviceIndex = 0 /* Metadata: 0x003A5925 */); // 0x0000000180C74C00-0x0000000180C74D80
		public static VideoStreamTexture Source(bool undistorted, int deviceIndex = 0 /* Metadata: 0x003A5929 */); // 0x0000000180C747B0-0x0000000180C74A90
		private static VideoStream Stream(uint deviceIndex); // 0x0000000180C74A90-0x0000000180C74C00
	}
}
