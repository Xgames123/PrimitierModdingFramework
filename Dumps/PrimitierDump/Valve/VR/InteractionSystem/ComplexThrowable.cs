/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	[RequireComponent] // 0x0000000180024D10-0x0000000180024D60
	public class ComplexThrowable : MonoBehaviour // TypeDefIndex: 7387
	{
		// Fields
		public float attachForce; // 0x18
		public float attachForceDamper; // 0x1C
		public AttachMode attachMode; // 0x20
		[EnumFlags] // 0x0000000180024D60-0x0000000180024D70
		public Hand.AttachmentFlags attachmentFlags; // 0x24
		private List<Hand> holdingHands; // 0x28
		private List<Rigidbody> holdingBodies; // 0x30
		private List<Vector3> holdingPoints; // 0x38
		private List<Rigidbody> rigidBodies; // 0x40
	
		// Nested types
		public enum AttachMode // TypeDefIndex: 7386
		{
			FixedJoint = 0,
			Force = 1
		}
	
		// Constructors
		public ComplexThrowable(); // 0x000000018058ABF0-0x000000018058AD00
	
		// Methods
		private void Awake(); // 0x0000000180589CA0-0x0000000180589CE0
		private void Update(); // 0x000000018058A9A0-0x000000018058ABF0
		private void OnHandHoverBegin(Hand hand); // 0x000000018058A130-0x000000018058A1E0
		private void OnHandHoverEnd(Hand hand); // 0x000000018058A1E0-0x000000018058A290
		private void HandHoverUpdate(Hand hand); // 0x000000018058A0E0-0x000000018058A130
		private void PhysicsAttach(Hand hand, GrabTypes startingGrabType); // 0x000000018058A290-0x000000018058A7C0
		private bool PhysicsDetach(Hand hand); // 0x000000018058A7C0-0x000000018058A9A0
		private void FixedUpdate(); // 0x0000000180589CE0-0x000000018058A0E0
	}
}
