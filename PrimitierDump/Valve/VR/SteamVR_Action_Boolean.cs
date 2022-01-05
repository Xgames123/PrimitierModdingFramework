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
	public class SteamVR_Action_Boolean : SteamVR_Action_In<Valve.VR.SteamVR_Action_Boolean_Source_Map, Valve.VR.SteamVR_Action_Boolean_Source>, ISteamVR_Action_Boolean, ISerializationCallbackReceiver // TypeDefIndex: 7170
	{
		// Properties
		public bool state { get; } // 0x00000001803E4E10-0x00000001803E4E90 
		public bool stateDown { get; } // 0x00000001803E4D10-0x00000001803E4D90 
		public bool stateUp { get; } // 0x00000001803E4D90-0x00000001803E4E10 
		public bool lastState { get; } // 0x00000001803E4CB0-0x00000001803E4D10 
		public bool lastStateDown { get; } // 0x00000001803E4BD0-0x00000001803E4C40 
		public bool lastStateUp { get; } // 0x00000001803E4C40-0x00000001803E4CB0 
	
		// Events
		public event ChangeHandler onChange {
			add; // 0x00000001803E49A0-0x00000001803E4A10
			remove; // 0x00000001803E4F70-0x00000001803E4FE0
		}
		public event UpdateHandler onUpdate {
			add; // 0x00000001803E4B60-0x00000001803E4BD0
			remove; // 0x00000001803E5130-0x00000001803E51A0
		}
		public event StateHandler onState {
			add; // 0x00000001803E4AF0-0x00000001803E4B60
			remove; // 0x00000001803E50C0-0x00000001803E5130
		}
		public event StateDownHandler onStateDown {
			add; // 0x00000001803E4A10-0x00000001803E4A80
			remove; // 0x00000001803E4FE0-0x00000001803E5050
		}
		public event StateUpHandler onStateUp {
			add; // 0x00000001803E4A80-0x00000001803E4AF0
			remove; // 0x00000001803E5050-0x00000001803E50C0
		}
		public event ActiveChangeHandler onActiveChange {
			add; // 0x00000001803E4930-0x00000001803E49A0
			remove; // 0x00000001803E4F00-0x00000001803E4F70
		}
		public event ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803E48C0-0x00000001803E4930
			remove; // 0x00000001803E4E90-0x00000001803E4F00
		}
	
		// Nested types
		public delegate void StateDownHandler(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7164; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void StateUpHandler(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7165; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void StateHandler(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7166; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void ActiveChangeHandler(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool active); // TypeDefIndex: 7167; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void ChangeHandler(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState); // TypeDefIndex: 7168; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void UpdateHandler(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState); // TypeDefIndex: 7169; 0x000000018028ABF0-0x000000018028AE70
	
		// Constructors
		public SteamVR_Action_Boolean(); // 0x00000001803E4880-0x00000001803E48C0
	
		// Methods
		public bool GetStateDown(SteamVR_Input_Sources inputSource); // 0x00000001803E2C70-0x00000001803E2D00
		public bool GetStateUp(SteamVR_Input_Sources inputSource); // 0x00000001803E2D00-0x00000001803E2D90
		public bool GetState(SteamVR_Input_Sources inputSource); // 0x00000001803E2D90-0x00000001803E2E20
		public bool GetLastStateDown(SteamVR_Input_Sources inputSource); // 0x00000001803E2B10-0x00000001803E2B90
		public bool GetLastStateUp(SteamVR_Input_Sources inputSource); // 0x00000001803E2B90-0x00000001803E2C10
		public bool GetLastState(SteamVR_Input_Sources inputSource); // 0x00000001803E2C10-0x00000001803E2C70
		public void AddOnActiveChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E2890-0x00000001803E2910
		public void RemoveOnActiveChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E2F10-0x00000001803E2F90
		public void AddOnActiveBindingChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E2810-0x00000001803E2890
		public void RemoveOnActiveBindingChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E2E90-0x00000001803E2F10
		public void AddOnChangeListener(ChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E2910-0x00000001803E2990
		public void RemoveOnChangeListener(ChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E2F90-0x00000001803E3010
		public void AddOnUpdateListener(UpdateHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E2A90-0x00000001803E2B10
		public void RemoveOnUpdateListener(UpdateHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E3110-0x00000001803E3190
		public void AddOnStateDownListener(StateDownHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E2990-0x00000001803E2A10
		public void RemoveOnStateDownListener(StateDownHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E3010-0x00000001803E3090
		public void AddOnStateUpListener(StateUpHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E2A10-0x00000001803E2A90
		public void RemoveOnStateUpListener(StateUpHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E3090-0x00000001803E3110
		public void RemoveAllListeners(SteamVR_Input_Sources input_Sources); // 0x00000001803E2E20-0x00000001803E2E90
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180265310-0x0000000180265320
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803E4840-0x00000001803E4880
	}
}
