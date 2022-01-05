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
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 8451
	{
		// Fields
		public Transform target; // 0x58
		public float tolerance; // 0x60
		public int maxIterations; // 0x64
		public bool useRotationLimits; // 0x68
		public bool XY; // 0x69
		public Bone[] bones; // 0x70
		protected Vector3 lastLocalDirection; // 0x78
		protected float chainLength; // 0x84
	
		// Properties
		protected virtual int minBones { get; } // 0x0000000180394DB0-0x0000000180394DC0 
		protected virtual bool boneLengthCanBeZero { get; } // 0x00000001802942D0-0x00000001802942E0 
		protected virtual bool allowCommonParent { get; } // 0x0000000180295620-0x0000000180295630 
		protected virtual Vector3 localDirection { get; } // 0x00000001807ECE90-0x00000001807ED030 
		protected float positionOffset { get; } // 0x00000001807ED030-0x00000001807ED0B0 
	
		// Constructors
		public IKSolverHeuristic(); // 0x00000001807ECE30-0x00000001807ECE90
	
		// Methods
		public bool SetChain(Transform[] hierarchy, Transform root); // 0x00000001807EC920-0x00000001807ECAC0
		public void AddBone(Transform bone); // 0x00000001807EB6A0-0x00000001807EB840
		public override void StoreDefaultLocalState(); // 0x00000001807ECDB0-0x00000001807ECE30
		public override void FixTransforms(); // 0x00000001807EB840-0x00000001807EB8D0
		public override bool IsValid(ref string message); // 0x00000001807EC510-0x00000001807EC920
		public override Point[] GetPoints(); // 0x00000001802DC790-0x00000001802DC800
		public override Point GetPoint(Transform transform); // 0x00000001807EB8D0-0x00000001807EB9F0
		protected override void OnInitiate(); // 0x0000000180265310-0x0000000180265320
		protected override void OnUpdate(); // 0x0000000180265310-0x0000000180265320
		protected void InitiateBones(); // 0x00000001807EBE40-0x00000001807EC510
		protected Vector3 GetSingularityOffset(); // 0x00000001807EB9F0-0x00000001807EBE40
		private bool SingularityDetected(); // 0x00000001807ECAC0-0x00000001807ECDB0
	}
}
