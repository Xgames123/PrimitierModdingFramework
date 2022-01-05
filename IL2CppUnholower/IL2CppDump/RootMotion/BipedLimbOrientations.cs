/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 8276
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { get; } // 0x00000001807C2810-0x00000001807C2AF0 
		public static BipedLimbOrientations MaxBiped { get; } // 0x00000001807C2530-0x00000001807C2810 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 8275
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis); // 0x0000000180713100-0x0000000180713170
		}
	
		// Constructors
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg); // 0x0000000180296340-0x00000001802963A0
	}
}
