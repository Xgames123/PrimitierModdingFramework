/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class Teleport : MonoBehaviour // TypeDefIndex: 7488
	{
		// Fields
		public SteamVR_Action_Boolean teleportAction; // 0x18
		public LayerMask traceLayerMask; // 0x20
		public LayerMask floorFixupTraceLayerMask; // 0x24
		public float floorFixupMaximumTraceDistance; // 0x28
		public Material areaVisibleMaterial; // 0x30
		public Material areaLockedMaterial; // 0x38
		public Material areaHighlightedMaterial; // 0x40
		public Material pointVisibleMaterial; // 0x48
		public Material pointLockedMaterial; // 0x50
		public Material pointHighlightedMaterial; // 0x58
		public Transform destinationReticleTransform; // 0x60
		public Transform invalidReticleTransform; // 0x68
		public GameObject playAreaPreviewCorner; // 0x70
		public GameObject playAreaPreviewSide; // 0x78
		public Color pointerValidColor; // 0x80
		public Color pointerInvalidColor; // 0x90
		public Color pointerLockedColor; // 0xA0
		public bool showPlayAreaMarker; // 0xB0
		public float teleportFadeTime; // 0xB4
		public float meshFadeTime; // 0xB8
		public float arcDistance; // 0xBC
		[Header] // 0x0000000180026420-0x0000000180026450
		public Transform onActivateObjectTransform; // 0xC0
		public Transform onDeactivateObjectTransform; // 0xC8
		public float activateObjectTime; // 0xD0
		public float deactivateObjectTime; // 0xD4
		[Header] // 0x0000000180026450-0x0000000180026480
		public AudioSource pointerAudioSource; // 0xD8
		public AudioSource loopingAudioSource; // 0xE0
		public AudioSource headAudioSource; // 0xE8
		public AudioSource reticleAudioSource; // 0xF0
		[Header] // 0x0000000180026480-0x00000001800264B0
		public AudioClip teleportSound; // 0xF8
		public AudioClip pointerStartSound; // 0x100
		public AudioClip pointerLoopSound; // 0x108
		public AudioClip pointerStopSound; // 0x110
		public AudioClip goodHighlightSound; // 0x118
		public AudioClip badHighlightSound; // 0x120
		[Header] // 0x0000000180026120-0x0000000180026150
		public bool debugFloor; // 0x128
		public bool showOffsetReticle; // 0x129
		public Transform offsetReticleTransform; // 0x130
		public MeshRenderer floorDebugSphere; // 0x138
		public LineRenderer floorDebugLine; // 0x140
		private LineRenderer pointerLineRenderer; // 0x148
		private GameObject teleportPointerObject; // 0x150
		private Transform pointerStartTransform; // 0x158
		private Hand pointerHand; // 0x160
		private Player player; // 0x168
		private TeleportArc teleportArc; // 0x170
		private bool visible; // 0x178
		private TeleportMarkerBase[] teleportMarkers; // 0x180
		private TeleportMarkerBase pointedAtTeleportMarker; // 0x188
		private TeleportMarkerBase teleportingToMarker; // 0x190
		private Vector3 pointedAtPosition; // 0x198
		private Vector3 prevPointedAtPosition; // 0x1A4
		private bool teleporting; // 0x1B0
		private float currentFadeTime; // 0x1B4
		private float meshAlphaPercent; // 0x1B8
		private float pointerShowStartTime; // 0x1BC
		private float pointerHideStartTime; // 0x1C0
		private bool meshFading; // 0x1C4
		private float fullTintAlpha; // 0x1C8
		private float invalidReticleMinScale; // 0x1CC
		private float invalidReticleMaxScale; // 0x1D0
		private float invalidReticleMinScaleDistance; // 0x1D4
		private float invalidReticleMaxScaleDistance; // 0x1D8
		private Vector3 invalidReticleScale; // 0x1DC
		private Quaternion invalidReticleTargetRotation; // 0x1E8
		private Transform playAreaPreviewTransform; // 0x1F8
		private Transform[] playAreaPreviewCorners; // 0x200
		private Transform[] playAreaPreviewSides; // 0x208
		private float loopingAudioMaxVolume; // 0x210
		private Coroutine hintCoroutine; // 0x218
		private bool originalHoverLockState; // 0x220
		private Interactable originalHoveringInteractable; // 0x228
		private AllowTeleportWhileAttachedToHand allowTeleportWhileAttached; // 0x230
		private Vector3 startingFeetOffset; // 0x238
		private bool movedFeetFarEnough; // 0x244
		private SteamVR_Events.Action chaperoneInfoInitializedAction; // 0x248
		public static SteamVR_Events.Event<float> ChangeScene; // 0x00
		public static SteamVR_Events.Event<TeleportMarkerBase> Player; // 0x08
		public static SteamVR_Events.Event<TeleportMarkerBase> PlayerPre; // 0x10
		private static Teleport _instance; // 0x18
	
		// Properties
		public static Teleport instance { get; } // 0x0000000180C7E610-0x0000000180C7E750 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _TeleportHintCoroutine_d__106 : IEnumerator<object> // TypeDefIndex: 7487
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Teleport __4__this; // 0x20
			private float _prevBreakTime_5__2; // 0x28
			private float _prevHapticPulseTime_5__3; // 0x2C
			private bool _pulsed_5__4; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _TeleportHintCoroutine_d__106(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029D4E0-0x000000018029D750
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029D750-0x000000018029D790
		}
	
		// Constructors
		public Teleport(); // 0x0000000180C7E4C0-0x0000000180C7E610
		static Teleport(); // 0x0000000180C7E3D0-0x0000000180C7E4C0
	
		// Methods
		public static SteamVR_Events.Action<float> ChangeSceneAction(UnityAction<float> action); // 0x0000000180C78EA0-0x0000000180C78F50
		public static SteamVR_Events.Action<TeleportMarkerBase> PlayerAction(UnityAction<TeleportMarkerBase> action); // 0x0000000180C7B710-0x0000000180C7B7C0
		public static SteamVR_Events.Action<TeleportMarkerBase> PlayerPreAction(UnityAction<TeleportMarkerBase> action); // 0x0000000180C7B7C0-0x0000000180C7B870
		private void Awake(); // 0x0000000180C78BD0-0x0000000180C78DF0
		private void Start(); // 0x0000000180C7C0E0-0x0000000180C7C350
		private void OnEnable(); // 0x0000000180C7B5E0-0x0000000180C7B620
		private void OnDisable(); // 0x0000000180C7B5A0-0x0000000180C7B5E0
		private void CheckForSpawnPoint(); // 0x0000000180C78F50-0x0000000180C79090
		public void HideTeleportPointer(); // 0x0000000180C79AB0-0x0000000180C79B30
		private void Update(); // 0x0000000180C7DDA0-0x0000000180C7E230
		private void UpdatePointer(); // 0x0000000180C7CDA0-0x0000000180C7DCC0
		private void FixedUpdate(); // 0x0000000180C79090-0x0000000180C79650
		private void OnChaperoneInfoInitialized(); // 0x0000000180C7A390-0x0000000180C7B5A0
		private void HidePointer(); // 0x0000000180C796F0-0x0000000180C79AB0
		private void ShowPointer(Hand newPointerHand, Hand oldPointerHand); // 0x0000000180C7B900-0x0000000180C7C060
		private void UpdateTeleportColors(); // 0x0000000180C7DCC0-0x0000000180C7DDA0
		private void PlayAudioClip(AudioSource source, AudioClip clip); // 0x0000000180C7B620-0x0000000180C7B660
		private void PlayPointerHaptic(bool validLocation); // 0x0000000180C7B660-0x0000000180C7B710
		private void TryTeleportPlayer(); // 0x0000000180C7CCE0-0x0000000180C7CDA0
		private void InitiateTeleportFade(); // 0x0000000180C79E10-0x0000000180C7A0E0
		private void TeleportPlayer(); // 0x0000000180C7C3C0-0x0000000180C7CCE0
		private void HighlightSelected(TeleportMarkerBase hitTeleportMarker); // 0x0000000180C79B30-0x0000000180C79E10
		public void ShowTeleportHint(); // 0x0000000180C7C060-0x0000000180C7C0E0
		public void CancelTeleportHint(); // 0x0000000180C78DF0-0x0000000180C78EA0
		[IteratorStateMachine] // 0x00000001800264B0-0x0000000180026500
		private IEnumerator TeleportHintCoroutine(); // 0x0000000180C7C350-0x0000000180C7C3C0
		public bool IsEligibleForTeleport(Hand hand); // 0x0000000180C7A0E0-0x0000000180C7A2C0
		private bool ShouldOverrideHoverLock(); // 0x0000000180C7B870-0x0000000180C7B900
		private bool WasTeleportButtonReleased(Hand hand); // 0x0000000180C7E300-0x0000000180C7E3D0
		private bool IsTeleportButtonDown(Hand hand); // 0x0000000180C7A2C0-0x0000000180C7A390
		private bool WasTeleportButtonPressed(Hand hand); // 0x0000000180C7E230-0x0000000180C7E300
		private Transform GetPointerStartTransform(Hand hand); // 0x0000000180C79650-0x0000000180C796F0
	}
}
