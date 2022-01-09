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
	public class SteamVR_Behaviour_Pose : MonoBehaviour // TypeDefIndex: 7256
	{
		// Fields
		public SteamVR_Action_Pose poseAction; // 0x18
		[Tooltip] // 0x0000000180023A00-0x0000000180023A30
		public SteamVR_Input_Sources inputSource; // 0x20
		[Tooltip] // 0x0000000180023A30-0x0000000180023A60
		public Transform origin; // 0x28
		public SteamVR_Behaviour_PoseEvent onTransformUpdated; // 0x30
		public SteamVR_Behaviour_PoseEvent onTransformChanged; // 0x38
		public SteamVR_Behaviour_Pose_ConnectedChangedEvent onConnectedChanged; // 0x40
		public SteamVR_Behaviour_Pose_TrackingChangedEvent onTrackingChanged; // 0x48
		public SteamVR_Behaviour_Pose_DeviceIndexChangedEvent onDeviceIndexChanged; // 0x50
		public UpdateHandler onTransformUpdatedEvent; // 0x58
		public ChangeHandler onTransformChangedEvent; // 0x60
		public DeviceConnectedChangeHandler onConnectedChangedEvent; // 0x68
		public TrackingChangeHandler onTrackingChangedEvent; // 0x70
		public DeviceIndexChangedHandler onDeviceIndexChangedEvent; // 0x78
		[Tooltip] // 0x0000000180023A60-0x0000000180023A90
		public bool broadcastDeviceChanges; // 0x80
		protected int deviceIndex; // 0x84
		protected SteamVR_HistoryBuffer historyBuffer; // 0x88
		protected int lastFrameUpdated; // 0x90
	
		// Properties
		public bool isValid { get; } // 0x00000001803FCD80-0x00000001803FCDC0 
		public bool isActive { get; } // 0x00000001803FA7C0-0x00000001803FA810 
	
		// Nested types
		public delegate void ActiveChangeHandler(SteamVR_Behaviour_Pose fromAction, SteamVR_Input_Sources fromSource, bool active); // TypeDefIndex: 7249; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void ChangeHandler(SteamVR_Behaviour_Pose fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7250; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void UpdateHandler(SteamVR_Behaviour_Pose fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7251; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void TrackingChangeHandler(SteamVR_Behaviour_Pose fromAction, SteamVR_Input_Sources fromSource, ETrackingResult trackingState); // TypeDefIndex: 7252; 0x000000018028D130-0x000000018028D3A0
	
		public delegate void ValidPoseChangeHandler(SteamVR_Behaviour_Pose fromAction, SteamVR_Input_Sources fromSource, bool validPose); // TypeDefIndex: 7253; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void DeviceConnectedChangeHandler(SteamVR_Behaviour_Pose fromAction, SteamVR_Input_Sources fromSource, bool deviceConnected); // TypeDefIndex: 7254; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void DeviceIndexChangedHandler(SteamVR_Behaviour_Pose fromAction, SteamVR_Input_Sources fromSource, int newDeviceIndex); // TypeDefIndex: 7255; 0x000000018028D130-0x000000018028D3A0
	
		// Constructors
		public SteamVR_Behaviour_Pose(); // 0x00000001803FCCB0-0x00000001803FCD80
	
		// Methods
		protected virtual void Start(); // 0x00000001803FC410-0x00000001803FC540
		protected virtual void OnEnable(); // 0x00000001803FC120-0x00000001803FC390
		protected virtual void OnDisable(); // 0x00000001803FBEC0-0x00000001803FC120
		private void SteamVR_Behaviour_Pose_OnUpdate(SteamVR_Action_Pose fromAction, SteamVR_Input_Sources fromSource); // 0x00000001803FC5B0-0x00000001803FC7F0
		protected virtual void UpdateTransform(); // 0x00000001803FCA10-0x00000001803FCCB0
		private void SteamVR_Behaviour_Pose_OnChange(SteamVR_Action_Pose fromAction, SteamVR_Input_Sources fromSource); // 0x00000001803FC540-0x00000001803FC5B0
		protected virtual void OnDeviceConnectedChanged(SteamVR_Action_Pose changedAction, SteamVR_Input_Sources changedSource, bool connected); // 0x00000001803FBE20-0x00000001803FBEC0
		protected virtual void OnTrackingChanged(SteamVR_Action_Pose changedAction, SteamVR_Input_Sources changedSource, ETrackingResult trackingChanged); // 0x00000001803FC390-0x00000001803FC410
		protected virtual void CheckDeviceIndex(); // 0x00000001803FB8F0-0x00000001803FBB20
		public int GetDeviceIndex(); // 0x00000001803FBBF0-0x00000001803FBC20
		public Vector3 GetVelocity(); // 0x00000001803FBDD0-0x00000001803FBE20
		public Vector3 GetAngularVelocity(); // 0x00000001803FBBA0-0x00000001803FBBF0
		public bool GetVelocitiesAtTimeOffset(float secondsFromNow, out Vector3 velocity, out Vector3 angularVelocity); // 0x00000001803FBD60-0x00000001803FBDD0
		public void GetEstimatedPeakVelocities(out Vector3 velocity, out Vector3 angularVelocity); // 0x00000001803FBC20-0x00000001803FBCA0
		protected void UpdateHistoryBuffer(); // 0x00000001803FC830-0x00000001803FCA10
		public string GetLocalizedName(params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts); // 0x00000001803FBCA0-0x00000001803FBD60
	}
}
