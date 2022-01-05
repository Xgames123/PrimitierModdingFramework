/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct HmdMatrix34_t // TypeDefIndex: 6755
	{
		// Fields
		public float m0; // 0x00
		public float m1; // 0x04
		public float m2; // 0x08
		public float m3; // 0x0C
		public float m4; // 0x10
		public float m5; // 0x14
		public float m6; // 0x18
		public float m7; // 0x1C
		public float m8; // 0x20
		public float m9; // 0x24
		public float m10; // 0x28
		public float m11; // 0x2C
	
		// Methods
		public Vector3 GetPosition(); // 0x0000000180911F00-0x0000000180911F20
		public bool IsRotationValid(); // 0x0000000180912180-0x00000001809121E0
		public Quaternion GetRotation(); // 0x0000000180911F20-0x0000000180912180
		private static void _copysign(ref float sizeval, float signval); // 0x00000001809121E0-0x0000000180912210
	}
}
