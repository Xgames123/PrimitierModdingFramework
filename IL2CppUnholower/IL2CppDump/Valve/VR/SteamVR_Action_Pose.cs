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
	public class SteamVR_Action_Pose : SteamVR_Action_Pose_Base<Valve.VR.SteamVR_Action_Pose_Source_Map<Valve.VR.SteamVR_Action_Pose_Source>, Valve.VR.SteamVR_Action_Pose_Source>, ISerializationCallbackReceiver // TypeDefIndex: 7189
	{
		// Events
		public event ActiveChangeHandler onActiveChange {
			add; // 0x00000001803E92E0-0x00000001803E9350
			remove; // 0x00000001803E9670-0x00000001803E96E0
		}
		public event ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803E91F0-0x00000001803E92E0
			remove; // 0x00000001803E9580-0x00000001803E9670
		}
		public event ChangeHandler onChange {
			add; // 0x00000001803E9350-0x00000001803E93C0
			remove; // 0x00000001803E96E0-0x00000001803E9750
		}
		public event UpdateHandler onUpdate {
			add; // 0x00000001803E94A0-0x00000001803E9510
			remove; // 0x00000001803E9830-0x00000001803E98A0
		}
		public event TrackingChangeHandler onTrackingChanged {
			add; // 0x00000001803E9430-0x00000001803E94A0
			remove; // 0x00000001803E97C0-0x00000001803E9830
		}
		public event ValidPoseChangeHandler onValidPoseChanged {
			add; // 0x00000001803E9510-0x00000001803E9580
			remove; // 0x00000001803E98A0-0x00000001803E9910
		}
		public event DeviceConnectedChangeHandler onDeviceConnectedChanged {
			add; // 0x00000001803E93C0-0x00000001803E9430
			remove; // 0x00000001803E9750-0x00000001803E97C0
		}
	
		// Nested types
		public delegate void ActiveChangeHandler(SteamVR_Action_Pose fromAction, SteamVR_Input_Sources fromSource, bool active); // TypeDefIndex: 7183; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void ChangeHandler(SteamVR_Action_Pose fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7184; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void UpdateHandler(SteamVR_Action_Pose fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7185; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void TrackingChangeHandler(SteamVR_Action_Pose fromAction, SteamVR_Input_Sources fromSource, ETrackingResult trackingState); // TypeDefIndex: 7186; 0x0000000180296640-0x00000001802969E0
	
		public delegate void ValidPoseChangeHandler(SteamVR_Action_Pose fromAction, SteamVR_Input_Sources fromSource, bool validPose); // TypeDefIndex: 7187; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void DeviceConnectedChangeHandler(SteamVR_Action_Pose fromAction, SteamVR_Input_Sources fromSource, bool deviceConnected); // TypeDefIndex: 7188; 0x000000018028ABF0-0x000000018028AE70
	
		// Constructors
		public SteamVR_Action_Pose(); // 0x00000001803E91B0-0x00000001803E91F0
	
		// Methods
		public void AddOnDeviceConnectedChanged(SteamVR_Input_Sources inputSource, DeviceConnectedChangeHandler functionToCall); // 0x00000001803E5DA0-0x00000001803E5E20
		public void RemoveOnDeviceConnectedChanged(SteamVR_Input_Sources inputSource, DeviceConnectedChangeHandler functionToStopCalling); // 0x00000001803E6110-0x00000001803E6190
		public void AddOnTrackingChanged(SteamVR_Input_Sources inputSource, TrackingChangeHandler functionToCall); // 0x00000001803E5E20-0x00000001803E5EA0
		public void RemoveOnTrackingChanged(SteamVR_Input_Sources inputSource, TrackingChangeHandler functionToStopCalling); // 0x00000001803E6190-0x00000001803E6210
		public void AddOnValidPoseChanged(SteamVR_Input_Sources inputSource, ValidPoseChangeHandler functionToCall); // 0x00000001803E5F20-0x00000001803E5FA0
		public void RemoveOnValidPoseChanged(SteamVR_Input_Sources inputSource, ValidPoseChangeHandler functionToStopCalling); // 0x00000001803E6290-0x00000001803E6310
		public void AddOnActiveChangeListener(SteamVR_Input_Sources inputSource, ActiveChangeHandler functionToCall); // 0x00000001803E5CA0-0x00000001803E5D20
		public void RemoveOnActiveChangeListener(SteamVR_Input_Sources inputSource, ActiveChangeHandler functionToStopCalling); // 0x00000001803E6010-0x00000001803E6090
		public void AddOnChangeListener(SteamVR_Input_Sources inputSource, ChangeHandler functionToCall); // 0x00000001803E5D20-0x00000001803E5DA0
		public void RemoveOnChangeListener(SteamVR_Input_Sources inputSource, ChangeHandler functionToStopCalling); // 0x00000001803E6090-0x00000001803E6110
		public void AddOnUpdateListener(SteamVR_Input_Sources inputSource, UpdateHandler functionToCall); // 0x00000001803E5EA0-0x00000001803E5F20
		public void RemoveOnUpdateListener(SteamVR_Input_Sources inputSource, UpdateHandler functionToStopCalling); // 0x00000001803E6210-0x00000001803E6290
		public void RemoveAllListeners(SteamVR_Input_Sources input_Sources); // 0x00000001803E5FA0-0x00000001803E6010
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180265310-0x0000000180265320
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803E9170-0x00000001803E91B0
		public static void SetTrackingUniverseOrigin(ETrackingUniverseOrigin newOrigin); // 0x00000001803E6310-0x00000001803E6390
	}
}
