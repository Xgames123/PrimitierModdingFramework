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
	public class IKEffector // TypeDefIndex: 8429
	{
		// Fields
		public Transform bone; // 0x10
		public Transform target; // 0x18
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float positionWeight; // 0x20
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float rotationWeight; // 0x24
		public Vector3 position; // 0x28
		public Quaternion rotation; // 0x34
		public Vector3 positionOffset; // 0x44
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _isEndEffector_k__BackingField; // 0x50
		public bool effectChildNodes; // 0x51
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float maintainRelativePositionWeight; // 0x54
		public Transform[] childBones; // 0x58
		public Transform planeBone1; // 0x60
		public Transform planeBone2; // 0x68
		public Transform planeBone3; // 0x70
		public Quaternion planeRotationOffset; // 0x78
		private float posW; // 0x88
		private float rotW; // 0x8C
		private Vector3[] localPositions; // 0x90
		private bool usePlaneNodes; // 0x98
		private Quaternion animatedPlaneRotation; // 0x9C
		private Vector3 animatedPosition; // 0xAC
		private bool firstUpdate; // 0xB8
		private int chainIndex; // 0xBC
		private int nodeIndex; // 0xC0
		private int plane1ChainIndex; // 0xC4
		private int plane1NodeIndex; // 0xC8
		private int plane2ChainIndex; // 0xCC
		private int plane2NodeIndex; // 0xD0
		private int plane3ChainIndex; // 0xD4
		private int plane3NodeIndex; // 0xD8
		private int[] childChainIndexes; // 0xE0
		private int[] childNodeIndexes; // 0xE8
	
		// Properties
		public bool isEndEffector { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802AF7D0-0x00000001802AF7E0 0x00000001802AF7F0-0x00000001802AF800
	
		// Constructors
		public IKEffector(); // 0x000000018086A680-0x000000018086A7B0
		public IKEffector(Transform bone, Transform[] childBones); // 0x000000018086A7B0-0x000000018086A900
	
		// Methods
		public IKSolver.Node GetNode(IKSolverFullBody solver); // 0x0000000180868AB0-0x0000000180868B20
		public void PinToBone(float positionWeight, float rotationWeight); // 0x000000018086A000-0x000000018086A0B0
		public bool IsValid(IKSolver solver, ref string message); // 0x0000000180869530-0x0000000180869870
		public void Initiate(IKSolverFullBody solver); // 0x00000001808691F0-0x0000000180869530
		public void ResetOffset(IKSolverFullBody solver); // 0x000000018086A0B0-0x000000018086A1E0
		public void SetToTarget(); // 0x000000018086A1E0-0x000000018086A290
		public void OnPreSolve(IKSolverFullBody solver); // 0x00000001808698A0-0x000000018086A000
		public void OnPostWrite(); // 0x0000000180869870-0x00000001808698A0
		private Quaternion GetPlaneRotation(IKSolverFullBody solver); // 0x0000000180868B20-0x0000000180868D20
		public void Update(IKSolverFullBody solver); // 0x000000018086A290-0x000000018086A680
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset); // 0x0000000180868D20-0x00000001808691F0
	}
}
