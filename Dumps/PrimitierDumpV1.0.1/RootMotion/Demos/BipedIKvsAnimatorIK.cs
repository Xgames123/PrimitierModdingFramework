/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class BipedIKvsAnimatorIK : MonoBehaviour // TypeDefIndex: 8301
	{
		// Fields
		[LargeHeader] // 0x000000018001C030-0x000000018001C060
		public Animator animator; // 0x18
		public BipedIK bipedIK; // 0x20
		[LargeHeader] // 0x000000018001C060-0x000000018001C090
		public Transform lookAtTargetBiped; // 0x28
		public Transform lookAtTargetAnimator; // 0x30
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float lookAtWeight; // 0x38
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float lookAtBodyWeight; // 0x3C
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float lookAtHeadWeight; // 0x40
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float lookAtEyesWeight; // 0x44
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float lookAtClampWeight; // 0x48
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float lookAtClampWeightHead; // 0x4C
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float lookAtClampWeightEyes; // 0x50
		[LargeHeader] // 0x000000018001C090-0x000000018001C0C0
		public Transform footTargetBiped; // 0x58
		public Transform footTargetAnimator; // 0x60
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float footPositionWeight; // 0x68
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float footRotationWeight; // 0x6C
		[LargeHeader] // 0x000000018001C0C0-0x000000018001C0F0
		public Transform handTargetBiped; // 0x70
		public Transform handTargetAnimator; // 0x78
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float handPositionWeight; // 0x80
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float handRotationWeight; // 0x84
	
		// Constructors
		public BipedIKvsAnimatorIK(); // 0x00000001807C24F0-0x00000001807C2530
	
		// Methods
		private void OnAnimatorIK(int layer); // 0x00000001807C1CE0-0x00000001807C24F0
	}
}
