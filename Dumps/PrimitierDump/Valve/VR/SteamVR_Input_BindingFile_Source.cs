/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	[Serializable]
	public class SteamVR_Input_BindingFile_Source // TypeDefIndex: 7307
	{
		// Fields
		public string path; // 0x10
		public string mode; // 0x18
		public SteamVR_Input_BindingFile_Source_Input_StringDictionary parameters; // 0x20
		public SteamVR_Input_BindingFile_Source_Input inputs; // 0x28
		protected const string outputKeyName = "output"; // Metadata: 0x003A5580
	
		// Constructors
		public SteamVR_Input_BindingFile_Source(); // 0x000000018032D2F0-0x000000018032D3C0
	
		// Methods
		public string GetOutput(); // 0x000000018032CA90-0x000000018032CD90
		public override bool Equals(object obj); // 0x000000018032C8E0-0x000000018032CA90
		public override int GetHashCode(); // 0x0000000180328F60-0x0000000180328F70
	}
}
