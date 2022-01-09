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
	public class IKSolverCCD : IKSolverHeuristic // TypeDefIndex: 8444
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
	
		// Constructors
		public IKSolverCCD(); // 0x00000001808719D0-0x00000001808719E0
	
		// Methods
		public void FadeOutBoneWeights(); // 0x0000000180870C40-0x0000000180870D20
		protected override void OnInitiate(); // 0x0000000180870D20-0x0000000180870DB0
		protected override void OnUpdate(); // 0x0000000180870DB0-0x00000001808710D0
		private void Solve(Vector3 targetPosition); // 0x00000001808710D0-0x00000001808719D0
	}
}
