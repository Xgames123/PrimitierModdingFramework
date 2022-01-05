/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class MotionAbsorbCharacter : MonoBehaviour // TypeDefIndex: 8333
	{
		// Fields
		public Animator animator; // 0x18
		public MotionAbsorb motionAbsorb; // 0x20
		public Transform cube; // 0x28
		public float cubeRandomPosition; // 0x30
		public AnimationCurve motionAbsorbWeight; // 0x38
		private Vector3 cubeDefaultPosition; // 0x40
		private AnimatorStateInfo info; // 0x4C
		private Rigidbody cubeRigidbody; // 0x70
	
		// Constructors
		public MotionAbsorbCharacter(); // 0x0000000180775530-0x0000000180775540
	
		// Methods
		private void Start(); // 0x00000001807752A0-0x0000000180775310
		private void Update(); // 0x0000000180775470-0x0000000180775530
		private void SwingStart(); // 0x0000000180775310-0x0000000180775470
	}
}
