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
	[AddComponentMenu] // 0x000000018001DF20-0x000000018001DF50
	public class GrounderVRIK : Grounder // TypeDefIndex: 8396
	{
		// Fields
		[Tooltip] // 0x000000018001DF50-0x000000018001DF80
		public VRIK ik; // 0x40
		private Transform[] feet; // 0x48
	
		// Constructors
		public GrounderVRIK(); // 0x0000000180863250-0x00000001808632A0
	
		// Methods
		[ContextMenu] // 0x000000018001D9E0-0x000000018001DA10
		private void OpenTutorial(); // 0x0000000180265310-0x0000000180265320
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		protected override void OpenUserManual(); // 0x0000000180265310-0x0000000180265320
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		protected override void OpenScriptReference(); // 0x0000000180265310-0x0000000180265320
		public override void ResetPosition(); // 0x00000001808276C0-0x00000001808276E0
		private bool IsReadyToInitiate(); // 0x0000000180862720-0x00000001808627C0
		private void Update(); // 0x0000000180863170-0x0000000180863250
		private void Initiate(); // 0x0000000180862470-0x0000000180862720
		private void OnSolverUpdate(); // 0x0000000180862D00-0x0000000180863070
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg); // 0x0000000180863070-0x0000000180863170
		private void OnPostSolverUpdate(); // 0x0000000180862AA0-0x0000000180862D00
		private void OnDrawGizmosSelected(); // 0x0000000180862970-0x0000000180862AA0
		private void OnDestroy(); // 0x00000001808627C0-0x0000000180862970
	}
}
