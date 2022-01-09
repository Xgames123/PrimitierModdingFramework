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
	public class IKSolverArm : IKSolver // TypeDefIndex: 8443
	{
		// Fields
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float IKRotationWeight; // 0x58
		public Quaternion IKRotation; // 0x5C
		public Point chest; // 0x70
		public Point shoulder; // 0x78
		public Point upperArm; // 0x80
		public Point forearm; // 0x88
		public Point hand; // 0x90
		public bool isLeft; // 0x98
		public IKSolverVR.Arm arm; // 0xA0
		private Vector3[] positions; // 0xA8
		private Quaternion[] rotations; // 0xB0
	
		// Constructors
		public IKSolverArm(); // 0x0000000180870AD0-0x0000000180870C40
	
		// Methods
		public override bool IsValid(ref string message); // 0x000000018086FC80-0x0000000180870160
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root); // 0x00000001807EDF90-0x00000001807EE010
		public override Point[] GetPoints(); // 0x000000018086FA80-0x000000018086FC80
		public override Point GetPoint(Transform transform); // 0x000000018086F870-0x000000018086FA80
		public override void StoreDefaultLocalState(); // 0x00000001807EE110-0x00000001807EE170
		public override void FixTransforms(); // 0x00000001807ED0B0-0x00000001807ED120
		protected override void OnInitiate(); // 0x0000000180870160-0x00000001808701E0
		protected override void OnUpdate(); // 0x00000001808701E0-0x0000000180870280
		private void Solve(); // 0x00000001808707B0-0x0000000180870840
		private void Read(); // 0x0000000180870280-0x00000001808707B0
		private void Write(); // 0x0000000180870840-0x0000000180870AD0
	}
}
