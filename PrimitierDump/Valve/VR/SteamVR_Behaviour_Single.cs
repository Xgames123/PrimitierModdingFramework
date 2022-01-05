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
	public class SteamVR_Behaviour_Single : MonoBehaviour // TypeDefIndex: 7260
	{
		// Fields
		public SteamVR_Action_Single singleAction; // 0x18
		[Tooltip] // 0x0000000180023A00-0x0000000180023A30
		public SteamVR_Input_Sources inputSource; // 0x20
		[Tooltip] // 0x0000000180023A90-0x0000000180023AC0
		public SteamVR_Behaviour_SingleEvent onChange; // 0x28
		[Tooltip] // 0x0000000180023AC0-0x0000000180023AF0
		public SteamVR_Behaviour_SingleEvent onUpdate; // 0x30
		[Tooltip] // 0x0000000180023AF0-0x0000000180023B20
		public SteamVR_Behaviour_SingleEvent onAxis; // 0x38
		public ChangeHandler onChangeEvent; // 0x40
		public UpdateHandler onUpdateEvent; // 0x48
		public AxisHandler onAxisEvent; // 0x50
	
		// Properties
		public bool isActive { get; } // 0x000000018031F3C0-0x000000018031F3F0 
	
		// Nested types
		public delegate void AxisHandler(SteamVR_Behaviour_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // TypeDefIndex: 7257; 0x000000018028B5D0-0x000000018028B890
	
		public delegate void ChangeHandler(SteamVR_Behaviour_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // TypeDefIndex: 7258; 0x000000018028B5D0-0x000000018028B890
	
		public delegate void UpdateHandler(SteamVR_Behaviour_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // TypeDefIndex: 7259; 0x000000018028B5D0-0x000000018028B890
	
		// Constructors
		public SteamVR_Behaviour_Single(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		protected virtual void OnEnable(); // 0x00000001803FD020-0x00000001803FD0F0
		protected virtual void OnDisable(); // 0x00000001803FD010-0x00000001803FD020
		protected void AddHandlers(); // 0x00000001803FCDC0-0x00000001803FCF50
		protected void RemoveHandlers(); // 0x00000001803FD0F0-0x00000001803FD2D0
		private void SteamVR_Behaviour_Single_OnUpdate(SteamVR_Action_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // 0x00000001803FD430-0x00000001803FD4E0
		private void SteamVR_Behaviour_Single_OnChange(SteamVR_Action_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // 0x00000001803FD380-0x00000001803FD430
		private void SteamVR_Behaviour_Single_OnAxis(SteamVR_Action_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta); // 0x00000001803FD2D0-0x00000001803FD380
		public string GetLocalizedName(params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts); // 0x00000001803FCF50-0x00000001803FD010
	}
}
