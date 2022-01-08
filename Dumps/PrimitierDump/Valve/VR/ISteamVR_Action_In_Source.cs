/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public interface ISteamVR_Action_In_Source : ISteamVR_Action_Source // TypeDefIndex: 7178
	{
		// Properties
		bool changed { get; }
		bool lastChanged { get; }
		float changedTime { get; }
		float updateTime { get; }
		ulong activeOrigin { get; }
		ulong lastActiveOrigin { get; }
		SteamVR_Input_Sources activeDevice { get; }
		uint trackedDeviceIndex { get; }
		string renderModelComponentName { get; }
		string localizedOriginName { get; }
	}
}
