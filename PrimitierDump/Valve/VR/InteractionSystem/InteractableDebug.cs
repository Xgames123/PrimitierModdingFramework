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
	public class InteractableDebug : MonoBehaviour // TypeDefIndex: 7422
	{
		// Fields
		[NonSerialized]
		public Hand attachedToHand; // 0x18
		public float simulateReleasesForXSecondsAroundRelease; // 0x20
		public float simulateReleasesEveryXSeconds; // 0x24
		public bool setPositionsForSimulations; // 0x28
		private Renderer[] selfRenderers; // 0x30
		private Collider[] colliders; // 0x38
		private Color lastColor; // 0x40
		private Throwable throwable; // 0x50
		private const bool onlyColorOnChange = true; // Metadata: 0x003A5A4B
		public Rigidbody rigidbody; // 0x58
		private bool isSimulation; // 0x60
	
		// Properties
		private bool isThrowable { get; } // 0x00000001803573F0-0x0000000180357450 
	
		// Constructors
		public InteractableDebug(); // 0x00000001803573E0-0x00000001803573F0
	
		// Methods
		private void Awake(); // 0x0000000180356400-0x00000001803564A0
		private void OnAttachedToHand(Hand hand); // 0x0000000180356F40-0x0000000180357000
		protected virtual void HandAttachedUpdate(Hand hand); // 0x0000000180356C80-0x0000000180356E80
		private void OnDetachedFromHand(Hand hand); // 0x0000000180357000-0x00000001803573D0
		public Collider[] GetColliders(); // 0x0000000180268FE0-0x0000000180268FF0
		public void IgnoreObject(InteractableDebug otherInteractable); // 0x0000000180356E80-0x0000000180356F40
		public void SetIsSimulation(); // 0x00000001803573D0-0x00000001803573E0
		private InteractableDebug CreateSimulation(Hand fromHand, float timeOffset, Color copyColor); // 0x0000000180356A10-0x0000000180356C80
		private void CreateMarker(Color markerColor, float destroyAfter = 10f /* Metadata: 0x003A5A43 */); // 0x0000000180356960-0x0000000180356A10
		private void CreateMarker(Color markerColor, Vector3 forward, float destroyAfter = 10f /* Metadata: 0x003A5A47 */); // 0x00000001803565C0-0x0000000180356960
		private void ColorSelf(Color newColor); // 0x00000001803564A0-0x0000000180356530
		private void ColorThing(Color newColor, Renderer[] renderers); // 0x0000000180356530-0x00000001803565C0
	}
}
