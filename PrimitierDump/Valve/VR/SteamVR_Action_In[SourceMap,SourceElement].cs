/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	[Serializable]
	public abstract class SteamVR_Action_In<SourceMap, SourceElement> : SteamVR_Action<SourceMap, SourceElement>, ISteamVR_Action_In // TypeDefIndex: 7174
		where SourceMap : SteamVR_Action_In_Source_Map<SourceElement>, new()
		where SourceElement : SteamVR_Action_In_Source, new()
	{
		// Properties
		public bool changed { get; }
		public bool lastChanged { get; }
		public float changedTime { get; }
		public float updateTime { get; }
		public ulong activeOrigin { get; }
		public ulong lastActiveOrigin { get; }
		public SteamVR_Input_Sources activeDevice { get; }
		public uint trackedDeviceIndex { get; }
		public string renderModelComponentName { get; }
		public string localizedOriginName { get; }
	
		// Constructors
		protected SteamVR_Action_In();
	
		// Methods
		public virtual void UpdateValues();
		public virtual string GetRenderModelComponentName(SteamVR_Input_Sources inputSource);
		public virtual SteamVR_Input_Sources GetActiveDevice(SteamVR_Input_Sources inputSource);
		public virtual uint GetDeviceIndex(SteamVR_Input_Sources inputSource);
		public virtual bool GetChanged(SteamVR_Input_Sources inputSource);
		public override float GetTimeLastChanged(SteamVR_Input_Sources inputSource);
		public string GetLocalizedOriginPart(SteamVR_Input_Sources inputSource, params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts);
		public string GetLocalizedOrigin(SteamVR_Input_Sources inputSource);
		public override bool IsUpdating(SteamVR_Input_Sources inputSource);
		public void ForceAddSourceToUpdateList(SteamVR_Input_Sources inputSource);
		public string GetControllerType(SteamVR_Input_Sources inputSource);
	}
}
