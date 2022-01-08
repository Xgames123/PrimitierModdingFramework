/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class Hand : MonoBehaviour // TypeDefIndex: 7409
	{
		// Fields
		public const AttachmentFlags defaultAttachmentFlags = AttachmentFlags.SnapOnAttach | AttachmentFlags.DetachOthers | AttachmentFlags.DetachFromOtherHand | AttachmentFlags.ParentToHand | AttachmentFlags.TurnOnKinematic; // Metadata: 0x003A59CB
		public Hand otherHand; // 0x18
		public SteamVR_Input_Sources handType; // 0x20
		public SteamVR_Behaviour_Pose trackedObject; // 0x28
		public SteamVR_Action_Boolean grabPinchAction; // 0x30
		public SteamVR_Action_Boolean grabGripAction; // 0x38
		public SteamVR_Action_Vibration hapticAction; // 0x40
		public SteamVR_Action_Boolean uiInteractAction; // 0x48
		public bool useHoverSphere; // 0x50
		public Transform hoverSphereTransform; // 0x58
		public float hoverSphereRadius; // 0x60
		public LayerMask hoverLayerMask; // 0x64
		public float hoverUpdateInterval; // 0x68
		public bool useControllerHoverComponent; // 0x6C
		public string controllerHoverComponent; // 0x70
		public float controllerHoverRadius; // 0x78
		public bool useFingerJointHover; // 0x7C
		public SteamVR_Skeleton_JointIndexEnum fingerJointHover; // 0x80
		public float fingerJointHoverRadius; // 0x84
		[Tooltip] // 0x0000000180024F30-0x0000000180024F60
		public Transform objectAttachmentPoint; // 0x88
		public Camera noSteamVRFallbackCamera; // 0x90
		public float noSteamVRFallbackMaxDistanceNoItem; // 0x98
		public float noSteamVRFallbackMaxDistanceWithItem; // 0x9C
		private float noSteamVRFallbackInteractorDistance; // 0xA0
		public GameObject renderModelPrefab; // 0xA8
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public List<RenderModel> renderModels; // 0xB0
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public RenderModel mainRenderModel; // 0xB8
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public RenderModel hoverhighlightRenderModel; // 0xC0
		public bool showDebugText; // 0xC8
		public bool spewDebugText; // 0xC9
		public bool showDebugInteractables; // 0xCA
		private List<AttachedObject> attachedObjects; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _hoverLocked_k__BackingField; // 0xD8
		private Interactable _hoveringInteractable; // 0xE0
		private TextMesh debugText; // 0xE8
		private int prevOverlappingColliders; // 0xF0
		private const int ColliderArraySize = 32; // Metadata: 0x003A59CF
		private Collider[] overlappingColliders; // 0xF8
		private Player playerInstance; // 0x100
		private GameObject applicationLostFocusObject; // 0x108
		private SteamVR_Events.Action inputFocusAction; // 0x110
		protected const float MaxVelocityChange = 10f; // Metadata: 0x003A59D3
		protected const float VelocityMagic = 6000f; // Metadata: 0x003A59D7
		protected const float AngularVelocityMagic = 50f; // Metadata: 0x003A59DB
		protected const float MaxAngularVelocityChange = 20f; // Metadata: 0x003A59DF
	
		// Properties
		public ReadOnlyCollection<AttachedObject> AttachedObjects { get; } // 0x000000018059C3C0-0x000000018059C410 
		public bool hoverLocked { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018059C7F0-0x000000018059C800 0x000000018059C950-0x000000018059C960
		public bool isActive { get; } // 0x000000018059C800-0x000000018059C8A0 
		public bool isPoseValid { get; } // 0x000000018059C8A0-0x000000018059C8C0 
		public Interactable hoveringInteractable { get; set; } // 0x000000018026A6D0-0x000000018026A6E0 0x000000018059C960-0x000000018059CC70
		public GameObject currentAttachedObject { get; } // 0x000000018059C600-0x000000018059C690 
		public AttachedObject? currentAttachedObjectInfo { get; } // 0x000000018059C410-0x000000018059C600 
		public AllowTeleportWhileAttachedToHand currentAttachedTeleportManager { get; } // 0x000000018059C690-0x000000018059C7F0 
		public SteamVR_Behaviour_Skeleton skeleton { get; } // 0x000000018059C8C0-0x000000018059C950 
	
		// Nested types
		[Flags] // 0x0000000180014D50-0x0000000180014D60
		public enum AttachmentFlags // TypeDefIndex: 7404
		{
			SnapOnAttach = 1,
			DetachOthers = 2,
			DetachFromOtherHand = 4,
			ParentToHand = 8,
			VelocityMovement = 16,
			TurnOnKinematic = 32,
			TurnOffGravity = 64,
			AllowSidegrade = 128
		}
	
		public struct AttachedObject // TypeDefIndex: 7405
		{
			// Fields
			public GameObject attachedObject; // 0x00
			public Interactable interactable; // 0x08
			public Rigidbody attachedRigidbody; // 0x10
			public CollisionDetectionMode collisionDetectionMode; // 0x18
			public bool attachedRigidbodyWasKinematic; // 0x1C
			public bool attachedRigidbodyUsedGravity; // 0x1D
			public GameObject originalParent; // 0x20
			public bool isParentedToHand; // 0x28
			public GrabTypes grabbedWithType; // 0x2C
			public AttachmentFlags attachmentFlags; // 0x30
			public Vector3 initialPositionalOffset; // 0x34
			public Quaternion initialRotationalOffset; // 0x40
			public Transform attachedOffsetTransform; // 0x50
			public Transform handAttachmentPointTransform; // 0x58
			public Vector3 easeSourcePosition; // 0x60
			public Quaternion easeSourceRotation; // 0x6C
			public float attachTime; // 0x7C
			public AllowTeleportWhileAttachedToHand allowTeleportWhileAttachedToHand; // 0x80
	
			// Methods
			public bool HasAttachFlag(AttachmentFlags flag); // 0x000000018028B0E0-0x000000018028B0F0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass79_0 // TypeDefIndex: 7406
		{
			// Fields
			public GameObject objectToDetach; // 0x10
	
			// Constructors
			public __c__DisplayClass79_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _DetachObject_b__0(AttachedObject l); // 0x000000018029E5B0-0x000000018029E630
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 7407
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<AttachedObject> __9__83_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018029E690-0x000000018029E6F0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _CleanUpAttachedObjectStack_b__83_0(AttachedObject l); // 0x000000018029E2A0-0x000000018029E310
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Start_d__87 : IEnumerator<object> // TypeDefIndex: 7408
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Hand __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Start_d__87(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029D260-0x000000018029D4A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029D4A0-0x000000018029D4E0
		}
	
		// Constructors
		public Hand(); // 0x000000018059C1C0-0x000000018059C3C0
	
		// Methods
		public void ShowController(bool permanent = false /* Metadata: 0x003A59A5 */); // 0x000000018059A090-0x000000018059A180
		public void HideController(bool permanent = false /* Metadata: 0x003A59A6 */); // 0x00000001805983A0-0x0000000180598490
		public void ShowSkeleton(bool permanent = false /* Metadata: 0x003A59A7 */); // 0x000000018059A3A0-0x000000018059A490
		public void HideSkeleton(bool permanent = false /* Metadata: 0x003A59A8 */); // 0x00000001805985B0-0x00000001805986A0
		public bool HasSkeleton(); // 0x00000001805982E0-0x00000001805983A0
		public void Show(); // 0x000000018059A490-0x000000018059A4A0
		public void Hide(); // 0x00000001805986A0-0x00000001805986B0
		public void SetVisibility(bool visible); // 0x0000000180599FF0-0x000000018059A090
		public void SetSkeletonRangeOfMotion(EVRSkeletalMotionRange newRangeOfMotion, float blendOverSeconds = 0.1f /* Metadata: 0x003A59A9 */); // 0x0000000180599E30-0x0000000180599F10
		public void SetTemporarySkeletonRangeOfMotion(SkeletalMotionRangeChange temporaryRangeOfMotionChange, float blendOverSeconds = 0.1f /* Metadata: 0x003A59AD */); // 0x0000000180599F10-0x0000000180599FF0
		public void ResetTemporarySkeletonRangeOfMotion(float blendOverSeconds = 0.1f /* Metadata: 0x003A59B1 */); // 0x0000000180599B90-0x0000000180599C60
		public void SetAnimationState(int stateValue); // 0x0000000180599C60-0x0000000180599D30
		public void StopAnimation(); // 0x000000018059A510-0x000000018059A5D0
		public void AttachObject(GameObject objectToAttach, GrabTypes grabbedWithType, AttachmentFlags flags = AttachmentFlags.SnapOnAttach | AttachmentFlags.DetachOthers | AttachmentFlags.DetachFromOtherHand | AttachmentFlags.ParentToHand | AttachmentFlags.TurnOnKinematic /* Metadata: 0x003A59B5 */, Transform attachmentOffset = null); // 0x0000000180591D50-0x0000000180593830
		public bool ObjectIsAttached(GameObject go); // 0x0000000180599200-0x0000000180599300
		public void ForceHoverUnlock(); // 0x00000001805961D0-0x00000001805961E0
		public void DetachObject(GameObject objectToDetach, bool restoreOriginalParent = true /* Metadata: 0x003A59B9 */); // 0x0000000180594360-0x0000000180595750
		public Vector3 GetTrackedObjectVelocity(float timeOffset = 0f /* Metadata: 0x003A59BA */); // 0x0000000180596AE0-0x0000000180596DB0
		public Vector3 GetTrackedObjectAngularVelocity(float timeOffset = 0f /* Metadata: 0x003A59BE */); // 0x0000000180596810-0x0000000180596AE0
		public void GetEstimatedPeakVelocities(out Vector3 velocity, out Vector3 angularVelocity); // 0x0000000180596400-0x00000001805964D0
		private void CleanUpAttachedObjectStack(); // 0x0000000180594230-0x0000000180594360
		protected virtual void Awake(); // 0x0000000180593830-0x0000000180593B30
		protected virtual void OnDestroy(); // 0x0000000180599300-0x0000000180599400
		protected virtual void OnTransformUpdated(SteamVR_Behaviour_Pose updatedPose, SteamVR_Input_Sources updatedSource); // 0x0000000180498960-0x0000000180498980
		[IteratorStateMachine] // 0x0000000180024F60-0x0000000180024FB0
		protected virtual IEnumerator Start(); // 0x000000018059A4A0-0x000000018059A510
		protected virtual void UpdateHovering(); // 0x000000018059B830-0x000000018059BC30
		protected virtual bool CheckHoveringForTransform(Vector3 hoverPosition, float hoverRadius, ref float closestDistance, ref Interactable closestInteractable, Color debugColor); // 0x0000000180593B30-0x0000000180594230
		protected virtual void UpdateNoSteamVRFallback(); // 0x000000018059BC30-0x000000018059C090
		private void UpdateDebugText(); // 0x000000018059B140-0x000000018059B830
		protected virtual void OnEnable(); // 0x0000000180599770-0x0000000180599890
		protected virtual void OnDisable(); // 0x0000000180599400-0x0000000180599440
		protected virtual void Update(); // 0x000000018059C090-0x000000018059C1C0
		public bool IsStillHovering(Interactable interactable); // 0x0000000180599190-0x0000000180599200
		protected virtual void HandFollowUpdate(); // 0x0000000180597380-0x00000001805982E0
		protected virtual void FixedUpdate(); // 0x0000000180595750-0x00000001805961D0
		protected void UpdateAttachedVelocity(AttachedObject attachedObjectInfo); // 0x000000018059AE60-0x000000018059B140
		public void ResetAttachedTransform(AttachedObject attachedObject); // 0x0000000180599990-0x0000000180599B90
		protected Vector3 TargetItemPosition(AttachedObject attachedObject); // 0x000000018059A5D0-0x000000018059AA20
		protected Quaternion TargetItemRotation(AttachedObject attachedObject); // 0x000000018059AA20-0x000000018059ADC0
		protected bool GetUpdatedAttachedVelocities(AttachedObject attachedObjectInfo, out Vector3 velocityTarget, out Vector3 angularTarget); // 0x0000000180596DB0-0x00000001805972D0
		protected virtual void OnInputFocus(bool hasFocus); // 0x0000000180599890-0x0000000180599990
		protected virtual void OnDrawGizmos(); // 0x0000000180599440-0x0000000180599770
		private void HandDebugLog(string msg); // 0x00000001805972D0-0x0000000180597380
		public void HoverLock(Interactable interactable); // 0x00000001805986B0-0x0000000180598750
		public void HoverUnlock(Interactable interactable); // 0x0000000180598750-0x0000000180598830
		public void TriggerHapticPulse(ushort microSecondsDuration); // 0x000000018059ADC0-0x000000018059AE20
		public void TriggerHapticPulse(float duration, float frequency, float amplitude); // 0x000000018059AE20-0x000000018059AE60
		public void ShowGrabHint(); // 0x000000018059A280-0x000000018059A3A0
		public void HideGrabHint(); // 0x0000000180598490-0x00000001805985B0
		public void ShowGrabHint(string text); // 0x000000018059A180-0x000000018059A280
		public GrabTypes GetGrabStarting(GrabTypes explicitType = GrabTypes.None /* Metadata: 0x003A59C2 */); // 0x0000000180596630-0x0000000180596810
		public GrabTypes GetGrabEnding(GrabTypes explicitType = GrabTypes.None /* Metadata: 0x003A59C6 */); // 0x00000001805964D0-0x0000000180596630
		public bool IsGrabEnding(GameObject attachedObject); // 0x0000000180598E70-0x0000000180598FB0
		public bool IsGrabbingWithType(GrabTypes type); // 0x00000001805990A0-0x0000000180599190
		public bool IsGrabbingWithOppositeType(GrabTypes type); // 0x0000000180598FB0-0x00000001805990A0
		public GrabTypes GetBestGrabbingType(); // 0x0000000180596310-0x00000001805963E0
		public GrabTypes GetBestGrabbingType(GrabTypes preferred, bool forcePreference = false /* Metadata: 0x003A59CA */); // 0x00000001805961E0-0x0000000180596310
		private void InitController(); // 0x0000000180598830-0x0000000180598E70
		public void SetRenderModel(GameObject prefab); // 0x0000000180599D90-0x0000000180599E30
		public void SetHoverRenderModel(RenderModel hoverRenderModel); // 0x0000000180599D30-0x0000000180599D90
		public int GetDeviceIndex(); // 0x00000001805963E0-0x0000000180596400
	}
}
