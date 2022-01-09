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
	public abstract class IK : SolverManager // TypeDefIndex: 8407
	{
		// Constructors
		protected IK(); // 0x0000000180877010-0x0000000180877020
	
		// Methods
		public abstract IKSolver GetIKSolver();
		protected override void UpdateSolver(); // 0x0000000180876F30-0x0000000180877010
		protected override void InitiateSolver(); // 0x0000000180876EC0-0x0000000180876F30
		protected override void FixTransforms(); // 0x0000000180876E50-0x0000000180876EC0
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
