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
	[AddComponentMenu] // 0x000000018001D950-0x000000018001D9B0
	[HelpURL] // 0x000000018001D950-0x000000018001D9B0
	public class GrounderFBBIK : Grounder // TypeDefIndex: 8392
	{
		// Fields
		[Tooltip] // 0x000000018001D9B0-0x000000018001D9E0
		public FullBodyBipedIK ik; // 0x40
		[Tooltip] // 0x000000018001D8F0-0x000000018001D920
		public float spineBend; // 0x48
		[Tooltip] // 0x000000018001D920-0x000000018001D950
		public float spineSpeed; // 0x4C
		public SpineEffector[] spine; // 0x50
		private Transform[] feet; // 0x58
		private Vector3 spineOffset; // 0x60
		private bool firstSolve; // 0x6C
	
		// Nested types
		[Serializable]
		public class SpineEffector // TypeDefIndex: 8391
		{
			// Fields
			[Tooltip] // 0x000000018001DA10-0x000000018001DA40
			public FullBodyBipedEffector effectorType; // 0x10
			[Tooltip] // 0x000000018001DA40-0x000000018001DA70
			public float horizontalWeight; // 0x14
			[Tooltip] // 0x000000018001DA70-0x000000018001DAA0
			public float verticalWeight; // 0x18
	
			// Constructors
			public SpineEffector(); // 0x0000000180717FE0-0x0000000180717FF0
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight); // 0x0000000180717F90-0x0000000180717FE0
		}
	
		// Constructors
		public GrounderFBBIK(); // 0x0000000180826550-0x0000000180826610
	
		// Methods
		[ContextMenu] // 0x000000018001D9E0-0x000000018001DA10
		private void OpenTutorial(); // 0x0000000180826210-0x0000000180826250
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		protected override void OpenUserManual(); // 0x0000000180826250-0x0000000180826290
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		protected override void OpenScriptReference(); // 0x00000001808261D0-0x0000000180826210
		public override void ResetPosition(); // 0x0000000180826290-0x00000001808262D0
		private bool IsReadyToInitiate(); // 0x00000001808259A0-0x0000000180825A40
		private void Update(); // 0x0000000180826470-0x0000000180826550
		private void FixedUpdate(); // 0x00000001808256F0-0x0000000180825700
		private void LateUpdate(); // 0x00000001808256F0-0x0000000180825700
		private void Initiate(); // 0x0000000180825700-0x00000001808259A0
		private void OnSolverUpdate(); // 0x0000000180825C90-0x00000001808261D0
		private void SetLegIK(IKEffector effector, Grounding.Leg leg); // 0x00000001808262D0-0x0000000180826470
		private void OnDrawGizmosSelected(); // 0x0000000180825B60-0x0000000180825C90
		private void OnDestroy(); // 0x0000000180825A40-0x0000000180825B60
	}
}
