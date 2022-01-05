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
	[Serializable]
	public class IKSolverLookAt : IKSolver // TypeDefIndex: 8457
	{
		// Fields
		public Transform target; // 0x58
		public LookAtBone[] spine; // 0x60
		public LookAtBone head; // 0x68
		public LookAtBone[] eyes; // 0x70
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float bodyWeight; // 0x78
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float headWeight; // 0x7C
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float eyesWeight; // 0x80
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float clampWeight; // 0x84
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float clampWeightHead; // 0x88
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float clampWeightEyes; // 0x8C
		[Range] // 0x000000018001F730-0x000000018001F750
		public int clampSmoothing; // 0x90
		public AnimationCurve spineWeightCurve; // 0x98
		public Vector3 spineTargetOffset; // 0xA0
		private Vector3[] spineForwards; // 0xB0
		private Vector3[] headForwards; // 0xB8
		private Vector3[] eyeForward; // 0xC0
	
		// Properties
		private bool spineIsValid { get; } // 0x00000001807F22E0-0x00000001807F23D0 
		private bool spineIsEmpty { get; } // 0x00000001807F22C0-0x00000001807F22E0 
		private bool headIsValid { get; } // 0x00000001807F22B0-0x00000001807F22C0 
		private bool headIsEmpty { get; } // 0x00000001807F2240-0x00000001807F22B0 
		private bool eyesIsValid { get; } // 0x00000001807F2150-0x00000001807F2240 
		private bool eyesIsEmpty { get; } // 0x00000001807F2130-0x00000001807F2150 
	
		// Nested types
		[Serializable]
		public class LookAtBone : IKSolver.Bone // TypeDefIndex: 8456
		{
			// Properties
			public Vector3 forward { get; } // 0x00000001807134C0-0x0000000180713540 
	
			// Constructors
			public LookAtBone(); // 0x0000000180713480-0x0000000180713490
			public LookAtBone(Transform transform); // 0x0000000180713490-0x00000001807134C0
	
			// Methods
			public void Initiate(Transform root); // 0x0000000180713200-0x0000000180713320
			public void LookAt(Vector3 direction, float weight); // 0x0000000180713320-0x0000000180713480
		}
	
		// Constructors
		public IKSolverLookAt(); // 0x00000001807F1EE0-0x00000001807F2130
	
		// Methods
		public void SetLookAtWeight(float weight); // 0x00000001807F1310-0x00000001807F1340
		public void SetLookAtWeight(float weight, float bodyWeight); // 0x00000001807F1150-0x00000001807F11B0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight); // 0x00000001807F11B0-0x00000001807F1230
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight); // 0x00000001807F10B0-0x00000001807F1150
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight); // 0x00000001807F1230-0x00000001807F1310
		public void SetLookAtWeight(float weight, float bodyWeight = 0f /* Metadata: 0x003A6B5A */, float headWeight = 1f /* Metadata: 0x003A6B5E */, float eyesWeight = 0.5f /* Metadata: 0x003A6B62 */, float clampWeight = 0.5f /* Metadata: 0x003A6B66 */, float clampWeightHead = 0.5f /* Metadata: 0x003A6B6A */, float clampWeightEyes = 0.3f /* Metadata: 0x003A6B6E */); // 0x00000001807F1340-0x00000001807F1450
		public override void StoreDefaultLocalState(); // 0x00000001807F1D80-0x00000001807F1EE0
		public override void FixTransforms(); // 0x00000001807EFD20-0x00000001807EFEA0
		public override bool IsValid(ref string message); // 0x00000001807F06B0-0x00000001807F09C0
		public override Point[] GetPoints(); // 0x00000001807F03E0-0x00000001807F06B0
		public override Point GetPoint(Transform transform); // 0x00000001807F0220-0x00000001807F03E0
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root); // 0x00000001807F1000-0x00000001807F10B0
		protected override void OnInitiate(); // 0x00000001807F09C0-0x00000001807F0D70
		protected override void OnUpdate(); // 0x00000001807F0D70-0x00000001807F0E50
		private void SolveSpine(); // 0x00000001807F1AA0-0x00000001807F1D80
		private void SolveHead(); // 0x00000001807F1770-0x00000001807F1AA0
		private void SolveEyes(); // 0x00000001807F1450-0x00000001807F1770
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp); // 0x00000001807EFEA0-0x00000001807F0220
		private void SetBones(Transform[] array, ref LookAtBone[] bones); // 0x00000001807F0E50-0x00000001807F1000
	}
}
