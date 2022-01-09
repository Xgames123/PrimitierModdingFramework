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
	public class FBIKBoxing : MonoBehaviour // TypeDefIndex: 8319
	{
		// Fields
		[Tooltip] // 0x000000018001C490-0x000000018001C4C0
		public Transform target; // 0x18
		[Tooltip] // 0x000000018001C4C0-0x000000018001C4F0
		public Transform pin; // 0x20
		[Tooltip] // 0x000000018001C4F0-0x000000018001C520
		public FullBodyBipedIK ik; // 0x28
		[Tooltip] // 0x000000018001C520-0x000000018001C550
		public AimIK aim; // 0x30
		[Tooltip] // 0x000000018001C550-0x000000018001C580
		public float weight; // 0x38
		[Tooltip] // 0x000000018001C580-0x000000018001C5B0
		public FullBodyBipedEffector effector; // 0x3C
		[Tooltip] // 0x000000018001C5B0-0x000000018001C5E0
		public AnimationCurve aimWeight; // 0x40
		private Animator animator; // 0x48
	
		// Constructors
		public FBIKBoxing(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x000000018081C2A0-0x000000018081C2E0
		private void LateUpdate(); // 0x000000018081C090-0x000000018081C2A0
	}
}
