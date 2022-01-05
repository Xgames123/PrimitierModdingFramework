/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class MechSpiderLeg : MonoBehaviour // TypeDefIndex: 8305
	{
		// Fields
		public MechSpider mechSpider; // 0x18
		public MechSpiderLeg unSync; // 0x20
		public Vector3 offset; // 0x28
		public float minDelay; // 0x34
		public float maxOffset; // 0x38
		public float stepSpeed; // 0x3C
		public float footHeight; // 0x40
		public float velocityPrediction; // 0x44
		public float raycastFocus; // 0x48
		public AnimationCurve yOffset; // 0x50
		public ParticleSystem sand; // 0x58
		private IK ik; // 0x60
		private float stepProgress; // 0x68
		private float lastStepTime; // 0x6C
		private Vector3 defaultPosition; // 0x70
		private RaycastHit hit; // 0x7C
	
		// Properties
		public bool isStepping { get; } // 0x0000000180773F50-0x0000000180773F60 
		public Vector3 position { get; set; } // 0x0000000180773F60-0x0000000180773FC0 0x0000000180773FC0-0x0000000180774010
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Step_d__26 : IEnumerator<object> // TypeDefIndex: 8304
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public MechSpiderLeg __4__this; // 0x20
			public Vector3 stepStartPosition; // 0x28
			public Vector3 targetPosition; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Step_d__26(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180850520-0x00000001808508E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001808508E0-0x0000000180850920
		}
	
		// Constructors
		public MechSpiderLeg(); // 0x0000000180773F10-0x0000000180773F50
	
		// Methods
		private void Awake(); // 0x00000001807732A0-0x00000001807732E0
		private void Start(); // 0x00000001807738B0-0x0000000180773B40
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance); // 0x00000001807732E0-0x0000000180773780
		private void OnEnable(); // 0x0000000180773780-0x00000001807738B0
		private void Update(); // 0x0000000180773BE0-0x0000000180773F10
		[IteratorStateMachine] // 0x000000018001C0F0-0x000000018001C140
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition); // 0x0000000180773B40-0x0000000180773BE0
	}
}
