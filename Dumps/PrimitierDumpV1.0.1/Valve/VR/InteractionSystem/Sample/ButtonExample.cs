/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR.InteractionSystem;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class ButtonExample : MonoBehaviour // TypeDefIndex: 7513
	{
		// Fields
		public HoverButton hoverButton; // 0x18
		public GameObject prefab; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoPlant_d__4 : IEnumerator<object> // TypeDefIndex: 7512
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ButtonExample __4__this; // 0x20
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
			public _DoPlant_d__4(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180298140-0x00000001802985D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001802985D0-0x0000000180298610
		}
	
		// Constructors
		public ButtonExample(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x0000000180587A30-0x0000000180587AF0
		private void OnButtonDown(Valve.VR.InteractionSystem.Hand hand); // 0x00000001805879C0-0x0000000180587A30
		[IteratorStateMachine] // 0x0000000180026880-0x00000001800268D0
		private IEnumerator DoPlant(); // 0x0000000180587950-0x00000001805879C0
	}
}
