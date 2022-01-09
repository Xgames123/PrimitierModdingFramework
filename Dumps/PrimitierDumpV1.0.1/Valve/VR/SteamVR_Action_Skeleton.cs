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
	[Serializable]
	public class SteamVR_Action_Skeleton : SteamVR_Action_Pose_Base<Valve.VR.SteamVR_Action_Skeleton_Source_Map, Valve.VR.SteamVR_Action_Skeleton_Source>, ISteamVR_Action_Skeleton_Source, ISerializationCallbackReceiver // TypeDefIndex: 7208
	{
		// Fields
		public const int numBones = 31; // Metadata: 0x003A52C2
		public static Quaternion steamVRFixUpRotation; // 0x00
	
		// Properties
		public Vector3[] bonePositions { get; } // 0x00000001803F2500-0x00000001803F2560 
		public Quaternion[] boneRotations { get; } // 0x00000001803F2560-0x00000001803F25C0 
		public Vector3[] lastBonePositions { get; } // 0x00000001803F2780-0x00000001803F27E0 
		public Quaternion[] lastBoneRotations { get; } // 0x00000001803F27E0-0x00000001803F2840 
		public EVRSkeletalMotionRange rangeOfMotion { get; set; } // 0x00000001803F2FC0-0x00000001803F3020 0x00000001803F3730-0x00000001803F3790
		public EVRSkeletalTransformSpace skeletalTransformSpace { get; set; } // 0x00000001803F3180-0x00000001803F31E0 0x00000001803F3790-0x00000001803F37F0
		public EVRSummaryType summaryDataType { get; set; } // 0x00000001803F31E0-0x00000001803F3240 0x00000001803F37F0-0x00000001803F3850
		public EVRSkeletalTrackingLevel skeletalTrackingLevel { get; } // 0x00000001803F3120-0x00000001803F3180 
		public float thumbCurl { get; } // 0x00000001803F3240-0x00000001803F32C0 
		public float indexCurl { get; } // 0x00000001803F2680-0x00000001803F2700 
		public float middleCurl { get; } // 0x00000001803F2D80-0x00000001803F2E00 
		public float ringCurl { get; } // 0x00000001803F3020-0x00000001803F30A0 
		public float pinkyCurl { get; } // 0x00000001803F2EE0-0x00000001803F2F60 
		public float thumbIndexSplay { get; } // 0x00000001803F32C0-0x00000001803F3340 
		public float indexMiddleSplay { get; } // 0x00000001803F2700-0x00000001803F2780 
		public float middleRingSplay { get; } // 0x00000001803F2E00-0x00000001803F2E80 
		public float ringPinkySplay { get; } // 0x00000001803F30A0-0x00000001803F3120 
		public float lastThumbCurl { get; } // 0x00000001803F2C80-0x00000001803F2D00 
		public float lastIndexCurl { get; } // 0x00000001803F2900-0x00000001803F2980 
		public float lastMiddleCurl { get; } // 0x00000001803F2A00-0x00000001803F2A80 
		public float lastRingCurl { get; } // 0x00000001803F2B80-0x00000001803F2C00 
		public float lastPinkyCurl { get; } // 0x00000001803F2B00-0x00000001803F2B80 
		public float lastThumbIndexSplay { get; } // 0x00000001803F2D00-0x00000001803F2D80 
		public float lastIndexMiddleSplay { get; } // 0x00000001803F2980-0x00000001803F2A00 
		public float lastMiddleRingSplay { get; } // 0x00000001803F2A80-0x00000001803F2B00 
		public float lastRingPinkySplay { get; } // 0x00000001803F2C00-0x00000001803F2C80 
		public float[] fingerCurls { get; } // 0x00000001803F25C0-0x00000001803F2620 
		public float[] fingerSplays { get; } // 0x00000001803F2620-0x00000001803F2680 
		public float[] lastFingerCurls { get; } // 0x00000001803F2840-0x00000001803F28A0 
		public float[] lastFingerSplays { get; } // 0x00000001803F28A0-0x00000001803F2900 
		public bool poseChanged { get; } // 0x00000001803F2F60-0x00000001803F2FC0 
		public bool onlyUpdateSummaryData { get; set; } // 0x00000001803F2E80-0x00000001803F2EE0 0x00000001803F36D0-0x00000001803F3730
		public int boneCount { get; } // 0x00000001803EC000-0x00000001803EC060 
	
		// Events
		public event ActiveChangeHandler onActiveChange {
			add; // 0x00000001803F2260-0x00000001803F22D0
			remove; // 0x00000001803F3430-0x00000001803F34A0
		}
		public event ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803F2170-0x00000001803F2260
			remove; // 0x00000001803F3340-0x00000001803F3430
		}
		public event ChangeHandler onChange {
			add; // 0x00000001803F22D0-0x00000001803F2340
			remove; // 0x00000001803F34A0-0x00000001803F3510
		}
		public event UpdateHandler onUpdate {
			add; // 0x00000001803F2420-0x00000001803F2490
			remove; // 0x00000001803F35F0-0x00000001803F3660
		}
		public event TrackingChangeHandler onTrackingChanged {
			add; // 0x00000001803F23B0-0x00000001803F2420
			remove; // 0x00000001803F3580-0x00000001803F35F0
		}
		public event ValidPoseChangeHandler onValidPoseChanged {
			add; // 0x00000001803F2490-0x00000001803F2500
			remove; // 0x00000001803F3660-0x00000001803F36D0
		}
		public event DeviceConnectedChangeHandler onDeviceConnectedChanged {
			add; // 0x00000001803F2340-0x00000001803F23B0
			remove; // 0x00000001803F3510-0x00000001803F3580
		}
	
		// Nested types
		public delegate void ActiveChangeHandler(SteamVR_Action_Skeleton fromAction, bool active); // TypeDefIndex: 7202; 0x000000018028AE70-0x000000018028B0D0
	
		public delegate void ChangeHandler(SteamVR_Action_Skeleton fromAction); // TypeDefIndex: 7203; 0x000000018028C940-0x000000018028CB90
	
		public delegate void UpdateHandler(SteamVR_Action_Skeleton fromAction); // TypeDefIndex: 7204; 0x000000018028C940-0x000000018028CB90
	
		public delegate void TrackingChangeHandler(SteamVR_Action_Skeleton fromAction, ETrackingResult trackingState); // TypeDefIndex: 7205; 0x00000001802969E0-0x0000000180296D60
	
		public delegate void ValidPoseChangeHandler(SteamVR_Action_Skeleton fromAction, bool validPose); // TypeDefIndex: 7206; 0x000000018028AE70-0x000000018028B0D0
	
		public delegate void DeviceConnectedChangeHandler(SteamVR_Action_Skeleton fromAction, bool deviceConnected); // TypeDefIndex: 7207; 0x000000018028AE70-0x000000018028B0D0
	
		// Constructors
		public SteamVR_Action_Skeleton(); // 0x00000001803F2130-0x00000001803F2170
		static SteamVR_Action_Skeleton(); // 0x00000001803F20C0-0x00000001803F2130
	
		// Methods
		public virtual void UpdateValue(bool skipStateAndEventUpdates); // 0x00000001803F2050-0x00000001803F20C0
		public void UpdateValueWithoutEvents(); // 0x00000001803F1FE0-0x00000001803F2050
		public void UpdateTransform(Transform transformToUpdate); // 0x00000001803F1F90-0x00000001803F1FE0
		public bool GetActive(); // 0x00000001803EBF20-0x00000001803EBF80
		public bool GetSetActive(); // 0x00000001803ED070-0x00000001803ED0E0
		public bool GetVelocitiesAtTimeOffset(float secondsFromNow, out Vector3 velocity, out Vector3 angularVelocity); // 0x00000001803ED220-0x00000001803ED2B0
		public bool GetPoseAtTimeOffset(float secondsFromNow, out Vector3 position, out Quaternion rotation, out Vector3 velocity, out Vector3 angularVelocity); // 0x00000001803ECF00-0x00000001803ECF90
		public Vector3 GetLocalPosition(); // 0x00000001803ECD20-0x00000001803ECDA0
		public Quaternion GetLocalRotation(); // 0x00000001803ECDA0-0x00000001803ECE10
		public Vector3 GetVelocity(); // 0x00000001803ED2B0-0x00000001803ED330
		public Vector3 GetAngularVelocity(); // 0x00000001803EBF80-0x00000001803EC000
		public bool GetDeviceIsConnected(); // 0x00000001803EC2F0-0x00000001803EC350
		public bool GetPoseIsValid(); // 0x00000001803ECF90-0x00000001803ECFF0
		public ETrackingResult GetTrackingResult(); // 0x00000001803ED1C0-0x00000001803ED220
		public Vector3 GetLastLocalPosition(); // 0x00000001803ECA70-0x00000001803ECAF0
		public Quaternion GetLastLocalRotation(); // 0x00000001803ECAF0-0x00000001803ECB60
		public Vector3 GetLastVelocity(); // 0x00000001803ECCA0-0x00000001803ECD20
		public Vector3 GetLastAngularVelocity(); // 0x00000001803EC590-0x00000001803EC610
		public bool GetLastDeviceIsConnected(); // 0x00000001803EC7D0-0x00000001803EC830
		public bool GetLastPoseIsValid(); // 0x00000001803ECB60-0x00000001803ECBC0
		public ETrackingResult GetLastTrackingResult(); // 0x00000001803ECC40-0x00000001803ECCA0
		public Vector3[] GetBonePositions(bool copy = false /* Metadata: 0x003A52BA */); // 0x00000001803EC130-0x00000001803EC210
		public Quaternion[] GetBoneRotations(bool copy = false /* Metadata: 0x003A52BB */); // 0x00000001803EC210-0x00000001803EC2F0
		public Vector3[] GetLastBonePositions(bool copy = false /* Metadata: 0x003A52BC */); // 0x00000001803EC610-0x00000001803EC6F0
		public Quaternion[] GetLastBoneRotations(bool copy = false /* Metadata: 0x003A52BD */); // 0x00000001803EC6F0-0x00000001803EC7D0
		public void SetRangeOfMotion(EVRSkeletalMotionRange range); // 0x00000001803ED640-0x00000001803ED6A0
		public void SetSkeletalTransformSpace(EVRSkeletalTransformSpace space); // 0x00000001803ED6A0-0x00000001803ED700
		public uint GetBoneCount(); // 0x00000001803EC000-0x00000001803EC060
		public int[] GetBoneHierarchy(); // 0x00000001803EC060-0x00000001803EC0C0
		public string GetBoneName(int boneIndex); // 0x00000001803EC0C0-0x00000001803EC130
		public SteamVR_Utils.RigidTransform[] GetReferenceTransforms(EVRSkeletalTransformSpace transformSpace, EVRSkeletalReferencePose referencePose); // 0x00000001803ECFF0-0x00000001803ED070
		public EVRSkeletalTrackingLevel GetSkeletalTrackingLevel(); // 0x00000001803ED0E0-0x00000001803ED140
		public float[] GetFingerCurls(bool copy = false /* Metadata: 0x003A52BE */); // 0x00000001803EC3D0-0x00000001803EC4B0
		public float[] GetLastFingerCurls(bool copy = false /* Metadata: 0x003A52BF */); // 0x00000001803EC8B0-0x00000001803EC990
		public float[] GetFingerSplays(bool copy = false /* Metadata: 0x003A52C0 */); // 0x00000001803EC4B0-0x00000001803EC590
		public float[] GetLastFingerSplays(bool copy = false /* Metadata: 0x003A52C1 */); // 0x00000001803EC990-0x00000001803ECA70
		public float GetFingerCurl(int finger); // 0x00000001803EC350-0x00000001803EC3D0
		public float GetSplay(int fingerGapIndex); // 0x00000001803ED140-0x00000001803ED1C0
		public float GetFingerCurl(SteamVR_Skeleton_FingerIndexEnum finger); // 0x00000001803EC350-0x00000001803EC3D0
		public float GetSplay(SteamVR_Skeleton_FingerSplayIndexEnum fingerSplay); // 0x00000001803ED140-0x00000001803ED1C0
		public float GetLastFingerCurl(int finger); // 0x00000001803EC830-0x00000001803EC8B0
		public float GetLastSplay(int fingerGapIndex); // 0x00000001803ECBC0-0x00000001803ECC40
		public float GetLastFingerCurl(SteamVR_Skeleton_FingerIndexEnum finger); // 0x00000001803EC830-0x00000001803EC8B0
		public float GetLastSplay(SteamVR_Skeleton_FingerSplayIndexEnum fingerSplay); // 0x00000001803ECBC0-0x00000001803ECC40
		public string GetLocalizedName(params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts); // 0x00000001803ECE10-0x00000001803ECF00
		public void RemoveAllListeners(SteamVR_Input_Sources input_Sources); // 0x00000001803ED330-0x00000001803ED3A0
		public void AddOnDeviceConnectedChanged(DeviceConnectedChangeHandler functionToCall); // 0x00000001803EBD60-0x00000001803EBDD0
		public void RemoveOnDeviceConnectedChanged(DeviceConnectedChangeHandler functionToStopCalling); // 0x00000001803ED480-0x00000001803ED4F0
		public void AddOnTrackingChanged(TrackingChangeHandler functionToCall); // 0x00000001803EBDD0-0x00000001803EBE40
		public void RemoveOnTrackingChanged(TrackingChangeHandler functionToStopCalling); // 0x00000001803ED4F0-0x00000001803ED560
		public void AddOnValidPoseChanged(ValidPoseChangeHandler functionToCall); // 0x00000001803EBEB0-0x00000001803EBF20
		public void RemoveOnValidPoseChanged(ValidPoseChangeHandler functionToStopCalling); // 0x00000001803ED5D0-0x00000001803ED640
		public void AddOnActiveChangeListener(ActiveChangeHandler functionToCall); // 0x00000001803EBC80-0x00000001803EBCF0
		public void RemoveOnActiveChangeListener(ActiveChangeHandler functionToStopCalling); // 0x00000001803ED3A0-0x00000001803ED410
		public void AddOnChangeListener(ChangeHandler functionToCall); // 0x00000001803EBCF0-0x00000001803EBD60
		public void RemoveOnChangeListener(ChangeHandler functionToStopCalling); // 0x00000001803ED410-0x00000001803ED480
		public void AddOnUpdateListener(UpdateHandler functionToCall); // 0x00000001803EBE40-0x00000001803EBEB0
		public void RemoveOnUpdateListener(UpdateHandler functionToStopCalling); // 0x00000001803ED560-0x00000001803ED5D0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180265310-0x0000000180265320
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803F1F50-0x00000001803F1F90
	}
}
