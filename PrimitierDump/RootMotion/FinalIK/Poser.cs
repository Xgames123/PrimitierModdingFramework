/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public abstract class Poser : SolverManager // TypeDefIndex: 8494
	{
		// Fields
		public Transform poseRoot; // 0x38
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float weight; // 0x40
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float localRotationWeight; // 0x44
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float localPositionWeight; // 0x48
		private bool initiated; // 0x4C
	
		// Constructors
		protected Poser(); // 0x00000001807797D0-0x00000001807797F0
	
		// Methods
		public abstract void AutoMapping();
		public void UpdateManual(); // 0x0000000180779760-0x0000000180779780
		protected abstract void InitiatePoser();
		protected abstract void UpdatePoser();
		protected abstract void FixPoserTransforms();
		protected override void UpdateSolver(); // 0x0000000180779780-0x00000001807797D0
		protected override void InitiateSolver(); // 0x0000000180779730-0x0000000180779760
		protected override void FixTransforms(); // 0x0000000180779710-0x0000000180779730
	}
}
