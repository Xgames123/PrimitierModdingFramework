/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[Serializable]
	public class InteractionEffector // TypeDefIndex: 8472
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private FullBodyBipedEffector _effectorType_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _isPaused_k__BackingField; // 0x14
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private InteractionObject _interactionObject_k__BackingField; // 0x18
		private Poser poser; // 0x20
		private IKEffector effector; // 0x28
		private float timer; // 0x30
		private float length; // 0x34
		private float weight; // 0x38
		private float fadeInSpeed; // 0x3C
		private float defaultPositionWeight; // 0x40
		private float defaultRotationWeight; // 0x44
		private float defaultPull; // 0x48
		private float defaultReach; // 0x4C
		private float defaultPush; // 0x50
		private float defaultPushParent; // 0x54
		private float resetTimer; // 0x58
		private bool positionWeightUsed; // 0x5C
		private bool rotationWeightUsed; // 0x5D
		private bool pullUsed; // 0x5E
		private bool reachUsed; // 0x5F
		private bool pushUsed; // 0x60
		private bool pushParentUsed; // 0x61
		private bool pickedUp; // 0x62
		private bool defaults; // 0x63
		private bool pickUpOnPostFBBIK; // 0x64
		private Vector3 pickUpPosition; // 0x68
		private Vector3 pausePositionRelative; // 0x74
		private Quaternion pickUpRotation; // 0x80
		private Quaternion pauseRotationRelative; // 0x90
		private InteractionTarget interactionTarget; // 0xA0
		private Transform target; // 0xA8
		private List<bool> triggered; // 0xB0
		private InteractionSystem interactionSystem; // 0xB8
		private bool started; // 0xC0
	
		// Properties
		public FullBodyBipedEffector effectorType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180260E80-0x0000000180260F00 0x00000001802A2B90-0x00000001802A2BA0
		public bool isPaused { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036C110-0x000000018036C120 0x000000018036C1A0-0x000000018036C1B0
		public InteractionObject interactionObject { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public bool inInteraction { get; } // 0x00000001807FCD90-0x00000001807FCDF0 
		public float progress { get; } // 0x00000001807FCDF0-0x00000001807FCE70 
	
		// Constructors
		public InteractionEffector(FullBodyBipedEffector effectorType); // 0x00000001807FCD10-0x00000001807FCD90
	
		// Methods
		public void Initiate(InteractionSystem interactionSystem); // 0x00000001807FAC80-0x00000001807FAD20
		private void StoreDefaults(); // 0x00000001807FBF10-0x00000001807FC0B0
		public bool ResetToDefaults(float speed); // 0x00000001807FB380-0x00000001807FB7A0
		public bool Pause(); // 0x00000001807FAFC0-0x00000001807FB130
		public bool Resume(); // 0x00000001807FB7A0-0x00000001807FB850
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt); // 0x00000001807FB850-0x00000001807FBD50
		public void Update(Transform root, float speed); // 0x00000001807FC3D0-0x00000001807FCD10
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause); // 0x00000001807FC0B0-0x00000001807FC3D0
		private void PickUp(Transform root); // 0x00000001807FB130-0x00000001807FB380
		public bool Stop(); // 0x00000001807FBD50-0x00000001807FBF10
		public void OnPostFBBIK(); // 0x00000001807FAD20-0x00000001807FAFC0
	}
}
