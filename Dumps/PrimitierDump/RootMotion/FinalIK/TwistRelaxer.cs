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
	public class TwistRelaxer : MonoBehaviour // TypeDefIndex: 8471
	{
		// Fields
		public IK ik; // 0x18
		[Tooltip] // 0x0000000180020890-0x00000001800208C0
		public Transform parent; // 0x20
		[Tooltip] // 0x00000001800208C0-0x00000001800208F0
		public Transform child; // 0x28
		[Range] // 0x00000001800208F0-0x0000000180020950
		[Tooltip] // 0x00000001800208F0-0x0000000180020950
		public float weight; // 0x30
		[Range] // 0x0000000180020950-0x00000001800209A0
		[Tooltip] // 0x0000000180020950-0x00000001800209A0
		public float parentChildCrossfade; // 0x34
		[Range] // 0x00000001800209A0-0x0000000180020A00
		[Tooltip] // 0x00000001800209A0-0x0000000180020A00
		public float twistAngleOffset; // 0x38
		private Vector3 twistAxis; // 0x3C
		private Vector3 axis; // 0x48
		private Vector3 axisRelativeToParentDefault; // 0x54
		private Vector3 axisRelativeToChildDefault; // 0x60
	
		// Constructors
		public TwistRelaxer(); // 0x0000000180719A00-0x0000000180719A60
	
		// Methods
		public void Relax(); // 0x0000000180719110-0x00000001807194F0
		private void Start(); // 0x00000001807194F0-0x0000000180719A00
		private void OnPostUpdate(); // 0x0000000180719090-0x0000000180719110
		private void LateUpdate(); // 0x0000000180718F00-0x0000000180718F80
		private void OnDestroy(); // 0x0000000180718F80-0x0000000180719090
	}
}
