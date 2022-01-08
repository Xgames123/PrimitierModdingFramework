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
	public class HandPhysics : MonoBehaviour // TypeDefIndex: 7413
	{
		// Fields
		[Tooltip] // 0x0000000180025010-0x0000000180025040
		public HandCollider handColliderPrefab; // 0x18
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public HandCollider handCollider; // 0x20
		[Tooltip] // 0x0000000180025040-0x0000000180025070
		public LayerMask clearanceCheckMask; // 0x28
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Hand hand; // 0x30
		private const float handResetDistance = 0.6f; // Metadata: 0x003A5A1F
		private const float collisionReenableClearanceRadius = 0.1f; // Metadata: 0x003A5A23
		private bool initialized; // 0x38
		private bool collisionsEnabled; // 0x39
		private Matrix4x4 wristToRoot; // 0x3C
		private Matrix4x4 rootToArmature; // 0x7C
		private Matrix4x4 wristToArmature; // 0xBC
		private Vector3 targetPosition; // 0xFC
		private Quaternion targetRotation; // 0x108
		private const int wristBone = 1; // Metadata: 0x003A5A27
		private const int rootBone = 0; // Metadata: 0x003A5A2B
		private Collider[] clearanceBuffer; // 0x118
		private Transform wrist; // 0x120
		private const int thumbBone = 4; // Metadata: 0x003A5A2F
		private const int indexBone = 9; // Metadata: 0x003A5A33
		private const int middleBone = 14; // Metadata: 0x003A5A37
		private const int ringBone = 19; // Metadata: 0x003A5A3B
		private const int pinkyBone = 24; // Metadata: 0x003A5A3F
	
		// Constructors
		public HandPhysics(); // 0x0000000180355640-0x00000001803556D0
	
		// Methods
		private void Start(); // 0x00000001803543D0-0x0000000180354680
		private void FixedUpdate(); // 0x0000000180354060-0x0000000180354230
		private void UpdateCenterPoint(); // 0x0000000180354680-0x0000000180354830
		private void UpdatePositions(); // 0x0000000180354D40-0x0000000180355640
		private void UpdateFingertips(); // 0x0000000180354830-0x0000000180354AD0
		private void UpdateHand(SteamVR_Behaviour_Pose pose, SteamVR_Input_Sources inputSource); // 0x0000000180354AD0-0x0000000180354D40
		private Vector3 ProcessPos(int boneIndex, Vector3 pos); // 0x0000000180354230-0x0000000180354310
		private Quaternion ProcessRot(int boneIndex, Quaternion rot); // 0x0000000180354310-0x00000001803543D0
	}
}
