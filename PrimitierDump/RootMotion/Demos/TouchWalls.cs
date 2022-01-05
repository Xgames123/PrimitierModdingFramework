/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class TouchWalls : MonoBehaviour // TypeDefIndex: 8347
	{
		// Fields
		public InteractionSystem interactionSystem; // 0x18
		public EffectorLink[] effectorLinks; // 0x20
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 8346
		{
			// Fields
			public bool enabled; // 0x10
			public FullBodyBipedEffector effectorType; // 0x14
			public InteractionObject interactionObject; // 0x18
			public Transform spherecastFrom; // 0x20
			public float spherecastRadius; // 0x28
			public float minDistance; // 0x2C
			public LayerMask touchLayers; // 0x30
			public float lerpSpeed; // 0x34
			public float minSwitchTime; // 0x38
			public float releaseDistance; // 0x3C
			public bool sliding; // 0x40
			private Vector3 raycastDirectionLocal; // 0x44
			private float raycastDistance; // 0x50
			private bool inTouch; // 0x54
			private RaycastHit hit; // 0x58
			private Vector3 targetPosition; // 0x84
			private Quaternion targetRotation; // 0x90
			private bool initiated; // 0xA0
			private float nextSwitchTime; // 0xA4
			private float speedF; // 0xA8
	
			// Constructors
			public EffectorLink(); // 0x0000000180840480-0x00000001808404B0
	
			// Methods
			public void Initiate(InteractionSystem interactionSystem); // 0x000000018083F630-0x000000018083F9E0
			private bool FindWalls(Vector3 direction); // 0x000000018083F510-0x000000018083F630
			public void Update(InteractionSystem interactionSystem); // 0x000000018083FCC0-0x0000000180840480
			private void StopTouch(InteractionSystem interactionSystem); // 0x000000018083FB60-0x000000018083FCC0
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x000000018083FA60-0x000000018083FAE0
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x000000018083F9E0-0x000000018083FA60
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x000000018083FAE0-0x000000018083FB60
			public void Destroy(InteractionSystem interactionSystem); // 0x000000018083F360-0x000000018083F510
		}
	
		// Constructors
		public TouchWalls(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x0000000180718660-0x00000001807186D0
		private void FixedUpdate(); // 0x0000000180718510-0x0000000180718590
		private void OnDestroy(); // 0x0000000180718590-0x0000000180718660
	}
}
