/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	[RequireComponent] // 0x0000000180025070-0x00000001800250C0
	public class HapticRack : MonoBehaviour // TypeDefIndex: 7414
	{
		// Fields
		[Tooltip] // 0x00000001800250C0-0x00000001800250F0
		public LinearMapping linearMapping; // 0x18
		[Tooltip] // 0x00000001800250F0-0x0000000180025120
		public int teethCount; // 0x20
		[Tooltip] // 0x0000000180025120-0x0000000180025150
		public int minimumPulseDuration; // 0x24
		[Tooltip] // 0x0000000180025150-0x0000000180025180
		public int maximumPulseDuration; // 0x28
		[Tooltip] // 0x0000000180025180-0x00000001800251B0
		public UnityEvent onPulse; // 0x30
		private Hand hand; // 0x38
		private int previousToothIndex; // 0x40
	
		// Constructors
		public HapticRack(); // 0x0000000180355950-0x0000000180355980
	
		// Methods
		private void Awake(); // 0x00000001803556D0-0x0000000180355760
		private void OnHandHoverBegin(Hand hand); // 0x00000001802A43D0-0x00000001802A43E0
		private void OnHandHoverEnd(Hand hand); // 0x0000000180355760-0x0000000180355770
		private void Update(); // 0x0000000180355840-0x0000000180355950
		private void Pulse(); // 0x0000000180355770-0x0000000180355840
	}
}
