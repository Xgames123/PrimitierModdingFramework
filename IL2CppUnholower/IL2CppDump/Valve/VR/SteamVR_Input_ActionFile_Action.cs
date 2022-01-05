/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Valve.Newtonsoft.Json;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	[Serializable]
	public class SteamVR_Input_ActionFile_Action // TypeDefIndex: 7289
	{
		// Fields
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		private static string[] _requirementValues; // 0x00
		public string name; // 0x10
		public string type; // 0x18
		public string scope; // 0x20
		public string skeleton; // 0x28
		public string requirement; // 0x30
		private const string nameTemplate = "/actions/{0}/{1}/{2}"; // Metadata: 0x003A5533
		protected const string prefix = "/actions/"; // Metadata: 0x003A554B
	
		// Properties
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public static string[] requirementValues { get; } // 0x000000018032A510-0x000000018032A600 
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public SteamVR_Input_ActionFile_Action_Requirements requirementEnum { get; set; } // 0x000000018032A460-0x000000018032A510 0x000000018032A600-0x000000018032A690
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public string codeFriendlyName { get; } // 0x0000000180329450-0x0000000180329460 
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public string shortName { get; } // 0x000000018032A2C0-0x000000018032A2D0 
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public string path { get; } // 0x000000018032A400-0x000000018032A460 
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public SteamVR_ActionDirections direction { get; } // 0x000000018032A370-0x000000018032A400 
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public string actionSet { get; } // 0x000000018032A2D0-0x000000018032A370 
	
		// Constructors
		public SteamVR_Input_ActionFile_Action(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public SteamVR_Input_ActionFile_Action GetCopy(); // 0x000000018032A0D0-0x000000018032A160
		public static string CreateNewName(string actionSet, string direction); // 0x0000000180329DD0-0x0000000180329E40
		public static string CreateNewName(string actionSet, SteamVR_ActionDirections direction, string actionName); // 0x0000000180329D00-0x0000000180329DD0
		public static SteamVR_Input_ActionFile_Action CreateNew(string actionSet, SteamVR_ActionDirections direction, string actionType); // 0x0000000180329E40-0x0000000180329F70
		public void SetNewActionSet(string newSetName); // 0x000000018032A160-0x000000018032A2C0
		public override string ToString(); // 0x000000018032A2C0-0x000000018032A2D0
		public override bool Equals(object obj); // 0x0000000180329F70-0x000000018032A0D0
		public override int GetHashCode(); // 0x0000000180328F60-0x0000000180328F70
	}
}
