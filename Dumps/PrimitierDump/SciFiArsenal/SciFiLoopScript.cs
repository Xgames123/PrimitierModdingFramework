/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace SciFiArsenal
{
	public class SciFiLoopScript : MonoBehaviour // TypeDefIndex: 8774
	{
		// Fields
		public GameObject chosenEffect; // 0x18
		public float loopTimeLimit; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _EffectLoop_d__4 : IEnumerator<object> // TypeDefIndex: 8773
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SciFiLoopScript __4__this; // 0x20
			private GameObject _effectPlayer_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _EffectLoop_d__4(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180885B80-0x0000000180885D40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180885D40-0x0000000180885D80
		}
	
		// Constructors
		public SciFiLoopScript(); // 0x0000000180B50D90-0x0000000180B50DA0
	
		// Methods
		private void Start(); // 0x0000000180B50D50-0x0000000180B50D90
		public void PlayEffect(); // 0x0000000180B50D50-0x0000000180B50D90
		[IteratorStateMachine] // 0x000000018002EB90-0x000000018002EBE0
		private IEnumerator EffectLoop(); // 0x0000000180B50CE0-0x0000000180B50D50
	}
}
