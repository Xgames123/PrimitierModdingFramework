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

namespace RootMotion.FinalIK
{
	public class AimController : MonoBehaviour // TypeDefIndex: 8507
	{
		// Fields
		[Tooltip] // 0x000000018001BF40-0x000000018001BF70
		public AimIK ik; // 0x18
		[Range] // 0x0000000180021C90-0x0000000180021CE0
		[Tooltip] // 0x0000000180021C90-0x0000000180021CE0
		public float weight; // 0x20
		[Header] // 0x0000000180021CE0-0x0000000180021D40
		[Tooltip] // 0x0000000180021CE0-0x0000000180021D40
		public Transform target; // 0x28
		[Tooltip] // 0x0000000180021D40-0x0000000180021D70
		public float targetSwitchSmoothTime; // 0x30
		[Tooltip] // 0x0000000180021D70-0x0000000180021DA0
		public float weightSmoothTime; // 0x34
		[Header] // 0x0000000180021DA0-0x0000000180021E00
		[Tooltip] // 0x0000000180021DA0-0x0000000180021E00
		public bool smoothTurnTowardsTarget; // 0x38
		[Tooltip] // 0x0000000180021E00-0x0000000180021E30
		public float maxRadiansDelta; // 0x3C
		[Tooltip] // 0x0000000180021E30-0x0000000180021E60
		public float maxMagnitudeDelta; // 0x40
		[Tooltip] // 0x0000000180021E60-0x0000000180021E90
		public float slerpSpeed; // 0x44
		[Tooltip] // 0x0000000180021E90-0x0000000180021EC0
		public Vector3 pivotOffsetFromRoot; // 0x48
		[Tooltip] // 0x0000000180021EC0-0x0000000180021EF0
		public float minDistance; // 0x54
		[Tooltip] // 0x0000000180021EF0-0x0000000180021F20
		public Vector3 offset; // 0x58
		[Header] // 0x0000000180021F20-0x0000000180021FA0
		[Range] // 0x0000000180021F20-0x0000000180021FA0
		[Tooltip] // 0x0000000180021F20-0x0000000180021FA0
		public float maxRootAngle; // 0x64
		[Tooltip] // 0x0000000180021FA0-0x0000000180021FD0
		public bool turnToTarget; // 0x68
		[Tooltip] // 0x0000000180021FD0-0x0000000180022000
		public float turnToTargetTime; // 0x6C
		[Header] // 0x0000000180022000-0x0000000180022060
		[Tooltip] // 0x0000000180022000-0x0000000180022060
		public bool useAnimatedAimDirection; // 0x70
		[Tooltip] // 0x0000000180022060-0x0000000180022090
		public Vector3 animatedAimDirection; // 0x74
		private Transform lastTarget; // 0x80
		private float switchWeight; // 0x88
		private float switchWeightV; // 0x8C
		private float weightV; // 0x90
		private Vector3 lastPosition; // 0x94
		private Vector3 dir; // 0xA0
		private bool lastSmoothTowardsTarget; // 0xAC
		private bool turningToTarget; // 0xAD
		private float turnToTargetMlp; // 0xB0
		private float turnToTargetMlpV; // 0xB4
	
		// Properties
		private Vector3 pivot { get; } // 0x00000001807B9340-0x00000001807B9450 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _TurnToTarget_d__33 : IEnumerator<object> // TypeDefIndex: 8506
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public AimController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _TurnToTarget_d__33(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018071A150-0x000000018071A230
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018071A230-0x000000018071A270
		}
	
		// Constructors
		public AimController(); // 0x00000001807B92A0-0x00000001807B9340
	
		// Methods
		private void Start(); // 0x00000001807B9140-0x00000001807B9230
		private void LateUpdate(); // 0x00000001807B83F0-0x00000001807B8E50
		private void ApplyMinDistance(); // 0x00000001807B8280-0x00000001807B83F0
		private void RootRotation(); // 0x00000001807B8E50-0x00000001807B9140
		[IteratorStateMachine] // 0x0000000180022090-0x00000001800220E0
		private IEnumerator TurnToTarget(); // 0x00000001807B9230-0x00000001807B92A0
	}
}
