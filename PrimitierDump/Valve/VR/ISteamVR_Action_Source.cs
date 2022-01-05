/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public interface ISteamVR_Action_Source // TypeDefIndex: 7158
	{
		// Properties
		bool active { get; }
		bool activeBinding { get; }
		bool lastActive { get; }
		bool lastActiveBinding { get; }
		string fullPath { get; }
		ulong handle { get; }
		SteamVR_ActionSet actionSet { get; }
		SteamVR_ActionDirections direction { get; }
	}
}
