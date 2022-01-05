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
	public interface ISteamVR_Action_Pose : ISteamVR_Action_In_Source // TypeDefIndex: 7193
	{
		// Properties
		Vector3 localPosition { get; }
		Quaternion localRotation { get; }
		ETrackingResult trackingState { get; }
		Vector3 velocity { get; }
		Vector3 angularVelocity { get; }
		bool poseIsValid { get; }
		bool deviceIsConnected { get; }
		Vector3 lastLocalPosition { get; }
		Quaternion lastLocalRotation { get; }
		ETrackingResult lastTrackingState { get; }
		Vector3 lastVelocity { get; }
		Vector3 lastAngularVelocity { get; }
		bool lastPoseIsValid { get; }
		bool lastDeviceIsConnected { get; }
	}
}
