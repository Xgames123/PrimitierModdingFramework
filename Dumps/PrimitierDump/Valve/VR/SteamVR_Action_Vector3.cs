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
	public class SteamVR_Action_Vector3 : SteamVR_Action_In<Valve.VR.SteamVR_Action_Vector3_Source_Map, Valve.VR.SteamVR_Action_Vector3_Source>, ISteamVR_Action_Vector3, ISerializationCallbackReceiver // TypeDefIndex: 7231
	{
		// Properties
		public Vector3 axis { get; } // 0x00000001803F8170-0x00000001803F81F0 
		public Vector3 lastAxis { get; } // 0x00000001803F8270-0x00000001803F82F0 
		public Vector3 delta { get; } // 0x00000001803F81F0-0x00000001803F8270 
		public Vector3 lastDelta { get; } // 0x00000001803F82F0-0x00000001803F8370 
	
		// Events
		public event ChangeHandler onChange {
			add; // 0x00000001803F8090-0x00000001803F8100
			remove; // 0x00000001803F84C0-0x00000001803F8530
		}
		public event UpdateHandler onUpdate {
			add; // 0x00000001803F8100-0x00000001803F8170
			remove; // 0x00000001803F8530-0x00000001803F85A0
		}
		public event AxisHandler onAxis {
			add; // 0x00000001803F8020-0x00000001803F8090
			remove; // 0x00000001803F8450-0x00000001803F84C0
		}
		public event ActiveChangeHandler onActiveChange {
			add; // 0x00000001803F7FB0-0x00000001803F8020
			remove; // 0x00000001803F83E0-0x00000001803F8450
		}
		public event ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803F7F40-0x00000001803F7FB0
			remove; // 0x00000001803F8370-0x00000001803F83E0
		}
	
		// Nested types
		public delegate void AxisHandler(SteamVR_Action_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 axis, Vector3 delta); // TypeDefIndex: 7227; 0x000000018028BB70-0x000000018028C120
	
		public delegate void ActiveChangeHandler(SteamVR_Action_Vector3 fromAction, SteamVR_Input_Sources fromSource, bool active); // TypeDefIndex: 7228; 0x000000018028A840-0x000000018028ABF0
	
		public delegate void ChangeHandler(SteamVR_Action_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 axis, Vector3 delta); // TypeDefIndex: 7229; 0x000000018028BB70-0x000000018028C120
	
		public delegate void UpdateHandler(SteamVR_Action_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 axis, Vector3 delta); // TypeDefIndex: 7230; 0x000000018028BB70-0x000000018028C120
	
		// Constructors
		public SteamVR_Action_Vector3(); // 0x00000001803F7F00-0x00000001803F7F40
	
		// Methods
		public Vector3 GetAxis(SteamVR_Input_Sources inputSource); // 0x00000001803F6590-0x00000001803F6610
		public Vector3 GetAxisDelta(SteamVR_Input_Sources inputSource); // 0x00000001803F6510-0x00000001803F6590
		public Vector3 GetLastAxis(SteamVR_Input_Sources inputSource); // 0x00000001803F6690-0x00000001803F6710
		public Vector3 GetLastAxisDelta(SteamVR_Input_Sources inputSource); // 0x00000001803F6610-0x00000001803F6690
		public void AddOnActiveChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F6310-0x00000001803F6390
		public void RemoveOnActiveChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F6800-0x00000001803F6880
		public void AddOnActiveBindingChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F6290-0x00000001803F6310
		public void RemoveOnActiveBindingChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F6780-0x00000001803F6800
		public void AddOnChangeListener(ChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F6410-0x00000001803F6490
		public void RemoveOnChangeListener(ChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F6900-0x00000001803F6980
		public void AddOnUpdateListener(UpdateHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F6490-0x00000001803F6510
		public void RemoveOnUpdateListener(UpdateHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F6980-0x00000001803F6A00
		public void AddOnAxisListener(AxisHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F6390-0x00000001803F6410
		public void RemoveOnAxisListener(AxisHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F6880-0x00000001803F6900
		public void RemoveAllListeners(SteamVR_Input_Sources input_Sources); // 0x00000001803F6710-0x00000001803F6780
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180265310-0x0000000180265320
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803F7EC0-0x00000001803F7F00
	}
}
