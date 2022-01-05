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
	public class FingerRig : SolverManager // TypeDefIndex: 8387
	{
		// Fields
		[Range] // 0x000000018001D750-0x000000018001D7A0
		[Tooltip] // 0x000000018001D750-0x000000018001D7A0
		public float weight; // 0x38
		public Finger[] fingers; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initiated_k__BackingField; // 0x48
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018026BB60-0x000000018026BB70 0x000000018026BFF0-0x000000018026C000
	
		// Constructors
		public FingerRig(); // 0x0000000180822660-0x00000001808226B0
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x0000000180822280-0x0000000180822310
		[ContextMenu] // 0x000000018001D7A0-0x000000018001D7D0
		public void AutoDetect(); // 0x0000000180821DB0-0x0000000180822030
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null); // 0x0000000180821C10-0x0000000180821DB0
		public void RemoveFinger(int index); // 0x0000000180822310-0x00000001808224A0
		private void AddChildrenRecursive(Transform parent, ref Transform[] array); // 0x0000000180821B20-0x0000000180821C10
		protected override void InitiateSolver(); // 0x00000001808221A0-0x0000000180822280
		public void UpdateFingerSolvers(); // 0x00000001808225E0-0x0000000180822660
		public void FixFingerTransforms(); // 0x0000000180822030-0x00000001808221A0
		public void StoreDefaultLocalState(); // 0x00000001808224A0-0x00000001808225E0
		protected override void UpdateSolver(); // 0x00000001808225E0-0x0000000180822660
		protected override void FixTransforms(); // 0x0000000180822030-0x00000001808221A0
	}
}
