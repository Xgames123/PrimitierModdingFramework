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
	public class SteamVR_Input_ActionFile_ActionSet // TypeDefIndex: 7287
	{
		// Fields
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		private const string actionSetInstancePrefix = "instance_"; // Metadata: 0x003A550A
		public string name; // 0x10
		public string usage; // 0x18
		private const string nameTemplate = "/actions/{0}"; // Metadata: 0x003A5517
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public List<SteamVR_Input_ActionFile_Action> actionsInList; // 0x20
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public List<SteamVR_Input_ActionFile_Action> actionsOutList; // 0x28
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public List<SteamVR_Input_ActionFile_Action> actionsList; // 0x30
	
		// Properties
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public string codeFriendlyName { get; } // 0x0000000180329450-0x0000000180329460 
		[JsonIgnore] // 0x0000000180014D50-0x0000000180014D60
		public string shortName { get; } // 0x0000000180329460-0x00000001803294E0 
	
		// Constructors
		public SteamVR_Input_ActionFile_ActionSet(); // 0x00000001803293A0-0x0000000180329450
	
		// Methods
		public void SetNewShortName(string newShortName); // 0x0000000180328FB0-0x0000000180329000
		public static string CreateNewName(); // 0x0000000180328CE0-0x0000000180328D40
		public static string GetPathFromName(string name); // 0x0000000180328F70-0x0000000180328FB0
		public static SteamVR_Input_ActionFile_ActionSet CreateNew(); // 0x0000000180328D40-0x0000000180328DF0
		public SteamVR_Input_ActionFile_ActionSet GetCopy(); // 0x0000000180328EF0-0x0000000180328F60
		public override bool Equals(object obj); // 0x0000000180328DF0-0x0000000180328EF0
		public override int GetHashCode(); // 0x0000000180328F60-0x0000000180328F70
	}
}
