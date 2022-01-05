/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class BuggyController : MonoBehaviour // TypeDefIndex: 7499
	{
		// Fields
		public Transform modelJoystick; // 0x18
		public float joystickRot; // 0x20
		public Transform modelTrigger; // 0x28
		public float triggerRot; // 0x30
		public BuggyBuddy buggy; // 0x38
		public Transform buttonBrake; // 0x40
		public Transform buttonReset; // 0x48
		public Canvas ui_Canvas; // 0x50
		public Image ui_rpm; // 0x58
		public Image ui_speed; // 0x60
		public RectTransform ui_steer; // 0x68
		public float ui_steerangle; // 0x70
		public Vector2 ui_fillAngles; // 0x74
		public Transform resetToPoint; // 0x80
		public SteamVR_Action_Vector2 actionSteering; // 0x88
		public SteamVR_Action_Single actionThrottle; // 0x90
		public SteamVR_Action_Boolean actionBrake; // 0x98
		public SteamVR_Action_Boolean actionReset; // 0xA0
		private float usteer; // 0xA8
		private Interactable interactable; // 0xB0
		private Quaternion trigSRot; // 0xB8
		private Quaternion joySRot; // 0xC8
		private Coroutine resettingRoutine; // 0xD8
		private Vector3 initialScale; // 0xE0
		private float buzztimer; // 0xEC
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoReset_d__26 : IEnumerator<object> // TypeDefIndex: 7497
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BuggyController __4__this; // 0x20
			private float _endTime_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoReset_d__26(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180299520-0x0000000180299870
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180299870-0x00000001802998B0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoBuzz_d__28 : IEnumerator<object> // TypeDefIndex: 7498
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BuggyController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoBuzz_d__28(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180297150-0x0000000180297310
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180297310-0x0000000180297350
		}
	
		// Constructors
		public BuggyController(); // 0x0000000180587650-0x00000001805877C0
	
		// Methods
		private void Start(); // 0x0000000180586EC0-0x0000000180587000
		private void Update(); // 0x0000000180587000-0x0000000180587650
		[IteratorStateMachine] // 0x0000000180026710-0x0000000180026760
		private IEnumerator DoReset(); // 0x0000000180586E50-0x0000000180586EC0
		[IteratorStateMachine] // 0x0000000180026760-0x00000001800267B0
		private IEnumerator DoBuzz(); // 0x0000000180586DE0-0x0000000180586E50
	}
}
