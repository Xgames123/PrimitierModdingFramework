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
	public class SteamVR_Behaviour_Vector2 : MonoBehaviour // TypeDefIndex: 7275
	{
		// Fields
		public SteamVR_Action_Vector2 vector2Action; // 0x18
		[Tooltip] // 0x0000000180023A00-0x0000000180023A30
		public SteamVR_Input_Sources inputSource; // 0x20
		[Tooltip] // 0x0000000180023A90-0x0000000180023AC0
		public SteamVR_Behaviour_Vector2Event onChange; // 0x28
		[Tooltip] // 0x0000000180023AC0-0x0000000180023AF0
		public SteamVR_Behaviour_Vector2Event onUpdate; // 0x30
		[Tooltip] // 0x0000000180023AF0-0x0000000180023B20
		public SteamVR_Behaviour_Vector2Event onAxis; // 0x38
		public ChangeHandler onChangeEvent; // 0x40
		public UpdateHandler onUpdateEvent; // 0x48
		public AxisHandler onAxisEvent; // 0x50
	
		// Properties
		public bool isActive { get; } // 0x000000018031F3C0-0x000000018031F3F0 
	
		// Nested types
		public delegate void AxisHandler(SteamVR_Behaviour_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 newAxis, Vector2 newDelta); // TypeDefIndex: 7272; 0x000000018028B890-0x000000018028BB70
	
		public delegate void ChangeHandler(SteamVR_Behaviour_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 newAxis, Vector2 newDelta); // TypeDefIndex: 7273; 0x000000018028B890-0x000000018028BB70
	
		public delegate void UpdateHandler(SteamVR_Behaviour_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 newAxis, Vector2 newDelta); // TypeDefIndex: 7274; 0x000000018028B890-0x000000018028BB70
	
		// Constructors
		public SteamVR_Behaviour_Vector2(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018031EF00-0x000000018031EFD0
		protected virtual void OnDisable(); // 0x000000018031EEF0-0x000000018031EF00
		protected void AddHandlers(); // 0x000000018031ECA0-0x000000018031EE30
		protected void RemoveHandlers(); // 0x000000018031EFD0-0x000000018031F1B0
		private void SteamVR_Behaviour_Vector2_OnUpdate(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 newAxis, Vector2 newDelta); // 0x000000018031F310-0x000000018031F3C0
		private void SteamVR_Behaviour_Vector2_OnChange(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 newAxis, Vector2 newDelta); // 0x000000018031F260-0x000000018031F310
		private void SteamVR_Behaviour_Vector2_OnAxis(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 newAxis, Vector2 newDelta); // 0x000000018031F1B0-0x000000018031F260
		public string GetLocalizedName(params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts); // 0x000000018031EE30-0x000000018031EEF0
	}
}
