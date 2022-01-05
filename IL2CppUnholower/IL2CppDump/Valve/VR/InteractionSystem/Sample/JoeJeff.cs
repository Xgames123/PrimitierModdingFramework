/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR.InteractionSystem;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class JoeJeff : MonoBehaviour // TypeDefIndex: 7506
	{
		// Fields
		public float animationSpeed; // 0x18
		public float jumpVelocity; // 0x1C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_MovingTurnSpeed; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_StationaryTurnSpeed; // 0x24
		public float airControl; // 0x28
		[Tooltip] // 0x0000000180026800-0x0000000180026830
		public float frictionTime; // 0x2C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float footHeight; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float footRadius; // 0x34
		private RaycastHit footHit; // 0x38
		private bool isGrounded; // 0x64
		private float turnAmount; // 0x68
		private float forwardAmount; // 0x6C
		private float groundedTime; // 0x70
		private Animator animator; // 0x78
		private Vector3 input; // 0x80
		private bool held; // 0x8C
		private Rigidbody rigidbody; // 0x90
		private Interactable interactable; // 0x98
		public FireSource fire; // 0xA0
		private float jumpTimer; // 0xA8
	
		// Constructors
		public JoeJeff(); // 0x000000018035C8E0-0x000000018035C910
	
		// Methods
		private void Start(); // 0x000000018035C3F0-0x000000018035C490
		private void Update(); // 0x000000018035C6E0-0x000000018035C8E0
		private void FixRotation(); // 0x000000018035BAC0-0x000000018035BC00
		public void OnAnimatorMove(); // 0x000000018035C110-0x000000018035C3F0
		public void Move(Vector3 move, bool jump); // 0x000000018035BF80-0x000000018035C110
		private void UpdateAnimator(Vector3 move); // 0x000000018035C490-0x000000018035C6E0
		private void ApplyExtraTurnRotation(); // 0x000000018035B7D0-0x000000018035B860
		private void CheckGrounded(); // 0x000000018035B860-0x000000018035BAC0
		private void FixedUpdate(); // 0x000000018035BC00-0x000000018035BDF0
		private void HandleGroundedMovement(bool jump); // 0x000000018035BDF0-0x000000018035BE10
		public void Jump(); // 0x000000018035BE10-0x000000018035BF80
	}
}
