/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class Arrow : MonoBehaviour // TypeDefIndex: 7466
	{
		// Fields
		public ParticleSystem glintParticle; // 0x18
		public Rigidbody arrowHeadRB; // 0x20
		public Rigidbody shaftRB; // 0x28
		public PhysicMaterial targetPhysMaterial; // 0x30
		private Vector3 prevPosition; // 0x38
		private Quaternion prevRotation; // 0x44
		private Vector3 prevVelocity; // 0x54
		private Vector3 prevHeadPosition; // 0x60
		public SoundPlayOneshot fireReleaseSound; // 0x70
		public SoundPlayOneshot airReleaseSound; // 0x78
		public SoundPlayOneshot hitTargetSound; // 0x80
		public PlaySound hitGroundSound; // 0x88
		private bool inFlight; // 0x90
		private bool released; // 0x91
		private bool hasSpreadFire; // 0x92
		private int travelledFrames; // 0x94
		private GameObject scaleParentObject; // 0x98
	
		// Constructors
		public Arrow(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x0000000180583C70-0x0000000180583CE0
		private void FixedUpdate(); // 0x0000000180583150-0x0000000180583270
		public void ArrowReleased(float inputVelocity); // 0x0000000180582C60-0x0000000180583150
		protected void SetCollisionMode(CollisionDetectionMode newMode, bool force = false /* Metadata: 0x003A5ABE */); // 0x0000000180583B80-0x0000000180583C70
		private void OnCollisionEnter(Collision collision); // 0x0000000180583270-0x0000000180583AE0
		private void StickInTarget(Collision collision, bool bSkipRayCast); // 0x0000000180583CE0-0x00000001805844C0
		private void OnDestroy(); // 0x0000000180583AE0-0x0000000180583B80
	}
}
