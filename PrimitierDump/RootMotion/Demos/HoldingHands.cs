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
	public class HoldingHands : MonoBehaviour // TypeDefIndex: 8324
	{
		// Fields
		public FullBodyBipedIK rightHandChar; // 0x18
		public FullBodyBipedIK leftHandChar; // 0x20
		public Transform rightHandTarget; // 0x28
		public Transform leftHandTarget; // 0x30
		public float crossFade; // 0x38
		public float speed; // 0x3C
		private Quaternion rightHandRotation; // 0x40
		private Quaternion leftHandRotation; // 0x50
	
		// Constructors
		public HoldingHands(); // 0x00000001808672E0-0x00000001808672F0
	
		// Methods
		private void Start(); // 0x0000000180867160-0x00000001808672E0
		private void LateUpdate(); // 0x0000000180866D00-0x0000000180867160
	}
}
