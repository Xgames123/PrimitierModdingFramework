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
	public class SteamVR_Action_Pose_Source : SteamVR_Action_In_Source, ISteamVR_Action_Pose // TypeDefIndex: 7192
	{
		// Fields
		public ETrackingUniverseOrigin universeOrigin; // 0x158
		protected static uint poseActionData_size; // 0x00
		public float changeTolerance; // 0x15C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Pose.ActiveChangeHandler onActiveChange; // 0x160
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Pose.ActiveChangeHandler onActiveBindingChange; // 0x168
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Pose.ChangeHandler onChange; // 0x170
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Pose.UpdateHandler onUpdate; // 0x178
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Pose.TrackingChangeHandler onTrackingChanged; // 0x180
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Pose.ValidPoseChangeHandler onValidPoseChanged; // 0x188
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Pose.DeviceConnectedChangeHandler onDeviceConnectedChanged; // 0x190
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _changed_k__BackingField; // 0x198
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastChanged_k__BackingField; // 0x199
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastActive_k__BackingField; // 0x19A
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _localPosition_k__BackingField; // 0x19C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Quaternion _localRotation_k__BackingField; // 0x1A8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _lastLocalPosition_k__BackingField; // 0x1B8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Quaternion _lastLocalRotation_k__BackingField; // 0x1C4
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _velocity_k__BackingField; // 0x1D4
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _lastVelocity_k__BackingField; // 0x1E0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _angularVelocity_k__BackingField; // 0x1EC
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _lastAngularVelocity_k__BackingField; // 0x1F8
		protected InputPoseActionData_t poseActionData; // 0x208
		protected InputPoseActionData_t lastPoseActionData; // 0x268
		protected InputPoseActionData_t tempPoseActionData; // 0x2C8
		protected SteamVR_Action_Pose poseAction; // 0x328
		public static float framesAhead; // 0x04
	
		// Properties
		public override bool changed { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E41D0-0x00000001803E41E0 0x00000001803E9080-0x00000001803E9090
		public override bool lastChanged { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8B00-0x00000001803E8B10 0x00000001803E90C0-0x00000001803E90D0
		public override ulong activeOrigin { get; } // 0x00000001803E8A40-0x00000001803E8A80 
		public override ulong lastActiveOrigin { get; } // 0x00000001803E8AC0-0x00000001803E8AD0 
		public override bool active { get; } // 0x00000001803E4220-0x00000001803E4280 
		public override bool activeBinding { get; } // 0x00000001803E8A30-0x00000001803E8A40 
		public override bool lastActive { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8AD0-0x00000001803E8AE0 0x00000001803E9090-0x00000001803E90A0
		public override bool lastActiveBinding { get; } // 0x00000001803E8AB0-0x00000001803E8AC0 
		public ETrackingResult trackingState { get; } // 0x00000001803E8BD0-0x00000001803E8BE0 
		public ETrackingResult lastTrackingState { get; } // 0x00000001803E8B60-0x00000001803E8B70 
		public bool poseIsValid { get; } // 0x00000001803E8BC0-0x00000001803E8BD0 
		public bool lastPoseIsValid { get; } // 0x00000001803E8B50-0x00000001803E8B60 
		public bool deviceIsConnected { get; } // 0x00000001803E8AA0-0x00000001803E8AB0 
		public bool lastDeviceIsConnected { get; } // 0x00000001803E8B10-0x00000001803E8B20 
		public Vector3 localPosition { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8B90-0x00000001803E8BB0 0x00000001803E9120-0x00000001803E9140
		public Quaternion localRotation { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8BB0-0x00000001803E8BC0 0x00000001803E9140-0x00000001803E9150
		public Vector3 lastLocalPosition { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8B20-0x00000001803E8B40 0x00000001803E90D0-0x00000001803E90F0
		public Quaternion lastLocalRotation { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8B40-0x00000001803E8B50 0x00000001803E90F0-0x00000001803E9100
		public Vector3 velocity { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8BE0-0x00000001803E8C00 0x00000001803E9150-0x00000001803E9170
		public Vector3 lastVelocity { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8B70-0x00000001803E8B90 0x00000001803E9100-0x00000001803E9120
		public Vector3 angularVelocity { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8A80-0x00000001803E8AA0 0x00000001803E9060-0x00000001803E9080
		public Vector3 lastAngularVelocity { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803E8AE0-0x00000001803E8B00 0x00000001803E90A0-0x00000001803E90C0
	
		// Events
		public event SteamVR_Action_Pose.ActiveChangeHandler onActiveChange {
			add; // 0x00000001803E8670-0x00000001803E8710
			remove; // 0x00000001803E8CA0-0x00000001803E8D40
		}
		public event SteamVR_Action_Pose.ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803E85D0-0x00000001803E8670
			remove; // 0x00000001803E8C00-0x00000001803E8CA0
		}
		public event SteamVR_Action_Pose.ChangeHandler onChange {
			add; // 0x00000001803E8710-0x00000001803E87B0
			remove; // 0x00000001803E8D40-0x00000001803E8DE0
		}
		public event SteamVR_Action_Pose.UpdateHandler onUpdate {
			add; // 0x00000001803E88F0-0x00000001803E8990
			remove; // 0x00000001803E8F20-0x00000001803E8FC0
		}
		public event SteamVR_Action_Pose.TrackingChangeHandler onTrackingChanged {
			add; // 0x00000001803E8850-0x00000001803E88F0
			remove; // 0x00000001803E8E80-0x00000001803E8F20
		}
		public event SteamVR_Action_Pose.ValidPoseChangeHandler onValidPoseChanged {
			add; // 0x00000001803E8990-0x00000001803E8A30
			remove; // 0x00000001803E8FC0-0x00000001803E9060
		}
		public event SteamVR_Action_Pose.DeviceConnectedChangeHandler onDeviceConnectedChanged {
			add; // 0x00000001803E87B0-0x00000001803E8850
			remove; // 0x00000001803E8DE0-0x00000001803E8E80
		}
	
		// Constructors
		public SteamVR_Action_Pose_Source(); // 0x00000001803E8550-0x00000001803E85D0
		static SteamVR_Action_Pose_Source(); // 0x00000001803E8500-0x00000001803E8550
	
		// Methods
		public override void Preinitialize(SteamVR_Action wrappingAction, SteamVR_Input_Sources forInputSource); // 0x00000001803E74A0-0x00000001803E7540
		public override void Initialize(); // 0x00000001803E7380-0x00000001803E74A0
		public virtual void RemoveAllListeners(); // 0x00000001803E7540-0x00000001803E78F0
		public override void UpdateValue(); // 0x00000001803E7A60-0x00000001803E7A80
		public virtual void UpdateValue(bool skipStateAndEventUpdates); // 0x00000001803E7A80-0x00000001803E8500
		protected void SetCacheVariables(); // 0x00000001803E78F0-0x00000001803E79F0
		protected bool GetChanged(); // 0x00000001803E65A0-0x00000001803E6730
		public bool GetVelocitiesAtTimeOffset(float secondsFromNow, out Vector3 velocityAtTime, out Vector3 angularVelocityAtTime); // 0x00000001803E6E30-0x00000001803E7380
		public bool GetPoseAtTimeOffset(float secondsFromNow, out Vector3 positionAtTime, out Quaternion rotationAtTime, out Vector3 velocityAtTime, out Vector3 angularVelocityAtTime); // 0x00000001803E6730-0x00000001803E6D10
		public void UpdateTransform(Transform transformToUpdate); // 0x00000001803E79F0-0x00000001803E7A60
		protected virtual void CheckAndSendEvents(); // 0x00000001803E6390-0x00000001803E65A0
		protected Vector3 GetUnityCoordinateVelocity(HmdVector3_t vector); // 0x00000001803E6DE0-0x00000001803E6E30
		protected Vector3 GetUnityCoordinateAngularVelocity(HmdVector3_t vector); // 0x00000001803E6D10-0x00000001803E6D70
		protected Vector3 GetUnityCoordinateVelocity(float x, float y, float z); // 0x00000001803E6DB0-0x00000001803E6DE0
		protected Vector3 GetUnityCoordinateAngularVelocity(float x, float y, float z); // 0x00000001803E6D70-0x00000001803E6DB0
	}
}
