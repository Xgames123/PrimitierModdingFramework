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
	[AddComponentMenu] // 0x000000018001DAA0-0x000000018001DB00
	[HelpURL] // 0x000000018001DAA0-0x000000018001DB00
	public class GrounderIK : Grounder // TypeDefIndex: 8393
	{
		// Fields
		public IK[] legs; // 0x40
		[Tooltip] // 0x000000018001DB00-0x000000018001DB30
		public Transform pelvis; // 0x48
		[Tooltip] // 0x000000018001DB30-0x000000018001DB60
		public Transform characterRoot; // 0x50
		[Range] // 0x000000018001DB60-0x000000018001DBC0
		[Tooltip] // 0x000000018001DB60-0x000000018001DBC0
		public float rootRotationWeight; // 0x58
		[Tooltip] // 0x000000018001DBC0-0x000000018001DBF0
		public float rootRotationSpeed; // 0x5C
		[Tooltip] // 0x000000018001DBF0-0x000000018001DC20
		public float maxRootRotationAngle; // 0x60
		private Transform[] feet; // 0x68
		private Quaternion[] footRotations; // 0x70
		private Vector3 animatedPelvisLocalPosition; // 0x78
		private Vector3 solvedPelvisLocalPosition; // 0x84
		private int solvedFeet; // 0x90
		private bool solved; // 0x94
		private float lastWeight; // 0x98
		private Rigidbody characterRootRigidbody; // 0xA0
	
		// Constructors
		public GrounderIK(); // 0x0000000180827FB0-0x0000000180828070
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		protected override void OpenUserManual(); // 0x0000000180827680-0x00000001808276C0
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		protected override void OpenScriptReference(); // 0x0000000180827640-0x0000000180827680
		public override void ResetPosition(); // 0x00000001808276C0-0x00000001808276E0
		private bool IsReadyToInitiate(); // 0x0000000180826B60-0x0000000180826D40
		private void OnDisable(); // 0x0000000180826F70-0x00000001808270B0
		private void Update(); // 0x0000000180827B60-0x0000000180827FB0
		private void Initiate(); // 0x0000000180826610-0x0000000180826B60
		private void OnSolverUpdate(); // 0x00000001808272D0-0x0000000180827640
		private void SetLegIK(int index); // 0x00000001808276E0-0x0000000180827B60
		private void OnPostSolverUpdate(); // 0x00000001808270B0-0x00000001808272D0
		private void OnDestroy(); // 0x0000000180826D40-0x0000000180826F70
	}
}
