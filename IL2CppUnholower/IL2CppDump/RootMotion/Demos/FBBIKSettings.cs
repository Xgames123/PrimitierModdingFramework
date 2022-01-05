/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class FBBIKSettings : MonoBehaviour // TypeDefIndex: 8317
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public bool disableAfterStart; // 0x20
		public Limb leftArm; // 0x28
		public Limb rightArm; // 0x30
		public Limb leftLeg; // 0x38
		public Limb rightLeg; // 0x40
		public float rootPin; // 0x48
		public bool bodyEffectChildNodes; // 0x4C
	
		// Nested types
		[Serializable]
		public class Limb // TypeDefIndex: 8316
		{
			// Fields
			public FBIKChain.Smoothing reachSmoothing; // 0x10
			public float maintainRelativePositionWeight; // 0x14
			public float mappingWeight; // 0x18
	
			// Constructors
			public Limb(); // 0x00000001807131F0-0x0000000180713200
	
			// Methods
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver); // 0x0000000180713170-0x00000001807131F0
		}
	
		// Constructors
		public FBBIKSettings(); // 0x000000018081BF50-0x000000018081BF60
	
		// Methods
		public void UpdateSettings(); // 0x000000018081BDC0-0x000000018081BF40
		private void Start(); // 0x000000018081BD30-0x000000018081BDC0
		private void Update(); // 0x000000018081BF40-0x000000018081BF50
	}
}
