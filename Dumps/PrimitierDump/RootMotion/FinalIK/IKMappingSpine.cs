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
	public class IKMappingSpine : IKMapping // TypeDefIndex: 8435
	{
		// Fields
		public Transform[] spineBones; // 0x10
		public Transform leftUpperArmBone; // 0x18
		public Transform rightUpperArmBone; // 0x20
		public Transform leftThighBone; // 0x28
		public Transform rightThighBone; // 0x30
		[Range] // 0x000000018001F6B0-0x000000018001F6D0
		public int iterations; // 0x38
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float twistWeight; // 0x3C
		private int rootNodeIndex; // 0x40
		private BoneMap[] spine; // 0x48
		private BoneMap leftUpperArm; // 0x50
		private BoneMap rightUpperArm; // 0x58
		private BoneMap leftThigh; // 0x60
		private BoneMap rightThigh; // 0x68
		private bool useFABRIK; // 0x70
	
		// Constructors
		public IKMappingSpine(); // 0x000000018086DA80-0x000000018086DB60
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x000000018086DB60-0x000000018086DC90
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018086C8B0-0x000000018086CC60
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x000000018086D4C0-0x000000018086D4E0
		public void StoreDefaultLocalState(); // 0x000000018086D4E0-0x000000018086D560
		public void FixTransforms(); // 0x000000018086BDD0-0x000000018086BE70
		public override void Initiate(IKSolverFullBody solver); // 0x000000018086C080-0x000000018086C8B0
		private bool UseFABRIK(); // 0x000000018086D560-0x000000018086D590
		public void ReadPose(); // 0x000000018086D0C0-0x000000018086D4C0
		public void WritePose(IKSolverFullBody solver); // 0x000000018086D590-0x000000018086DA80
		public void ForwardReach(Vector3 position); // 0x000000018086BE70-0x000000018086C080
		private void BackwardReach(Vector3 position); // 0x000000018086BBD0-0x000000018086BDD0
		private void MapToSolverPositions(IKSolverFullBody solver); // 0x000000018086CC60-0x000000018086D0C0
	}
}
