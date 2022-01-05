/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[Serializable]
	public class BipedIKSolvers // TypeDefIndex: 8378
	{
		// Fields
		public IKSolverLimb leftFoot; // 0x10
		public IKSolverLimb rightFoot; // 0x18
		public IKSolverLimb leftHand; // 0x20
		public IKSolverLimb rightHand; // 0x28
		public IKSolverFABRIK spine; // 0x30
		public IKSolverLookAt lookAt; // 0x38
		public IKSolverAim aim; // 0x40
		public Constraints pelvis; // 0x48
		private IKSolverLimb[] _limbs; // 0x50
		private IKSolver[] _ikSolvers; // 0x58
	
		// Properties
		public IKSolverLimb[] limbs { get; } // 0x00000001807C0A50-0x00000001807C0C10 
		public IKSolver[] ikSolvers { get; } // 0x00000001807C07A0-0x00000001807C0A50 
	
		// Constructors
		public BipedIKSolvers(); // 0x00000001807C0630-0x00000001807C07A0
	
		// Methods
		public void AssignReferences(BipedReferences references); // 0x00000001807C0490-0x00000001807C0630
	}
}
