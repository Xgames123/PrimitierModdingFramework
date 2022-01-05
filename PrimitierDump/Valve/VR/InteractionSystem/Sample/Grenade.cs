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
	public class Grenade : MonoBehaviour // TypeDefIndex: 7505
	{
		// Fields
		public GameObject explodePartPrefab; // 0x18
		public int explodeCount; // 0x20
		public float minMagnitudeToExplode; // 0x24
		private Interactable interactable; // 0x28
	
		// Constructors
		public Grenade(); // 0x0000000180591D30-0x0000000180591D50
	
		// Methods
		private void Start(); // 0x0000000180591CF0-0x0000000180591D30
		private void OnCollisionEnter(Collision collision); // 0x00000001805919C0-0x0000000180591CF0
	}
}
