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
	[RequireComponent] // 0x000000018001C640-0x000000018001C6D0
	[RequireComponent] // 0x000000018001C640-0x000000018001C6D0
	public class FPSCharacter : MonoBehaviour // TypeDefIndex: 8322
	{
		// Fields
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float walkSpeed; // 0x18
		private float sVel; // 0x1C
		private Animator animator; // 0x20
		private FPSAiming FPSAiming; // 0x28
	
		// Constructors
		public FPSCharacter(); // 0x0000000180304CC0-0x0000000180304CD0
	
		// Methods
		private void Start(); // 0x00000001808219C0-0x0000000180821A20
		private void Update(); // 0x0000000180821A20-0x0000000180821B20
		private void OnGUI(); // 0x0000000180821900-0x00000001808219C0
	}
}
