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
	public class TransferMotion : MonoBehaviour // TypeDefIndex: 8348
	{
		// Fields
		[Tooltip] // 0x000000018001CB80-0x000000018001CBB0
		public Transform to; // 0x18
		[Range] // 0x000000018001CBB0-0x000000018001CC10
		[Tooltip] // 0x000000018001CBB0-0x000000018001CC10
		public float transferMotion; // 0x20
		private Vector3 lastPosition; // 0x24
	
		// Constructors
		public TransferMotion(); // 0x0000000180718870-0x0000000180718880
	
		// Methods
		private void OnEnable(); // 0x00000001807186D0-0x0000000180718710
		private void Update(); // 0x0000000180718710-0x0000000180718870
	}
}
