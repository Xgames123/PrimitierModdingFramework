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
	public class SteamVR_Action_Vibration : SteamVR_Action_Out<Valve.VR.SteamVR_Action_Vibration_Source_Map, Valve.VR.SteamVR_Action_Vibration_Source>, ISerializationCallbackReceiver // TypeDefIndex: 7237
	{
		// Events
		public event ActiveChangeHandler onActiveChange {
			add; // 0x00000001803F9580-0x00000001803F95F0
			remove; // 0x00000001803F96D0-0x00000001803F9740
		}
		public event ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803F9510-0x00000001803F9580
			remove; // 0x00000001803F9660-0x00000001803F96D0
		}
		public event ExecuteHandler onExecute {
			add; // 0x00000001803F95F0-0x00000001803F9660
			remove; // 0x00000001803F9740-0x00000001803F97B0
		}
	
		// Nested types
		public delegate void ActiveChangeHandler(SteamVR_Action_Vibration fromAction, SteamVR_Input_Sources fromSource, bool active); // TypeDefIndex: 7235; 0x000000018028A840-0x000000018028ABF0
	
		public delegate void ExecuteHandler(SteamVR_Action_Vibration fromAction, SteamVR_Input_Sources fromSource, float secondsFromNow, float durationSeconds, float frequency, float amplitude); // TypeDefIndex: 7236; 0x000000018028D920-0x000000018028DEA0
	
		// Constructors
		public SteamVR_Action_Vibration(); // 0x00000001803F94D0-0x00000001803F9510
	
		// Methods
		public void Execute(float secondsFromNow, float durationSeconds, float frequency, float amplitude, SteamVR_Input_Sources inputSource); // 0x00000001803F8720-0x00000001803F87C0
		public void AddOnActiveChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F8620-0x00000001803F86A0
		public void RemoveOnActiveChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F8900-0x00000001803F8980
		public void AddOnActiveBindingChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F85A0-0x00000001803F8620
		public void RemoveOnActiveBindingChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F8880-0x00000001803F8900
		public void AddOnExecuteListener(ExecuteHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803F86A0-0x00000001803F8720
		public void RemoveOnExecuteListener(ExecuteHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803F8980-0x00000001803F8A00
		public override float GetTimeLastChanged(SteamVR_Input_Sources inputSource); // 0x00000001803F87C0-0x00000001803F8820
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180265310-0x0000000180265320
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803F9490-0x00000001803F94D0
		public override bool IsUpdating(SteamVR_Input_Sources inputSource); // 0x00000001803F8820-0x00000001803F8880
	}
}
