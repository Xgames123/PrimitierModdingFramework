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
	[AddComponentMenu] // 0x000000018001DC20-0x000000018001DC80
	[HelpURL] // 0x000000018001DC20-0x000000018001DC80
	public class GrounderQuadruped : Grounder // TypeDefIndex: 8395
	{
		// Fields
		[Tooltip] // 0x000000018001DC80-0x000000018001DCB0
		public Grounding forelegSolver; // 0x40
		[Range] // 0x000000018001DCB0-0x000000018001DD00
		[Tooltip] // 0x000000018001DCB0-0x000000018001DD00
		public float rootRotationWeight; // 0x48
		[Range] // 0x000000018001DD00-0x000000018001DD60
		[Tooltip] // 0x000000018001DD00-0x000000018001DD60
		public float minRootRotation; // 0x4C
		[Range] // 0x000000018001DD60-0x000000018001DDB0
		[Tooltip] // 0x000000018001DD60-0x000000018001DDB0
		public float maxRootRotation; // 0x50
		[Tooltip] // 0x000000018001DDB0-0x000000018001DDE0
		public float rootRotationSpeed; // 0x54
		[Tooltip] // 0x000000018001DDE0-0x000000018001DE10
		public float maxLegOffset; // 0x58
		[Tooltip] // 0x000000018001DE10-0x000000018001DE40
		public float maxForeLegOffset; // 0x5C
		[Range] // 0x000000018001DE40-0x000000018001DE90
		[Tooltip] // 0x000000018001DE40-0x000000018001DE90
		public float maintainHeadRotationWeight; // 0x60
		[Tooltip] // 0x000000018001DB30-0x000000018001DB60
		public Transform characterRoot; // 0x68
		[Tooltip] // 0x000000018001DE90-0x000000018001DEC0
		public Transform pelvis; // 0x70
		[Tooltip] // 0x000000018001DEC0-0x000000018001DEF0
		public Transform lastSpineBone; // 0x78
		[Tooltip] // 0x000000018001DEF0-0x000000018001DF20
		public Transform head; // 0x80
		public IK[] legs; // 0x88
		public IK[] forelegs; // 0x90
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Vector3 gravity; // 0x98
		private Foot[] feet; // 0xA8
		private Vector3 animatedPelvisLocalPosition; // 0xB0
		private Quaternion animatedPelvisLocalRotation; // 0xBC
		private Quaternion animatedHeadLocalRotation; // 0xCC
		private Vector3 solvedPelvisLocalPosition; // 0xDC
		private Quaternion solvedPelvisLocalRotation; // 0xE8
		private Quaternion solvedHeadLocalRotation; // 0xF8
		private int solvedFeet; // 0x108
		private bool solved; // 0x10C
		private float angle; // 0x110
		private Transform forefeetRoot; // 0x118
		private Quaternion headRotation; // 0x120
		private float lastWeight; // 0x130
		private Rigidbody characterRootRigidbody; // 0x138
	
		// Nested types
		public struct Foot // TypeDefIndex: 8394
		{
			// Fields
			public IKSolver solver; // 0x00
			public Transform transform; // 0x08
			public Quaternion rotation; // 0x10
			public Grounding.Leg leg; // 0x20
	
			// Constructors
			public Foot(IKSolver solver, Transform transform); // 0x000000018070FEC0-0x000000018070FF10
		}
	
		// Constructors
		public GrounderQuadruped(); // 0x0000000180862350-0x0000000180862470
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		protected override void OpenUserManual(); // 0x0000000180861730-0x0000000180861770
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		protected override void OpenScriptReference(); // 0x00000001808616F0-0x0000000180861730
		public override void ResetPosition(); // 0x0000000180861770-0x00000001808617B0
		private bool IsReadyToInitiate(); // 0x00000001808607C0-0x0000000180860910
		private bool IsReadyToInitiateLegs(IK[] ikComponents); // 0x0000000180860640-0x00000001808607C0
		private void OnDisable(); // 0x0000000180860A40-0x0000000180860AC0
		private void Update(); // 0x00000001808621D0-0x0000000180862350
		private void Initiate(); // 0x0000000180860270-0x0000000180860640
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset); // 0x000000018085FE30-0x0000000180860270
		private void LateUpdate(); // 0x0000000180860910-0x0000000180860A00
		private void RootRotation(); // 0x00000001808617B0-0x0000000180861D20
		private void OnSolverUpdate(); // 0x0000000180860E20-0x00000001808616F0
		private void UpdateForefeetRoot(); // 0x0000000180861EC0-0x00000001808621D0
		private void SetFootIK(Foot foot, float maxOffset); // 0x0000000180861D20-0x0000000180861EC0
		private void OnPostSolverUpdate(); // 0x0000000180860AC0-0x0000000180860E20
		private void OnDestroy(); // 0x0000000180860A00-0x0000000180860A40
		private void DestroyLegs(IK[] ikComponents); // 0x000000018085FC20-0x000000018085FE30
	}
}
