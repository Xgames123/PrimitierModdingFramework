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
	[RequireComponent] // 0x00000001800269C0-0x0000000180026A10
	public class InteractableExample : MonoBehaviour // TypeDefIndex: 7527
	{
		// Fields
		private TextMesh generalText; // 0x18
		private TextMesh hoveringText; // 0x20
		private Vector3 oldPosition; // 0x28
		private Quaternion oldRotation; // 0x34
		private float attachTime; // 0x44
		private Valve.VR.InteractionSystem.Hand.AttachmentFlags attachmentFlags; // 0x48
		private Interactable interactable; // 0x50
		private bool lastHovering; // 0x58
	
		// Constructors
		public InteractableExample(); // 0x0000000180357AA0-0x0000000180357AB0
	
		// Methods
		private void Awake(); // 0x0000000180357450-0x0000000180357540
		private void OnHandHoverBegin(Valve.VR.InteractionSystem.Hand hand); // 0x0000000180357910-0x0000000180357990
		private void OnHandHoverEnd(Valve.VR.InteractionSystem.Hand hand); // 0x0000000180357990-0x00000001803579E0
		private void HandHoverUpdate(Valve.VR.InteractionSystem.Hand hand); // 0x0000000180357600-0x0000000180357800
		private void OnAttachedToHand(Valve.VR.InteractionSystem.Hand hand); // 0x0000000180357800-0x0000000180357890
		private void OnDetachedFromHand(Valve.VR.InteractionSystem.Hand hand); // 0x0000000180357890-0x0000000180357910
		private void HandAttachedUpdate(Valve.VR.InteractionSystem.Hand hand); // 0x0000000180357540-0x0000000180357600
		private void Update(); // 0x00000001803579E0-0x0000000180357AA0
		private void OnHandFocusAcquired(Valve.VR.InteractionSystem.Hand hand); // 0x0000000180265310-0x0000000180265320
		private void OnHandFocusLost(Valve.VR.InteractionSystem.Hand hand); // 0x0000000180265310-0x0000000180265320
	}
}
