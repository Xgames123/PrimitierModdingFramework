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
	public class ResetInteractionObject : MonoBehaviour // TypeDefIndex: 8343
	{
		// Fields
		public float resetDelay; // 0x18
		private Vector3 defaultPosition; // 0x1C
		private Quaternion defaultRotation; // 0x28
		private Transform defaultParent; // 0x38
		private Rigidbody r; // 0x40
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ResetObject_d__7 : IEnumerator<object> // TypeDefIndex: 8342
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float resetTime; // 0x20
			public ResetInteractionObject __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ResetObject_d__7(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180850310-0x00000001808504E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001808504E0-0x0000000180850520
		}
	
		// Constructors
		public ResetInteractionObject(); // 0x0000000180776B40-0x0000000180776B50
	
		// Methods
		private void Start(); // 0x000000018077D560-0x000000018077D620
		private void OnPickUp(Transform t); // 0x000000018077D440-0x000000018077D4E0
		[IteratorStateMachine] // 0x000000018001CA90-0x000000018001CAE0
		private IEnumerator ResetObject(float resetTime); // 0x000000018077D4E0-0x000000018077D560
	}
}
