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
	public class SteamVR_Behaviour_Boolean : MonoBehaviour // TypeDefIndex: 7248
	{
		// Fields
		[Tooltip] // 0x00000001800239D0-0x0000000180023A00
		public SteamVR_Action_Boolean booleanAction; // 0x18
		[Tooltip] // 0x0000000180023A00-0x0000000180023A30
		public SteamVR_Input_Sources inputSource; // 0x20
		public SteamVR_Behaviour_BooleanEvent onChange; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ChangeHandler onChangeEvent; // 0x30
		public SteamVR_Behaviour_BooleanEvent onUpdate; // 0x38
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private UpdateHandler onUpdateEvent; // 0x40
		public SteamVR_Behaviour_BooleanEvent onPress; // 0x48
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private StateHandler onPressEvent; // 0x50
		public SteamVR_Behaviour_BooleanEvent onPressDown; // 0x58
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private StateDownHandler onPressDownEvent; // 0x60
		public SteamVR_Behaviour_BooleanEvent onPressUp; // 0x68
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private StateUpHandler onPressUpEvent; // 0x70
	
		// Properties
		public bool isActive { get; } // 0x00000001803FA7C0-0x00000001803FA810 
		public SteamVR_ActionSet actionSet { get; } // 0x00000001803FA720-0x00000001803FA7C0 
	
		// Events
		public event ChangeHandler onChangeEvent {
			add; // 0x00000001803FA400-0x00000001803FA4A0
			remove; // 0x00000001803FA810-0x00000001803FA8B0
		}
		public event UpdateHandler onUpdateEvent {
			add; // 0x00000001803FA680-0x00000001803FA720
			remove; // 0x00000001803FAA90-0x00000001803FAB30
		}
		public event StateHandler onPressEvent {
			add; // 0x00000001803FA540-0x00000001803FA5E0
			remove; // 0x00000001803FA950-0x00000001803FA9F0
		}
		public event StateDownHandler onPressDownEvent {
			add; // 0x00000001803FA4A0-0x00000001803FA540
			remove; // 0x00000001803FA8B0-0x00000001803FA950
		}
		public event StateUpHandler onPressUpEvent {
			add; // 0x00000001803FA5E0-0x00000001803FA680
			remove; // 0x00000001803FA9F0-0x00000001803FAA90
		}
	
		// Nested types
		public delegate void StateDownHandler(SteamVR_Behaviour_Boolean fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7242; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void StateUpHandler(SteamVR_Behaviour_Boolean fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7243; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void StateHandler(SteamVR_Behaviour_Boolean fromAction, SteamVR_Input_Sources fromSource); // TypeDefIndex: 7244; 0x000000018028CB90-0x000000018028CDE0
	
		public delegate void ActiveChangeHandler(SteamVR_Behaviour_Boolean fromAction, SteamVR_Input_Sources fromSource, bool active); // TypeDefIndex: 7245; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void ChangeHandler(SteamVR_Behaviour_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState); // TypeDefIndex: 7246; 0x000000018028ABF0-0x000000018028AE70
	
		public delegate void UpdateHandler(SteamVR_Behaviour_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState); // TypeDefIndex: 7247; 0x000000018028ABF0-0x000000018028AE70
	
		// Constructors
		public SteamVR_Behaviour_Boolean(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		protected virtual void OnEnable(); // 0x00000001803F9DC0-0x00000001803F9E90
		protected virtual void OnDisable(); // 0x00000001803F9DB0-0x00000001803F9DC0
		protected void AddHandlers(); // 0x00000001803F9A70-0x00000001803F9CF0
		protected void RemoveHandlers(); // 0x00000001803F9E90-0x00000001803FA160
		private void SteamVR_Behaviour_Boolean_OnStateUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource); // 0x00000001803FA270-0x00000001803FA2F0
		private void SteamVR_Behaviour_Boolean_OnStateDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource); // 0x00000001803FA1F0-0x00000001803FA270
		private void SteamVR_Behaviour_Boolean_OnState(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource); // 0x00000001803FA2F0-0x00000001803FA370
		private void SteamVR_Behaviour_Boolean_OnUpdate(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState); // 0x00000001803FA370-0x00000001803FA400
		private void SteamVR_Behaviour_Boolean_OnChange(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState); // 0x00000001803FA160-0x00000001803FA1F0
		public string GetLocalizedName(params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts); // 0x00000001803F9CF0-0x00000001803F9DB0
	}
}
