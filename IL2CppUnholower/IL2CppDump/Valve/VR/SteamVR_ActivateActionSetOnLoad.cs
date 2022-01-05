/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_ActivateActionSetOnLoad : MonoBehaviour // TypeDefIndex: 7241
	{
		// Fields
		public SteamVR_ActionSet actionSet; // 0x18
		public SteamVR_Input_Sources forSources; // 0x20
		public bool disableAllOtherActionSets; // 0x24
		public bool activateOnStart; // 0x25
		public bool deactivateOnDestroy; // 0x26
		public int initialPriority; // 0x28
	
		// Constructors
		public SteamVR_ActivateActionSetOnLoad(); // 0x00000001803F98B0-0x00000001803F9930
	
		// Methods
		private void Start(); // 0x00000001803F9820-0x00000001803F98B0
		private void OnDestroy(); // 0x00000001803F97B0-0x00000001803F9820
	}
}
