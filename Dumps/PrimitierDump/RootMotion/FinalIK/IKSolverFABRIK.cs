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
	public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 8445
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
		private bool[] limitedBones; // 0x90
		private Vector3[] solverLocalPositions; // 0x98
	
		// Properties
		protected override bool boneLengthCanBeZero { get; } // 0x0000000180295620-0x0000000180295630 
	
		// Constructors
		public IKSolverFABRIK(); // 0x0000000180876520-0x0000000180876590
	
		// Methods
		public void SolveForward(Vector3 position); // 0x0000000180875E90-0x0000000180875F40
		public void SolveBackward(Vector3 position); // 0x0000000180875DC0-0x0000000180875E90
		public override Vector3 GetIKPosition(); // 0x0000000180873F20-0x0000000180873FD0
		protected override void OnInitiate(); // 0x0000000180874F90-0x0000000180875380
		protected override void OnUpdate(); // 0x0000000180875AB0-0x0000000180875DC0
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length); // 0x0000000180875F40-0x0000000180876060
		private void OnPreSolve(); // 0x00000001808754E0-0x0000000180875AB0
		private void OnPostSolve(); // 0x0000000180875380-0x00000001808754E0
		private void Solve(Vector3 targetPosition); // 0x0000000180876060-0x0000000180876110
		private void ForwardReach(Vector3 position); // 0x0000000180873C10-0x0000000180873F20
		private void SolverMove(int index, Vector3 offset); // 0x00000001808762B0-0x0000000180876380
		private void SolverRotate(int index, Quaternion rotation, bool recursive); // 0x0000000180876440-0x0000000180876520
		private void SolverRotateChildren(int index, Quaternion rotation); // 0x0000000180876380-0x0000000180876440
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation); // 0x0000000180876110-0x00000001808762B0
		private Quaternion GetParentSolverRotation(int index); // 0x00000001808742B0-0x0000000180874420
		private Vector3 GetParentSolverPosition(int index); // 0x0000000180874130-0x00000001808742B0
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed); // 0x0000000180873FD0-0x0000000180874130
		private void LimitForward(int rotateBone, int limitBone); // 0x0000000180874420-0x0000000180874CB0
		private void BackwardReach(Vector3 position); // 0x0000000180873BD0-0x0000000180873C10
		private void BackwardReachUnlimited(Vector3 position); // 0x00000001808739D0-0x0000000180873BD0
		private void BackwardReachLimited(Vector3 position); // 0x00000001808731F0-0x00000001808739D0
		private void MapToSolverPositions(); // 0x0000000180874DC0-0x0000000180874F90
		private void MapToSolverPositionsLimited(); // 0x0000000180874CB0-0x0000000180874DC0
	}
}
