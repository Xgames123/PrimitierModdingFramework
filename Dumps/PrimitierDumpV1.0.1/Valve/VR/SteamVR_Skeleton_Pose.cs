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
	public class SteamVR_Skeleton_Pose : ScriptableObject // TypeDefIndex: 7313
	{
		// Fields
		public SteamVR_Skeleton_Pose_Hand leftHand; // 0x18
		public SteamVR_Skeleton_Pose_Hand rightHand; // 0x20
		protected const int leftHandInputSource = 1; // Metadata: 0x003A56D2
		protected const int rightHandInputSource = 2; // Metadata: 0x003A56D6
		public bool applyToSkeletonRoot; // 0x28
	
		// Constructors
		public SteamVR_Skeleton_Pose(); // 0x0000000180C71B80-0x0000000180C71C20
	
		// Methods
		public SteamVR_Skeleton_Pose_Hand GetHand(int hand); // 0x0000000180C71990-0x0000000180C719B0
		public SteamVR_Skeleton_Pose_Hand GetHand(SteamVR_Input_Sources hand); // 0x0000000180C71990-0x0000000180C719B0
	}
}
