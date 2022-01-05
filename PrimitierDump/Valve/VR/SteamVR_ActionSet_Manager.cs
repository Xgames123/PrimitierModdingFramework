/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public static class SteamVR_ActionSet_Manager // TypeDefIndex: 7163
	{
		// Fields
		public static VRActiveActionSet_t[] rawActiveActionSetArray; // 0x00
		[NonSerialized]
		private static uint activeActionSetSize; // 0x08
		private static bool changed; // 0x0C
		private static int lastFrameUpdated; // 0x10
		public static string debugActiveSetListText; // 0x18
		public static bool updateDebugTextInBuilds; // 0x20
	
		// Constructors
		static SteamVR_ActionSet_Manager(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public static void Initialize(); // 0x00000001803E16D0-0x00000001803E17C0
		public static void DisableAllActionSets(); // 0x00000001803E1450-0x00000001803E15D0
		public static void UpdateActionStates(bool force = false /* Metadata: 0x003A52B9 */); // 0x00000001803E1BD0-0x00000001803E1E90
		public static void SetChanged(); // 0x00000001803E17C0-0x00000001803E1820
		private static void UpdateActionSetsArray(); // 0x00000001803E1820-0x00000001803E1BD0
		public static SteamVR_ActionSet GetSetFromHandle(ulong handle); // 0x00000001803E15D0-0x00000001803E16D0
		private static void UpdateDebugText(); // 0x00000001803E1E90-0x00000001803E2120
	}
}
