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
	public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 8450
	{
		// Fields
		public Transform rootNode; // 0xD0
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float spineStiffness; // 0xD8
		[Range] // 0x000000018001F690-0x000000018001F6B0
		public float pullBodyVertical; // 0xDC
		[Range] // 0x000000018001F690-0x000000018001F6B0
		public float pullBodyHorizontal; // 0xE0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _pullBodyOffset_k__BackingField; // 0xE4
		private Vector3 offset; // 0xF0
	
		// Properties
		public IKEffector bodyEffector { get; } // 0x00000001807E9820-0x00000001807E9860 
		public IKEffector leftShoulderEffector { get; } // 0x00000001807E99E0-0x00000001807E9A20 
		public IKEffector rightShoulderEffector { get; } // 0x00000001807E9C00-0x00000001807E9C40 
		public IKEffector leftThighEffector { get; } // 0x00000001807E9A20-0x00000001807E9A60 
		public IKEffector rightThighEffector { get; } // 0x00000001807E9C40-0x00000001807E9C80 
		public IKEffector leftHandEffector { get; } // 0x00000001807E9920-0x00000001807E9960 
		public IKEffector rightHandEffector { get; } // 0x00000001807E9B40-0x00000001807E9B80 
		public IKEffector leftFootEffector { get; } // 0x00000001807E98E0-0x00000001807E9920 
		public IKEffector rightFootEffector { get; } // 0x00000001807E9B00-0x00000001807E9B40 
		public FBIKChain leftArmChain { get; } // 0x00000001807E9860-0x00000001807E98A0 
		public FBIKChain rightArmChain { get; } // 0x00000001807E9A80-0x00000001807E9AC0 
		public FBIKChain leftLegChain { get; } // 0x00000001807E9960-0x00000001807E99A0 
		public FBIKChain rightLegChain { get; } // 0x00000001807E9B80-0x00000001807E9BC0 
		public IKMappingLimb leftArmMapping { get; } // 0x00000001807E98A0-0x00000001807E98E0 
		public IKMappingLimb rightArmMapping { get; } // 0x00000001807E9AC0-0x00000001807E9B00 
		public IKMappingLimb leftLegMapping { get; } // 0x00000001807E99A0-0x00000001807E99E0 
		public IKMappingLimb rightLegMapping { get; } // 0x00000001807E9BC0-0x00000001807E9C00 
		public IKMappingBone headMapping { get; } // 0x00000001807E68A0-0x00000001807E68E0 
		public Vector3 pullBodyOffset { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807E9A60-0x00000001807E9A80 0x00000001807E9C80-0x00000001807E9CA0
	
		// Constructors
		public IKSolverFullBodyBiped(); // 0x00000001807E9720-0x00000001807E9820
	
		// Methods
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f /* Metadata: 0x003A6B42 */); // 0x00000001807E7450-0x00000001807E74C0
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight); // 0x00000001807E74C0-0x00000001807E7570
		public FBIKChain GetChain(FullBodyBipedChain c); // 0x00000001807E60F0-0x00000001807E61C0
		public FBIKChain GetChain(FullBodyBipedEffector effector); // 0x00000001807E61C0-0x00000001807E63B0
		public IKEffector GetEffector(FullBodyBipedEffector effector); // 0x00000001807E63B0-0x00000001807E65C0
		public IKEffector GetEndEffector(FullBodyBipedChain c); // 0x00000001807E65C0-0x00000001807E6690
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain); // 0x00000001807E69A0-0x00000001807E6A70
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector); // 0x00000001807E6A70-0x00000001807E6C50
		public IKMappingSpine GetSpineMapping(); // 0x00000001802DC790-0x00000001802DC800
		public IKMappingBone GetHeadMapping(); // 0x00000001807E68A0-0x00000001807E68E0
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb); // 0x00000001807E5D50-0x00000001807E5E20
		public override bool IsValid(ref string message); // 0x00000001807E6D10-0x00000001807E6EF0
		public void SetToReferences(BipedReferences references, Transform rootNode = null); // 0x00000001807E78C0-0x00000001807E9520
		public static Transform DetectRootNodeBone(BipedReferences references); // 0x00000001807E58F0-0x00000001807E5D50
		public void SetLimbOrientations(BipedLimbOrientations o); // 0x00000001807E7850-0x00000001807E78C0
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation); // 0x00000001807E7570-0x00000001807E7850
		private static Transform GetLeftClavicle(BipedReferences references); // 0x00000001807E68E0-0x00000001807E69A0
		private static Transform GetRightClavicle(BipedReferences references); // 0x00000001807E6C50-0x00000001807E6D10
		private static bool Contains(Transform[] array, Transform transform); // 0x00000001807E5830-0x00000001807E58F0
		protected override void ReadPose(); // 0x00000001807E70F0-0x00000001807E7450
		private void PullBody(); // 0x00000001807E6EF0-0x00000001807E70F0
		private Vector3 GetBodyOffset(); // 0x00000001807E5E20-0x00000001807E60F0
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset); // 0x00000001807E6690-0x00000001807E68A0
		protected override void ApplyBendConstraints(); // 0x00000001807E5380-0x00000001807E5830
		protected override void WritePose(); // 0x00000001807E9520-0x00000001807E9720
	}
}
