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
	[RequireComponent] // 0x00000001800262E0-0x0000000180026330
	public class Longbow : MonoBehaviour // TypeDefIndex: 7479
	{
		// Fields
		public Handedness currentHandGuess; // 0x18
		private float timeOfPossibleHandSwitch; // 0x1C
		private float timeBeforeConfirmingHandSwitch; // 0x20
		private bool possibleHandSwitch; // 0x24
		public Transform pivotTransform; // 0x28
		public Transform handleTransform; // 0x30
		private Hand hand; // 0x38
		private ArrowHand arrowHand; // 0x40
		public Transform nockTransform; // 0x48
		public Transform nockRestTransform; // 0x50
		public bool autoSpawnArrowHand; // 0x58
		public ItemPackage arrowHandItemPackage; // 0x60
		public GameObject arrowHandPrefab; // 0x68
		public bool nocked; // 0x70
		public bool pulled; // 0x71
		private const float minPull = 0.05f; // Metadata: 0x003A5AFF
		private const float maxPull = 0.5f; // Metadata: 0x003A5B03
		private float nockDistanceTravelled; // 0x74
		private float hapticDistanceThreshold; // 0x78
		private float lastTickDistance; // 0x7C
		private const float bowPullPulseStrengthLow = 100f; // Metadata: 0x003A5B07
		private const float bowPullPulseStrengthHigh = 500f; // Metadata: 0x003A5B0B
		private Vector3 bowLeftVector; // 0x80
		public float arrowMinVelocity; // 0x8C
		public float arrowMaxVelocity; // 0x90
		private float arrowVelocity; // 0x94
		private float minStrainTickTime; // 0x98
		private float maxStrainTickTime; // 0x9C
		private float nextStrainTick; // 0xA0
		private bool lerpBackToZeroRotation; // 0xA4
		private float lerpStartTime; // 0xA8
		private float lerpDuration; // 0xAC
		private Quaternion lerpStartRotation; // 0xB0
		private float nockLerpStartTime; // 0xC0
		private Quaternion nockLerpStartRotation; // 0xC4
		public float drawOffset; // 0xD4
		public LinearMapping bowDrawLinearMapping; // 0xD8
		private Vector3 lateUpdatePos; // 0xE0
		private Quaternion lateUpdateRot; // 0xEC
		public SoundBowClick drawSound; // 0x100
		private float drawTension; // 0x108
		public SoundPlayOneshot arrowSlideSound; // 0x110
		public SoundPlayOneshot releaseSound; // 0x118
		public SoundPlayOneshot nockSound; // 0x120
		private SteamVR_Events.Action newPosesAppliedAction; // 0x128
	
		// Nested types
		public enum Handedness // TypeDefIndex: 7477
		{
			Left = 0,
			Right = 1
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ResetDrawAnim_d__49 : IEnumerator<object> // TypeDefIndex: 7478
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Longbow __4__this; // 0x20
			private float _startTime_5__2; // 0x28
			private float _startLerp_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ResetDrawAnim_d__49(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029BD90-0x000000018029BE90
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029BE90-0x000000018029BED0
		}
	
		// Constructors
		public Longbow(); // 0x000000018035F330-0x000000018035F390
	
		// Methods
		private void OnAttachedToHand(Hand attachedHand); // 0x00000001802A43D0-0x00000001802A43E0
		private void HandAttachedUpdate(Hand hand); // 0x000000018035E370-0x000000018035EDF0
		public void ArrowReleased(); // 0x000000018035E0C0-0x000000018035E210
		[IteratorStateMachine] // 0x0000000180026330-0x0000000180026380
		private IEnumerator ResetDrawAnim(); // 0x000000018035EF60-0x000000018035EFD0
		public float GetArrowVelocity(); // 0x000000018035E360-0x000000018035E370
		public void StartRotationLerp(); // 0x000000018035F2D0-0x000000018035F330
		public void StartNock(ArrowHand currentArrowHand); // 0x000000018035F1C0-0x000000018035F2D0
		private void EvaluateHandedness(); // 0x000000018035E280-0x000000018035E360
		private void DoHandednessCheck(); // 0x000000018035E210-0x000000018035E280
		public void ArrowInPosition(); // 0x000000018035DFD0-0x000000018035E0C0
		public void ReleaseNock(); // 0x000000018035EEA0-0x000000018035EF60
		private void ShutDown(); // 0x000000018035EFD0-0x000000018035F1C0
		private void OnHandFocusLost(Hand hand); // 0x0000000180355980-0x00000001803559B0
		private void OnHandFocusAcquired(Hand hand); // 0x000000018035EE60-0x000000018035EEA0
		private void OnDetachedFromHand(Hand hand); // 0x000000018035EE00-0x000000018035EE60
		private void OnDestroy(); // 0x000000018035EDF0-0x000000018035EE00
	}
}
