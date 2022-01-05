/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class BuggyBuddy : MonoBehaviour // TypeDefIndex: 7496
	{
		// Fields
		public Transform turret; // 0x18
		private float turretRot; // 0x20
		[Tooltip] // 0x0000000180026590-0x00000001800265C0
		public float maxAngle; // 0x24
		[Tooltip] // 0x00000001800265C0-0x00000001800265F0
		public float maxTurnTorque; // 0x28
		[Tooltip] // 0x00000001800265F0-0x0000000180026620
		public float maxTorque; // 0x2C
		[Tooltip] // 0x0000000180026620-0x0000000180026650
		public float brakeTorque; // 0x30
		[Tooltip] // 0x0000000180026650-0x0000000180026680
		public GameObject[] wheelRenders; // 0x38
		[Tooltip] // 0x0000000180026680-0x00000001800266B0
		public float criticalSpeed; // 0x40
		[Tooltip] // 0x00000001800266B0-0x00000001800266E0
		public int stepsBelow; // 0x44
		[Tooltip] // 0x00000001800266E0-0x0000000180026710
		public int stepsAbove; // 0x48
		private WheelCollider[] m_Wheels; // 0x50
		public AudioSource au_motor; // 0x58
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public float mvol; // 0x60
		public AudioSource au_skid; // 0x68
		private float svol; // 0x70
		public WheelDust skidsample; // 0x78
		private float skidSpeed; // 0x80
		public Vector3 localGravity; // 0x84
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Rigidbody body; // 0x90
		public float rapidfireTime; // 0x98
		private float shootTimer; // 0x9C
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Vector2 steer; // 0xA0
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public float throttle; // 0xA8
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public float handBrake; // 0xAC
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Transform controllerReference; // 0xB0
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public float speed; // 0xB8
		public Transform centerOfMass; // 0xC0
	
		// Constructors
		public BuggyBuddy(); // 0x0000000180586D90-0x0000000180586DE0
	
		// Methods
		private void Start(); // 0x0000000180586500-0x0000000180586690
		private void Update(); // 0x0000000180586690-0x0000000180586D90
		private void FixedUpdate(); // 0x00000001805864B0-0x0000000180586500
		public static float FindAngle(Vector3 fromVector, Vector3 toVector, Vector3 upVector); // 0x0000000180586370-0x00000001805864B0
	}
}
