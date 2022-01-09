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
	public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 8442
	{
		// Fields
		public Transform transform; // 0x88
		public Vector3 axis; // 0x90
		public Vector3 poleAxis; // 0x9C
		public Vector3 polePosition; // 0xA8
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float poleWeight; // 0xB4
		public Transform poleTarget; // 0xB8
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float clampWeight; // 0xC0
		[Range] // 0x000000018001F730-0x000000018001F750
		public int clampSmoothing; // 0xC4
		public IterationDelegate OnPreIteration; // 0xC8
		private float step; // 0xD0
		private Vector3 clampedIKPosition; // 0xD4
		private RotationLimit transformLimit; // 0xE0
		private Transform lastTransform; // 0xE8
	
		// Properties
		public Vector3 transformAxis { get; } // 0x000000018086F750-0x000000018086F7E0 
		public Vector3 transformPoleAxis { get; } // 0x000000018086F7E0-0x000000018086F870 
		protected override int minBones { get; } // 0x0000000180398E30-0x0000000180398E40 
		protected override Vector3 localDirection { get; } // 0x000000018086F680-0x000000018086F750 
	
		// Constructors
		public IKSolverAim(); // 0x000000018086F610-0x000000018086F680
	
		// Methods
		public float GetAngle(); // 0x000000018086DDD0-0x000000018086DEF0
		protected override void OnInitiate(); // 0x000000018086E410-0x000000018086E7C0
		protected override void OnUpdate(); // 0x000000018086E7C0-0x000000018086EE90
		private void Solve(); // 0x000000018086F4D0-0x000000018086F610
		private Vector3 GetClampedIKPosition(); // 0x000000018086DEF0-0x000000018086E410
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight); // 0x000000018086EE90-0x000000018086F4D0
	}
}
