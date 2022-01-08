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
	public class SteamVR_Action_Vector3_Source : SteamVR_Action_In_Source, ISteamVR_Action_Vector3 // TypeDefIndex: 7233
	{
		// Fields
		protected static uint actionData_size; // 0x00
		public float changeTolerance; // 0x158
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector3.AxisHandler onAxis; // 0x160
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector3.ActiveChangeHandler onActiveChange; // 0x168
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector3.ActiveChangeHandler onActiveBindingChange; // 0x170
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector3.ChangeHandler onChange; // 0x178
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector3.UpdateHandler onUpdate; // 0x180
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _axis_k__BackingField; // 0x188
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _lastAxis_k__BackingField; // 0x194
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _delta_k__BackingField; // 0x1A0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _lastDelta_k__BackingField; // 0x1AC
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _changed_k__BackingField; // 0x1B8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastChanged_k__BackingField; // 0x1B9
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastActive_k__BackingField; // 0x1BA
		protected InputAnalogActionData_t actionData; // 0x1C0
		protected InputAnalogActionData_t lastActionData; // 0x1F0
		protected SteamVR_Action_Vector3 vector3Action; // 0x220
	
		// Properties
		public Vector3 axis { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F7A40-0x00000001803F7A60 0x00000001803F7E20-0x00000001803F7E40
		public Vector3 lastAxis { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F7AB0-0x00000001803F7AD0 0x00000001803F7E70-0x00000001803F7E90
		public Vector3 delta { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F7A60-0x00000001803F7A80 0x00000001803F7E40-0x00000001803F7E60
		public Vector3 lastDelta { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F7AE0-0x00000001803F7B00 0x00000001803F7EA0-0x00000001803F7EC0
		public override bool changed { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001802887D0-0x00000001802887E0 0x0000000180313A00-0x0000000180313A10
		public override bool lastChanged { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F7AD0-0x00000001803F7AE0 0x00000001803F7E90-0x00000001803F7EA0
		public override ulong activeOrigin { get; } // 0x00000001803F7A00-0x00000001803F7A40 
		public override ulong lastActiveOrigin { get; } // 0x00000001803F7A90-0x00000001803F7AA0 
		public override bool active { get; } // 0x00000001803E4220-0x00000001803E4280 
		public override bool activeBinding { get; } // 0x00000001803E4320-0x00000001803E4330 
		public override bool lastActive { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F7AA0-0x00000001803F7AB0 0x00000001803F7E60-0x00000001803F7E70
		public override bool lastActiveBinding { get; } // 0x00000001803F7A80-0x00000001803F7A90 
	
		// Events
		public event SteamVR_Action_Vector3.AxisHandler onAxis {
			add; // 0x00000001803F7820-0x00000001803F78C0
			remove; // 0x00000001803F7C40-0x00000001803F7CE0
		}
		public event SteamVR_Action_Vector3.ActiveChangeHandler onActiveChange {
			add; // 0x00000001803F7780-0x00000001803F7820
			remove; // 0x00000001803F7BA0-0x00000001803F7C40
		}
		public event SteamVR_Action_Vector3.ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803F76E0-0x00000001803F7780
			remove; // 0x00000001803F7B00-0x00000001803F7BA0
		}
		public event SteamVR_Action_Vector3.ChangeHandler onChange {
			add; // 0x00000001803F78C0-0x00000001803F7960
			remove; // 0x00000001803F7CE0-0x00000001803F7D80
		}
		public event SteamVR_Action_Vector3.UpdateHandler onUpdate {
			add; // 0x00000001803F7960-0x00000001803F7A00
			remove; // 0x00000001803F7D80-0x00000001803F7E20
		}
	
		// Constructors
		public SteamVR_Action_Vector3_Source(); // 0x00000001803F7660-0x00000001803F76E0
		static SteamVR_Action_Vector3_Source(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public override void Preinitialize(SteamVR_Action wrappingAction, SteamVR_Input_Sources forInputSource); // 0x00000001803F6B60-0x00000001803F6C10
		public override void Initialize(); // 0x00000001803F6A00-0x00000001803F6B20
		public void RemoveAllListeners(); // 0x00000001803F6C10-0x00000001803F6E00
		public override void UpdateValue(); // 0x00000001803F6E00-0x00000001803F7660
	}
}
