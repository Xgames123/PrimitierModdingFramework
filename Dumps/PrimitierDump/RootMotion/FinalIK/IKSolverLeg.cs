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
	public class IKSolverLeg : IKSolver // TypeDefIndex: 8452
	{
		// Fields
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float IKRotationWeight; // 0x58
		public Quaternion IKRotation; // 0x5C
		public Point pelvis; // 0x70
		public Point thigh; // 0x78
		public Point calf; // 0x80
		public Point foot; // 0x88
		public Point toe; // 0x90
		public IKSolverVR.Leg leg; // 0x98
		public Vector3 heelOffset; // 0xA0
		private Vector3[] positions; // 0xB0
		private Quaternion[] rotations; // 0xB8
	
		// Constructors
		public IKSolverLeg(); // 0x00000001807EE400-0x00000001807EE570
	
		// Methods
		public override bool IsValid(ref string message); // 0x00000001807ED530-0x00000001807ED8E0
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root); // 0x00000001807EDF90-0x00000001807EE010
		public override Point[] GetPoints(); // 0x00000001807ED330-0x00000001807ED530
		public override Point GetPoint(Transform transform); // 0x00000001807ED120-0x00000001807ED330
		public override void StoreDefaultLocalState(); // 0x00000001807EE110-0x00000001807EE170
		public override void FixTransforms(); // 0x00000001807ED0B0-0x00000001807ED120
		protected override void OnInitiate(); // 0x00000001807ED8E0-0x00000001807ED960
		protected override void OnUpdate(); // 0x00000001807ED960-0x00000001807EDA70
		private void Solve(); // 0x00000001807EE010-0x00000001807EE110
		private void Read(); // 0x00000001807EDA70-0x00000001807EDF90
		private void Write(); // 0x00000001807EE170-0x00000001807EE400
	}
}
