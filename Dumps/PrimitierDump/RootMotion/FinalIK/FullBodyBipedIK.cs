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
	[AddComponentMenu] // 0x000000018001E530-0x000000018001E590
	[HelpURL] // 0x000000018001E530-0x000000018001E590
	public class FullBodyBipedIK : IK // TypeDefIndex: 8406
	{
		// Fields
		public BipedReferences references; // 0x38
		public IKSolverFullBodyBiped solver; // 0x40
	
		// Constructors
		public FullBodyBipedIK(); // 0x0000000180823C10-0x0000000180823CA0
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		protected override void OpenUserManual(); // 0x00000001808234A0-0x00000001808234E0
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		protected override void OpenScriptReference(); // 0x0000000180823420-0x0000000180823460
		[ContextMenu] // 0x000000018001E590-0x000000018001E5C0
		private void OpenSetupTutorial(); // 0x0000000180823460-0x00000001808234A0
		[ContextMenu] // 0x000000018001E5C0-0x000000018001E5F0
		private void OpenInspectorTutorial(); // 0x00000001808233E0-0x0000000180823420
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x0000000180823BD0-0x0000000180823C10
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x00000001808232C0-0x0000000180823300
		public void SetReferences(BipedReferences references, Transform rootNode); // 0x0000000180823BA0-0x0000000180823BD0
		public override IKSolver GetIKSolver(); // 0x0000000180268310-0x0000000180268320
		public bool ReferencesError(ref string errorMessage); // 0x00000001808234E0-0x0000000180823740
		public bool ReferencesWarning(ref string warningMessage); // 0x0000000180823740-0x0000000180823B70
		[ContextMenu] // 0x000000018001E5F0-0x000000018001E620
		private void Reinitiate(); // 0x0000000180823B70-0x0000000180823BA0
		[ContextMenu] // 0x000000018001E620-0x000000018001E650
		private void AutoDetectReferences(); // 0x0000000180823300-0x00000001808233E0
	}
}
