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
	public class TargetHitEffect : MonoBehaviour // TypeDefIndex: 7532
	{
		// Fields
		public Collider targetCollider; // 0x18
		public GameObject spawnObjectOnCollision; // 0x20
		public bool colorSpawnedObject; // 0x28
		public bool destroyOnTargetCollision; // 0x29
	
		// Constructors
		public TargetHitEffect(); // 0x0000000180C74630-0x0000000180C74640
	
		// Methods
		private void OnCollisionEnter(Collision collision); // 0x0000000180C77EF0-0x0000000180C787A0
	}
}
