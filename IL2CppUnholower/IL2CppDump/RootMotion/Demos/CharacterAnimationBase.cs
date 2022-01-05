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
	public abstract class CharacterAnimationBase : MonoBehaviour // TypeDefIndex: 8361
	{
		// Fields
		public bool smoothFollow; // 0x18
		public float smoothFollowSpeed; // 0x1C
		protected bool animatePhysics; // 0x20
		private Vector3 lastPosition; // 0x24
		private Vector3 localPosition; // 0x30
		private Quaternion localRotation; // 0x3C
		private Quaternion lastRotation; // 0x4C
	
		// Properties
		public virtual bool animationGrounded { get; } // 0x00000001802942D0-0x00000001802942E0 
	
		// Constructors
		protected CharacterAnimationBase(); // 0x00000001807D03F0-0x00000001807D0410
	
		// Methods
		public virtual Vector3 GetPivotPoint(); // 0x00000001807CFEA0-0x00000001807CFEF0
		public float GetAngleFromForward(Vector3 worldDirection); // 0x00000001807CFE30-0x00000001807CFEA0
		protected virtual void Start(); // 0x00000001807D0160-0x00000001807D03F0
		protected virtual void LateUpdate(); // 0x00000001807CFEF0-0x00000001807CFF00
		protected virtual void FixedUpdate(); // 0x00000001807CFE20-0x00000001807CFE30
		private void SmoothFollow(); // 0x00000001807CFF00-0x00000001807D0160
	}
}
