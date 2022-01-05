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
	[RequireComponent] // 0x0000000180025F80-0x0000000180025FD0
	public class UIElement : MonoBehaviour // TypeDefIndex: 7449
	{
		// Fields
		public CustomEvents.UnityEventHand onHandClick; // 0x18
		protected Hand currentHand; // 0x20
	
		// Constructors
		public UIElement(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		protected virtual void Awake(); // 0x000000018029EA70-0x000000018029EB60
		protected virtual void OnHandHoverBegin(Hand hand); // 0x000000018029ECF0-0x000000018029EDE0
		protected virtual void OnHandHoverEnd(Hand hand); // 0x000000018029EDE0-0x000000018029EEE0
		protected virtual void HandHoverUpdate(Hand hand); // 0x000000018029EB60-0x000000018029ECA0
		protected virtual void OnButtonClick(); // 0x000000018029ECA0-0x000000018029ECF0
	}
}
