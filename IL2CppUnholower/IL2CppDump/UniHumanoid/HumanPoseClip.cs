/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public class HumanPoseClip : ScriptableObject // TypeDefIndex: 5957
	{
		// Fields
		public const string TPoseResourcePath = "T-Pose.pose"; // Metadata: 0x003A1C9C
		public Vector3 bodyPosition; // 0x18
		public Quaternion bodyRotation; // 0x24
		public float[] muscles; // 0x38
	
		// Constructors
		public HumanPoseClip(); // 0x000000018030DE80-0x000000018030DE90
	
		// Methods
		public HumanPose GetPose(); // 0x00000001812B66A0-0x00000001812B6700
		public void ApplyPose(ref HumanPose pose); // 0x00000001812B6600-0x00000001812B66A0
	}
}
