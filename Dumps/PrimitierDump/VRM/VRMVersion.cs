/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public static class VRMVersion // TypeDefIndex: 8026
	{
		// Fields
		public const int MAJOR = 0; // Metadata: 0x003A603A
		public const int MINOR = 73; // Metadata: 0x003A603E
		public const int PATCH = 0; // Metadata: 0x003A6042
		public const string VERSION = "0.73.0"; // Metadata: 0x003A6046
		private static readonly Regex VersionSpec; // 0x00
		public const string VRM_VERSION = "UniVRM-0.73.0"; // Metadata: 0x003A6050
		public const string MENU = "VRM0"; // Metadata: 0x003A6061
	
		// Nested types
		public struct Version // TypeDefIndex: 8025
		{
			// Fields
			public int Major; // 0x00
			public int Minor; // 0x04
			public int Patch; // 0x08
			public string Pre; // 0x10
		}
	
		// Constructors
		static VRMVersion(); // 0x00000001805556E0-0x0000000180555760
	
		// Methods
		public static bool IsNewer(string version); // 0x00000001805551F0-0x00000001805553C0
		public static bool IsNewer(string newer, string older); // 0x00000001805550E0-0x00000001805551F0
		public static bool ParseVersion(string version, out Version v); // 0x00000001805553C0-0x00000001805556E0
	}
}
