/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.Extras
{
	[RequireComponent] // 0x0000000180026AB0-0x0000000180026B00
	public class SteamVR_TestThrow : MonoBehaviour // TypeDefIndex: 7543
	{
		// Fields
		public GameObject prefab; // 0x18
		public Rigidbody attachPoint; // 0x20
		public SteamVR_Action_Boolean spawn; // 0x28
		private SteamVR_Behaviour_Pose trackedObj; // 0x30
		private FixedJoint joint; // 0x38
	
		// Constructors
		public SteamVR_TestThrow(); // 0x0000000180C741D0-0x0000000180C74260
	
		// Methods
		private void Awake(); // 0x0000000180C73D20-0x0000000180C73D60
		private void FixedUpdate(); // 0x0000000180C73D60-0x0000000180C741D0
	}
}
