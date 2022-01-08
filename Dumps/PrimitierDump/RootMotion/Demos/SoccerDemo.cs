/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018001CAE0-0x000000018001CB30
	public class SoccerDemo : MonoBehaviour // TypeDefIndex: 8345
	{
		// Fields
		private Animator animator; // 0x18
		private Vector3 defaultPosition; // 0x20
		private Quaternion defaultRotation; // 0x2C
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ResetDelayed_d__4 : IEnumerator<object> // TypeDefIndex: 8344
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SoccerDemo __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ResetDelayed_d__4(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180850170-0x00000001808502D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001808502D0-0x0000000180850310
		}
	
		// Constructors
		public SoccerDemo(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x00000001807178D0-0x00000001807179D0
		[IteratorStateMachine] // 0x000000018001CB30-0x000000018001CB80
		private IEnumerator ResetDelayed(); // 0x0000000180717860-0x00000001807178D0
	}
}
