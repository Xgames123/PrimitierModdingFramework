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
	public class SteamVR_Skeleton_PoseSnapshot // TypeDefIndex: 7323
	{
		// Fields
		public SteamVR_Input_Sources inputSource; // 0x10
		public Vector3 position; // 0x14
		public Quaternion rotation; // 0x20
		public Vector3[] bonePositions; // 0x30
		public Quaternion[] boneRotations; // 0x38
	
		// Constructors
		public SteamVR_Skeleton_PoseSnapshot(int boneCount, SteamVR_Input_Sources source); // 0x0000000180C718E0-0x0000000180C71990
	
		// Methods
		public void CopyFrom(SteamVR_Skeleton_PoseSnapshot source); // 0x0000000180C717B0-0x0000000180C718E0
	}
}
