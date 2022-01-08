/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018001C360-0x000000018001C3F0
	[RequireComponent] // 0x000000018001C360-0x000000018001C3F0
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson // TypeDefIndex: 8311
	{
		// Fields
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float headLookWeight; // 0x60
		public Vector3 gunHoldOffset; // 0x64
		public Vector3 leftHandOffset; // 0x70
		public Recoil recoil; // 0x80
		private AimIK aim; // 0x88
		private FullBodyBipedIK ik; // 0x90
		private Vector3 headLookAxis; // 0x98
		private Vector3 leftHandPosRelToRightHand; // 0xA4
		private Quaternion leftHandRotRelToRightHand; // 0xB0
		private Vector3 aimTarget; // 0xC0
		private Quaternion rightHandRotation; // 0xCC
	
		// Constructors
		public AnimatorController3rdPersonIK(); // 0x00000001807BF5B0-0x00000001807BF5E0
	
		// Methods
		protected override void Start(); // 0x00000001807BF380-0x00000001807BF5B0
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget); // 0x00000001807BEB10-0x00000001807BED70
		private void Read(); // 0x00000001807BF210-0x00000001807BF380
		private void AimIK(); // 0x00000001807BE4A0-0x00000001807BE500
		private void FBBIK(); // 0x00000001807BE500-0x00000001807BE8E0
		private void OnPreRead(); // 0x00000001807BEE90-0x00000001807BF210
		private void HeadLookAt(Vector3 lookAtTarget); // 0x00000001807BE8E0-0x00000001807BEB10
		private void OnDestroy(); // 0x00000001807BED70-0x00000001807BEE90
	}
}
