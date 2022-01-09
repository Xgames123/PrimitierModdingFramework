/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Action_Skeleton_Source : SteamVR_Action_Pose_Source, ISteamVR_Action_Skeleton_Source // TypeDefIndex: 7210
	{
		// Fields
		protected static uint skeletonActionData_size; // 0x00
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Skeleton.ActiveChangeHandler onActiveChange; // 0x330
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Skeleton.ActiveChangeHandler onActiveBindingChange; // 0x338
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Skeleton.ChangeHandler onChange; // 0x340
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Skeleton.UpdateHandler onUpdate; // 0x348
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Skeleton.TrackingChangeHandler onTrackingChanged; // 0x350
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Skeleton.ValidPoseChangeHandler onValidPoseChanged; // 0x358
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Skeleton.DeviceConnectedChangeHandler onDeviceConnectedChanged; // 0x360
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3[] _bonePositions_k__BackingField; // 0x368
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Quaternion[] _boneRotations_k__BackingField; // 0x370
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3[] _lastBonePositions_k__BackingField; // 0x378
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Quaternion[] _lastBoneRotations_k__BackingField; // 0x380
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private EVRSkeletalMotionRange _rangeOfMotion_k__BackingField; // 0x388
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private EVRSkeletalTransformSpace _skeletalTransformSpace_k__BackingField; // 0x38C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private EVRSummaryType _summaryDataType_k__BackingField; // 0x390
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float[] _fingerCurls_k__BackingField; // 0x398
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float[] _fingerSplays_k__BackingField; // 0x3A0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float[] _lastFingerCurls_k__BackingField; // 0x3A8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float[] _lastFingerSplays_k__BackingField; // 0x3B0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _poseChanged_k__BackingField; // 0x3B8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _onlyUpdateSummaryData_k__BackingField; // 0x3B9
		protected VRSkeletalSummaryData_t skeletalSummaryData; // 0x3BC
		protected VRSkeletalSummaryData_t lastSkeletalSummaryData; // 0x3E0
		protected SteamVR_Action_Skeleton skeletonAction; // 0x408
		protected VRBoneTransform_t[] tempBoneTransforms; // 0x410
		protected InputSkeletalActionData_t skeletonActionData; // 0x418
		protected InputSkeletalActionData_t lastSkeletonActionData; // 0x428
		protected InputSkeletalActionData_t tempSkeletonActionData; // 0x438
	
		// Properties
		public override bool activeBinding { get; } // 0x00000001803F14A0-0x00000001803F14B0 
		public override bool lastActiveBinding { get; } // 0x00000001803F1570-0x00000001803F1580 
		public Vector3[] bonePositions { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001802885B0-0x00000001802885C0 0x00000001803F1E80-0x00000001803F1E90
		public Quaternion[] boneRotations { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F14D0-0x00000001803F14E0 0x00000001803F1E90-0x00000001803F1EA0
		public Vector3[] lastBonePositions { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F1580-0x00000001803F1590 0x00000001803F1EC0-0x00000001803F1ED0
		public Quaternion[] lastBoneRotations { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F1590-0x00000001803F15A0 0x00000001803F1ED0-0x00000001803F1EE0
		public EVRSkeletalMotionRange rangeOfMotion { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803F18E0-0x00000001803F18F0 0x00000001803F1F20-0x00000001803F1F30
		public EVRSkeletalTransformSpace skeletalTransformSpace { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803F1980-0x00000001803F1990 0x00000001803F1F30-0x00000001803F1F40
		public EVRSummaryType summaryDataType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803F1990-0x00000001803F19A0 0x00000001803F1F40-0x00000001803F1F50
		public float thumbCurl { get; } // 0x00000001803F19A0-0x00000001803F19E0 
		public float indexCurl { get; } // 0x00000001803F14F0-0x00000001803F1530 
		public float middleCurl { get; } // 0x00000001803F1800-0x00000001803F1840 
		public float ringCurl { get; } // 0x00000001803F18F0-0x00000001803F1930 
		public float pinkyCurl { get; } // 0x00000001803F1890-0x00000001803F18D0 
		public float thumbIndexSplay { get; } // 0x00000001803F19E0-0x00000001803F1A20 
		public float indexMiddleSplay { get; } // 0x00000001803F1530-0x00000001803F1570 
		public float middleRingSplay { get; } // 0x00000001803F1840-0x00000001803F1880 
		public float ringPinkySplay { get; } // 0x00000001803F1930-0x00000001803F1970 
		public float lastThumbCurl { get; } // 0x00000001803F1780-0x00000001803F17C0 
		public float lastIndexCurl { get; } // 0x00000001803F15C0-0x00000001803F1600 
		public float lastMiddleCurl { get; } // 0x00000001803F1640-0x00000001803F1680 
		public float lastRingCurl { get; } // 0x00000001803F1700-0x00000001803F1740 
		public float lastPinkyCurl { get; } // 0x00000001803F16C0-0x00000001803F1700 
		public float lastThumbIndexSplay { get; } // 0x00000001803F17C0-0x00000001803F1800 
		public float lastIndexMiddleSplay { get; } // 0x00000001803F1600-0x00000001803F1640 
		public float lastMiddleRingSplay { get; } // 0x00000001803F1680-0x00000001803F16C0 
		public float lastRingPinkySplay { get; } // 0x00000001803F1740-0x00000001803F1780 
		public float[] fingerCurls { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F14E0-0x00000001803F14F0 0x00000001803F1EA0-0x00000001803F1EB0
		public float[] fingerSplays { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180287EA0-0x0000000180287EB0 0x00000001803F1EB0-0x00000001803F1EC0
		public float[] lastFingerCurls { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F15A0-0x00000001803F15B0 0x00000001803F1EE0-0x00000001803F1EF0
		public float[] lastFingerSplays { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F15B0-0x00000001803F15C0 0x00000001803F1EF0-0x00000001803F1F00
		public bool poseChanged { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F18D0-0x00000001803F18E0 0x00000001803F1F10-0x00000001803F1F20
		public bool onlyUpdateSummaryData { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803F1880-0x00000001803F1890 0x00000001803F1F00-0x00000001803F1F10
		public int boneCount { get; } // 0x00000001803F14B0-0x00000001803F14C0 
		public int[] boneHierarchy { get; } // 0x00000001803F14C0-0x00000001803F14D0 
		public EVRSkeletalTrackingLevel skeletalTrackingLevel { get; } // 0x00000001803F1970-0x00000001803F1980 
	
		// Events
		public event SteamVR_Action_Skeleton.ActiveChangeHandler onActiveChange {
			add; // 0x00000001803F10E0-0x00000001803F1180
			remove; // 0x00000001803F1AC0-0x00000001803F1B60
		}
		public event SteamVR_Action_Skeleton.ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803F1040-0x00000001803F10E0
			remove; // 0x00000001803F1A20-0x00000001803F1AC0
		}
		public event SteamVR_Action_Skeleton.ChangeHandler onChange {
			add; // 0x00000001803F1180-0x00000001803F1220
			remove; // 0x00000001803F1B60-0x00000001803F1C00
		}
		public event SteamVR_Action_Skeleton.UpdateHandler onUpdate {
			add; // 0x00000001803F1360-0x00000001803F1400
			remove; // 0x00000001803F1D40-0x00000001803F1DE0
		}
		public event SteamVR_Action_Skeleton.TrackingChangeHandler onTrackingChanged {
			add; // 0x00000001803F12C0-0x00000001803F1360
			remove; // 0x00000001803F1CA0-0x00000001803F1D40
		}
		public event SteamVR_Action_Skeleton.ValidPoseChangeHandler onValidPoseChanged {
			add; // 0x00000001803F1400-0x00000001803F14A0
			remove; // 0x00000001803F1DE0-0x00000001803F1E80
		}
		public event SteamVR_Action_Skeleton.DeviceConnectedChangeHandler onDeviceConnectedChanged {
			add; // 0x00000001803F1220-0x00000001803F12C0
			remove; // 0x00000001803F1C00-0x00000001803F1CA0
		}
	
		// Constructors
		public SteamVR_Action_Skeleton_Source(); // 0x00000001803F0F60-0x00000001803F1040
		static SteamVR_Action_Skeleton_Source(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public override void Preinitialize(SteamVR_Action wrappingAction, SteamVR_Input_Sources forInputSource); // 0x00000001803EF220-0x00000001803EF4E0
		public override void Initialize(); // 0x00000001803EEF80-0x00000001803EF1A0
		public override void RemoveAllListeners(); // 0x00000001803EF4E0-0x00000001803EF8A0
		public override void UpdateValue(); // 0x00000001803E7A60-0x00000001803E7A80
		public override void UpdateValue(bool skipStateAndEventUpdates); // 0x00000001803EFE80-0x00000001803F0F60
		public uint GetBoneCount(); // 0x00000001803ED8D0-0x00000001803EDCB0
		public int[] GetBoneHierarchy(); // 0x00000001803EDCB0-0x00000001803EE0C0
		public string GetBoneName(int boneIndex); // 0x00000001803EE0C0-0x00000001803EE4F0
		public SteamVR_Utils.RigidTransform[] GetReferenceTransforms(EVRSkeletalTransformSpace transformSpace, EVRSkeletalReferencePose referencePose); // 0x00000001803EE4F0-0x00000001803EEB40
		public EVRSkeletalTrackingLevel GetSkeletalTrackingLevel(); // 0x00000001803EEBA0-0x00000001803EEF80
		protected VRSkeletalSummaryData_t GetSkeletalSummaryData(EVRSummaryType summaryType = EVRSummaryType.FromAnimation /* Metadata: 0x003A52C6 */, bool force = false /* Metadata: 0x003A52CA */); // 0x00000001803EEB40-0x00000001803EEBA0
		protected void UpdateSkeletalSummaryData(EVRSummaryType summaryType = EVRSummaryType.FromAnimation /* Metadata: 0x003A52CB */, bool force = false /* Metadata: 0x003A52CF */); // 0x00000001803EF8A0-0x00000001803EFE80
		protected override void CheckAndSendEvents(); // 0x00000001803ED700-0x00000001803ED8D0
	}
}
