/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class DistanceHaptics : MonoBehaviour // TypeDefIndex: 7397
	{
		// Fields
		public Transform firstTransform; // 0x18
		public Transform secondTransform; // 0x20
		public AnimationCurve distanceIntensityCurve; // 0x28
		public AnimationCurve pulseIntervalCurve; // 0x30
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Start_d__4 : IEnumerator<object> // TypeDefIndex: 7396
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DistanceHaptics __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Start_d__4(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029D070-0x000000018029D220
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029D220-0x000000018029D260
		}
	
		// Constructors
		public DistanceHaptics(); // 0x0000000180590280-0x00000001805902F0
	
		// Methods
		[IteratorStateMachine] // 0x0000000180024E10-0x0000000180024E60
		private IEnumerator Start(); // 0x0000000180590210-0x0000000180590280
	}
}
