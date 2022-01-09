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
	public abstract class SteamVR_Action_Pose_Base<SourceMap, SourceElement> : SteamVR_Action_In<SourceMap, SourceElement>, ISteamVR_Action_Pose // TypeDefIndex: 7190
		where SourceMap : SteamVR_Action_Pose_Source_Map<SourceElement>, new()
		where SourceElement : SteamVR_Action_Pose_Source, new()
	{
		// Properties
		public Vector3 localPosition { get; }
		public Quaternion localRotation { get; }
		public ETrackingResult trackingState { get; }
		public Vector3 velocity { get; }
		public Vector3 angularVelocity { get; }
		public bool poseIsValid { get; }
		public bool deviceIsConnected { get; }
		public Vector3 lastLocalPosition { get; }
		public Quaternion lastLocalRotation { get; }
		public ETrackingResult lastTrackingState { get; }
		public Vector3 lastVelocity { get; }
		public Vector3 lastAngularVelocity { get; }
		public bool lastPoseIsValid { get; }
		public bool lastDeviceIsConnected { get; }
	
		// Constructors
		public SteamVR_Action_Pose_Base();
	
		// Methods
		protected static void SetUniverseOrigin(ETrackingUniverseOrigin newOrigin);
		public virtual void UpdateValues(bool skipStateAndEventUpdates);
		public bool GetVelocitiesAtTimeOffset(SteamVR_Input_Sources inputSource, float secondsFromNow, out Vector3 velocity, out Vector3 angularVelocity);
		public bool GetPoseAtTimeOffset(SteamVR_Input_Sources inputSource, float secondsFromNow, out Vector3 localPosition, out Quaternion localRotation, out Vector3 velocity, out Vector3 angularVelocity);
		public virtual void UpdateTransform(SteamVR_Input_Sources inputSource, Transform transformToUpdate);
		public Vector3 GetLocalPosition(SteamVR_Input_Sources inputSource);
		public Quaternion GetLocalRotation(SteamVR_Input_Sources inputSource);
		public Vector3 GetVelocity(SteamVR_Input_Sources inputSource);
		public Vector3 GetAngularVelocity(SteamVR_Input_Sources inputSource);
		public bool GetDeviceIsConnected(SteamVR_Input_Sources inputSource);
		public bool GetPoseIsValid(SteamVR_Input_Sources inputSource);
		public ETrackingResult GetTrackingResult(SteamVR_Input_Sources inputSource);
		public Vector3 GetLastLocalPosition(SteamVR_Input_Sources inputSource);
		public Quaternion GetLastLocalRotation(SteamVR_Input_Sources inputSource);
		public Vector3 GetLastVelocity(SteamVR_Input_Sources inputSource);
		public Vector3 GetLastAngularVelocity(SteamVR_Input_Sources inputSource);
		public bool GetLastDeviceIsConnected(SteamVR_Input_Sources inputSource);
		public bool GetLastPoseIsValid(SteamVR_Input_Sources inputSource);
		public ETrackingResult GetLastTrackingResult(SteamVR_Input_Sources inputSource);
	}
}
