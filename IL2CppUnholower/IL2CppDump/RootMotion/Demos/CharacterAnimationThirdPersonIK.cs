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
	[RequireComponent] // 0x000000018001C3F0-0x000000018001C440
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson // TypeDefIndex: 8312
	{
		// Fields
		private FullBodyBipedIK ik; // 0x90
	
		// Constructors
		public CharacterAnimationThirdPersonIK(); // 0x00000001807D0BB0-0x00000001807D0BE0
	
		// Methods
		protected override void Start(); // 0x00000001807D0AF0-0x00000001807D0BB0
		protected override void LateUpdate(); // 0x00000001807D06E0-0x00000001807D0950
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp); // 0x00000001807D0950-0x00000001807D0AF0
	}
}
