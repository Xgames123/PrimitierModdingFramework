/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public abstract class SteamVR_Action_Source : ISteamVR_Action_Source // TypeDefIndex: 7156
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Input_Sources _inputSource_k__BackingField; // 0x10
		protected ulong inputSourceHandle; // 0x18
		protected SteamVR_Action action; // 0x20
	
		// Properties
		public string fullPath { get; } // 0x00000001803F3F30-0x00000001803F3F60 
		public ulong handle { get; } // 0x00000001803F3F60-0x00000001803F3F90 
		public SteamVR_ActionSet actionSet { get; } // 0x00000001803F3ED0-0x00000001803F3F00 
		public SteamVR_ActionDirections direction { get; } // 0x00000001803F3F00-0x00000001803F3F30 
		public SteamVR_Input_Sources inputSource { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180260E80-0x0000000180260F00 0x00000001802A2B90-0x00000001802A2BA0
		public bool setActive { get; } // 0x00000001803F3F90-0x00000001803F3FD0 
		public abstract bool active { get; }
		public abstract bool activeBinding { get; }
		public abstract bool lastActive { get; protected set; }
		public abstract bool lastActiveBinding { get; }
	
		// Constructors
		public SteamVR_Action_Source(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public virtual void Preinitialize(SteamVR_Action wrappingAction, SteamVR_Input_Sources forInputSource); // 0x00000001803F3EC0-0x00000001803F3ED0
		public virtual void Initialize(); // 0x00000001803F3850-0x00000001803F38C0
	}
}
