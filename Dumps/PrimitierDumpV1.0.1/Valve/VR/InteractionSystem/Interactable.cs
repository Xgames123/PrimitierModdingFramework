/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class Interactable : MonoBehaviour // TypeDefIndex: 7421
	{
		// Fields
		[Tooltip] // 0x0000000180025230-0x0000000180025260
		public SteamVR_ActionSet activateActionSetOnAttach; // 0x18
		[Tooltip] // 0x0000000180025260-0x0000000180025290
		public bool hideHandOnAttach; // 0x20
		[Tooltip] // 0x0000000180025290-0x00000001800252C0
		public bool hideSkeletonOnAttach; // 0x21
		[Tooltip] // 0x00000001800252C0-0x00000001800252F0
		public bool hideControllerOnAttach; // 0x22
		[Tooltip] // 0x00000001800252F0-0x0000000180025320
		public int handAnimationOnPickup; // 0x24
		[Tooltip] // 0x0000000180025320-0x0000000180025350
		public SkeletalMotionRangeChange setRangeOfMotionOnPickup; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private OnAttachedToHandDelegate onAttachedToHand; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private OnDetachedFromHandDelegate onDetachedFromHand; // 0x38
		[Tooltip] // 0x0000000180025350-0x0000000180025380
		public bool useHandObjectAttachmentPoint; // 0x40
		public bool attachEaseIn; // 0x41
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public AnimationCurve snapAttachEaseInCurve; // 0x48
		public float snapAttachEaseInTime; // 0x50
		public bool snapAttachEaseInCompleted; // 0x54
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public SteamVR_Skeleton_Poser skeletonPoser; // 0x58
		[Tooltip] // 0x0000000180025380-0x00000001800253B0
		public bool handFollowTransform; // 0x60
		[Tooltip] // 0x00000001800253B0-0x00000001800253E0
		public bool highlightOnHover; // 0x61
		protected MeshRenderer[] highlightRenderers; // 0x68
		protected MeshRenderer[] existingRenderers; // 0x70
		protected GameObject highlightHolder; // 0x78
		protected SkinnedMeshRenderer[] highlightSkinnedRenderers; // 0x80
		protected SkinnedMeshRenderer[] existingSkinnedRenderers; // 0x88
		protected static Material highlightMat; // 0x00
		[Tooltip] // 0x00000001800253E0-0x0000000180025410
		public GameObject[] hideHighlight; // 0x90
		[Tooltip] // 0x0000000180025410-0x0000000180025440
		public int hoverPriority; // 0x98
		[NonSerialized]
		public Hand attachedToHand; // 0xA0
		[NonSerialized]
		public List<Hand> hoveringHands; // 0xA8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _isDestroying_k__BackingField; // 0xB0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _isHovering_k__BackingField; // 0xB1
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _wasHovering_k__BackingField; // 0xB2
		protected float blendToPoseTime; // 0xB4
		protected float releasePoseBlendTime; // 0xB8
	
		// Properties
		public Hand hoveringHand { get; } // 0x00000001803597C0-0x0000000180359830 
		public bool isDestroying { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180359830-0x0000000180359840 0x00000001803599A0-0x00000001803599B0
		public bool isHovering { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180359840-0x0000000180359850 0x00000001803599B0-0x00000001803599C0
		public bool wasHovering { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180359850-0x0000000180359860 0x00000001803599C0-0x00000001803599D0
	
		// Events
		public event OnAttachedToHandDelegate onAttachedToHand {
			add; // 0x0000000180359680-0x0000000180359720
			remove; // 0x0000000180359860-0x0000000180359900
		}
		public event OnDetachedFromHandDelegate onDetachedFromHand {
			add; // 0x0000000180359720-0x00000001803597C0
			remove; // 0x0000000180359900-0x00000001803599A0
		}
	
		// Nested types
		public delegate void OnAttachedToHandDelegate(Hand hand); // TypeDefIndex: 7419; 0x000000018028C940-0x000000018028CB90
	
		public delegate void OnDetachedFromHandDelegate(Hand hand); // TypeDefIndex: 7420; 0x000000018028C940-0x000000018028CB90
	
		// Constructors
		public Interactable(); // 0x00000001803595B0-0x0000000180359680
	
		// Methods
		private void Awake(); // 0x0000000180357B30-0x0000000180357B70
		protected virtual void Start(); // 0x0000000180358BD0-0x0000000180358E00
		protected virtual bool ShouldIgnoreHighlight(Component component); // 0x0000000180358AB0-0x0000000180358AF0
		protected virtual bool ShouldIgnore(GameObject check); // 0x0000000180358AF0-0x0000000180358BD0
		protected virtual void CreateHighlightRenderers(); // 0x0000000180357B70-0x0000000180358200
		protected virtual void UpdateHighlightRenderers(); // 0x0000000180358E00-0x00000001803594F0
		protected virtual void OnHandHoverBegin(Hand hand); // 0x0000000180358900-0x00000001803589B0
		protected virtual void OnHandHoverEnd(Hand hand); // 0x00000001803589B0-0x0000000180358AB0
		protected virtual void Update(); // 0x00000001803594F0-0x00000001803595B0
		protected virtual void OnAttachedToHand(Hand hand); // 0x0000000180358200-0x0000000180358340
		protected virtual void OnDetachedFromHand(Hand hand); // 0x0000000180358470-0x0000000180358810
		protected virtual void OnDestroy(); // 0x0000000180358340-0x0000000180358470
		protected virtual void OnDisable(); // 0x0000000180358810-0x0000000180358900
	}
}
