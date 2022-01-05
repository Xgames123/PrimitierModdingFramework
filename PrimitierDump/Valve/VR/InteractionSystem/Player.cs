/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class Player : MonoBehaviour // TypeDefIndex: 7438
	{
		// Fields
		[Tooltip] // 0x0000000180025B70-0x0000000180025BA0
		public Transform trackingOriginTransform; // 0x18
		[Tooltip] // 0x0000000180025BA0-0x0000000180025BD0
		public Transform[] hmdTransforms; // 0x20
		[Tooltip] // 0x0000000180025BD0-0x0000000180025C00
		public Hand[] hands; // 0x28
		[Tooltip] // 0x0000000180025C00-0x0000000180025C30
		public Collider headCollider; // 0x30
		[Tooltip] // 0x0000000180025C30-0x0000000180025C60
		public GameObject rigSteamVR; // 0x38
		[Tooltip] // 0x0000000180025C60-0x0000000180025C90
		public GameObject rig2DFallback; // 0x40
		[Tooltip] // 0x0000000180025C90-0x0000000180025CC0
		public Transform audioListener; // 0x48
		[Tooltip] // 0x0000000180025CC0-0x0000000180025CF0
		public SteamVR_Action_Boolean headsetOnHead; // 0x50
		public bool allowToggleTo2D; // 0x58
		private static Player _instance; // 0x00
	
		// Properties
		public static Player instance { get; } // 0x00000001803618C0-0x0000000180361990 
		public int handCount { get; } // 0x0000000180361750-0x00000001803617F0 
		public Hand leftHand { get; } // 0x0000000180361990-0x0000000180361A90 
		public Hand rightHand { get; } // 0x0000000180361A90-0x0000000180361B90 
		public float scale { get; } // 0x0000000180361B90-0x0000000180361BC0 
		public Transform hmdTransform { get; } // 0x00000001803617F0-0x00000001803618C0 
		public float eyeHeight { get; } // 0x00000001803613A0-0x0000000180361560 
		public Vector3 feetPositionGuess { get; } // 0x0000000180361560-0x0000000180361750 
		public Vector3 bodyDirectionGuess { get; } // 0x00000001803611B0-0x00000001803613A0 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Start_d__30 : IEnumerator<object> // TypeDefIndex: 7437
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Player __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Start_d__30(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029CEF0-0x000000018029D030
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029D030-0x000000018029D070
		}
	
		// Constructors
		public Player(); // 0x0000000180361130-0x00000001803611B0
	
		// Methods
		public Hand GetHand(int i); // 0x00000001803604F0-0x00000001803605D0
		private void Awake(); // 0x00000001803601B0-0x0000000180360300
		[IteratorStateMachine] // 0x0000000180025CF0-0x0000000180025D40
		private IEnumerator Start(); // 0x0000000180360F10-0x0000000180360F80
		protected virtual void Update(); // 0x0000000180360F80-0x0000000180361130
		private void OnDrawGizmos(); // 0x00000001803605D0-0x0000000180360F10
		public void Draw2DDebug(); // 0x0000000180360300-0x00000001803604F0
		private void ActivateRig(GameObject rig); // 0x0000000180360020-0x00000001803601B0
		public void PlayerShotSelf(); // 0x0000000180265310-0x0000000180265320
	}
}
