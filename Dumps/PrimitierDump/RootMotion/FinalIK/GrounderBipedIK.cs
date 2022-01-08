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
	[AddComponentMenu] // 0x000000018001D860-0x000000018001D8C0
	[HelpURL] // 0x000000018001D860-0x000000018001D8C0
	public class GrounderBipedIK : Grounder // TypeDefIndex: 8390
	{
		// Fields
		[Tooltip] // 0x000000018001D8C0-0x000000018001D8F0
		public BipedIK ik; // 0x40
		[Tooltip] // 0x000000018001D8F0-0x000000018001D920
		public float spineBend; // 0x48
		[Tooltip] // 0x000000018001D920-0x000000018001D950
		public float spineSpeed; // 0x4C
		private Transform[] feet; // 0x50
		private Quaternion[] footRotations; // 0x58
		private Vector3 animatedPelvisLocalPosition; // 0x60
		private Vector3 solvedPelvisLocalPosition; // 0x6C
		private Vector3 spineOffset; // 0x78
		private float lastWeight; // 0x84
	
		// Constructors
		public GrounderBipedIK(); // 0x0000000180825460-0x0000000180825530
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		protected override void OpenUserManual(); // 0x00000001808251C0-0x0000000180825200
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		protected override void OpenScriptReference(); // 0x0000000180825180-0x00000001808251C0
		public override void ResetPosition(); // 0x0000000180825200-0x0000000180825250
		private bool IsReadyToInitiate(); // 0x0000000180824610-0x00000001808246D0
		private void Update(); // 0x0000000180825360-0x0000000180825460
		private void Initiate(); // 0x0000000180824280-0x0000000180824610
		private void OnDisable(); // 0x0000000180824890-0x00000001808248F0
		private void OnSolverUpdate(); // 0x0000000180824B00-0x0000000180825180
		private void SetLegIK(IKSolverLimb limb, int index); // 0x0000000180825250-0x0000000180825360
		private void OnPostSolverUpdate(); // 0x00000001808248F0-0x0000000180824B00
		private void OnDestroy(); // 0x00000001808246D0-0x0000000180824890
	}
}
