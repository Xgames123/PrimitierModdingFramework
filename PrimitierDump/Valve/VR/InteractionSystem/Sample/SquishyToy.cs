/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class SquishyToy : MonoBehaviour // TypeDefIndex: 7534
	{
		// Fields
		public Interactable interactable; // 0x18
		public SkinnedMeshRenderer renderer; // 0x20
		public bool affectMaterial; // 0x28
		public SteamVR_Action_Single gripSqueeze; // 0x30
		public SteamVR_Action_Single pinchSqueeze; // 0x38
		private Rigidbody rigidbody; // 0x40
	
		// Constructors
		public SquishyToy(); // 0x0000000180366FB0-0x0000000180367050
	
		// Methods
		private void Start(); // 0x0000000180366BC0-0x0000000180366CF0
		private void Update(); // 0x0000000180366CF0-0x0000000180366FB0
	}
}
