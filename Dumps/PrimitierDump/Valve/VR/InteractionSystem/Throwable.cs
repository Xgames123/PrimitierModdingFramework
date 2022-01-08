/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	[RequireComponent] // 0x0000000180025D40-0x0000000180025DD0
	[RequireComponent] // 0x0000000180025D40-0x0000000180025DD0
	public class Throwable : MonoBehaviour // TypeDefIndex: 7447
	{
		// Fields
		[EnumFlags] // 0x0000000180025DD0-0x0000000180025E10
		[Tooltip] // 0x0000000180025DD0-0x0000000180025E10
		public Hand.AttachmentFlags attachmentFlags; // 0x18
		[Tooltip] // 0x0000000180025E10-0x0000000180025E40
		public Transform attachmentOffset; // 0x20
		[Tooltip] // 0x0000000180025E40-0x0000000180025E70
		public float catchingSpeedThreshold; // 0x28
		public ReleaseStyle releaseVelocityStyle; // 0x2C
		[Tooltip] // 0x0000000180025E70-0x0000000180025EA0
		public float releaseVelocityTimeOffset; // 0x30
		public float scaleReleaseVelocity; // 0x34
		[Tooltip] // 0x0000000180025EA0-0x0000000180025ED0
		public float scaleReleaseVelocityThreshold; // 0x38
		[Tooltip] // 0x0000000180025ED0-0x0000000180025F00
		public AnimationCurve scaleReleaseVelocityCurve; // 0x40
		[Tooltip] // 0x0000000180025F00-0x0000000180025F30
		public bool restoreOriginalParent; // 0x48
		protected VelocityEstimator velocityEstimator; // 0x50
		protected bool attached; // 0x58
		protected float attachTime; // 0x5C
		protected Vector3 attachPosition; // 0x60
		protected Quaternion attachRotation; // 0x6C
		protected Transform attachEaseInTransform; // 0x80
		public UnityEvent onPickUp; // 0x88
		public UnityEvent onDetachFromHand; // 0x90
		public HandEvent onHeldUpdate; // 0x98
		protected RigidbodyInterpolation hadInterpolation; // 0xA0
		protected Rigidbody rigidbody; // 0xA8
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Interactable interactable; // 0xB0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _LateDetach_d__29 : IEnumerator<object> // TypeDefIndex: 7446
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Hand hand; // 0x20
			public Throwable __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _LateDetach_d__29(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029A980-0x000000018029AA40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029AA40-0x000000018029AA80
		}
	
		// Constructors
		public Throwable(); // 0x00000001802962D0-0x0000000180296340
	
		// Methods
		protected virtual void Awake(); // 0x0000000180295630-0x0000000180295710
		protected virtual void OnHandHoverBegin(Hand hand); // 0x00000001802961A0-0x00000001802962B0
		protected virtual void OnHandHoverEnd(Hand hand); // 0x00000001802962B0-0x00000001802962D0
		protected virtual void HandHoverUpdate(Hand hand); // 0x0000000180295D00-0x0000000180295D80
		protected virtual void OnAttachedToHand(Hand hand); // 0x0000000180295DF0-0x0000000180295F40
		protected virtual void OnDetachedFromHand(Hand hand); // 0x0000000180295F40-0x0000000180296050
		public virtual void GetReleaseVelocities(Hand hand, out Vector3 velocity, out Vector3 angularVelocity); // 0x0000000180295710-0x0000000180295C60
		protected virtual void HandAttachedUpdate(Hand hand); // 0x0000000180295C60-0x0000000180295D00
		[IteratorStateMachine] // 0x0000000180025F30-0x0000000180025F80
		protected virtual IEnumerator LateDetach(Hand hand); // 0x0000000180295D80-0x0000000180295DF0
		protected virtual void OnHandFocusAcquired(Hand hand); // 0x0000000180296050-0x00000001802960F0
		protected virtual void OnHandFocusLost(Hand hand); // 0x00000001802960F0-0x00000001802961A0
	}
}
