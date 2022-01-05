/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: SteamVR_Actions.dll - Assembly: SteamVR_Actions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8125-8127

namespace Valve.VR
{
	public class SteamVR_Actions // TypeDefIndex: 8127
	{
		// Fields
		private static SteamVR_Input_ActionSet_main p_main; // 0x00
		private static SteamVR_Action_Vector2 p_main_Move; // 0x08
		private static SteamVR_Action_Boolean p_main_EnableMoving; // 0x10
		private static SteamVR_Action_Boolean p_main_Grab; // 0x18
		private static SteamVR_Action_Boolean p_main_Bond; // 0x20
		private static SteamVR_Action_Single p_main_Squeeze; // 0x28
		private static SteamVR_Action_Pose p_main_Pose; // 0x30
		private static SteamVR_Action_Boolean p_main_Menu; // 0x38
		private static SteamVR_Action_Vibration p_main_Haptic; // 0x40
	
		// Properties
		public static SteamVR_Input_ActionSet_main main { get; } // 0x00000001808F49A0-0x00000001808F4A00 
		public static SteamVR_Action_Vector2 main_Move { get; } // 0x00000001808F4880-0x00000001808F48E0 
		public static SteamVR_Action_Boolean main_EnableMoving { get; } // 0x00000001808F4700-0x00000001808F4760 
		public static SteamVR_Action_Boolean main_Grab { get; } // 0x00000001808F4760-0x00000001808F47C0 
		public static SteamVR_Action_Boolean main_Bond { get; } // 0x00000001808F46A0-0x00000001808F4700 
		public static SteamVR_Action_Single main_Squeeze { get; } // 0x00000001808F4940-0x00000001808F49A0 
		public static SteamVR_Action_Pose main_Pose { get; } // 0x00000001808F48E0-0x00000001808F4940 
		public static SteamVR_Action_Boolean main_Menu { get; } // 0x00000001808F4820-0x00000001808F4880 
		public static SteamVR_Action_Vibration main_Haptic { get; } // 0x00000001808F47C0-0x00000001808F4820 
	
		// Constructors
		public SteamVR_Actions(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		private static void StartPreInitActionSets(); // 0x00000001808F4530-0x00000001808F46A0
		private static void InitializeActionArrays(); // 0x00000001808F2C00-0x00000001808F4130
		private static void PreInitActions(); // 0x00000001808F4130-0x00000001808F4350
		public static void PreInitialize(); // 0x00000001808F4350-0x00000001808F4530
	}
}
