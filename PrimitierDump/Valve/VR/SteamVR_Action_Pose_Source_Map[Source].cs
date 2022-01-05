/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Action_Pose_Source_Map<Source> : SteamVR_Action_In_Source_Map<Source> // TypeDefIndex: 7191
		where Source : SteamVR_Action_Pose_Source, new()
	{
		// Constructors
		public SteamVR_Action_Pose_Source_Map();
	
		// Methods
		public void SetTrackingUniverseOrigin(ETrackingUniverseOrigin newOrigin);
		public virtual void UpdateValues(bool skipStateAndEventUpdates);
	}
}
