/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Action_Single_Source : SteamVR_Action_In_Source, ISteamVR_Action_Single // TypeDefIndex: 7200
	{
		// Fields
		protected static uint actionData_size; // 0x00
		public float changeTolerance; // 0x158
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Single.AxisHandler onAxis; // 0x160
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Single.ActiveChangeHandler onActiveChange; // 0x168
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Single.ActiveChangeHandler onActiveBindingChange; // 0x170
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Single.ChangeHandler onChange; // 0x178
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Single.UpdateHandler onUpdate; // 0x180
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _changed_k__BackingField; // 0x188
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastChanged_k__BackingField; // 0x189
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _lastActive_k__BackingField; // 0x18A
		protected InputAnalogActionData_t actionData; // 0x190
		protected InputAnalogActionData_t lastActionData; // 0x1C0
		protected SteamVR_Action_Single singleAction; // 0x1F0
	
		// Properties
		public float axis { get; } // 0x00000001803EB110-0x00000001803EB150 
		public float lastAxis { get; } // 0x00000001803EB1C0-0x00000001803EB200 
		public float delta { get; } // 0x00000001803EB160-0x00000001803EB1A0 
		public float lastDelta { get; } // 0x00000001803EB210-0x00000001803EB250 
		public override bool changed { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803EB150-0x00000001803EB160 0x00000001803EB570-0x00000001803EB580
		public override bool lastChanged { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803EB200-0x00000001803EB210 0x00000001803EB590-0x00000001803EB5A0
		public override ulong activeOrigin { get; } // 0x00000001803EB0D0-0x00000001803EB110 
		public override ulong lastActiveOrigin { get; } // 0x00000001803EB1A0-0x00000001803EB1B0 
		public override bool active { get; } // 0x00000001803E4220-0x00000001803E4280 
		public override bool activeBinding { get; } // 0x00000001803133B0-0x00000001803133C0 
		public override bool lastActive { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001803EB1B0-0x00000001803EB1C0 0x00000001803EB580-0x00000001803EB590
		public override bool lastActiveBinding { get; } // 0x00000001803E4320-0x00000001803E4330 
	
		// Events
		public event SteamVR_Action_Single.AxisHandler onAxis {
			add; // 0x00000001803EAEF0-0x00000001803EAF90
			remove; // 0x00000001803EB390-0x00000001803EB430
		}
		public event SteamVR_Action_Single.ActiveChangeHandler onActiveChange {
			add; // 0x00000001803EAE50-0x00000001803EAEF0
			remove; // 0x00000001803EB2F0-0x00000001803EB390
		}
		public event SteamVR_Action_Single.ActiveChangeHandler onActiveBindingChange {
			add; // 0x00000001803EADB0-0x00000001803EAE50
			remove; // 0x00000001803EB250-0x00000001803EB2F0
		}
		public event SteamVR_Action_Single.ChangeHandler onChange {
			add; // 0x00000001803EAF90-0x00000001803EB030
			remove; // 0x00000001803EB430-0x00000001803EB4D0
		}
		public event SteamVR_Action_Single.UpdateHandler onUpdate {
			add; // 0x00000001803EB030-0x00000001803EB0D0
			remove; // 0x00000001803EB4D0-0x00000001803EB570
		}
	
		// Constructors
		public SteamVR_Action_Single_Source(); // 0x00000001803EAD30-0x00000001803EADB0
		static SteamVR_Action_Single_Source(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public override void Preinitialize(SteamVR_Action wrappingAction, SteamVR_Input_Sources forInputSource); // 0x00000001803EA220-0x00000001803EA2D0
		public override void Initialize(); // 0x00000001803EA0C0-0x00000001803EA1E0
		public void RemoveAllListeners(); // 0x00000001803EA2D0-0x00000001803EA4C0
		public override void UpdateValue(); // 0x00000001803EA4C0-0x00000001803EAD30
	}
}
