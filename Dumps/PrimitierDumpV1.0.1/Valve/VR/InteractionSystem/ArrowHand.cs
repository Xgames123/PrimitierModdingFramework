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
	public class ArrowHand : MonoBehaviour // TypeDefIndex: 7468
	{
		// Fields
		private Hand hand; // 0x18
		private Longbow bow; // 0x20
		private GameObject currentArrow; // 0x28
		public GameObject arrowPrefab; // 0x30
		public Transform arrowNockTransform; // 0x38
		public float nockDistance; // 0x40
		public float lerpCompleteDistance; // 0x44
		public float rotationLerpThreshold; // 0x48
		public float positionLerpThreshold; // 0x4C
		private bool allowArrowSpawn; // 0x50
		private bool nocked; // 0x51
		private GrabTypes nockedWithType; // 0x54
		private bool inNockRange; // 0x58
		private bool arrowLerpComplete; // 0x59
		public SoundPlayOneshot arrowSpawnSound; // 0x60
		private AllowTeleportWhileAttachedToHand allowTeleport; // 0x68
		public int maxArrowCount; // 0x70
		private List<GameObject> arrowList; // 0x78
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ArrowReleaseHaptics_d__25 : IEnumerator<object> // TypeDefIndex: 7467
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ArrowHand __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ArrowReleaseHaptics_d__25(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180296D60-0x0000000180296FA0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180296FA0-0x0000000180296FE0
		}
	
		// Constructors
		public ArrowHand(); // 0x0000000180582C30-0x0000000180582C60
	
		// Methods
		private void Awake(); // 0x0000000180581C60-0x0000000180581D00
		private void OnAttachedToHand(Hand attachedHand); // 0x0000000180582B40-0x0000000180582BA0
		private GameObject InstantiateArrow(); // 0x00000001805828E0-0x0000000180582B40
		private void HandAttachedUpdate(Hand hand); // 0x0000000180582130-0x00000001805828E0
		private void OnDetachedFromHand(Hand hand); // 0x0000000180582BA0-0x0000000180582C00
		private void FireArrow(); // 0x0000000180581D70-0x0000000180582130
		private void EnableArrowSpawn(); // 0x0000000180581D00-0x0000000180581D10
		[IteratorStateMachine] // 0x0000000180026290-0x00000001800262E0
		private IEnumerator ArrowReleaseHaptics(); // 0x0000000180581BF0-0x0000000180581C60
		private void OnHandFocusLost(Hand hand); // 0x0000000180355980-0x00000001803559B0
		private void OnHandFocusAcquired(Hand hand); // 0x0000000180582C00-0x0000000180582C30
		private void FindBow(); // 0x0000000180581D10-0x0000000180581D70
	}
}
