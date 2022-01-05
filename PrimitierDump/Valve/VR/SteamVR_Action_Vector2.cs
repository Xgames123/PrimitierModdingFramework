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
	public class SteamVR_Action_Vector2 : SteamVR_Action_In<Valve.VR.SteamVR_Action_Vector2_Source_Map, Valve.VR.SteamVR_Action_Vector2_Source>, ISteamVR_Action_Vector2, ISerializationCallbackReceiver // TypeDefIndex: 7223
	{
		// Properties
		public Vector2 axis { get; } // 0x00000001803F5EA0-0x00000001803F5F10 
		public Vector2 lastAxis { get; } // 0x00000001803F5F80-0x00000001803F5FF0 
		public Vector2 delta { get; } // 0x00000001803F5F10-0x00000001803F5F80 
		public Vector2 lastDelta { get; } // 0x00000001803F5FF0-0x00000001803F6060 
	
		// Events
		public event ChangeHandler onChange {
			add; // 0x00000001803F5DC0-0x00000001803F5E30
			remove; // 0x00000001803F61B0-0x00000001803F6220
		}
		public event UpdateHandler onUpdate {
			add; // 0x00000001803F5E30-0x00000001803F5EA0
			remove; // 0x00000001803F6220-0x00000001803F6290
		}
		public event AxisHandler onAxis {
			add; // 0x00000001803F5D50-0x00000001803F5DC0
			remove; // 0x00000001803F6140-0x00000001803F61B0
		}
		public event ActiveChangeHandler onActiveChange {
			add; // 0x00000001803F5CE0-0x00000001803F5D50
			remove; // 0x00000001803F60D0-0x00000001803F6140
		}
		public event ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803F5C70-0x00000001803F5CE0
			remove; // 0x00000001803F6060-0x00000001803F60D0
		}
	
		// Nested types
		public delegate void AxisHandler(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 axis, Vector2 delta); // TypeDefIndex: 7219; 0x000000018028B890-0x000000018028BB70
	
		public delegate void ActiveChangeHandler(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, bool active); // TypeDefIndex: 7220; 0x000000018028A840-0x000000018028ABF0
	
		public delegate void ChangeHandler(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 axis, Vector2 delta); // TypeDefIndex: 7221; 0x000000018028B890-0x000000018028BB70
	
		public delegate void UpdateHandler(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 axis, Vector2 delta); // TypeDefIndex: 7222; 0x000000018028B890-0x000000018028BB70
	
		// Constructors
		public SteamVR_Action_Vector2(); // 0x00000001803F5C30-0x00000001803F5C70
	
		// Methods
		public Vector2 GetAxis(SteamVR_Input_Sources inputSource); // 0x00000001803F42C0-0x00000001803F4330
		public Vector2 GetAxisDelta(SteamVR_Input_Sources inputSource); // 0x00000001803F4250-0x00000001803F42C0
		public Vector2 GetLastAxis(SteamVR_Input_Sources inputSource); // 0x00000001803F43A0-0x00000001803F4410
		public Vector2 GetLastAxisDelta(SteamVR_Input_Sources inputSource); // 0x00000001803F4330-0x00000001803F43A0
		public void AddOnActiveChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F4050-0x00000001803F40D0
		public void RemoveOnActiveChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F4500-0x00000001803F4580
		public void AddOnActiveBindingChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F3FD0-0x00000001803F4050
		public void RemoveOnActiveBindingChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F4480-0x00000001803F4500
		public void AddOnChangeListener(ChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F4150-0x00000001803F41D0
		public void RemoveOnChangeListener(ChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F4600-0x00000001803F4680
		public void AddOnUpdateListener(UpdateHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F41D0-0x00000001803F4250
		public void RemoveOnUpdateListener(UpdateHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F4680-0x00000001803F4700
		public void AddOnAxisListener(AxisHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F40D0-0x00000001803F4150
		public void RemoveOnAxisListener(AxisHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F4580-0x00000001803F4600
		public void RemoveAllListeners(SteamVR_Input_Sources input_Sources); // 0x00000001803F4410-0x00000001803F4480
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180265310-0x0000000180265320
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803F5BF0-0x00000001803F5C30
	}
}
