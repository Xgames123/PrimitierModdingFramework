/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class FloppyHand : MonoBehaviour // TypeDefIndex: 7524
	{
		// Fields
		protected float fingerFlexAngle; // 0x18
		public SteamVR_Action_Single squeezyAction; // 0x20
		public SteamVR_Input_Sources inputSource; // 0x28
		public Finger[] fingers; // 0x30
		public Vector3 constforce; // 0x38
	
		// Nested types
		[Serializable]
		public class Finger // TypeDefIndex: 7523
		{
			// Fields
			public float mass; // 0x10
			[Range] // 0x000000018001BE80-0x000000018001BEA0
			public float pos; // 0x14
			public Vector3 forwardAxis; // 0x18
			public SkinnedMeshRenderer renderer; // 0x28
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public SteamVR_Action_Single squeezyAction; // 0x30
			public SteamVR_Input_Sources inputSource; // 0x38
			public Transform[] bones; // 0x40
			public Transform referenceBone; // 0x48
			public Vector2 referenceAngles; // 0x50
			public eulerAxis referenceAxis; // 0x58
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public float flexAngle; // 0x5C
			private Vector3[] rotation; // 0x60
			private Vector3[] velocity; // 0x68
			private Transform[] boneTips; // 0x70
			private Vector3[] oldTipPosition; // 0x78
			private Vector3[] oldTipDelta; // 0x80
			private Vector3[,] inertiaSmoothing; // 0x88
			private float squeezySmooth; // 0x90
			private int inertiaSteps; // 0x94
			private float k; // 0x98
			private float damping; // 0x9C
			private Quaternion[] startRot; // 0xA0
	
			// Nested types
			public enum eulerAxis // TypeDefIndex: 7522
			{
				X = 0,
				Y = 1,
				Z = 2
			}
	
			// Constructors
			public Finger(); // 0x000000018028F600-0x000000018028F630
	
			// Methods
			public void ApplyForce(Vector3 worldForce); // 0x000000018028DFC0-0x000000018028E0B0
			public void Init(); // 0x000000018028E290-0x000000018028E530
			public void UpdateFinger(float deltaTime); // 0x000000018028E680-0x000000018028F600
			public void ApplyTransforms(); // 0x000000018028E0B0-0x000000018028E200
			private Vector3 FixVector(Vector3 ang); // 0x000000018028E220-0x000000018028E290
			private float FixAngle(float ang); // 0x000000018028E200-0x000000018028E220
			private Vector3 PowVector(Vector3 vector, float power); // 0x000000018028E530-0x000000018028E680
		}
	
		// Constructors
		public FloppyHand(); // 0x0000000180591360-0x00000001805913F0
	
		// Methods
		private void Start(); // 0x0000000180591100-0x0000000180591230
		private void Update(); // 0x0000000180591230-0x0000000180591360
	}
}
