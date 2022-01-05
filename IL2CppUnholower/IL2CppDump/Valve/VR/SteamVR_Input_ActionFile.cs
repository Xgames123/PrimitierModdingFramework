/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Valve.Newtonsoft.Json;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	[Serializable]
	public class SteamVR_Input_ActionFile // TypeDefIndex: 7284
	{
		// Fields
		public List<SteamVR_Input_ActionFile_Action> actions; // 0x10
		public List<SteamVR_Input_ActionFile_ActionSet> action_sets; // 0x18
		public List<SteamVR_Input_ActionFile_DefaultBinding> default_bindings; // 0x20
		public List<Dictionary<string, string>> localization; // 0x28
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public string filePath; // 0x30
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public List<SteamVR_Input_ActionFile_LocalizationItem> localizationHelperList; // 0x38
		private const string findString_appKeyStart = "\"app_key\""; // Metadata: 0x003A54C3
		private const string findString_appKeyEnd = "\","; // Metadata: 0x003A54D0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 7283
		{
			// Fields
			public SteamVR_Input_ActionFile_ActionSet actionset; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _InitializeHelperLists_b__0(SteamVR_Input_ActionFile_Action action); // 0x000000018029E3C0-0x000000018029E490
			internal bool _InitializeHelperLists_b__1(SteamVR_Input_ActionFile_Action action); // 0x000000018029E490-0x000000018029E560
			internal bool _InitializeHelperLists_b__2(SteamVR_Input_ActionFile_Action action); // 0x000000018029E560-0x000000018029E5B0
		}
	
		// Constructors
		public SteamVR_Input_ActionFile(); // 0x000000018032BF50-0x000000018032C0B0
	
		// Methods
		public void InitializeHelperLists(); // 0x000000018032AEC0-0x000000018032B350
		public void SaveHelperLists(); // 0x000000018032B810-0x000000018032BE30
		public static string GetShortName(string name); // 0x000000018032AE30-0x000000018032AEC0
		public static string GetCodeFriendlyName(string name); // 0x000000018032A990-0x000000018032AB20
		public string[] GetFilesToCopy(bool throwErrors = false /* Metadata: 0x003A54C2 */); // 0x000000018032AB20-0x000000018032AE30
		public void CopyFilesToPath(string toPath, bool overwrite); // 0x000000018032A690-0x000000018032A920
		private static void RemoveAppKey(string newFilePath); // 0x000000018032B6F0-0x000000018032B810
		public static SteamVR_Input_ActionFile Open(string path); // 0x000000018032B640-0x000000018032B6F0
		public void Save(string path); // 0x000000018032BE30-0x000000018032BF50
	}
}
