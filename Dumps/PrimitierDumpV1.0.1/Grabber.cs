/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using Valve.VR;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Grabber : MonoBehaviour // TypeDefIndex: 8655
{
	// Fields
	public Transform realHand; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Vector3 colliderCenter; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float colliderRadius; // 0x2C
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Vector3 rayDirection; // 0x30
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject tip; // 0x40
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject ray; // 0x48
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Input_Sources source; // 0x50
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Action_Boolean grabAction; // 0x58
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Action_Boolean bondAction; // 0x60
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform ikTarget; // 0x68
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private readonly float handFollowDistance; // 0x70
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private readonly float remoteGrabDistance; // 0x74
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private readonly float releaseDistance; // 0x78
	[NonSerialized]
	public Collider touchingCollider; // 0x80
	[NonSerialized]
	public Collider grabbingCollider; // 0x88
	private Joint joint; // 0x90
	private ParentConstraint ikTargetConstraint; // 0x98
	private Rigidbody rb; // 0xA0
	private Bond bond; // 0xA8
	private Vector3 remoteGrabPos; // 0xB0
	private bool grabActionPrevState; // 0xBC
	private bool bondActionPrevState; // 0xBD

	// Nested types
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class _WakeUpDelayed_d__29 : IEnumerator<object> // TypeDefIndex: 8654
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		public Rigidbody rb; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 

		// Constructors
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		public _WakeUpDelayed_d__29(int __1__state); // 0x0000000180296FE0-0x0000000180297010

		// Methods
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
		private bool MoveNext(); // 0x00000001808888C0-0x0000000180888970
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IEnumerator.Reset(); // 0x0000000180888970-0x00000001808889B0
	}

	// Constructors
	public Grabber(); // 0x0000000180306B80-0x0000000180306BA0

	// Methods
	private void Start(); // 0x0000000180306480-0x00000001803064F0
	private void FixedUpdate(); // 0x0000000180305A30-0x00000001803060E0
	public void Grab(bool isRemote); // 0x00000001803060E0-0x00000001803061F0
	public void Release(); // 0x0000000180306250-0x0000000180306350
	private void ResetPoseAndVelocity(); // 0x0000000180306350-0x0000000180306480
	private void CheckTouchingCollider(); // 0x0000000180305490-0x00000001803057D0
	public void SwitchTarget(Collider col, bool isRemote = false /* Metadata: 0x003A6CED */); // 0x00000001803064F0-0x0000000180306B10
	[IteratorStateMachine] // 0x000000018002D7A0-0x000000018002D7F0
	private IEnumerator WakeUpDelayed(Rigidbody rb); // 0x0000000180306B10-0x0000000180306B80
	private void CastRemoteGrabber(); // 0x0000000180305070-0x0000000180305490
	private void DrawRay(Vector3 start, Vector3 end); // 0x00000001803057D0-0x0000000180305A30
	private bool IsGrabbing(); // 0x00000001803061F0-0x0000000180306250
}

