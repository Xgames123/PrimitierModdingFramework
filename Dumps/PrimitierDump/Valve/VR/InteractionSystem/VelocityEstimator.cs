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
	public class VelocityEstimator : MonoBehaviour // TypeDefIndex: 7457
	{
		// Fields
		[Tooltip] // 0x0000000180026070-0x00000001800260A0
		public int velocityAverageFrames; // 0x18
		[Tooltip] // 0x00000001800260A0-0x00000001800260D0
		public int angularVelocityAverageFrames; // 0x1C
		public bool estimateOnAwake; // 0x20
		private Coroutine routine; // 0x28
		private int sampleCount; // 0x30
		private Vector3[] velocitySamples; // 0x38
		private Vector3[] angularVelocitySamples; // 0x40
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _EstimateVelocityCoroutine_d__13 : IEnumerator<object> // TypeDefIndex: 7456
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public VelocityEstimator __4__this; // 0x20
			private Vector3 _previousPosition_5__2; // 0x28
			private Quaternion _previousRotation_5__3; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _EstimateVelocityCoroutine_d__13(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180299E10-0x000000018029A1C0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029A1C0-0x000000018029A200
		}
	
		// Constructors
		public VelocityEstimator(); // 0x00000001802A20B0-0x00000001802A20D0
	
		// Methods
		public void BeginEstimatingVelocity(); // 0x00000001802A1B30-0x00000001802A1BC0
		public void FinishEstimatingVelocity(); // 0x00000001802A1C20-0x00000001802A1C50
		public Vector3 GetVelocityEstimate(); // 0x00000001802A1F50-0x00000001802A20B0
		public Vector3 GetAngularVelocityEstimate(); // 0x00000001802A1DF0-0x00000001802A1F50
		public Vector3 GetAccelerationEstimate(); // 0x00000001802A1C50-0x00000001802A1DF0
		private void Awake(); // 0x00000001802A1AC0-0x00000001802A1B30
		[IteratorStateMachine] // 0x00000001800260D0-0x0000000180026120
		private IEnumerator EstimateVelocityCoroutine(); // 0x00000001802A1BC0-0x00000001802A1C20
	}
}
