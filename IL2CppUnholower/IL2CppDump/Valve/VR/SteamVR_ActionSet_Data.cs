/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_ActionSet_Data : ISteamVR_ActionSet // TypeDefIndex: 7161
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action[] _allActions_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ISteamVR_Action_In[] _nonVisualInActions_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ISteamVR_Action_In[] _visualActions_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Pose[] _poseActions_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Action_Skeleton[] _skeletonActions_k__BackingField; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ISteamVR_Action_Out[] _outActionArray_k__BackingField; // 0x38
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _fullPath_k__BackingField; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _usage_k__BackingField; // 0x48
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ulong _handle_k__BackingField; // 0x50
		protected bool[] rawSetActive; // 0x58
		protected float[] rawSetLastChanged; // 0x60
		protected int[] rawSetPriority; // 0x68
		protected bool initialized; // 0x70
		private string cachedShortName; // 0x78
	
		// Properties
		public SteamVR_Action[] allActions { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public ISteamVR_Action_In[] nonVisualInActions { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public ISteamVR_Action_In[] visualActions { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public SteamVR_Action_Pose[] poseActions { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
		public SteamVR_Action_Skeleton[] skeletonActions { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		public ISteamVR_Action_Out[] outActionArray { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FE0-0x0000000180268FF0 0x00000001802A43D0-0x00000001802A43E0
		public string fullPath { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		public string usage { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
		public ulong handle { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802BC110-0x00000001802BC120 0x00000001803DFE50-0x00000001803DFE60
	
		// Constructors
		public SteamVR_ActionSet_Data(); // 0x00000001803E0DB0-0x00000001803E0E90
	
		// Methods
		public void PreInitialize(); // 0x0000000180265310-0x0000000180265320
		public void FinishPreInitialize(); // 0x00000001803E03E0-0x00000001803E0A70
		public void Initialize(); // 0x00000001803E0AF0-0x00000001803E0C80
		public bool IsActive(SteamVR_Input_Sources source = SteamVR_Input_Sources.Any /* Metadata: 0x003A528F */); // 0x00000001803E0C80-0x00000001803E0CF0
		public float GetTimeLastChanged(SteamVR_Input_Sources source = SteamVR_Input_Sources.Any /* Metadata: 0x003A5293 */); // 0x00000001803E0AA0-0x00000001803E0AF0
		public void Activate(SteamVR_Input_Sources activateForSource = SteamVR_Input_Sources.Any /* Metadata: 0x003A5297 */, int priority = 0 /* Metadata: 0x003A529B */, bool disableAllOtherActionSets = false /* Metadata: 0x003A529F */); // 0x00000001803DFE90-0x00000001803E0260
		public void Deactivate(SteamVR_Input_Sources forSource = SteamVR_Input_Sources.Any /* Metadata: 0x003A52A0 */); // 0x00000001803E0260-0x00000001803E03E0
		public string GetShortName(); // 0x00000001803E0A70-0x00000001803E0AA0
		public bool ReadRawSetActive(SteamVR_Input_Sources inputSource); // 0x00000001803E0CF0-0x00000001803E0D30
		public float ReadRawSetLastChanged(SteamVR_Input_Sources inputSource); // 0x00000001803E0D30-0x00000001803E0D70
		public int ReadRawSetPriority(SteamVR_Input_Sources inputSource); // 0x00000001803E0D70-0x00000001803E0DB0
	}
}
