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
	public class OffsetPose : MonoBehaviour // TypeDefIndex: 8536
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x18
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 8535
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public Vector3 offset; // 0x14
			public Vector3 pin; // 0x20
			public Vector3 pinWeight; // 0x2C
	
			// Constructors
			public EffectorLink(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x000000018083F030-0x000000018083F340
		}
	
		// Constructors
		public OffsetPose(); // 0x00000001807773C0-0x0000000180777410
	
		// Methods
		public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x0000000180777200-0x00000001807772F0
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x00000001807772F0-0x00000001807773C0
	}
}
