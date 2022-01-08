/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Action_Boolean_Source : SteamVR_Action_In_Source, ISteamVR_Action_Boolean // TypeDefIndex: 7172
	{
		// Fields
		protected static uint actionData_size; // 0x00
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Boolean.StateDownHandler onStateDown; // 0x158
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Boolean.StateUpHandler onStateUp; // 0x160
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Boolean.StateHandler onState; // 0x168
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Boolean.ActiveChangeHandler onActiveChange; // 0x170
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Boolean.ActiveChangeHandler onActiveBindingChange; // 0x178
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Boolean.ChangeHandler onChange; // 0x180
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Boolean.UpdateHandler onUpdate; // 0x188
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastActive_k__BackingField; // 0x190
		protected InputDigitalActionData_t actionData; // 0x198
		protected InputDigitalActionData_t lastActionData; // 0x1B0
		protected SteamVR_Action_Boolean booleanAction; // 0x1C8
	
		// Properties
		public bool state { get; } // 0x00000001803E43B0-0x00000001803E43E0 
		public bool stateDown { get; } // 0x00000001803E4330-0x00000001803E4370 
		public bool stateUp { get; } // 0x00000001803E4370-0x00000001803E43B0 
		public override bool changed { get; protected set; } // 0x00000001803E4280-0x00000001803E42B0 0x0000000180265310-0x0000000180265320
		public bool lastState { get; } // 0x00000001803E4320-0x00000001803E4330 
		public bool lastStateDown { get; } // 0x00000001803E42E0-0x00000001803E4300 
		public bool lastStateUp { get; } // 0x00000001803E4300-0x00000001803E4320 
		public override bool lastChanged { get; protected set; } // 0x00000001803E42D0-0x00000001803E42E0 0x0000000180265310-0x0000000180265320
		public override ulong activeOrigin { get; } // 0x00000001803E41E0-0x00000001803E4220 
		public override ulong lastActiveOrigin { get; } // 0x00000001803E42C0-0x00000001803E42D0 
		public override bool active { get; } // 0x00000001803E4220-0x00000001803E4280 
		public override bool activeBinding { get; } // 0x00000001803E41D0-0x00000001803E41E0 
		public override bool lastActive { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803133B0-0x00000001803133C0 0x00000001803139E0-0x00000001803139F0
		public override bool lastActiveBinding { get; } // 0x00000001803E42B0-0x00000001803E42C0 
	
		// Events
		public event SteamVR_Action_Boolean.StateDownHandler onStateDown {
			add; // 0x00000001803E3F50-0x00000001803E3FF0
			remove; // 0x00000001803E45C0-0x00000001803E4660
		}
		public event SteamVR_Action_Boolean.StateUpHandler onStateUp {
			add; // 0x00000001803E3FF0-0x00000001803E4090
			remove; // 0x00000001803E4660-0x00000001803E4700
		}
		public event SteamVR_Action_Boolean.StateHandler onState {
			add; // 0x00000001803E4090-0x00000001803E4130
			remove; // 0x00000001803E4700-0x00000001803E47A0
		}
		public event SteamVR_Action_Boolean.ActiveChangeHandler onActiveChange {
			add; // 0x00000001803E3E10-0x00000001803E3EB0
			remove; // 0x00000001803E4480-0x00000001803E4520
		}
		public event SteamVR_Action_Boolean.ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803E3D70-0x00000001803E3E10
			remove; // 0x00000001803E43E0-0x00000001803E4480
		}
		public event SteamVR_Action_Boolean.ChangeHandler onChange {
			add; // 0x00000001803E3EB0-0x00000001803E3F50
			remove; // 0x00000001803E4520-0x00000001803E45C0
		}
		public event SteamVR_Action_Boolean.UpdateHandler onUpdate {
			add; // 0x00000001803E4130-0x00000001803E41D0
			remove; // 0x00000001803E47A0-0x00000001803E4840
		}
	
		// Constructors
		public SteamVR_Action_Boolean_Source(); // 0x00000001803E3D10-0x00000001803E3D70
		static SteamVR_Action_Boolean_Source(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public override void Preinitialize(SteamVR_Action wrappingAction, SteamVR_Input_Sources forInputSource); // 0x00000001803E32F0-0x00000001803E33A0
		public override void Initialize(); // 0x00000001803E3190-0x00000001803E32B0
		public void RemoveAllListeners(); // 0x00000001803E33A0-0x00000001803E3590
		public override void UpdateValue(); // 0x00000001803E3590-0x00000001803E3D10
	}
}
