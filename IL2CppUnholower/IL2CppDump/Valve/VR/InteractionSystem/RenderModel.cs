/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class RenderModel : MonoBehaviour // TypeDefIndex: 7439
	{
		// Fields
		public GameObject handPrefab; // 0x18
		protected GameObject handInstance; // 0x20
		protected Renderer[] handRenderers; // 0x28
		public bool displayHandByDefault; // 0x30
		protected SteamVR_Behaviour_Skeleton handSkeleton; // 0x38
		protected Animator handAnimator; // 0x40
		protected string animatorParameterStateName; // 0x48
		protected int handAnimatorStateId; // 0x50
		[Space] // 0x0000000180024160-0x0000000180024170
		public GameObject controllerPrefab; // 0x58
		protected GameObject controllerInstance; // 0x60
		protected Renderer[] controllerRenderers; // 0x68
		protected SteamVR_RenderModel controllerRenderModel; // 0x70
		public bool displayControllerByDefault; // 0x78
		protected Material delayedSetMaterial; // 0x80
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private System.Action onControllerLoaded; // 0x88
		protected SteamVR_Events.Action renderModelLoadedAction; // 0x90
		protected SteamVR_Input_Sources inputSource; // 0x98
	
		// Properties
		public EVRSkeletalMotionRange GetSkeletonRangeOfMotion { get; } // 0x0000000180364450-0x00000001803644E0 
	
		// Events
		public event System.Action onControllerLoaded {
			add; // 0x00000001803643B0-0x0000000180364450
			remove; // 0x00000001803644E0-0x0000000180364580
		}
	
		// Constructors
		public RenderModel(); // 0x0000000180364360-0x00000001803643B0
	
		// Methods
		protected void Awake(); // 0x00000001803625F0-0x00000001803626C0
		protected void InitializeHand(); // 0x00000001803630C0-0x0000000180363530
		protected void InitializeController(); // 0x0000000180362EC0-0x00000001803630C0
		protected virtual void DestroyHand(); // 0x00000001803628A0-0x00000001803629F0
		protected virtual void OnSkeletonActiveChange(SteamVR_Action_Skeleton changedAction, bool newState); // 0x00000001803639C0-0x00000001803639E0
		protected void OnEnable(); // 0x00000001803637E0-0x0000000180363810
		protected void OnDisable(); // 0x00000001803637B0-0x00000001803637E0
		protected void OnDestroy(); // 0x0000000180363790-0x00000001803637B0
		public SteamVR_Behaviour_Skeleton GetSkeleton(); // 0x0000000180268FE0-0x0000000180268FF0
		public virtual void SetInputSource(SteamVR_Input_Sources newInputSource); // 0x0000000180363EF0-0x0000000180363F80
		public virtual void OnHandInitialized(int deviceIndex); // 0x0000000180363810-0x0000000180363850
		public void MatchHandToTransform(Transform match); // 0x0000000180363650-0x0000000180363790
		public void SetHandPosition(Vector3 newPosition); // 0x0000000180363D00-0x0000000180363DB0
		public void SetHandRotation(Quaternion newRotation); // 0x0000000180363DB0-0x0000000180363E60
		public Vector3 GetHandPosition(); // 0x0000000180362D30-0x0000000180362DF0
		public Quaternion GetHandRotation(); // 0x0000000180362DF0-0x0000000180362EB0
		private void OnRenderModelLoaded(SteamVR_RenderModel loadedRenderModel, bool success); // 0x0000000180363850-0x00000001803639C0
		public void SetVisibility(bool state, bool overrideDefault = false /* Metadata: 0x003A5A58 */); // 0x0000000180364160-0x0000000180364290
		public void Show(bool overrideDefault = false /* Metadata: 0x003A5A59 */); // 0x0000000180364290-0x00000001803642A0
		public void Hide(); // 0x0000000180362EB0-0x0000000180362EC0
		public virtual void SetMaterial(Material material); // 0x0000000180363F80-0x0000000180364020
		public void SetControllerMaterial(Material material); // 0x0000000180363B40-0x0000000180363BE0
		public void SetHandMaterial(Material material); // 0x0000000180363C70-0x0000000180363D00
		public void SetControllerVisibility(bool state, bool permanent = false /* Metadata: 0x003A5A5A */); // 0x0000000180363BE0-0x0000000180363C70
		public void SetHandVisibility(bool state, bool permanent = false /* Metadata: 0x003A5A5B */); // 0x0000000180363E60-0x0000000180363EF0
		public bool IsHandVisibile(); // 0x00000001803635C0-0x0000000180363650
		public bool IsControllerVisibile(); // 0x0000000180363530-0x00000001803635C0
		public Transform GetBone(int boneIndex); // 0x0000000180362BB0-0x0000000180362C60
		public Vector3 GetBonePosition(int boneIndex, bool local = false /* Metadata: 0x003A5A5C */); // 0x00000001803629F0-0x0000000180362AD0
		public Vector3 GetControllerPosition(string componentName = null); // 0x0000000180362C60-0x0000000180362D30
		public Quaternion GetBoneRotation(int boneIndex, bool local = false /* Metadata: 0x003A5A5D */); // 0x0000000180362AD0-0x0000000180362BB0
		public void SetSkeletonRangeOfMotion(EVRSkeletalMotionRange newRangeOfMotion, float blendOverSeconds = 0.1f /* Metadata: 0x003A5A5E */); // 0x0000000180364020-0x00000001803640C0
		public void SetTemporarySkeletonRangeOfMotion(SkeletalMotionRangeChange temporaryRangeOfMotionChange, float blendOverSeconds = 0.1f /* Metadata: 0x003A5A62 */); // 0x00000001803640C0-0x0000000180364160
		public void ResetTemporarySkeletonRangeOfMotion(float blendOverSeconds = 0.1f /* Metadata: 0x003A5A66 */); // 0x00000001803639E0-0x0000000180363A70
		public void SetAnimationState(int stateValue); // 0x0000000180363A70-0x0000000180363B40
		public void StopAnimation(); // 0x00000001803642A0-0x0000000180364360
		private bool CheckAnimatorInit(); // 0x00000001803626C0-0x00000001803628A0
	}
}
