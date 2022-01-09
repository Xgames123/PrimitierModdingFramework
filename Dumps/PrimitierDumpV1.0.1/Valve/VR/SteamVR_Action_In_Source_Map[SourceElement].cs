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
	public class SteamVR_Action_In_Source_Map<SourceElement> : SteamVR_Action_Source_Map<SourceElement> // TypeDefIndex: 7175
		where SourceElement : SteamVR_Action_In_Source, new()
	{
		// Fields
		protected List<int> updatingSources;
	
		// Constructors
		public SteamVR_Action_In_Source_Map();
	
		// Methods
		public bool IsUpdating(SteamVR_Input_Sources inputSource);
		protected override void OnAccessSource(SteamVR_Input_Sources inputSource);
		public void ForceAddSourceToUpdateList(SteamVR_Input_Sources inputSource);
		public void UpdateValues();
	}
}
