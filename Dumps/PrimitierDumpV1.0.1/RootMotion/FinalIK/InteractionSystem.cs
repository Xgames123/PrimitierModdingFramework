/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x0000000180020FD0-0x0000000180021030
	[HelpURL] // 0x0000000180020FD0-0x0000000180021030
	public class InteractionSystem : MonoBehaviour // TypeDefIndex: 8483
	{
		// Fields
		[Tooltip] // 0x0000000180021030-0x0000000180021060
		public string targetTag; // 0x18
		[Tooltip] // 0x0000000180021060-0x0000000180021090
		public float fadeInTime; // 0x20
		[Tooltip] // 0x0000000180021090-0x00000001800210C0
		public float speed; // 0x24
		[Tooltip] // 0x00000001800210C0-0x00000001800210F0
		public float resetToDefaultsSpeed; // 0x28
		[FormerlySerializedAs] // 0x00000001800210F0-0x0000000180021170
		[Header] // 0x00000001800210F0-0x0000000180021170
		[Tooltip] // 0x00000001800210F0-0x0000000180021170
		public Collider characterCollider; // 0x30
		[FormerlySerializedAs] // 0x0000000180021170-0x00000001800211D0
		[Tooltip] // 0x0000000180021170-0x00000001800211D0
		public Transform FPSCamera; // 0x38
		[Tooltip] // 0x00000001800211D0-0x0000000180021200
		public LayerMask camRaycastLayers; // 0x40
		[Tooltip] // 0x0000000180021200-0x0000000180021230
		public float camRaycastDistance; // 0x44
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<InteractionTrigger> _triggersInRange_k__BackingField; // 0x48
		private List<InteractionTrigger> inContact; // 0x50
		private List<int> bestRangeIndexes; // 0x58
		public InteractionDelegate OnInteractionStart; // 0x60
		public InteractionDelegate OnInteractionPause; // 0x68
		public InteractionDelegate OnInteractionPickUp; // 0x70
		public InteractionDelegate OnInteractionResume; // 0x78
		public InteractionDelegate OnInteractionStop; // 0x80
		public InteractionEventDelegate OnInteractionEvent; // 0x88
		public RaycastHit raycastHit; // 0x90
		[SerializeField] // 0x0000000180021230-0x0000000180021290
		[Space] // 0x0000000180021230-0x0000000180021290
		[Tooltip] // 0x0000000180021230-0x0000000180021290
		private FullBodyBipedIK fullBody; // 0xC0
		[Tooltip] // 0x0000000180021290-0x00000001800212C0
		public InteractionLookAt lookAt; // 0xC8
		private InteractionEffector[] interactionEffectors; // 0xD0
		private bool initiated; // 0xD8
		private Collider lastCollider; // 0xE0
		private Collider c; // 0xE8
	
		// Properties
		public bool inInteraction { get; } // 0x000000018076F5A0-0x000000018076F690 
		public FullBodyBipedIK ik { get; set; } // 0x0000000180268300-0x0000000180268310 0x0000000180268380-0x0000000180268390
		public List<InteractionTrigger> triggersInRange { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
	
		// Nested types
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // TypeDefIndex: 8481; 0x0000000180840C20-0x0000000180840F10
	
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent); // TypeDefIndex: 8482; 0x0000000180840FB0-0x00000001808412E0
	
		// Constructors
		public InteractionSystem(); // 0x000000018076F090-0x000000018076F5A0
	
		// Methods
		[ContextMenu] // 0x0000000180020B80-0x0000000180020BB0
		private void OpenTutorial1(); // 0x000000018076CE90-0x000000018076CED0
		[ContextMenu] // 0x0000000180020BB0-0x0000000180020BE0
		private void OpenTutorial2(); // 0x000000018076CED0-0x000000018076CF10
		[ContextMenu] // 0x0000000180020BE0-0x0000000180020C10
		private void OpenTutorial3(); // 0x000000018076CF10-0x000000018076CF50
		[ContextMenu] // 0x0000000180020C10-0x0000000180020C40
		private void OpenTutorial4(); // 0x000000018076CF50-0x000000018076CF90
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x000000018076DB70-0x000000018076DBB0
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x000000018076AB90-0x000000018076ABD0
		public bool IsInInteraction(FullBodyBipedEffector effectorType); // 0x000000018076BA70-0x000000018076BB60
		public bool IsPaused(FullBodyBipedEffector effectorType); // 0x000000018076BD90-0x000000018076BE80
		public bool IsPaused(); // 0x000000018076BCA0-0x000000018076BD90
		public bool IsInSync(); // 0x000000018076BB60-0x000000018076BCA0
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt); // 0x000000018076D3A0-0x000000018076D4D0
		public bool PauseInteraction(FullBodyBipedEffector effectorType); // 0x000000018076D060-0x000000018076D110
		public bool ResumeInteraction(FullBodyBipedEffector effectorType); // 0x000000018076D2F0-0x000000018076D3A0
		public bool StopInteraction(FullBodyBipedEffector effectorType); // 0x000000018076DAC0-0x000000018076DB70
		public void PauseAll(); // 0x000000018076CFD0-0x000000018076D060
		public void ResumeAll(); // 0x000000018076D260-0x000000018076D2F0
		public void StopAll(); // 0x000000018076DA40-0x000000018076DAC0
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType); // 0x000000018076B680-0x000000018076B730
		public float GetProgress(FullBodyBipedEffector effectorType); // 0x000000018076B840-0x000000018076B8F0
		public float GetMinActiveProgress(); // 0x000000018076B730-0x000000018076B840
		public bool TriggerInteraction(int index, bool interrupt); // 0x000000018076E650-0x000000018076E870
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject); // 0x000000018076E3F0-0x000000018076E650
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget); // 0x000000018076E0A0-0x000000018076E3F0
		public InteractionTrigger.Range GetClosestInteractionRange(); // 0x000000018076B110-0x000000018076B210
		public InteractionObject GetClosestInteractionObjectInRange(); // 0x000000018076AF70-0x000000018076AFC0
		public InteractionTarget GetClosestInteractionTargetInRange(); // 0x000000018076B210-0x000000018076B2B0
		public InteractionObject[] GetClosestInteractionObjectsInRange(); // 0x000000018076AFC0-0x000000018076B110
		public InteractionTarget[] GetClosestInteractionTargetsInRange(); // 0x000000018076B2B0-0x000000018076B460
		public bool TriggerEffectorsReady(int index); // 0x000000018076DBB0-0x000000018076DF70
		public InteractionTrigger.Range GetTriggerRange(int index); // 0x000000018076B8F0-0x000000018076BA30
		public int GetClosestTriggerIndex(); // 0x000000018076B460-0x000000018076B680
		private void Start(); // 0x000000018076D4D0-0x000000018076DA40
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018076BA30-0x000000018076BA50
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018076BA50-0x000000018076BA70
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018076BA50-0x000000018076BA70
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018076BF70-0x000000018076C1B0
		public void OnTriggerEnter(Collider c); // 0x000000018076CC30-0x000000018076CD50
		public void OnTriggerExit(Collider c); // 0x000000018076CD50-0x000000018076CE50
		private bool ContactIsInRange(int index, out int bestRangeIndex); // 0x000000018076ABD0-0x000000018076AF70
		private void OnDrawGizmosSelected(); // 0x000000018076C5C0-0x000000018076C6B0
		private void Update(); // 0x000000018076ECC0-0x000000018076F090
		private void Raycasting(); // 0x000000018076D110-0x000000018076D260
		private void UpdateTriggerEventBroadcasting(); // 0x000000018076E9E0-0x000000018076ECC0
		private void UpdateEffectors(); // 0x000000018076E870-0x000000018076E9E0
		private void OnPreFBBIK(); // 0x000000018076C920-0x000000018076CC30
		private void OnPostFBBIK(); // 0x000000018076C760-0x000000018076C920
		private void OnFixTransforms(); // 0x000000018076C6B0-0x000000018076C760
		private void OnDestroy(); // 0x000000018076C1B0-0x000000018076C5C0
		private bool IsValid(bool log); // 0x000000018076BE80-0x000000018076BF70
		private bool TriggerIndexIsValid(int index); // 0x000000018076DF70-0x000000018076E0A0
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		private void OpenUserManual(); // 0x000000018076CF90-0x000000018076CFD0
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		private void OpenScriptReference(); // 0x000000018076CE50-0x000000018076CE90
	}
}
