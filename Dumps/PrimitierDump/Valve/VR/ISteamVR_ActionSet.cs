/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public interface ISteamVR_ActionSet // TypeDefIndex: 7162
	{
		// Properties
		SteamVR_Action[] allActions { get; }
		ISteamVR_Action_In[] nonVisualInActions { get; }
		ISteamVR_Action_In[] visualActions { get; }
		SteamVR_Action_Pose[] poseActions { get; }
		SteamVR_Action_Skeleton[] skeletonActions { get; }
		ISteamVR_Action_Out[] outActionArray { get; }
		string fullPath { get; }
		string usage { get; }
		ulong handle { get; }
	
		// Methods
		bool ReadRawSetActive(SteamVR_Input_Sources inputSource);
		float ReadRawSetLastChanged(SteamVR_Input_Sources inputSource);
		int ReadRawSetPriority(SteamVR_Input_Sources inputSource);
		bool IsActive(SteamVR_Input_Sources source = SteamVR_Input_Sources.Any /* Metadata: 0x003A52A4 */);
		float GetTimeLastChanged(SteamVR_Input_Sources source = SteamVR_Input_Sources.Any /* Metadata: 0x003A52A8 */);
		void Activate(SteamVR_Input_Sources activateForSource = SteamVR_Input_Sources.Any /* Metadata: 0x003A52AC */, int priority = 0 /* Metadata: 0x003A52B0 */, bool disableAllOtherActionSets = false /* Metadata: 0x003A52B4 */);
		void Deactivate(SteamVR_Input_Sources forSource = SteamVR_Input_Sources.Any /* Metadata: 0x003A52B5 */);
		string GetShortName();
	}
}
