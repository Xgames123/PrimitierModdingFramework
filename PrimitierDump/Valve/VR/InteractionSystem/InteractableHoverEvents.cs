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
	[RequireComponent] // 0x0000000180025440-0x0000000180025490
	public class InteractableHoverEvents : MonoBehaviour // TypeDefIndex: 7423
	{
		// Fields
		public UnityEvent onHandHoverBegin; // 0x18
		public UnityEvent onHandHoverEnd; // 0x20
		public UnityEvent onAttachedToHand; // 0x28
		public UnityEvent onDetachedFromHand; // 0x30
	
		// Constructors
		public InteractableHoverEvents(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void OnHandHoverBegin(); // 0x0000000180357AF0-0x0000000180357B10
		private void OnHandHoverEnd(); // 0x0000000180357B10-0x0000000180357B30
		private void OnAttachedToHand(Hand hand); // 0x0000000180357AB0-0x0000000180357AD0
		private void OnDetachedFromHand(Hand hand); // 0x0000000180357AD0-0x0000000180357AF0
	}
}
