/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public static class SteamVR_Input_Source // TypeDefIndex: 7311
	{
		// Fields
		public static int numSources; // 0x00
		private static ulong[] inputSourceHandlesBySource; // 0x08
		private static Dictionary<ulong, SteamVR_Input_Sources> inputSourceSourcesByHandle; // 0x10
		private static System.Type enumType; // 0x18
		private static System.Type descriptionType; // 0x20
		private static SteamVR_Input_Sources[] allSources; // 0x28
	
		// Constructors
		static SteamVR_Input_Source(); // 0x00000001803333D0-0x0000000180333540
	
		// Methods
		public static ulong GetHandle(SteamVR_Input_Sources inputSource); // 0x0000000180332B20-0x0000000180332BE0
		public static SteamVR_Input_Sources GetSource(ulong handle); // 0x0000000180332D90-0x0000000180332E80
		public static SteamVR_Input_Sources[] GetAllSources(); // 0x0000000180332990-0x0000000180332B20
		private static string GetPath(string inputSourceEnumName); // 0x0000000180332BE0-0x0000000180332D90
		public static void Initialize(); // 0x0000000180332E80-0x00000001803333D0
	}
}
