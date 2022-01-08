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

namespace Valve.VR.InteractionSystem.Sample
{
	public class FlowerPlanted : MonoBehaviour // TypeDefIndex: 7526
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoPlant_d__2 : IEnumerator<object> // TypeDefIndex: 7525
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FlowerPlanted __4__this; // 0x20
			private GameObject _planting_5__2; // 0x28
			private Rigidbody _rigidbody_5__3; // 0x30
			private Vector3 _initialScale_5__4; // 0x38
			private Vector3 _targetScale_5__5; // 0x44
			private float _startTime_5__6; // 0x50
			private float _overTime_5__7; // 0x54
			private float _endTime_5__8; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoPlant_d__2(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180297B10-0x0000000180298100
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180298100-0x0000000180298140
		}
	
		// Constructors
		public FlowerPlanted(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x0000000180591460-0x00000001805914D0
		public void Plant(); // 0x0000000180591460-0x00000001805914D0
		[IteratorStateMachine] // 0x0000000180026970-0x00000001800269C0
		private IEnumerator DoPlant(); // 0x00000001805913F0-0x0000000180591460
	}
}
