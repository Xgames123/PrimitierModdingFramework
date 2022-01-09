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
	public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 8446
	{
		// Fields
		public int iterations; // 0x58
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float rootPin; // 0x5C
		public FABRIKChain[] chains; // 0x60
		private bool zeroWeightApplied; // 0x68
		private bool[] isRoot; // 0x70
		private Vector3 rootDefaultPosition; // 0x78
	
		// Constructors
		public IKSolverFABRIKRoot(); // 0x0000000180873190-0x00000001808731F0
	
		// Methods
		public override bool IsValid(ref string message); // 0x0000000180872370-0x0000000180872C60
		public override void StoreDefaultLocalState(); // 0x00000001808730C0-0x0000000180873190
		public override void FixTransforms(); // 0x0000000180871B40-0x0000000180871C10
		protected override void OnInitiate(); // 0x0000000180872C60-0x0000000180872E50
		private bool IsRoot(int index); // 0x0000000180872290-0x0000000180872370
		protected override void OnUpdate(); // 0x0000000180872E50-0x00000001808730C0
		public override Point[] GetPoints(); // 0x0000000180872090-0x0000000180872290
		public override Point GetPoint(Transform transform); // 0x0000000180871FE0-0x0000000180872090
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain); // 0x00000001808719E0-0x0000000180871B40
		private Vector3 GetCentroid(); // 0x0000000180871C10-0x0000000180871FE0
	}
}
