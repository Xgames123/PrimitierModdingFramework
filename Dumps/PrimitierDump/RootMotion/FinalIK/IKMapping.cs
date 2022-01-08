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
	public class IKMapping // TypeDefIndex: 8431
	{
		// Nested types
		[Serializable]
		public class BoneMap // TypeDefIndex: 8430
		{
			// Fields
			public Transform transform; // 0x10
			public int chainIndex; // 0x18
			public int nodeIndex; // 0x1C
			public Vector3 defaultLocalPosition; // 0x20
			public Quaternion defaultLocalRotation; // 0x2C
			public Vector3 localSwingAxis; // 0x3C
			public Vector3 localTwistAxis; // 0x48
			public Vector3 planePosition; // 0x54
			public Vector3 ikPosition; // 0x60
			public Quaternion defaultLocalTargetRotation; // 0x6C
			private Quaternion maintainRotation; // 0x7C
			public float length; // 0x8C
			public Quaternion animatedRotation; // 0x90
			private Transform planeBone1; // 0xA0
			private Transform planeBone2; // 0xA8
			private Transform planeBone3; // 0xB0
			private int plane1ChainIndex; // 0xB8
			private int plane1NodeIndex; // 0xBC
			private int plane2ChainIndex; // 0xC0
			private int plane2NodeIndex; // 0xC4
			private int plane3ChainIndex; // 0xC8
			private int plane3NodeIndex; // 0xCC
	
			// Properties
			public Vector3 swingDirection { get; } // 0x000000018070ED90-0x000000018070EE10 
			public bool isNodeBone { get; } // 0x000000018070EB70-0x000000018070EB80 
			private Quaternion lastAnimatedTargetRotation { get; } // 0x000000018070EB80-0x000000018070ED90 
	
			// Constructors
			public BoneMap(); // 0x000000018070EB40-0x000000018070EB70
	
			// Methods
			public void Initiate(Transform transform, IKSolverFullBody solver); // 0x000000018070D8C0-0x000000018070D900
			public void StoreDefaultLocalState(); // 0x000000018070E270-0x000000018070E2D0
			public void FixTransform(bool position); // 0x000000018070D5B0-0x000000018070D610
			public void SetLength(BoneMap nextBone); // 0x000000018070DD80-0x000000018070DE30
			public void SetLocalSwingAxis(BoneMap swingTarget); // 0x000000018070DE30-0x000000018070DF60
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2); // 0x000000018070DF60-0x000000018070E0B0
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection); // 0x000000018070E0B0-0x000000018070E150
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3); // 0x000000018070E150-0x000000018070E230
			public void UpdatePlane(bool rotation, bool position); // 0x000000018070E7F0-0x000000018070EB40
			public void SetIKPosition(); // 0x000000018070DD40-0x000000018070DD80
			public void MaintainRotation(); // 0x000000018070D900-0x000000018070D940
			public void SetToIKPosition(); // 0x000000018070E230-0x000000018070E270
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null); // 0x000000018070D430-0x000000018070D5B0
			public Vector3 GetPlanePosition(IKSolverFullBody solver); // 0x000000018070D610-0x000000018070D710
			public void PositionToPlane(IKSolverFullBody solver); // 0x000000018070D940-0x000000018070DA70
			public void RotateToPlane(IKSolverFullBody solver, float weight); // 0x000000018070DC50-0x000000018070DD40
			public void Swing(Vector3 swingTarget, float weight); // 0x000000018070E4A0-0x000000018070E670
			public void Swing(Vector3 pos1, Vector3 pos2, float weight); // 0x000000018070E2D0-0x000000018070E4A0
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight); // 0x000000018070E670-0x000000018070E7F0
			public void RotateToMaintain(float weight); // 0x000000018070DBB0-0x000000018070DC50
			public void RotateToEffector(IKSolverFullBody solver, float weight); // 0x000000018070DA70-0x000000018070DBB0
			private Quaternion GetTargetRotation(IKSolverFullBody solver); // 0x000000018070D710-0x000000018070D8C0
		}
	
		// Constructors
		public IKMapping(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public virtual bool IsValid(IKSolver solver, ref string message); // 0x00000001802942D0-0x00000001802942E0
		public virtual void Initiate(IKSolverFullBody solver); // 0x0000000180265310-0x0000000180265320
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null); // 0x000000018086DC90-0x000000018086DDD0
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018081E8C0-0x000000018081E9C0
	}
}
