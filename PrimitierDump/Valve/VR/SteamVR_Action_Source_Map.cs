/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public abstract class SteamVR_Action_Source_Map // TypeDefIndex: 7155
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _fullPath_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ulong _handle_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_ActionSet _actionSet_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_ActionDirections _direction_k__BackingField; // 0x28
		public SteamVR_Action action; // 0x30
		private static string inLowered; // 0x00
		private static string outLowered; // 0x08
	
		// Properties
		public string fullPath { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public ulong handle { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public SteamVR_ActionSet actionSet { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public SteamVR_ActionDirections direction { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x00000001802B51E0-0x00000001802B51F0 0x00000001802B51F0-0x00000001802B5200
	
		// Constructors
		protected SteamVR_Action_Source_Map(); // 0x00000001802650F0-0x0000000180265100
		static SteamVR_Action_Source_Map(); // 0x00000001803F3DF0-0x00000001803F3EC0
	
		// Methods
		public virtual void PreInitialize(SteamVR_Action wrappingAction, string actionPath, bool throwErrors = true /* Metadata: 0x003A526F */); // 0x00000001803F3C80-0x00000001803F3DF0
		protected abstract void PreinitializeMap(SteamVR_Input_Sources inputSource, SteamVR_Action wrappingAction);
		public virtual void Initialize(); // 0x00000001803F3AE0-0x00000001803F3C80
		private string GetActionSetPath(); // 0x00000001803F3A80-0x00000001803F3AE0
		private SteamVR_ActionDirections GetActionDirection(); // 0x00000001803F38C0-0x00000001803F3A80
	}
}
