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
	public class WheelDust : MonoBehaviour // TypeDefIndex: 7502
	{
		// Fields
		private WheelCollider col; // 0x18
		public ParticleSystem p; // 0x20
		public float EmissionMul; // 0x28
		public float velocityMul; // 0x2C
		public float maxEmission; // 0x30
		public float minSlip; // 0x34
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public float amt; // 0x38
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Vector3 slip; // 0x3C
		private float emitTimer; // 0x48
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _emitter_d__11 : IEnumerator<object> // TypeDefIndex: 7501
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WheelDust __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _emitter_d__11(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001808FCF90-0x00000001808FD070
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001808FD070-0x00000001808FD0B0
		}
	
		// Constructors
		public WheelDust(); // 0x00000001802A2F60-0x00000001802A2F70
	
		// Methods
		private void Start(); // 0x00000001802A2CD0-0x00000001802A2D70
		private void Update(); // 0x00000001802A2D70-0x00000001802A2F60
		[IteratorStateMachine] // 0x00000001800267B0-0x0000000180026800
		private IEnumerator emitter(); // 0x00000001802A2F70-0x00000001802A2FE0
		private void DoEmit(); // 0x00000001802A2BA0-0x00000001802A2CD0
	}
}
