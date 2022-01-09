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
	public class BalloonColliders : MonoBehaviour // TypeDefIndex: 7472
	{
		// Fields
		public GameObject[] colliders; // 0x18
		private Vector3[] colliderLocalPositions; // 0x20
		private Quaternion[] colliderLocalRotations; // 0x28
		private Rigidbody rb; // 0x30
	
		// Constructors
		public BalloonColliders(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x0000000180584550-0x0000000180584810
		private void OnEnable(); // 0x0000000180584A60-0x0000000180584D90
		private void OnDisable(); // 0x00000001805848D0-0x0000000180584A60
		private void OnDestroy(); // 0x0000000180584810-0x00000001805848D0
	}
}
