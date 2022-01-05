/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace SciFiArsenal
{
	public class SciFiProjectileScript : MonoBehaviour // TypeDefIndex: 8775
	{
		// Fields
		public GameObject impactParticle; // 0x18
		public GameObject projectileParticle; // 0x20
		public GameObject muzzleParticle; // 0x28
		public GameObject[] trailParticles; // 0x30
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Vector3 impactNormal; // 0x38
		private bool hasCollided; // 0x44
	
		// Constructors
		public SciFiProjectileScript(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x0000000180B512F0-0x0000000180B515A0
		private void OnCollisionEnter(Collision hit); // 0x0000000180B50E70-0x0000000180B512F0
	}
}
