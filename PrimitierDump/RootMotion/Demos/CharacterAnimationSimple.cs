/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018001CE40-0x000000018001CE90
	public class CharacterAnimationSimple : CharacterAnimationBase // TypeDefIndex: 8362
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private CharacterThirdPerson characterController; // 0x60
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float pivotOffset; // 0x68
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private AnimationCurve moveSpeed; // 0x70
		private Animator animator; // 0x78
	
		// Constructors
		public CharacterAnimationSimple(); // 0x00000001807D03F0-0x00000001807D0410
	
		// Methods
		protected override void Start(); // 0x00000001807D0520-0x00000001807D0570
		public override Vector3 GetPivotPoint(); // 0x00000001807D0410-0x00000001807D0520
		private void Update(); // 0x00000001807D0570-0x00000001807D06E0
	}
}
