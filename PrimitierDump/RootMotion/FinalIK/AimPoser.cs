/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public class AimPoser : MonoBehaviour // TypeDefIndex: 8509
	{
		// Fields
		public float angleBuffer; // 0x18
		public Pose[] poses; // 0x20
	
		// Nested types
		[Serializable]
		public class Pose // TypeDefIndex: 8508
		{
			// Fields
			public bool visualize; // 0x10
			public string name; // 0x18
			public Vector3 direction; // 0x20
			public float yaw; // 0x2C
			public float pitch; // 0x30
			private float angleBuffer; // 0x34
	
			// Constructors
			public Pose(); // 0x0000000180714410-0x0000000180714430
	
			// Methods
			public bool IsInDirection(Vector3 d); // 0x0000000180714190-0x0000000180714410
			public void SetAngleBuffer(float value); // 0x000000018036B520-0x000000018036B530
		}
	
		// Constructors
		public AimPoser(); // 0x00000001807BDA10-0x00000001807BDA60
	
		// Methods
		public Pose GetPose(Vector3 localDirection); // 0x00000001807BD860-0x00000001807BD980
		public void SetPoseActive(Pose pose); // 0x00000001807BD980-0x00000001807BDA10
	}
}
