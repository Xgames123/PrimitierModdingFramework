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
	public class SteamVR_Action_Single : SteamVR_Action_In<Valve.VR.SteamVR_Action_Single_Source_Map, Valve.VR.SteamVR_Action_Single_Source>, ISteamVR_Action_Single, ISerializationCallbackReceiver // TypeDefIndex: 7198
	{
		// Properties
		public float axis { get; } // 0x00000001803EB850-0x00000001803EB8D0 
		public float lastAxis { get; } // 0x00000001803EB950-0x00000001803EB9D0 
		public float delta { get; } // 0x00000001803EB8D0-0x00000001803EB950 
		public float lastDelta { get; } // 0x00000001803EB9D0-0x00000001803EBA50 
	
		// Events
		public event ChangeHandler onChange {
			add; // 0x00000001803EB770-0x00000001803EB7E0
			remove; // 0x00000001803EBBA0-0x00000001803EBC10
		}
		public event UpdateHandler onUpdate {
			add; // 0x00000001803EB7E0-0x00000001803EB850
			remove; // 0x00000001803EBC10-0x00000001803EBC80
		}
		public event AxisHandler onAxis {
			add; // 0x00000001803EB700-0x00000001803EB770
			remove; // 0x00000001803EBB30-0x00000001803EBBA0
		}
		public event ActiveChangeHandler onActiveChange {
			add; // 0x00000001803EB690-0x00000001803EB700
			remove; // 0x00000001803EBAC0-0x00000001803EBB30
		}
		public event ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803EB620-0x00000001803EB690
			remove; // 0x00000001803EBA50-0x00000001803EBAC0
		}
	
		// Nested types
		public delegate void AxisHandler(SteamVR_Action_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // TypeDefIndex: 7194; 0x000000018028B5D0-0x000000018028B890
	
		public delegate void ActiveChangeHandler(SteamVR_Action_Single fromAction, SteamVR_Input_Sources fromSource, bool active); // TypeDefIndex: 7195; 0x000000018028A840-0x000000018028ABF0
	
		public delegate void ChangeHandler(SteamVR_Action_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // TypeDefIndex: 7196; 0x000000018028B5D0-0x000000018028B890
	
		public delegate void UpdateHandler(SteamVR_Action_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // TypeDefIndex: 7197; 0x000000018028B5D0-0x000000018028B890
	
		// Constructors
		public SteamVR_Action_Single(); // 0x00000001803EB5E0-0x00000001803EB620
	
		// Methods
		public float GetAxis(SteamVR_Input_Sources inputSource); // 0x00000001803E9C20-0x00000001803E9CB0
		public float GetAxisDelta(SteamVR_Input_Sources inputSource); // 0x00000001803E9B90-0x00000001803E9C20
		public float GetLastAxis(SteamVR_Input_Sources inputSource); // 0x00000001803E9D40-0x00000001803E9DD0
		public float GetLastAxisDelta(SteamVR_Input_Sources inputSource); // 0x00000001803E9CB0-0x00000001803E9D40
		public void AddOnActiveChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E9990-0x00000001803E9A10
		public void RemoveOnActiveChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E9EC0-0x00000001803E9F40
		public void AddOnActiveBindingChangeListener(ActiveChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E9910-0x00000001803E9990
		public void RemoveOnActiveBindingChangeListener(ActiveChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E9E40-0x00000001803E9EC0
		public void AddOnChangeListener(ChangeHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E9A90-0x00000001803E9B10
		public void RemoveOnChangeListener(ChangeHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E9FC0-0x00000001803EA040
		public void AddOnUpdateListener(UpdateHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E9B10-0x00000001803E9B90
		public void RemoveOnUpdateListener(UpdateHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803EA040-0x00000001803EA0C0
		public void AddOnAxisListener(AxisHandler functionToCall, SteamVR_Input_Sources inputSource); // 0x00000001803E9A10-0x00000001803E9A90
		public void RemoveOnAxisListener(AxisHandler functionToStopCalling, SteamVR_Input_Sources inputSource); // 0x00000001803E9F40-0x00000001803E9FC0
		public void RemoveAllListeners(SteamVR_Input_Sources inputSource); // 0x00000001803E9DD0-0x00000001803E9E40
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180265310-0x0000000180265320
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803EB5A0-0x00000001803EB5E0
	}
}
