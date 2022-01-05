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
	[RequireComponent] // 0x00000001800251B0-0x0000000180025200
	public class HoverButton : MonoBehaviour // TypeDefIndex: 7416
	{
		// Fields
		public Transform movingPart; // 0x18
		public Vector3 localMoveDistance; // 0x20
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float engageAtPercent; // 0x2C
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float disengageAtPercent; // 0x30
		public HandEvent onButtonDown; // 0x38
		public HandEvent onButtonUp; // 0x40
		public HandEvent onButtonIsPressed; // 0x48
		public bool engaged; // 0x50
		public bool buttonDown; // 0x51
		public bool buttonUp; // 0x52
		private Vector3 startPosition; // 0x54
		private Vector3 endPosition; // 0x60
		private Vector3 handEnteredPosition; // 0x6C
		private bool hovering; // 0x78
		private Hand lastHoveredHand; // 0x80
	
		// Constructors
		public HoverButton(); // 0x0000000180355ED0-0x0000000180355F10
	
		// Methods
		private void Start(); // 0x0000000180355DA0-0x0000000180355ED0
		private void HandHoverUpdate(Hand hand); // 0x00000001803559B0-0x0000000180355C50
		private void LateUpdate(); // 0x0000000180355D30-0x0000000180355DA0
		private void InvokeEvents(bool wasEngaged, bool isEngaged); // 0x0000000180355C50-0x0000000180355D30
	}
}
