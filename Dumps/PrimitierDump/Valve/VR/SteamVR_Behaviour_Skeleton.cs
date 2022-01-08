/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Behaviour_Skeleton : MonoBehaviour // TypeDefIndex: 7270
	{
		// Fields
		[Tooltip] // 0x0000000180023B20-0x0000000180023B50
		public SteamVR_Action_Skeleton skeletonAction; // 0x18
		[Tooltip] // 0x0000000180023A00-0x0000000180023A30
		public SteamVR_Input_Sources inputSource; // 0x20
		[Tooltip] // 0x0000000180023B50-0x0000000180023B80
		public EVRSkeletalMotionRange rangeOfMotion; // 0x24
		[Tooltip] // 0x0000000180023B80-0x0000000180023BB0
		public Transform skeletonRoot; // 0x28
		[Tooltip] // 0x0000000180023A30-0x0000000180023A60
		public Transform origin; // 0x30
		[Tooltip] // 0x0000000180023BB0-0x0000000180023BE0
		public bool updatePose; // 0x38
		[Tooltip] // 0x0000000180023BE0-0x0000000180023C10
		public bool onlySetRotations; // 0x39
		[Range] // 0x0000000180023C10-0x0000000180023C70
		[Tooltip] // 0x0000000180023C10-0x0000000180023C70
		public float skeletonBlend; // 0x3C
		public SteamVR_Behaviour_SkeletonEvent onBoneTransformsUpdated; // 0x40
		public SteamVR_Behaviour_SkeletonEvent onTransformUpdated; // 0x48
		public SteamVR_Behaviour_SkeletonEvent onTransformChanged; // 0x50
		public SteamVR_Behaviour_Skeleton_ConnectedChangedEvent onConnectedChanged; // 0x58
		public SteamVR_Behaviour_Skeleton_TrackingChangedEvent onTrackingChanged; // 0x60
		public UpdateHandler onBoneTransformsUpdatedEvent; // 0x68
		public UpdateHandler onTransformUpdatedEvent; // 0x70
		public ChangeHandler onTransformChangedEvent; // 0x78
		public DeviceConnectedChangeHandler onConnectedChangedEvent; // 0x80
		public TrackingChangeHandler onTrackingChangedEvent; // 0x88
		[Tooltip] // 0x0000000180023C70-0x0000000180023CA0
		public MirrorType mirroring; // 0x90
		[Header] // 0x0000000180023CA0-0x0000000180023D00
		[Tooltip] // 0x0000000180023CA0-0x0000000180023D00
		public SteamVR_Skeleton_Poser fallbackPoser; // 0x98
		[Tooltip] // 0x0000000180023D00-0x0000000180023D30
		public SteamVR_Action_Single fallbackCurlAction; // 0xA0
		protected SteamVR_Skeleton_Poser blendPoser; // 0xA8
		protected SteamVR_Skeleton_PoseSnapshot blendSnapshot; // 0xB0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Transform[] _proximals_k__BackingField; // 0xB8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Transform[] _middles_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Transform[] _distals_k__BackingField; // 0xC8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Transform[] _tips_k__BackingField; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Transform[] _auxs_k__BackingField; // 0xD8
		protected Coroutine blendRoutine; // 0xE0
		protected Coroutine rangeOfMotionBlendRoutine; // 0xE8
		protected Coroutine attachRoutine; // 0xF0
		protected Transform[] bones; // 0xF8
		protected EVRSkeletalMotionRange? temporaryRangeOfMotion; // 0x100
		protected static readonly Quaternion rightFlipAngle; // 0x00
	
		// Properties
		public bool skeletonAvailable { get; } // 0x000000018031EA20-0x000000018031EA50 
		public bool isActive { get; } // 0x000000018031E390-0x000000018031E3B0 
		public float[] fingerCurls { get; } // 0x000000018031E0B0-0x000000018031E1A0 
		public float thumbCurl { get; } // 0x000000018031EA90-0x000000018031EAF0 
		public float indexCurl { get; } // 0x000000018031E1E0-0x000000018031E250 
		public float middleCurl { get; } // 0x000000018031E400-0x000000018031E470 
		public float ringCurl { get; } // 0x000000018031E7E0-0x000000018031E850 
		public float pinkyCurl { get; } // 0x000000018031E5F0-0x000000018031E660 
		public Transform root { get; } // 0x000000018031E990-0x000000018031E9D0 
		public Transform wrist { get; } // 0x000000018031EC00-0x000000018031EC40 
		public Transform indexMetacarpal { get; } // 0x000000018031E290-0x000000018031E2D0 
		public Transform indexProximal { get; } // 0x000000018031E310-0x000000018031E350 
		public Transform indexMiddle { get; } // 0x000000018031E2D0-0x000000018031E310 
		public Transform indexDistal { get; } // 0x000000018031E250-0x000000018031E290 
		public Transform indexTip { get; } // 0x000000018031E350-0x000000018031E390 
		public Transform middleMetacarpal { get; } // 0x000000018031E4B0-0x000000018031E4F0 
		public Transform middleProximal { get; } // 0x000000018031E530-0x000000018031E570 
		public Transform middleMiddle { get; } // 0x000000018031E4F0-0x000000018031E530 
		public Transform middleDistal { get; } // 0x000000018031E470-0x000000018031E4B0 
		public Transform middleTip { get; } // 0x000000018031E570-0x000000018031E5B0 
		public Transform pinkyMetacarpal { get; } // 0x000000018031E6A0-0x000000018031E6E0 
		public Transform pinkyProximal { get; } // 0x000000018031E720-0x000000018031E760 
		public Transform pinkyMiddle { get; } // 0x000000018031E6E0-0x000000018031E720 
		public Transform pinkyDistal { get; } // 0x000000018031E660-0x000000018031E6A0 
		public Transform pinkyTip { get; } // 0x000000018031E760-0x000000018031E7A0 
		public Transform ringMetacarpal { get; } // 0x000000018031E890-0x000000018031E8D0 
		public Transform ringProximal { get; } // 0x000000018031E910-0x000000018031E950 
		public Transform ringMiddle { get; } // 0x000000018031E8D0-0x000000018031E910 
		public Transform ringDistal { get; } // 0x000000018031E850-0x000000018031E890 
		public Transform ringTip { get; } // 0x000000018031E950-0x000000018031E990 
		public Transform thumbMetacarpal { get; } // 0x000000018031EB30-0x000000018031EB70 
		public Transform thumbProximal { get; } // 0x000000018031EB30-0x000000018031EB70 
		public Transform thumbMiddle { get; } // 0x000000018031EB70-0x000000018031EBB0 
		public Transform thumbDistal { get; } // 0x000000018031EAF0-0x000000018031EB30 
		public Transform thumbTip { get; } // 0x000000018031EBB0-0x000000018031EBF0 
		public Transform thumbAux { get; } // 0x000000018031EA50-0x000000018031EA90 
		public Transform indexAux { get; } // 0x000000018031E1A0-0x000000018031E1E0 
		public Transform middleAux { get; } // 0x000000018031E3C0-0x000000018031E400 
		public Transform ringAux { get; } // 0x000000018031E7A0-0x000000018031E7E0 
		public Transform pinkyAux { get; } // 0x000000018031E5B0-0x000000018031E5F0 
		public Transform[] proximals { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001802DC810-0x00000001802DC820 0x0000000180268360-0x0000000180268370
		public Transform[] middles { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180268300-0x0000000180268310 0x0000000180268380-0x0000000180268390
		public Transform[] distals { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x000000018031E0A0-0x000000018031E0B0 0x000000018031EC40-0x000000018031EC50
		public Transform[] tips { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x000000018031EBF0-0x000000018031EC00 0x000000018031EC50-0x000000018031EC60
		public Transform[] auxs { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x000000018026A2F0-0x000000018026A300 0x000000018026A920-0x000000018026A930
		public EVRSkeletalTrackingLevel skeletalTrackingLevel { get; } // 0x000000018031E9D0-0x000000018031EA20 
		public bool isBlending { get; } // 0x000000018031E3B0-0x000000018031E3C0 
		public SteamVR_ActionSet actionSet { get; } // 0x000000018031E040-0x000000018031E070 
		public SteamVR_ActionDirections direction { get; } // 0x000000018031E070-0x000000018031E0A0 
	
		// Nested types
		public enum MirrorType // TypeDefIndex: 7261
		{
			None = 0,
			LeftToRight = 1,
			RightToLeft = 2
		}
	
		public delegate void ActiveChangeHandler(SteamVR_Behaviour_Skeleton fromAction, SteamVR_Input_Sources inputSource, bool active); // TypeDefIndex: 7262; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void ChangeHandler(SteamVR_Behaviour_Skeleton fromAction, SteamVR_Input_Sources inputSource); // TypeDefIndex: 7263; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void UpdateHandler(SteamVR_Behaviour_Skeleton fromAction, SteamVR_Input_Sources inputSource); // TypeDefIndex: 7264; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void TrackingChangeHandler(SteamVR_Behaviour_Skeleton fromAction, SteamVR_Input_Sources inputSource, ETrackingResult trackingState); // TypeDefIndex: 7265; 0x0000000180296640-0x00000001802969E0
	
		public delegate void ValidPoseChangeHandler(SteamVR_Behaviour_Skeleton fromAction, SteamVR_Input_Sources inputSource, bool validPose); // TypeDefIndex: 7266; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void DeviceConnectedChangeHandler(SteamVR_Behaviour_Skeleton fromAction, SteamVR_Input_Sources inputSource, bool deviceConnected); // TypeDefIndex: 7267; 0x000000018028ABF0-0x000000018028AE70
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoBlendRoutine_d__152 : IEnumerator<object> // TypeDefIndex: 7268
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float overTime; // 0x20
			public SteamVR_Behaviour_Skeleton __4__this; // 0x28
			public float blendToAmount; // 0x30
			private float _startTime_5__2; // 0x34
			private float _endTime_5__3; // 0x38
			private float _startAmount_5__4; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoBlendRoutine_d__152(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180297010-0x0000000180297110
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180297110-0x0000000180297150
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoRangeOfMotionBlend_d__156 : IEnumerator<object> // TypeDefIndex: 7269
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float overTime; // 0x20
			public SteamVR_Behaviour_Skeleton __4__this; // 0x28
			public EVRSkeletalMotionRange oldRangeOfMotion; // 0x30
			public EVRSkeletalMotionRange newRangeOfMotion; // 0x34
			private float _startTime_5__2; // 0x38
			private float _endTime_5__3; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoRangeOfMotionBlend_d__156(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180298C60-0x00000001802994E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001802994E0-0x0000000180299520
		}
	
		// Constructors
		public SteamVR_Behaviour_Skeleton(); // 0x000000018031E020-0x000000018031E040
		static SteamVR_Behaviour_Skeleton(); // 0x000000018031DFB0-0x000000018031E020
	
		// Methods
		protected virtual void Awake(); // 0x000000018031A030-0x000000018031AD90
		protected virtual void CheckSkeletonAction(); // 0x000000018031AFC0-0x000000018031B100
		protected virtual void AssignBonesArray(); // 0x0000000180319FE0-0x000000018031A030
		protected virtual void OnEnable(); // 0x000000018031C530-0x000000018031C7C0
		protected virtual void OnDisable(); // 0x000000018031C2B0-0x000000018031C530
		private void OnDeviceConnectedChanged(SteamVR_Action_Skeleton fromAction, bool deviceConnected); // 0x000000018031C220-0x000000018031C2B0
		private void OnTrackingChanged(SteamVR_Action_Skeleton fromAction, ETrackingResult trackingState); // 0x000000018031C7C0-0x000000018031C840
		protected virtual void SteamVR_Input_OnSkeletonsUpdated(bool skipSendingEvents); // 0x000000018031CCC0-0x000000018031CCE0
		protected virtual void UpdateSkeleton(); // 0x000000018031DE10-0x000000018031DFB0
		public void SetTemporaryRangeOfMotion(EVRSkeletalMotionRange newRangeOfMotion, float blendOverSeconds = 0.1f /* Metadata: 0x003A5424 */); // 0x000000018031CB60-0x000000018031CCC0
		public void ResetTemporaryRangeOfMotion(float blendOverSeconds = 0.1f /* Metadata: 0x003A5428 */); // 0x000000018031C8E0-0x000000018031C9E0
		public void SetRangeOfMotion(EVRSkeletalMotionRange newRangeOfMotion, float blendOverSeconds = 0.1f /* Metadata: 0x003A542C */); // 0x000000018031CAB0-0x000000018031CB60
		public void BlendToSkeleton(float overTime = 0.1f /* Metadata: 0x003A5430 */); // 0x000000018031AE30-0x000000018031AEF0
		public void BlendToPoser(SteamVR_Skeleton_Poser poser, float overTime = 0.1f /* Metadata: 0x003A5434 */); // 0x000000018031ADA0-0x000000018031AE30
		public void BlendToAnimation(float overTime = 0.1f /* Metadata: 0x003A5438 */); // 0x000000018031AD90-0x000000018031ADA0
		public void BlendTo(float blendToAmount, float overTime); // 0x000000018031AEF0-0x000000018031AFC0
		[IteratorStateMachine] // 0x0000000180023D30-0x0000000180023D80
		protected IEnumerator DoBlendRoutine(float blendToAmount, float overTime); // 0x000000018031B140-0x000000018031B1D0
		protected void RangeOfMotionBlend(EVRSkeletalMotionRange newRangeOfMotion, float blendOverSeconds); // 0x000000018031C840-0x000000018031C8E0
		protected void TemporaryRangeOfMotionBlend(EVRSkeletalMotionRange newRangeOfMotion, float blendOverSeconds); // 0x000000018031CCE0-0x000000018031CE00
		protected void ResetTemporaryRangeOfMotionBlend(float blendOverSeconds); // 0x000000018031C8E0-0x000000018031C9E0
		[IteratorStateMachine] // 0x0000000180023D80-0x0000000180023DD0
		protected IEnumerator DoRangeOfMotionBlend(EVRSkeletalMotionRange oldRangeOfMotion, EVRSkeletalMotionRange newRangeOfMotion, float overTime); // 0x000000018031B1D0-0x000000018031B270
		protected virtual Quaternion GetBlendPoseForBone(int boneIndex, Quaternion skeletonRotation); // 0x000000018031B8F0-0x000000018031B940
		public virtual void UpdateSkeletonTransforms(); // 0x000000018031D160-0x000000018031DE10
		public virtual void SetBonePosition(int boneIndex, Vector3 localPosition); // 0x000000018031C9E0-0x000000018031CA50
		public virtual void SetBoneRotation(int boneIndex, Quaternion localRotation); // 0x000000018031CA50-0x000000018031CAB0
		public virtual Transform GetBone(int joint); // 0x000000018031BF80-0x000000018031BFF0
		public Vector3 GetBonePosition(int joint, bool local = false /* Metadata: 0x003A543C */); // 0x000000018031B940-0x000000018031B9E0
		public Quaternion GetBoneRotation(int joint, bool local = false /* Metadata: 0x003A543D */); // 0x000000018031BCD0-0x000000018031BD80
		protected Vector3[] GetBonePositions(); // 0x000000018031B9E0-0x000000018031BCD0
		protected Quaternion[] GetBoneRotations(); // 0x000000018031BD80-0x000000018031BF80
		public static Vector3 MirrorPosition(int boneIndex, Vector3 rawPosition); // 0x000000018031C010-0x000000018031C100
		public static Quaternion MirrorRotation(int boneIndex, Quaternion rawRotation); // 0x000000018031C100-0x000000018031C220
		protected virtual void UpdatePose(); // 0x000000018031CE40-0x000000018031D160
		public void ForceToReferencePose(EVRSkeletalReferencePose referencePose); // 0x000000018031B270-0x000000018031B8F0
		protected static bool IsMetacarpal(int boneIndex); // 0x000000018031BFF0-0x000000018031C010
	}
}
