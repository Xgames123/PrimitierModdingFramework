/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKConstraintBend // TypeDefIndex: 8428
	{
		// Fields
		public Transform bone1; // 0x10
		public Transform bone2; // 0x18
		public Transform bone3; // 0x20
		public Transform bendGoal; // 0x28
		public Vector3 direction; // 0x30
		public Quaternion rotationOffset; // 0x3C
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float weight; // 0x4C
		public Vector3 defaultLocalDirection; // 0x50
		public Vector3 defaultChildDirection; // 0x5C
		[NonSerialized]
		public float clampF; // 0x68
		private int chainIndex1; // 0x6C
		private int nodeIndex1; // 0x70
		private int chainIndex2; // 0x74
		private int nodeIndex2; // 0x78
		private int chainIndex3; // 0x7C
		private int nodeIndex3; // 0x80
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initiated_k__BackingField; // 0x84
		private bool limbOrientationsSet; // 0x85
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180868A90-0x0000000180868AA0 0x0000000180868AA0-0x0000000180868AB0
	
		// Constructors
		public IKConstraintBend(); // 0x00000001808689E0-0x0000000180868A20
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3); // 0x0000000180868A20-0x0000000180868A90
	
		// Methods
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger); // 0x0000000180867E60-0x00000001808680B0
		public void SetBones(Transform bone1, Transform bone2, Transform bone3); // 0x00000001808687C0-0x00000001808687D0
		public void Initiate(IKSolverFullBody solver); // 0x00000001808679E0-0x0000000180867E60
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last); // 0x00000001808687D0-0x00000001808689E0
		public void LimitBend(float solverWeight, float positionWeight); // 0x00000001808680B0-0x00000001808685A0
		public Vector3 GetDir(IKSolverFullBody solver); // 0x00000001808672F0-0x00000001808679E0
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent); // 0x00000001808686B0-0x00000001808687C0
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent); // 0x00000001808685A0-0x00000001808686B0
	}
}
