/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class HandCollider : MonoBehaviour // TypeDefIndex: 7412
	{
		// Fields
		private Rigidbody rigidbody; // 0x18
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public HandPhysics hand; // 0x20
		public LayerMask collisionMask; // 0x28
		private Collider[] colliders; // 0x30
		public FingerColliders fingerColliders; // 0x38
		private static PhysicMaterial physicMaterial_lowfriction; // 0x00
		private static PhysicMaterial physicMaterial_highfriction; // 0x08
		private float scale; // 0x40
		private Vector3 center; // 0x44
		private Vector3 targetPosition; // 0x50
		private Quaternion targetRotation; // 0x5C
		protected const float MaxVelocityChange = 10f; // Metadata: 0x003A5A03
		protected const float VelocityMagic = 6000f; // Metadata: 0x003A5A07
		protected const float AngularVelocityMagic = 50f; // Metadata: 0x003A5A0B
		protected const float MaxAngularVelocityChange = 20f; // Metadata: 0x003A5A0F
		public bool collidersInRadius; // 0x6C
		private const float minCollisionEnergy = 0.1f; // Metadata: 0x003A5A13
		private const float maxCollisionEnergy = 1f; // Metadata: 0x003A5A17
		private const float minCollisionHapticsTime = 0.2f; // Metadata: 0x003A5A1B
		private float lastCollisionHapticsTime; // 0x70
	
		// Nested types
		[Serializable]
		public class FingerColliders // TypeDefIndex: 7411
		{
			// Fields
			[Tooltip] // 0x0000000180024FB0-0x0000000180024FE0
			public Transform[] thumbColliders; // 0x10
			[Tooltip] // 0x0000000180024FE0-0x0000000180025010
			public Transform[] indexColliders; // 0x18
			[Tooltip] // 0x0000000180024FE0-0x0000000180025010
			public Transform[] middleColliders; // 0x20
			[Tooltip] // 0x0000000180024FE0-0x0000000180025010
			public Transform[] ringColliders; // 0x28
			[Tooltip] // 0x0000000180024FE0-0x0000000180025010
			public Transform[] pinkyColliders; // 0x30
	
			// Properties
			public Transform[] this[int finger] { get => default; set {} } // 0x000000018028DF40-0x000000018028DF80 0x000000018028DF80-0x000000018028DFC0
	
			// Constructors
			public FingerColliders(); // 0x000000018028DEA0-0x000000018028DF40
		}
	
		// Constructors
		public HandCollider(); // 0x0000000180353FD0-0x0000000180354020
	
		// Methods
		private void Awake(); // 0x00000001803532C0-0x0000000180353320
		private void Start(); // 0x0000000180353B80-0x0000000180353EB0
		private void SetPhysicMaterial(PhysicMaterial mat); // 0x0000000180353AC0-0x0000000180353B80
		public void SetCollisionDetectionEnabled(bool value); // 0x0000000180353AA0-0x0000000180353AC0
		public void MoveTo(Vector3 position, Quaternion rotation); // 0x0000000180353810-0x0000000180353830
		public void TeleportTo(Vector3 position, Quaternion rotation); // 0x0000000180353EB0-0x0000000180353FD0
		public void Reset(); // 0x0000000180353A50-0x0000000180353A90
		public void SetCenterPoint(Vector3 newCenter); // 0x0000000180353A90-0x0000000180353AA0
		protected void ExecuteFixedUpdate(); // 0x0000000180353320-0x0000000180353580
		protected bool GetTargetVelocities(out Vector3 velocityTarget, out Vector3 angularTarget); // 0x0000000180353580-0x0000000180353810
		private void OnCollisionEnter(Collision collision); // 0x0000000180353830-0x0000000180353A50
	}
}
