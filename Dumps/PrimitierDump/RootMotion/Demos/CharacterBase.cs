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
	[RequireComponent] // 0x000000018001CF20-0x000000018001CFB0
	[RequireComponent] // 0x000000018001CF20-0x000000018001CFB0
	public abstract class CharacterBase : MonoBehaviour // TypeDefIndex: 8364
	{
		// Fields
		[Header] // 0x000000018001CFB0-0x000000018001D010
		[Tooltip] // 0x000000018001CFB0-0x000000018001D010
		public Transform gravityTarget; // 0x18
		[SerializeField] // 0x000000018001D010-0x000000018001D060
		[Tooltip] // 0x000000018001D010-0x000000018001D060
		protected float gravityMultiplier; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float airborneThreshold; // 0x24
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float slopeStartAngle; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float slopeEndAngle; // 0x2C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float spherecastRadius; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private LayerMask groundLayers; // 0x34
		private PhysicMaterial zeroFrictionMaterial; // 0x38
		private PhysicMaterial highFrictionMaterial; // 0x40
		protected Rigidbody r; // 0x48
		protected const float half = 0.5f; // Metadata: 0x003A6AA1
		protected float originalHeight; // 0x50
		protected Vector3 originalCenter; // 0x54
		protected CapsuleCollider capsule; // 0x60
	
		// Constructors
		protected CharacterBase(); // 0x00000001807D1F00-0x00000001807D1F30
	
		// Methods
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);
		protected Vector3 GetGravity(); // 0x00000001807D13F0-0x00000001807D15C0
		protected virtual void Start(); // 0x00000001807D1D00-0x00000001807D1ED0
		protected virtual RaycastHit GetSpherecastHit(); // 0x00000001807D1650-0x00000001807D1940
		public float GetAngleFromForward(Vector3 worldDirection); // 0x00000001807CFE30-0x00000001807CFEA0
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle); // 0x00000001807D1970-0x00000001807D1B50
		protected void ScaleCapsule(float mlp); // 0x00000001807D1B50-0x00000001807D1D00
		protected void HighFriction(); // 0x00000001807D1940-0x00000001807D1970
		protected void ZeroFriction(); // 0x00000001807D1ED0-0x00000001807D1F00
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal); // 0x00000001807D15C0-0x00000001807D1650
	}
}
