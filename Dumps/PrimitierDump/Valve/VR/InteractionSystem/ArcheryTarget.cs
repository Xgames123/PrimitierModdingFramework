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

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class ArcheryTarget : MonoBehaviour // TypeDefIndex: 7465
	{
		// Fields
		public UnityEvent onTakeDamage; // 0x18
		public bool onceOnly; // 0x20
		public Transform targetCenter; // 0x28
		public Transform baseTransform; // 0x30
		public Transform fallenDownTransform; // 0x38
		public float fallTime; // 0x40
		private const float targetRadius = 0.25f; // Metadata: 0x003A5ABA
		private bool targetEnabled; // 0x44
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _FallDown_d__11 : IEnumerator<object> // TypeDefIndex: 7464
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ArcheryTarget __4__this; // 0x20
			private Quaternion _startingRot_5__2; // 0x28
			private float _startTime_5__3; // 0x38
			private float _rotLerp_5__4; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _FallDown_d__11(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029A200-0x000000018029A3D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029A3D0-0x000000018029A410
		}
	
		// Constructors
		public ArcheryTarget(); // 0x0000000180581BD0-0x0000000180581BF0
	
		// Methods
		private void ApplyDamage(); // 0x0000000180581AC0-0x0000000180581AD0
		private void FireExposure(); // 0x0000000180581AC0-0x0000000180581AD0
		private void OnDamageTaken(); // 0x0000000180581B40-0x0000000180581BD0
		[IteratorStateMachine] // 0x0000000180026240-0x0000000180026290
		private IEnumerator FallDown(); // 0x0000000180581AD0-0x0000000180581B40
	}
}
