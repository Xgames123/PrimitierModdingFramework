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
	public class IKMappingLimb : IKMapping // TypeDefIndex: 8434
	{
		// Fields
		public Transform parentBone; // 0x10
		public Transform bone1; // 0x18
		public Transform bone2; // 0x20
		public Transform bone3; // 0x28
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float maintainRotationWeight; // 0x30
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float weight; // 0x34
		private BoneMap boneMapParent; // 0x38
		private BoneMap boneMap1; // 0x40
		private BoneMap boneMap2; // 0x48
		private BoneMap boneMap3; // 0x50
	
		// Nested types
		[Serializable]
		public enum BoneMapType // TypeDefIndex: 8433
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}
	
		// Constructors
		public IKMappingLimb(); // 0x000000018086BB10-0x000000018086BBD0
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x000000018086BA10-0x000000018086BB10
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018086B2F0-0x000000018086B390
		public BoneMap GetBoneMap(BoneMapType boneMap); // 0x000000018086AFB0-0x000000018086B080
		public void SetLimbOrientation(Vector3 upper, Vector3 lower); // 0x000000018086B420-0x000000018086B7D0
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x000000018086B400-0x000000018086B420
		public void StoreDefaultLocalState(); // 0x000000018086B7D0-0x000000018086B880
		public void FixTransforms(); // 0x000000018086AEF0-0x000000018086AFB0
		public override void Initiate(IKSolverFullBody solver); // 0x000000018086B080-0x000000018086B2F0
		public void ReadPose(); // 0x000000018086B390-0x000000018086B400
		public void WritePose(IKSolverFullBody solver, bool fullBody); // 0x000000018086B880-0x000000018086BA10
	}
}
