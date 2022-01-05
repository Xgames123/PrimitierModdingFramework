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
	[Serializable]
	public class SteamVR_Skeleton_Pose_Hand // TypeDefIndex: 7314
	{
		// Fields
		public SteamVR_Input_Sources inputSource; // 0x10
		public SteamVR_Skeleton_FingerExtensionTypes thumbFingerMovementType; // 0x14
		public SteamVR_Skeleton_FingerExtensionTypes indexFingerMovementType; // 0x18
		public SteamVR_Skeleton_FingerExtensionTypes middleFingerMovementType; // 0x1C
		public SteamVR_Skeleton_FingerExtensionTypes ringFingerMovementType; // 0x20
		public SteamVR_Skeleton_FingerExtensionTypes pinkyFingerMovementType; // 0x24
		public bool ignoreRootPoseData; // 0x28
		public bool ignoreWristPoseData; // 0x29
		public Vector3 position; // 0x2C
		public Quaternion rotation; // 0x38
		public Vector3[] bonePositions; // 0x48
		public Quaternion[] boneRotations; // 0x50
	
		// Constructors
		public SteamVR_Skeleton_Pose_Hand(SteamVR_Input_Sources source); // 0x0000000180C71B50-0x0000000180C71B80
	
		// Methods
		public SteamVR_Skeleton_FingerExtensionTypes GetFingerExtensionType(int finger); // 0x0000000180C719B0-0x0000000180C71A90
		public SteamVR_Skeleton_FingerExtensionTypes GetMovementTypeForBone(int boneIndex); // 0x0000000180C71A90-0x0000000180C71B50
	}
}
