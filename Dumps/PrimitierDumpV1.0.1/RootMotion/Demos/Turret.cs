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
	public class Turret : MonoBehaviour // TypeDefIndex: 8356
	{
		// Fields
		public Transform target; // 0x18
		public Part[] parts; // 0x20
	
		// Nested types
		[Serializable]
		public class Part // TypeDefIndex: 8355
		{
			// Fields
			public Transform transform; // 0x10
			private RotationLimit rotationLimit; // 0x18
	
			// Constructors
			public Part(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public void AimAt(Transform target); // 0x0000000180848140-0x0000000180848280
		}
	
		// Constructors
		public Turret(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Update(); // 0x0000000180718E90-0x0000000180718F00
	}
}
