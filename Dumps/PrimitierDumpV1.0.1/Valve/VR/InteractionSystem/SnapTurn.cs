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
	public class SnapTurn : MonoBehaviour // TypeDefIndex: 7482
	{
		// Fields
		public float snapAngle; // 0x18
		public bool showTurnAnimation; // 0x1C
		public AudioSource snapTurnSource; // 0x20
		public AudioClip rotateSound; // 0x28
		public GameObject rotateRightFX; // 0x30
		public GameObject rotateLeftFX; // 0x38
		public SteamVR_Action_Boolean snapLeftAction; // 0x40
		public SteamVR_Action_Boolean snapRightAction; // 0x48
		public bool fadeScreen; // 0x50
		public float fadeTime; // 0x54
		public Color screenFadeColor; // 0x58
		public float distanceFromFace; // 0x68
		public Vector3 additionalOffset; // 0x6C
		public static float teleportLastActiveTime; // 0x00
		private bool canRotate; // 0x78
		public float canTurnEverySeconds; // 0x7C
		private Coroutine rotateCoroutine; // 0x80
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoRotatePlayer_d__21 : IEnumerator<object> // TypeDefIndex: 7481
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SnapTurn __4__this; // 0x20
			public float angle; // 0x28
			private Player _player_5__2; // 0x30
			private GameObject _fx_5__3; // 0x38
			private float _endTime_5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoRotatePlayer_d__21(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001802998B0-0x0000000180299DD0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180299DD0-0x0000000180299E10
		}
	
		// Constructors
		public SnapTurn(); // 0x0000000180366350-0x0000000180366450
	
		// Methods
		private void Start(); // 0x0000000180365B50-0x0000000180365B60
		private void AllOff(); // 0x00000001803658A0-0x0000000180365970
		private void Update(); // 0x0000000180365EB0-0x0000000180366350
		public void RotatePlayer(float angle); // 0x00000001803659F0-0x0000000180365AA0
		[IteratorStateMachine] // 0x0000000180026380-0x00000001800263D0
		private IEnumerator DoRotatePlayer(float angle); // 0x0000000180365970-0x00000001803659F0
		private void ShowRotateFX(GameObject fx); // 0x0000000180365AA0-0x0000000180365B50
		private void UpdateOrientation(GameObject fx); // 0x0000000180365B60-0x0000000180365EB0
	}
}
