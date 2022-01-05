/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	[RequireComponent] // 0x0000000180024E60-0x0000000180024EB0
	public class Equippable : MonoBehaviour // TypeDefIndex: 7401
	{
		// Fields
		[Tooltip] // 0x0000000180024EB0-0x0000000180024EE0
		public Transform[] antiFlip; // 0x18
		public WhichHand defaultHand; // 0x20
		private Vector3 initialScale; // 0x24
		private Interactable interactable; // 0x30
	
		// Properties
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public SteamVR_Input_Sources attachedHandType { get; } // 0x0000000180590630-0x00000001805906D0 
	
		// Constructors
		public Equippable(); // 0x0000000180590620-0x0000000180590630
	
		// Methods
		private void Start(); // 0x0000000180590350-0x00000001805903D0
		private void Update(); // 0x00000001805903D0-0x0000000180590620
	}
}
