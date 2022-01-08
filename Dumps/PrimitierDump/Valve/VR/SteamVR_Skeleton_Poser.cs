/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Skeleton_Poser : MonoBehaviour // TypeDefIndex: 7322
	{
		// Fields
		public bool poseEditorExpanded; // 0x18
		public bool blendEditorExpanded; // 0x19
		public string[] poseNames; // 0x20
		public GameObject overridePreviewLeftHandPrefab; // 0x28
		public GameObject overridePreviewRightHandPrefab; // 0x30
		public SteamVR_Skeleton_Pose skeletonMainPose; // 0x38
		public List<SteamVR_Skeleton_Pose> skeletonAdditionalPoses; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool showLeftPreview; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool showRightPreview; // 0x49
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected GameObject previewLeftInstance; // 0x50
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected GameObject previewRightInstance; // 0x58
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected int previewPoseSelection; // 0x60
		public List<PoseBlendingBehaviour> blendingBehaviours; // 0x68
		public SteamVR_Skeleton_PoseSnapshot blendedSnapshotL; // 0x70
		public SteamVR_Skeleton_PoseSnapshot blendedSnapshotR; // 0x78
		private SkeletonBlendablePose[] blendPoses; // 0x80
		private int boneCount; // 0x88
		private bool poseUpdatedThisFrame; // 0x8C
		public float scale; // 0x90
	
		// Properties
		public int blendPoseCount { get; } // 0x0000000180C730C0-0x0000000180C730E0 
	
		// Nested types
		public class SkeletonBlendablePose // TypeDefIndex: 7318
		{
			// Fields
			public SteamVR_Skeleton_Pose pose; // 0x10
			public SteamVR_Skeleton_PoseSnapshot snapshotR; // 0x18
			public SteamVR_Skeleton_PoseSnapshot snapshotL; // 0x20
	
			// Constructors
			public SkeletonBlendablePose(SteamVR_Skeleton_Pose p); // 0x0000000180292520-0x0000000180292600
			public SkeletonBlendablePose(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public SteamVR_Skeleton_PoseSnapshot GetHandSnapshot(SteamVR_Input_Sources inputSource); // 0x0000000180291CA0-0x0000000180291CB0
			public void UpdateAdditiveAnimation(SteamVR_Action_Skeleton skeletonAction, SteamVR_Input_Sources inputSource); // 0x0000000180291E80-0x0000000180292520
			public void PoseToSnapshots(); // 0x0000000180291CB0-0x0000000180291E80
		}
	
		[Serializable]
		public class PoseBlendingBehaviour // TypeDefIndex: 7320
		{
			// Fields
			public string name; // 0x10
			public bool enabled; // 0x18
			public float influence; // 0x1C
			public int pose; // 0x20
			public float value; // 0x24
			public SteamVR_Action_Single action_single; // 0x28
			public SteamVR_Action_Boolean action_bool; // 0x30
			public float smoothingSpeed; // 0x38
			public BlenderTypes type; // 0x3C
			public bool useMask; // 0x40
			public SteamVR_Skeleton_HandMask mask; // 0x48
			public bool previewEnabled; // 0x50
	
			// Nested types
			public enum BlenderTypes // TypeDefIndex: 7319
			{
				Manual = 0,
				AnalogAction = 1,
				BooleanAction = 2
			}
	
			// Constructors
			public PoseBlendingBehaviour(); // 0x000000018028FB80-0x000000018028FC00
	
			// Methods
			public void Update(float deltaTime, SteamVR_Input_Sources inputSource); // 0x000000018028FA60-0x000000018028FB80
			public void ApplyBlending(SteamVR_Skeleton_PoseSnapshot snapshot, SkeletonBlendablePose[] blendPoses, SteamVR_Input_Sources inputSource); // 0x000000018028F690-0x000000018028FA60
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 7321
		{
			// Fields
			public string behaviourName; // 0x10
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _FindBlendingBehaviour_b__0(PoseBlendingBehaviour b); // 0x000000018029E390-0x000000018029E3C0
		}
	
		// Constructors
		public SteamVR_Skeleton_Poser(); // 0x0000000180C73010-0x0000000180C730C0
	
		// Methods
		protected void Awake(); // 0x0000000180C71EC0-0x0000000180C722E0
		public void SetBlendingBehaviourValue(string behaviourName, float value); // 0x0000000180C72CD0-0x0000000180C72DA0
		public float GetBlendingBehaviourValue(string behaviourName); // 0x0000000180C727A0-0x0000000180C727D0
		public void SetBlendingBehaviourEnabled(string behaviourName, bool value); // 0x0000000180C72CA0-0x0000000180C72CD0
		public bool GetBlendingBehaviourEnabled(string behaviourName); // 0x0000000180C72770-0x0000000180C727A0
		public PoseBlendingBehaviour GetBlendingBehaviour(string behaviourName); // 0x0000000180C727D0-0x0000000180C727E0
		protected PoseBlendingBehaviour FindBlendingBehaviour(string behaviourName, bool throwErrors = true /* Metadata: 0x003A56EA */); // 0x0000000180C72540-0x0000000180C726E0
		public SteamVR_Skeleton_Pose GetPoseByIndex(int index); // 0x0000000180C727F0-0x0000000180C72870
		private SteamVR_Skeleton_PoseSnapshot GetHandSnapshot(SteamVR_Input_Sources inputSource); // 0x0000000180C727E0-0x0000000180C727F0
		public SteamVR_Skeleton_PoseSnapshot GetBlendedPose(SteamVR_Action_Skeleton skeletonAction, SteamVR_Input_Sources handType); // 0x0000000180C72730-0x0000000180C72770
		public SteamVR_Skeleton_PoseSnapshot GetBlendedPose(SteamVR_Behaviour_Skeleton skeletonBehaviour); // 0x0000000180C726E0-0x0000000180C72730
		public void UpdatePose(SteamVR_Action_Skeleton skeletonAction, SteamVR_Input_Sources inputSource); // 0x0000000180C72DA0-0x0000000180C73010
		protected void ApplyBlenderBehaviours(SteamVR_Action_Skeleton skeletonAction, SteamVR_Input_Sources inputSource, SteamVR_Skeleton_PoseSnapshot snapshot); // 0x0000000180C71C20-0x0000000180C71EC0
		protected void LateUpdate(); // 0x0000000180C72C90-0x0000000180C72CA0
		protected Vector3 BlendVectors(Vector3[] vectors, float[] weights); // 0x0000000180C72420-0x0000000180C72540
		protected Quaternion BlendQuaternions(Quaternion[] quaternions, float[] weights); // 0x0000000180C722E0-0x0000000180C72420
		public Vector3 GetTargetHandPosition(SteamVR_Behaviour_Skeleton hand, Transform origin); // 0x0000000180C72870-0x0000000180C72AC0
		public Quaternion GetTargetHandRotation(SteamVR_Behaviour_Skeleton hand, Transform origin); // 0x0000000180C72AC0-0x0000000180C72C90
	}
}
