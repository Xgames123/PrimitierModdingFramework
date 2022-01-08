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
	public class SteamVR_ActionSet : IEquatable<Valve.VR.SteamVR_ActionSet>, ISteamVR_ActionSet, ISerializationCallbackReceiver // TypeDefIndex: 7160
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string actionSetPath; // 0x10
		[NonSerialized]
		protected SteamVR_ActionSet_Data setData; // 0x18
		[NonSerialized]
		protected bool initialized; // 0x20
	
		// Properties
		public SteamVR_Action[] allActions { get; } // 0x00000001803E2470-0x00000001803E24B0 
		public ISteamVR_Action_In[] nonVisualInActions { get; } // 0x00000001803E2530-0x00000001803E2570 
		public ISteamVR_Action_In[] visualActions { get; } // 0x00000001803E2670-0x00000001803E26B0 
		public SteamVR_Action_Pose[] poseActions { get; } // 0x00000001803E25B0-0x00000001803E25F0 
		public SteamVR_Action_Skeleton[] skeletonActions { get; } // 0x00000001803E25F0-0x00000001803E2630 
		public ISteamVR_Action_Out[] outActionArray { get; } // 0x00000001803E2570-0x00000001803E25B0 
		public string fullPath { get; } // 0x00000001803E24B0-0x00000001803E24F0 
		public string usage { get; } // 0x00000001803E2630-0x00000001803E2670 
		public ulong handle { get; } // 0x00000001803E24F0-0x00000001803E2530 
	
		// Constructors
		public SteamVR_ActionSet(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static CreateType Create<CreateType>(string newSetPath)
			where CreateType : SteamVR_ActionSet, new();
		public static CreateType CreateFromName<CreateType>(string newSetName)
			where CreateType : SteamVR_ActionSet, new();
		public void PreInitialize(string newActionPath); // 0x00000001803E2120-0x00000001803E2260
		public virtual void FinishPreInitialize(); // 0x00000001803E1110-0x00000001803E1130
		public virtual void Initialize(bool createNew = false /* Metadata: 0x003A5278 */, bool throwErrors = true /* Metadata: 0x003A5279 */); // 0x00000001803E11C0-0x00000001803E13D0
		public string GetPath(); // 0x0000000180268FC0-0x0000000180268FD0
		public bool IsActive(SteamVR_Input_Sources source = SteamVR_Input_Sources.Any /* Metadata: 0x003A527A */); // 0x00000001803E13D0-0x00000001803E1450
		public float GetTimeLastChanged(SteamVR_Input_Sources source = SteamVR_Input_Sources.Any /* Metadata: 0x003A527E */); // 0x00000001803E1170-0x00000001803E11C0
		public void Activate(SteamVR_Input_Sources activateForSource = SteamVR_Input_Sources.Any /* Metadata: 0x003A5282 */, int priority = 0 /* Metadata: 0x003A5286 */, bool disableAllOtherActionSets = false /* Metadata: 0x003A528A */); // 0x00000001803DFE60-0x00000001803DFE90
		public void Deactivate(SteamVR_Input_Sources forSource = SteamVR_Input_Sources.Any /* Metadata: 0x003A528B */); // 0x00000001803E0E90-0x00000001803E1010
		public string GetShortName(); // 0x00000001803E1130-0x00000001803E1170
		public bool ShowBindingHints(ISteamVR_Action_In originToHighlight = null); // 0x00000001803E2330-0x00000001803E23C0
		public bool ReadRawSetActive(SteamVR_Input_Sources inputSource); // 0x00000001803E2260-0x00000001803E22B0
		public float ReadRawSetLastChanged(SteamVR_Input_Sources inputSource); // 0x00000001803E22B0-0x00000001803E22F0
		public int ReadRawSetPriority(SteamVR_Input_Sources inputSource); // 0x00000001803E22F0-0x00000001803E2330
		public SteamVR_ActionSet_Data GetActionSetData(); // 0x0000000180268C10-0x0000000180268C20
		public CreateType GetCopy<CreateType>()
			where CreateType : SteamVR_ActionSet, new();
		public bool Equals(SteamVR_ActionSet other); // 0x0000000180367050-0x0000000180367070
		public override bool Equals(object other); // 0x00000001803E1010-0x00000001803E1110
		public override int GetHashCode(); // 0x0000000180367340-0x0000000180367360
		public static bool operator !=(SteamVR_ActionSet set1, SteamVR_ActionSet set2); // 0x00000001803E2760-0x00000001803E2810
		public static bool operator ==(SteamVR_ActionSet set1, SteamVR_ActionSet set2); // 0x00000001803E26B0-0x00000001803E2760
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180265310-0x0000000180265320
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803E23C0-0x00000001803E2470
	}
}
