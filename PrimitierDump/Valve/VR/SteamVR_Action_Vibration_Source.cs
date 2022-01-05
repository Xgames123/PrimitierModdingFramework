/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Action_Vibration_Source : SteamVR_Action_Out_Source // TypeDefIndex: 7239
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vibration.ActiveChangeHandler onActiveChange; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vibration.ActiveChangeHandler onActiveBindingChange; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Vibration.ExecuteHandler onExecute; // 0x38
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastActive_k__BackingField; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _timeLastExecuted_k__BackingField; // 0x44
		protected SteamVR_Action_Vibration vibrationAction; // 0x48
	
		// Properties
		public override bool active { get; } // 0x00000001803E4220-0x00000001803E4280 
		public override bool activeBinding { get; } // 0x00000001802942D0-0x00000001802942E0 
		public override bool lastActive { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001802B7950-0x00000001802B7960 0x00000001803F9470-0x00000001803F9480
		public override bool lastActiveBinding { get; } // 0x00000001802942D0-0x00000001802942E0 
		public float timeLastExecuted { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803F9280-0x00000001803F9290 0x00000001803F9480-0x00000001803F9490
	
		// Events
		public event SteamVR_Action_Vibration.ActiveChangeHandler onActiveChange {
			add; // 0x00000001803F9140-0x00000001803F91E0
			remove; // 0x00000001803F9330-0x00000001803F93D0
		}
		public event SteamVR_Action_Vibration.ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803F90A0-0x00000001803F9140
			remove; // 0x00000001803F9290-0x00000001803F9330
		}
		public event SteamVR_Action_Vibration.ExecuteHandler onExecute {
			add; // 0x00000001803F91E0-0x00000001803F9280
			remove; // 0x00000001803F93D0-0x00000001803F9470
		}
	
		// Constructors
		public SteamVR_Action_Vibration_Source(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public override void Initialize(); // 0x00000001803F8EE0-0x00000001803F8F60
		public override void Preinitialize(SteamVR_Action wrappingAction, SteamVR_Input_Sources forInputSource); // 0x00000001803F9000-0x00000001803F90A0
		public void Execute(float secondsFromNow, float durationSeconds, float frequency, float amplitude); // 0x00000001803F8A00-0x00000001803F8EE0
	}
}
