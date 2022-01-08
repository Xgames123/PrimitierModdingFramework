/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018001C440-0x000000018001C490
	public class CharacterController3rdPerson : MonoBehaviour // TypeDefIndex: 8313
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private CameraController cam; // 0x18
		private AnimatorController3rdPerson animatorController; // 0x20
	
		// Properties
		private static Vector3 inputVector { get; } // 0x00000001807D2330-0x00000001807D23B0 
		private static Vector3 inputVectorRaw { get; } // 0x00000001807D22B0-0x00000001807D2330 
	
		// Constructors
		public CharacterController3rdPerson(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x00000001807D2250-0x00000001807D22B0
		private void LateUpdate(); // 0x00000001807D1F30-0x00000001807D2250
	}
}
