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
	public class SteamVR_Action_Vector2_Source : SteamVR_Action_In_Source, ISteamVR_Action_Vector2 // TypeDefIndex: 7225
	{
		// Fields
		protected static uint actionData_size; // 0x00
		public float changeTolerance; // 0x158
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector2.AxisHandler onAxis; // 0x160
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector2.ActiveChangeHandler onActiveChange; // 0x168
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector2.ActiveChangeHandler onActiveBindingChange; // 0x170
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector2.ChangeHandler onChange; // 0x178
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vector2.UpdateHandler onUpdate; // 0x180
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector2 _axis_k__BackingField; // 0x188
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector2 _lastAxis_k__BackingField; // 0x190
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector2 _delta_k__BackingField; // 0x198
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector2 _lastDelta_k__BackingField; // 0x1A0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _changed_k__BackingField; // 0x1A8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastChanged_k__BackingField; // 0x1A9
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastActive_k__BackingField; // 0x1AA
		protected InputAnalogActionData_t actionData; // 0x1B0
		protected InputAnalogActionData_t lastActionData; // 0x1E0
		protected SteamVR_Action_Vector2 vector2Action; // 0x210
	
		// Properties
		public Vector2 axis { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F5710-0x00000001803F5730 0x00000001803F5B00-0x00000001803F5B30
		public Vector2 lastAxis { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F5790-0x00000001803F57B0 0x00000001803F5B80-0x00000001803F5BB0
		public Vector2 delta { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F5740-0x00000001803F5760 0x00000001803F5B40-0x00000001803F5B70
		public Vector2 lastDelta { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F57C0-0x00000001803F57E0 0x00000001803F5BC0-0x00000001803F5BF0
		public override bool changed { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F5730-0x00000001803F5740 0x00000001803F5B30-0x00000001803F5B40
		public override bool lastChanged { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F57B0-0x00000001803F57C0 0x00000001803F5BB0-0x00000001803F5BC0
		public override ulong activeOrigin { get; } // 0x00000001803F56D0-0x00000001803F5710 
		public override ulong lastActiveOrigin { get; } // 0x00000001803F5770-0x00000001803F5780 
		public override bool active { get; } // 0x00000001803E4220-0x00000001803E4280 
		public override bool activeBinding { get; } // 0x00000001803E42B0-0x00000001803E42C0 
		public override bool lastActive { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F5780-0x00000001803F5790 0x00000001803F5B70-0x00000001803F5B80
		public override bool lastActiveBinding { get; } // 0x00000001803F5760-0x00000001803F5770 
	
		// Events
		public event SteamVR_Action_Vector2.AxisHandler onAxis {
			add; // 0x00000001803F54F0-0x00000001803F5590
			remove; // 0x00000001803F5920-0x00000001803F59C0
		}
		public event SteamVR_Action_Vector2.ActiveChangeHandler onActiveChange {
			add; // 0x00000001803F5450-0x00000001803F54F0
			remove; // 0x00000001803F5880-0x00000001803F5920
		}
		public event SteamVR_Action_Vector2.ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803F53B0-0x00000001803F5450
			remove; // 0x00000001803F57E0-0x00000001803F5880
		}
		public event SteamVR_Action_Vector2.ChangeHandler onChange {
			add; // 0x00000001803F5590-0x00000001803F5630
			remove; // 0x00000001803F59C0-0x00000001803F5A60
		}
		public event SteamVR_Action_Vector2.UpdateHandler onUpdate {
			add; // 0x00000001803F5630-0x00000001803F56D0
			remove; // 0x00000001803F5A60-0x00000001803F5B00
		}
	
		// Constructors
		public SteamVR_Action_Vector2_Source(); // 0x00000001803F5330-0x00000001803F53B0
		static SteamVR_Action_Vector2_Source(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public override void Preinitialize(SteamVR_Action wrappingAction, SteamVR_Input_Sources forInputSource); // 0x00000001803F4860-0x00000001803F4910
		public override void Initialize(); // 0x00000001803F4700-0x00000001803F4820
		public void RemoveAllListeners(); // 0x00000001803F4910-0x00000001803F4B00
		public override void UpdateValue(); // 0x00000001803F4B00-0x00000001803F5330
	}
}
