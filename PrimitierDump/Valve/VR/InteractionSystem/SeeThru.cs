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
	public class SeeThru : MonoBehaviour // TypeDefIndex: 7440
	{
		// Fields
		public Material seeThruMaterial; // 0x18
		private GameObject seeThru; // 0x20
		private Interactable interactable; // 0x28
		private Renderer sourceRenderer; // 0x30
		private Renderer destRenderer; // 0x38
	
		// Constructors
		public SeeThru(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x00000001803645B0-0x0000000180364C70
		private void OnEnable(); // 0x0000000180364E70-0x0000000180365040
		private void OnDisable(); // 0x0000000180364CA0-0x0000000180364E70
		private void AttachedToHand(Hand hand); // 0x0000000180364580-0x00000001803645B0
		private void DetachedFromHand(Hand hand); // 0x0000000180364C70-0x0000000180364CA0
		private void Update(); // 0x0000000180365040-0x00000001803652E0
	}
}
