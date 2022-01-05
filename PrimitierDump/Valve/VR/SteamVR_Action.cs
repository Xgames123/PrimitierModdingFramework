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
	[Serializable]
	public abstract class SteamVR_Action : IEquatable<Valve.VR.SteamVR_Action>, ISteamVR_Action // TypeDefIndex: 7153
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected string actionPath; // 0x10
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool needsReinit; // 0x18
		public static bool startUpdatingSourceOnAccess; // 0x00
		[NonSerialized]
		private string cachedShortName; // 0x20
	
		// Properties
		public abstract string fullPath { get; }
		public abstract ulong handle { get; }
		public abstract SteamVR_ActionSet actionSet { get; }
		public abstract SteamVR_ActionDirections direction { get; }
		public bool setActive { get; } // 0x0000000180367550-0x0000000180367580 
		public abstract bool active { get; }
		public abstract bool activeBinding { get; }
		public abstract bool lastActive { get; }
		public abstract bool lastActiveBinding { get; }
	
		// Constructors
		public SteamVR_Action(); // 0x00000001802650F0-0x0000000180265100
		static SteamVR_Action(); // 0x0000000180367510-0x0000000180367550
	
		// Methods
		public static CreateType Create<CreateType>(string newActionPath)
			where CreateType : SteamVR_Action, new();
		public static CreateType CreateUninitialized<CreateType>(string setName, SteamVR_ActionDirections direction, string newActionName, bool caseSensitive)
			where CreateType : SteamVR_Action, new();
		public static CreateType CreateUninitialized<CreateType>(string actionPath, bool caseSensitive)
			where CreateType : SteamVR_Action, new();
		public CreateType GetCopy<CreateType>()
			where CreateType : SteamVR_Action, new();
		public abstract string TryNeedsInitData();
		protected abstract void InitializeCopy(string newActionPath, SteamVR_Action_Source_Map newData);
		public abstract void PreInitialize(string newActionPath);
		protected abstract void CreateUninitialized(string newActionPath, bool caseSensitive);
		protected abstract void CreateUninitialized(string newActionSet, SteamVR_ActionDirections direction, string newAction, bool caseSensitive);
		public abstract void Initialize(bool createNew = false /* Metadata: 0x003A526D */, bool throwNotSetError = true /* Metadata: 0x003A526E */);
		public abstract float GetTimeLastChanged(SteamVR_Input_Sources inputSource);
		public abstract SteamVR_Action_Source_Map GetSourceMap();
		public abstract bool GetActive(SteamVR_Input_Sources inputSource);
		public bool GetSetActive(SteamVR_Input_Sources inputSource); // 0x0000000180367360-0x00000001803673A0
		public abstract bool GetActiveBinding(SteamVR_Input_Sources inputSource);
		public abstract bool GetLastActive(SteamVR_Input_Sources inputSource);
		public abstract bool GetLastActiveBinding(SteamVR_Input_Sources inputSource);
		public string GetPath(); // 0x0000000180268FC0-0x0000000180268FD0
		public abstract bool IsUpdating(SteamVR_Input_Sources inputSource);
		public override int GetHashCode(); // 0x0000000180367340-0x0000000180367360
		public bool Equals(SteamVR_Action other); // 0x0000000180367050-0x0000000180367070
		public override bool Equals(object other); // 0x0000000180367070-0x0000000180367190
		public static bool operator !=(SteamVR_Action action1, SteamVR_Action action2); // 0x0000000180367650-0x00000001803676C0
		public static bool operator ==(SteamVR_Action action1, SteamVR_Action action2); // 0x0000000180367580-0x0000000180367650
		public static SteamVR_Action FindExistingActionForPartialPath(string path); // 0x0000000180367190-0x0000000180367340
		public string GetShortName(); // 0x00000001803673A0-0x00000001803673E0
		public void ShowOrigins(); // 0x0000000180367450-0x0000000180367510
		public void HideOrigins(); // 0x00000001803673E0-0x0000000180367450
	}
}
