/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_ExternalCamera_LegacyManager // TypeDefIndex: 7349
	{
		// Fields
		public static int cameraIndex; // 0x00
		private static SteamVR_Events.Action newPosesAction; // 0x08
	
		// Properties
		public static bool hasCamera { get; } // 0x0000000180323BA0-0x0000000180323C00 
	
		// Constructors
		public SteamVR_ExternalCamera_LegacyManager(); // 0x00000001802650F0-0x0000000180265100
		static SteamVR_ExternalCamera_LegacyManager(); // 0x0000000180323B50-0x0000000180323BA0
	
		// Methods
		public static void SubscribeToNewPoses(); // 0x0000000180323950-0x0000000180323B50
		private static void OnNewPoses(TrackedDevicePose_t[] poses); // 0x0000000180323800-0x0000000180323950
	}
}
