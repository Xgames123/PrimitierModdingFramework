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
	public class PlatformRotator : MonoBehaviour // TypeDefIndex: 8353
	{
		// Fields
		public float maxAngle; // 0x18
		public float switchRotationTime; // 0x1C
		public float random; // 0x20
		public float rotationSpeed; // 0x24
		public Vector3 movePosition; // 0x28
		public float moveSpeed; // 0x34
		public int characterLayer; // 0x38
		private Quaternion defaultRotation; // 0x3C
		private Quaternion targetRotation; // 0x4C
		private Vector3 targetPosition; // 0x5C
		private Vector3 velocity; // 0x68
		private Rigidbody r; // 0x78
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _SwitchRotation_d__14 : IEnumerator<object> // TypeDefIndex: 8352
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PlatformRotator __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _SwitchRotation_d__14(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180850920-0x0000000180850A80
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180850A80-0x0000000180850AC0
		}
	
		// Constructors
		public PlatformRotator(); // 0x00000001807796E0-0x0000000180779710
	
		// Methods
		private void Start(); // 0x0000000180779530-0x0000000180779670
		private void FixedUpdate(); // 0x0000000180779110-0x0000000180779380
		[IteratorStateMachine] // 0x000000018001CC40-0x000000018001CC90
		private IEnumerator SwitchRotation(); // 0x0000000180779670-0x00000001807796E0
		private void OnCollisionEnter(Collision collision); // 0x0000000180779380-0x0000000180779460
		private void OnCollisionExit(Collision collision); // 0x0000000180779460-0x0000000180779530
	}
}
