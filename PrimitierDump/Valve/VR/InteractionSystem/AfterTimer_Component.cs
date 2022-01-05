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
	[Serializable]
	public class AfterTimer_Component : MonoBehaviour // TypeDefIndex: 7455
	{
		// Fields
		private System.Action callback; // 0x18
		private float triggerTime; // 0x20
		private bool timerActive; // 0x24
		private bool triggerOnEarlyDestroy; // 0x25
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Wait_d__5 : IEnumerator<object> // TypeDefIndex: 7454
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public AfterTimer_Component __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Wait_d__5(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029E850-0x000000018029E950
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029E950-0x000000018029E990
		}
	
		// Constructors
		public AfterTimer_Component(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public void Init(float _time, System.Action _callback, bool earlydestroy); // 0x0000000180581760-0x00000001805817E0
		[IteratorStateMachine] // 0x0000000180026020-0x0000000180026070
		private IEnumerator Wait(); // 0x0000000180581870-0x00000001805818E0
		private void OnDestroy(); // 0x00000001805817E0-0x0000000180581870
	}
}
