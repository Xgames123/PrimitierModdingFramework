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
	public class SteamVR_Behaviour_Vector3 : MonoBehaviour // TypeDefIndex: 7279
	{
		// Fields
		public SteamVR_Action_Vector3 vector3Action; // 0x18
		[Tooltip] // 0x0000000180023A00-0x0000000180023A30
		public SteamVR_Input_Sources inputSource; // 0x20
		[Tooltip] // 0x0000000180023A90-0x0000000180023AC0
		public SteamVR_Behaviour_Vector3Event onChange; // 0x28
		[Tooltip] // 0x0000000180023AC0-0x0000000180023AF0
		public SteamVR_Behaviour_Vector3Event onUpdate; // 0x30
		[Tooltip] // 0x0000000180023AF0-0x0000000180023B20
		public SteamVR_Behaviour_Vector3Event onAxis; // 0x38
		public ChangeHandler onChangeEvent; // 0x40
		public UpdateHandler onUpdateEvent; // 0x48
		public AxisHandler onAxisEvent; // 0x50
	
		// Properties
		public bool isActive { get; } // 0x000000018031F3C0-0x000000018031F3F0 
	
		// Nested types
		public delegate void AxisHandler(SteamVR_Behaviour_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 newAxis, Vector3 newDelta); // TypeDefIndex: 7276; 0x000000018028BB70-0x000000018028C120
	
		public delegate void ChangeHandler(SteamVR_Behaviour_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 newAxis, Vector3 newDelta); // TypeDefIndex: 7277; 0x000000018028BB70-0x000000018028C120
	
		public delegate void UpdateHandler(SteamVR_Behaviour_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 newAxis, Vector3 newDelta); // TypeDefIndex: 7278; 0x000000018028BB70-0x000000018028C120
	
		// Constructors
		public SteamVR_Behaviour_Vector3(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018031F690-0x000000018031F760
		protected virtual void OnDisable(); // 0x000000018031F680-0x000000018031F690
		protected void AddHandlers(); // 0x000000018031F430-0x000000018031F5C0
		protected void RemoveHandlers(); // 0x000000018031F760-0x000000018031F940
		private void SteamVR_Behaviour_Vector3_OnUpdate(SteamVR_Action_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 newAxis, Vector3 newDelta); // 0x000000018031FB40-0x000000018031FC40
		private void SteamVR_Behaviour_Vector3_OnChange(SteamVR_Action_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 newAxis, Vector3 newDelta); // 0x000000018031FA40-0x000000018031FB40
		private void SteamVR_Behaviour_Vector3_OnAxis(SteamVR_Action_Vector3 fromAction, SteamVR_Input_Sources fromSource, Vector3 newAxis, Vector3 newDelta); // 0x000000018031F940-0x000000018031FA40
		public string GetLocalizedName(params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts); // 0x000000018031F5C0-0x000000018031F680
	}
}
