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
	[RequireComponent] // 0x000000018001CE90-0x000000018001CEE0
	public class CharacterAnimationThirdPerson : CharacterAnimationBase // TypeDefIndex: 8363
	{
		// Fields
		public CharacterThirdPerson characterController; // 0x60
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float turnSensitivity; // 0x68
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float turnSpeed; // 0x6C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float runCycleLegOffset; // 0x70
		[Range] // 0x000000018001CEE0-0x000000018001CF20
		[SerializeField] // 0x000000018001CEE0-0x000000018001CF20
		private float animSpeedMultiplier; // 0x74
		protected Animator animator; // 0x78
		private Vector3 lastForward; // 0x80
		private const string groundedDirectional = "Grounded Directional"; // Metadata: 0x003A6A76
		private const string groundedStrafe = "Grounded Strafe"; // Metadata: 0x003A6A8E
		private float deltaAngle; // 0x8C
	
		// Properties
		public override bool animationGrounded { get; } // 0x00000001807D12F0-0x00000001807D13F0 
	
		// Constructors
		public CharacterAnimationThirdPerson(); // 0x00000001807D0BB0-0x00000001807D0BE0
	
		// Methods
		protected override void Start(); // 0x00000001807D0D50-0x00000001807D0DE0
		public override Vector3 GetPivotPoint(); // 0x00000001807D0BE0-0x00000001807D0C20
		protected virtual void Update(); // 0x00000001807D0DE0-0x00000001807D12F0
		private void OnAnimatorMove(); // 0x00000001807D0C20-0x00000001807D0D50
	}
}
