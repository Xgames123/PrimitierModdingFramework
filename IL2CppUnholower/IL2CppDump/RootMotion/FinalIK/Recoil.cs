/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public class Recoil : OffsetModifier // TypeDefIndex: 8543
	{
		// Fields
		[Tooltip] // 0x0000000180022D70-0x0000000180022DA0
		public AimIK aimIK; // 0x30
		[Tooltip] // 0x0000000180022DA0-0x0000000180022DD0
		public bool aimIKSolvedLast; // 0x38
		[Tooltip] // 0x0000000180022DD0-0x0000000180022E00
		public Handedness handedness; // 0x3C
		[Tooltip] // 0x0000000180022E00-0x0000000180022E30
		public bool twoHanded; // 0x40
		[Tooltip] // 0x0000000180022E30-0x0000000180022E60
		public AnimationCurve recoilWeight; // 0x48
		[Tooltip] // 0x0000000180022E60-0x0000000180022E90
		public float magnitudeRandom; // 0x50
		[Tooltip] // 0x0000000180022E90-0x0000000180022EC0
		public Vector3 rotationRandom; // 0x54
		[Tooltip] // 0x0000000180022EC0-0x0000000180022EF0
		public Vector3 handRotationOffset; // 0x60
		[Tooltip] // 0x0000000180022EF0-0x0000000180022F20
		public float blendTime; // 0x6C
		[Space] // 0x0000000180022F20-0x0000000180022F70
		[Tooltip] // 0x0000000180022F20-0x0000000180022F70
		public RecoilOffset[] offsets; // 0x70
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Quaternion rotationOffset; // 0x78
		private float magnitudeMlp; // 0x88
		private float endTime; // 0x8C
		private Quaternion handRotation; // 0x90
		private Quaternion secondaryHandRelativeRotation; // 0xA0
		private Quaternion randomRotation; // 0xB0
		private float length; // 0xC0
		private bool initiated; // 0xC4
		private float blendWeight; // 0xC8
		private float w; // 0xCC
		private Quaternion primaryHandRotation; // 0xD0
		private bool handRotationsSet; // 0xE0
		private Vector3 aimIKAxis; // 0xE4
	
		// Properties
		public bool isFinished { get; } // 0x000000018077D2E0-0x000000018077D300 
		private IKEffector primaryHandEffector { get; } // 0x000000018077D300-0x000000018077D350 
		private IKEffector secondaryHandEffector { get; } // 0x000000018077D3A0-0x000000018077D3F0 
		private Transform primaryHand { get; } // 0x000000018077D350-0x000000018077D3A0 
		private Transform secondaryHand { get; } // 0x000000018077D3F0-0x000000018077D440 
	
		// Nested types
		[Serializable]
		public class RecoilOffset // TypeDefIndex: 8541
		{
			// Fields
			[Tooltip] // 0x0000000180022F70-0x0000000180022FA0
			public Vector3 offset; // 0x10
			[Range] // 0x0000000180022FA0-0x0000000180022FF0
			[Tooltip] // 0x0000000180022FA0-0x0000000180022FF0
			public float additivity; // 0x1C
			[Tooltip] // 0x0000000180022FF0-0x0000000180023020
			public float maxAdditiveOffsetMag; // 0x20
			[Tooltip] // 0x0000000180023020-0x0000000180023050
			public EffectorLink[] effectorLinks; // 0x28
			private Vector3 additiveOffset; // 0x30
			private Vector3 lastOffset; // 0x3C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 8540
			{
				// Fields
				[Tooltip] // 0x0000000180022230-0x0000000180022260
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x0000000180022260-0x0000000180022290
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x00000001802650F0-0x0000000180265100
			}
	
			// Constructors
			public RecoilOffset(); // 0x0000000180849950-0x0000000180849970
	
			// Methods
			public void Start(); // 0x00000001808498C0-0x0000000180849950
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft); // 0x0000000180849610-0x00000001808498C0
		}
	
		[Serializable]
		public enum Handedness // TypeDefIndex: 8542
		{
			Right = 0,
			Left = 1
		}
	
		// Constructors
		public Recoil(); // 0x000000018077D260-0x000000018077D2E0
	
		// Methods
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation); // 0x000000018077D230-0x000000018077D260
		public void Fire(float magnitude); // 0x000000018077C000-0x000000018077C1A0
		protected override void OnModifyOffset(); // 0x000000018077C390-0x000000018077D230
		private void AfterFBBIK(); // 0x000000018077BE50-0x000000018077C000
		private void AfterAimIK(); // 0x000000018077BE00-0x000000018077BE50
		protected override void OnDestroy(); // 0x000000018077C1A0-0x000000018077C390
	}
}
