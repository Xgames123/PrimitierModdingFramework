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
	public class LockToPoint : MonoBehaviour // TypeDefIndex: 7500
	{
		// Fields
		public Transform snapTo; // 0x18
		private Rigidbody body; // 0x20
		public float snapTime; // 0x28
		private float dropTimer; // 0x2C
		private Interactable interactable; // 0x30
	
		// Constructors
		public LockToPoint(); // 0x000000018035DFC0-0x000000018035DFD0
	
		// Methods
		private void Start(); // 0x000000018035DF60-0x000000018035DFC0
		private void FixedUpdate(); // 0x000000018035DAA0-0x000000018035DF60
	}
}
