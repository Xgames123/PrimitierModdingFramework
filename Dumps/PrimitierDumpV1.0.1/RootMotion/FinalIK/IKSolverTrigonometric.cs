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
	public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 8459
	{
		// Fields
		public Transform target; // 0x58
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float IKRotationWeight; // 0x60
		public Quaternion IKRotation; // 0x64
		public Vector3 bendNormal; // 0x74
		public TrigonometricBone bone1; // 0x80
		public TrigonometricBone bone2; // 0x88
		public TrigonometricBone bone3; // 0x90
		protected Vector3 weightIKPosition; // 0x98
		protected bool directHierarchy; // 0xA4
	
		// Nested types
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone // TypeDefIndex: 8458
		{
			// Fields
			private Quaternion targetToLocalSpace; // 0x80
			private Vector3 defaultLocalBendNormal; // 0x90
	
			// Constructors
			public TrigonometricBone(); // 0x0000000180713480-0x0000000180713490
	
			// Methods
			public void Initiate(Vector3 childPosition, Vector3 bendNormal); // 0x0000000180718BA0-0x0000000180718D30
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal); // 0x0000000180718B10-0x0000000180718BA0
			public Vector3 GetBendNormalFromCurrentRotation(); // 0x0000000180718A90-0x0000000180718B10
		}
	
		// Constructors
		public IKSolverTrigonometric(); // 0x00000001807F4D40-0x00000001807F4E20
	
		// Methods
		public void SetBendGoalPosition(Vector3 goalPosition, float weight); // 0x00000001807F4010-0x00000001807F4280
		public void SetBendPlaneToCurrent(); // 0x00000001807F4280-0x00000001807F44A0
		public void SetIKRotation(Quaternion rotation); // 0x00000001807F4530-0x00000001807F4540
		public void SetIKRotationWeight(float weight); // 0x00000001807F4500-0x00000001807F4530
		public Quaternion GetIKRotation(); // 0x00000001807F28D0-0x00000001807F28E0
		public float GetIKRotationWeight(); // 0x00000001807F28C0-0x00000001807F28D0
		public override Point[] GetPoints(); // 0x00000001807F2A40-0x00000001807F2B90
		public override Point GetPoint(Transform transform); // 0x00000001807F28E0-0x00000001807F2A40
		public override void StoreDefaultLocalState(); // 0x00000001807F4CF0-0x00000001807F4D40
		public override void FixTransforms(); // 0x00000001807F23D0-0x00000001807F2430
		public override bool IsValid(ref string message); // 0x00000001807F2FB0-0x00000001807F3430
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root); // 0x00000001807F44A0-0x00000001807F4500
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x00000001807F4540-0x00000001807F4CF0
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x00000001807F2700-0x00000001807F28C0
		protected override void OnInitiate(); // 0x00000001807F3430-0x00000001807F3640
		private bool IsDirectHierarchy(); // 0x00000001807F2E80-0x00000001807F2FB0
		private void InitiateBones(); // 0x00000001807F2B90-0x00000001807F2E80
		protected override void OnUpdate(); // 0x00000001807F3640-0x00000001807F4010
		protected virtual void OnInitiateVirtual(); // 0x0000000180265310-0x0000000180265320
		protected virtual void OnUpdateVirtual(); // 0x0000000180265310-0x0000000180265320
		protected virtual void OnPostSolveVirtual(); // 0x0000000180265310-0x0000000180265320
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal); // 0x00000001807F2430-0x00000001807F2700
	}
}
