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
	[Serializable]
	public class Finger // TypeDefIndex: 8386
	{
		// Fields
		[Range] // 0x000000018001D570-0x000000018001D5D0
		[Tooltip] // 0x000000018001D570-0x000000018001D5D0
		public float weight; // 0x10
		[Range] // 0x000000018001D5D0-0x000000018001D630
		[Tooltip] // 0x000000018001D5D0-0x000000018001D630
		public float rotationWeight; // 0x14
		[Tooltip] // 0x000000018001D630-0x000000018001D660
		public DOF rotationDOF; // 0x18
		[Tooltip] // 0x000000018001D660-0x000000018001D690
		public Transform bone1; // 0x20
		[Tooltip] // 0x000000018001D690-0x000000018001D6C0
		public Transform bone2; // 0x28
		[Tooltip] // 0x000000018001D6C0-0x000000018001D6F0
		public Transform bone3; // 0x30
		[Tooltip] // 0x000000018001D6F0-0x000000018001D720
		public Transform tip; // 0x38
		[Tooltip] // 0x000000018001D720-0x000000018001D750
		public Transform target; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initiated_k__BackingField; // 0x48
		private IKSolverLimb solver; // 0x50
		private Quaternion bone3RelativeToTarget; // 0x58
		private Vector3 bone3DefaultLocalPosition; // 0x68
		private Quaternion bone3DefaultLocalRotation; // 0x74
		private Vector3 bone1Axis; // 0x84
		private Vector3 tipAxis; // 0x90
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018026BB60-0x000000018026BB70 0x000000018026BFF0-0x000000018026C000
		public Vector3 IKPosition { get; set; } // 0x0000000180823210-0x0000000180823240 0x0000000180823270-0x00000001808232A0
		public Quaternion IKRotation { get; set; } // 0x0000000180823240-0x0000000180823270 0x00000001808232A0-0x00000001808232C0
	
		// Nested types
		[Serializable]
		public enum DOF // TypeDefIndex: 8385
		{
			One = 0,
			Three = 1
		}
	
		// Constructors
		public Finger(); // 0x00000001808231F0-0x0000000180823210
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x0000000180822C60-0x0000000180822D70
		public void Initiate(Transform hand, int index); // 0x00000001808227A0-0x0000000180822C60
		public void FixTransforms(); // 0x00000001808226B0-0x00000001808227A0
		public void StoreDefaultLocalState(); // 0x0000000180822D70-0x0000000180822E50
		public void Update(float masterWeight); // 0x0000000180822E50-0x00000001808231F0
	}
}
