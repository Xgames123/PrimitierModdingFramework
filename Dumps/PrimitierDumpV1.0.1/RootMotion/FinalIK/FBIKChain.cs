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
	public class FBIKChain // TypeDefIndex: 8427
	{
		// Fields
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float pin; // 0x10
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float pull; // 0x14
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float push; // 0x18
		[Range] // 0x000000018001F690-0x000000018001F6B0
		public float pushParent; // 0x1C
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float reach; // 0x20
		public Smoothing reachSmoothing; // 0x24
		public Smoothing pushSmoothing; // 0x28
		public IKSolver.Node[] nodes; // 0x30
		public int[] children; // 0x38
		public ChildConstraint[] childConstraints; // 0x40
		public IKConstraintBend bendConstraint; // 0x48
		private float rootLength; // 0x50
		private bool initiated; // 0x54
		private float length; // 0x58
		private float distance; // 0x5C
		private IKSolver.Point p; // 0x60
		private float reachForce; // 0x68
		private float pullParentSum; // 0x6C
		private float[] crossFades; // 0x70
		private float sqrMag1; // 0x78
		private float sqrMag2; // 0x7C
		private float sqrMagDif; // 0x80
		private const float maxLimbLength = 0.99999f; // Metadata: 0x003A6ADA
	
		// Nested types
		[Serializable]
		public class ChildConstraint // TypeDefIndex: 8425
		{
			// Fields
			public float pushElasticity; // 0x10
			public float pullElasticity; // 0x14
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private Transform bone1; // 0x18
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private Transform bone2; // 0x20
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _nominalDistance_k__BackingField; // 0x28
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private bool _isRigid_k__BackingField; // 0x2C
			private float crossFade; // 0x30
			private float inverseCrossFade; // 0x34
			private int chain1Index; // 0x38
			private int chain2Index; // 0x3C
	
			// Properties
			public float nominalDistance { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B100-0x000000018036B110 0x000000018036B600-0x000000018036B610
			public bool isRigid { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001806BA150-0x00000001806BA160 0x00000001806BA790-0x00000001806BA7A0
	
			// Constructors
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f /* Metadata: 0x003A6ADE */, float pullElasticity = 0f /* Metadata: 0x003A6AE2 */); // 0x000000018070FE60-0x000000018070FEC0
	
			// Methods
			public void Initiate(IKSolverFullBody solver); // 0x000000018070F820-0x000000018070F880
			public void OnPreSolve(IKSolverFullBody solver); // 0x000000018070F880-0x000000018070FAD0
			public void Solve(IKSolverFullBody solver); // 0x000000018070FAD0-0x000000018070FE60
		}
	
		[Serializable]
		public enum Smoothing // TypeDefIndex: 8426
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}
	
		// Constructors
		public FBIKChain(); // 0x000000018081FAC0-0x000000018081FB90
		public FBIKChain(float pin, float pull, params /* 0x0000000180014D50-0x0000000180014D60 */ Transform[] nodeTransforms); // 0x000000018081F8A0-0x000000018081FAC0
	
		// Methods
		public void SetNodes(params /* 0x0000000180014D50-0x0000000180014D60 */ Transform[] boneTransforms); // 0x000000018081E3B0-0x000000018081E4F0
		public int GetNodeIndex(Transform boneTransform); // 0x000000018081D0A0-0x000000018081D190
		public bool IsValid(ref string message); // 0x000000018081D370-0x000000018081D480
		public void Initiate(IKSolverFullBody solver); // 0x000000018081D190-0x000000018081D370
		public void ReadPose(IKSolverFullBody solver, bool fullBody); // 0x000000018081DCF0-0x000000018081E3B0
		private void CalculateBoneLengths(IKSolverFullBody solver); // 0x000000018081C5E0-0x000000018081CCE0
		public void Reach(IKSolverFullBody solver); // 0x000000018081D8E0-0x000000018081DCF0
		public Vector3 Push(IKSolverFullBody solver); // 0x000000018081D480-0x000000018081D8E0
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false /* Metadata: 0x003A6AD9 */); // 0x000000018081EB70-0x000000018081F080
		public void Stage1(IKSolverFullBody solver); // 0x000000018081F080-0x000000018081F710
		public void Stage2(IKSolverFullBody solver, Vector3 position); // 0x000000018081F710-0x000000018081F8A0
		public void SolveConstraintSystems(IKSolverFullBody solver); // 0x000000018081E580-0x000000018081E8C0
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018081E8C0-0x000000018081E9C0
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude); // 0x000000018081CEE0-0x000000018081D0A0
		private void SolveChildConstraints(IKSolverFullBody solver); // 0x000000018081E4F0-0x000000018081E580
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance); // 0x000000018081E9C0-0x000000018081EB70
		public void ForwardReach(Vector3 position); // 0x000000018081CCE0-0x000000018081CEE0
		private void BackwardReach(Vector3 position); // 0x000000018081C2E0-0x000000018081C5E0
	}
}
