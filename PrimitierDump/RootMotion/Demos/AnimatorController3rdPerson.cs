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
	[RequireComponent] // 0x000000018001C310-0x000000018001C360
	public class AnimatorController3rdPerson : MonoBehaviour // TypeDefIndex: 8310
	{
		// Fields
		public float rotateSpeed; // 0x18
		public float blendSpeed; // 0x1C
		public float maxAngle; // 0x20
		public float moveSpeed; // 0x24
		public float rootMotionWeight; // 0x28
		protected Animator animator; // 0x30
		protected Vector3 moveBlend; // 0x38
		protected Vector3 moveInput; // 0x44
		protected Vector3 velocity; // 0x50
	
		// Constructors
		public AnimatorController3rdPerson(); // 0x00000001807BFB10-0x00000001807BFB40
	
		// Methods
		protected virtual void Start(); // 0x00000001807BFAD0-0x00000001807BFB10
		private void OnAnimatorMove(); // 0x00000001807BF860-0x00000001807BFAD0
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget); // 0x00000001807BF5E0-0x00000001807BF860
	}
}
