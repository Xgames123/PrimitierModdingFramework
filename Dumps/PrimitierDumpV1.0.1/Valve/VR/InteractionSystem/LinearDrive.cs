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
	[RequireComponent] // 0x00000001800254E0-0x0000000180025530
	public class LinearDrive : MonoBehaviour // TypeDefIndex: 7433
	{
		// Fields
		public Transform startPosition; // 0x18
		public Transform endPosition; // 0x20
		public LinearMapping linearMapping; // 0x28
		public bool repositionGameObject; // 0x30
		public bool maintainMomemntum; // 0x31
		public float momemtumDampenRate; // 0x34
		protected Hand.AttachmentFlags attachmentFlags; // 0x38
		protected float initialMappingOffset; // 0x3C
		protected int numMappingChangeSamples; // 0x40
		protected float[] mappingChangeSamples; // 0x48
		protected float prevMapping; // 0x50
		protected float mappingChangeRate; // 0x54
		protected int sampleCount; // 0x58
		protected Interactable interactable; // 0x60
	
		// Constructors
		public LinearDrive(); // 0x000000018035DA70-0x000000018035DAA0
	
		// Methods
		protected virtual void Awake(); // 0x000000018035D1A0-0x000000018035D200
		protected virtual void Start(); // 0x000000018035D5A0-0x000000018035D6C0
		protected virtual void HandHoverUpdate(Hand hand); // 0x000000018035D480-0x000000018035D5A0
		protected virtual void HandAttachedUpdate(Hand hand); // 0x000000018035D400-0x000000018035D480
		protected virtual void OnDetachedFromHand(Hand hand); // 0x000000018035D370-0x000000018035D400
		protected void CalculateMappingChangeRate(); // 0x000000018035D370-0x000000018035D400
		protected void UpdateLinearMapping(Transform updateTransform); // 0x000000018035D6C0-0x000000018035D8A0
		protected float CalculateLinearMapping(Transform updateTransform); // 0x000000018035D200-0x000000018035D370
		protected virtual void Update(); // 0x000000018035D8A0-0x000000018035DA70
	}
}
