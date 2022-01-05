/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public interface ISteamVR_Action_In : ISteamVR_Action, ISteamVR_Action_In_Source // TypeDefIndex: 7177
	{
		// Methods
		void UpdateValues();
		string GetRenderModelComponentName(SteamVR_Input_Sources inputSource);
		SteamVR_Input_Sources GetActiveDevice(SteamVR_Input_Sources inputSource);
		uint GetDeviceIndex(SteamVR_Input_Sources inputSource);
		bool GetChanged(SteamVR_Input_Sources inputSource);
		string GetLocalizedOriginPart(SteamVR_Input_Sources inputSource, params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts);
		string GetLocalizedOrigin(SteamVR_Input_Sources inputSource);
	}
}
