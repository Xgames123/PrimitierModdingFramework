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
	public class IKMappingBone : IKMapping // TypeDefIndex: 8432
	{
		// Fields
		public Transform bone; // 0x10
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float maintainRotationWeight; // 0x18
		private BoneMap boneMap; // 0x20
	
		// Constructors
		public IKMappingBone(); // 0x000000018086AE00-0x000000018086AE70
		public IKMappingBone(Transform bone); // 0x000000018086AE70-0x000000018086AEF0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018086AD00-0x000000018086AD90
		public void StoreDefaultLocalState(); // 0x000000018086ADB0-0x000000018086ADD0
		public void FixTransforms(); // 0x000000018086AC40-0x000000018086AC70
		public override void Initiate(IKSolverFullBody solver); // 0x000000018086AC70-0x000000018086AD00
		public void ReadPose(); // 0x000000018086AD90-0x000000018086ADB0
		public void WritePose(float solverWeight); // 0x000000018086ADD0-0x000000018086AE00
	}
}
