/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class ChaperoneInfo : MonoBehaviour // TypeDefIndex: 7485
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initialized_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _playAreaSizeX_k__BackingField; // 0x1C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _playAreaSizeZ_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _roomscale_k__BackingField; // 0x24
		public static SteamVR_Events.Event Initialized; // 0x00
		private static ChaperoneInfo _instance; // 0x08
	
		// Properties
		public bool initialized { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802A9AD0-0x00000001802A9AE0 0x00000001802C2010-0x00000001802C2020
		public float playAreaSizeX { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018045D380-0x000000018045D390 0x000000018045FA50-0x000000018045FA60
		public float playAreaSizeZ { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001803374D0-0x00000001803374E0 0x00000001803374E0-0x00000001803374F0
		public bool roomscale { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001803D8EF0-0x00000001803D8F00 0x0000000180587E90-0x0000000180587EA0
		public static ChaperoneInfo instance { get; } // 0x0000000180587C60-0x0000000180587E90 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Start_d__21 : IEnumerator<object> // TypeDefIndex: 7484
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ChaperoneInfo __4__this; // 0x20
			private CVRChaperone _chaperone_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Start_d__21(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029C8C0-0x000000018029CC50
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029CC50-0x000000018029CC90
		}
	
		// Constructors
		public ChaperoneInfo(); // 0x0000000180265240-0x0000000180265250
		static ChaperoneInfo(); // 0x0000000180587C00-0x0000000180587C60
	
		// Methods
		public static SteamVR_Events.Action InitializedAction(UnityAction action); // 0x0000000180587AF0-0x0000000180587B90
		[IteratorStateMachine] // 0x00000001800263D0-0x0000000180026420
		private IEnumerator Start(); // 0x0000000180587B90-0x0000000180587C00
	}
}
