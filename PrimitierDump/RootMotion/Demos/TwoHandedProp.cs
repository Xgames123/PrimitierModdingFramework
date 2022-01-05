/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class TwoHandedProp : MonoBehaviour // TypeDefIndex: 8349
	{
		// Fields
		[Tooltip] // 0x000000018001CC10-0x000000018001CC40
		public Transform leftHandTarget; // 0x18
		private FullBodyBipedIK ik; // 0x20
		private Vector3 targetPosRelativeToRight; // 0x28
		private Quaternion targetRotRelativeToRight; // 0x34
	
		// Constructors
		public TwoHandedProp(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x0000000180719F60-0x000000018071A150
		private void LateUpdate(); // 0x0000000180719B60-0x0000000180719E60
		private void AfterFBBIK(); // 0x0000000180719A60-0x0000000180719B60
		private void OnDestroy(); // 0x0000000180719E60-0x0000000180719F60
	}
}
