/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	public class SolverManager : MonoBehaviour // TypeDefIndex: 8292
	{
		// Fields
		[Tooltip] // 0x000000018001BEB0-0x000000018001BEE0
		public bool fixTransforms; // 0x18
		private Animator animator; // 0x20
		private Animation legacy; // 0x28
		private bool updateFrame; // 0x30
		private bool componentInitiated; // 0x31
		private bool skipSolverUpdate; // 0x32
	
		// Properties
		private bool animatePhysics { get; } // 0x0000000180717E00-0x0000000180717EE0 
		private bool isAnimated { get; } // 0x0000000180717EE0-0x0000000180717F90 
	
		// Constructors
		public SolverManager(); // 0x0000000180366610-0x0000000180366620
	
		// Methods
		public void Disable(); // 0x00000001807179D0-0x0000000180717A60
		protected virtual void InitiateSolver(); // 0x0000000180265310-0x0000000180265320
		protected virtual void UpdateSolver(); // 0x0000000180265310-0x0000000180265320
		protected virtual void FixTransforms(); // 0x0000000180265310-0x0000000180265320
		private void OnDisable(); // 0x0000000180717D20-0x0000000180717D80
		private void Start(); // 0x0000000180717C80-0x0000000180717CD0
		private void Initiate(); // 0x0000000180717C80-0x0000000180717CD0
		private void Update(); // 0x0000000180717DC0-0x0000000180717E00
		private void FindAnimatorRecursive(Transform t, bool findInChildren); // 0x0000000180717A60-0x0000000180717C30
		private void FixedUpdate(); // 0x0000000180717C30-0x0000000180717C80
		private void LateUpdate(); // 0x0000000180717CD0-0x0000000180717D20
		public void UpdateSolverExternal(); // 0x0000000180717D80-0x0000000180717DC0
	}
}
