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
	public class IKSolverFullBody : IKSolver // TypeDefIndex: 8447
	{
		// Fields
		[Range] // 0x000000018001F750-0x000000018001F770
		public int iterations; // 0x58
		public FBIKChain[] chain; // 0x60
		public IKEffector[] effectors; // 0x68
		public IKMappingSpine spineMapping; // 0x70
		public IKMappingBone[] boneMappings; // 0x78
		public IKMappingLimb[] limbMappings; // 0x80
		public bool FABRIKPass; // 0x88
		public UpdateDelegate OnPreRead; // 0x90
		public UpdateDelegate OnPreSolve; // 0x98
		public IterationDelegate OnPreIteration; // 0xA0
		public IterationDelegate OnPostIteration; // 0xA8
		public UpdateDelegate OnPreBend; // 0xB0
		public UpdateDelegate OnPostSolve; // 0xB8
		public UpdateDelegate OnStoreDefaultLocalState; // 0xC0
		public UpdateDelegate OnFixTransforms; // 0xC8
	
		// Constructors
		public IKSolverFullBody(); // 0x00000001807EB5B0-0x00000001807EB6A0
	
		// Methods
		public IKEffector GetEffector(Transform t); // 0x00000001807EA070-0x00000001807EA190
		public FBIKChain GetChain(Transform transform); // 0x00000001807EA020-0x00000001807EA070
		public int GetChainIndex(Transform transform); // 0x00000001807E9EB0-0x00000001807EA020
		public Node GetNode(int chainIndex, int nodeIndex); // 0x00000001807EA190-0x00000001807EA200
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex); // 0x00000001807E9E20-0x00000001807E9EB0
		public override Point[] GetPoints(); // 0x00000001807EA3C0-0x00000001807EA570
		public override Point GetPoint(Transform transform); // 0x00000001807EA200-0x00000001807EA3C0
		public override bool IsValid(ref string message); // 0x00000001807EA570-0x00000001807EA7F0
		public override void StoreDefaultLocalState(); // 0x00000001807EB370-0x00000001807EB480
		public override void FixTransforms(); // 0x00000001807E9CF0-0x00000001807E9E20
		protected override void OnInitiate(); // 0x00000001807EA7F0-0x00000001807EA9C0
		protected override void OnUpdate(); // 0x00000001807EA9C0-0x00000001807EAB70
		protected virtual void ReadPose(); // 0x00000001807EAB70-0x00000001807EAED0
		protected virtual void Solve(); // 0x00000001807EAED0-0x00000001807EB370
		protected virtual void ApplyBendConstraints(); // 0x00000001807E9CA0-0x00000001807E9CF0
		protected virtual void WritePose(); // 0x00000001807EB480-0x00000001807EB5B0
	}
}
