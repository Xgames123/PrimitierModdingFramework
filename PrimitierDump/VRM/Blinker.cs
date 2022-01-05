/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class Blinker : MonoBehaviour // TypeDefIndex: 7980
	{
		// Fields
		private VRMBlendShapeProxy m_blendShapes; // 0x18
		[FormerlySerializedAs] // 0x0000000180035240-0x0000000180035280
		[SerializeField] // 0x0000000180035240-0x0000000180035280
		public float Interval; // 0x20
		[FormerlySerializedAs] // 0x0000000180035280-0x00000001800352D0
		[SerializeField] // 0x0000000180035280-0x00000001800352D0
		public float ClosingTime; // 0x24
		[FormerlySerializedAs] // 0x00000001800352D0-0x0000000180035310
		[SerializeField] // 0x00000001800352D0-0x0000000180035310
		public float OpeningSeconds; // 0x28
		[FormerlySerializedAs] // 0x0000000180035310-0x0000000180035360
		[SerializeField] // 0x0000000180035310-0x0000000180035360
		public float CloseSeconds; // 0x2C
		private Coroutine m_coroutine; // 0x30
		private float m_nextRequest; // 0x38
		private bool m_request; // 0x3C
	
		// Properties
		public bool Request { get; set; } // 0x0000000180338B10-0x0000000180338B20 0x0000000180338B20-0x0000000180338B70
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _BlinkRoutine_d__11 : IEnumerator<object> // TypeDefIndex: 7979
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Blinker __4__this; // 0x20
			private float _waitTime_5__2; // 0x28
			private float _value_5__3; // 0x2C
			private float _closeSpeed_5__4; // 0x30
			private float _openSpeed_5__5; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _BlinkRoutine_d__11(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018054A9F0-0x000000018054ADB0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018054ADB0-0x000000018054ADF0
		}
	
		// Constructors
		public Blinker(); // 0x0000000180338AE0-0x0000000180338B10
	
		// Methods
		[IteratorStateMachine] // 0x0000000180035360-0x00000001800353B0
		private IEnumerator BlinkRoutine(); // 0x00000001803389A0-0x0000000180338A10
		private void OnEnable(); // 0x0000000180338A40-0x0000000180338AE0
		private void OnDisable(); // 0x0000000180338A10-0x0000000180338A40
	}
}
