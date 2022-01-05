/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace SciFiArsenal
{
	public class SciFiDragMouseOrbit : MonoBehaviour // TypeDefIndex: 8770
	{
		// Fields
		public Transform target; // 0x18
		public float distance; // 0x20
		public float xSpeed; // 0x24
		public float ySpeed; // 0x28
		public float yMinLimit; // 0x2C
		public float yMaxLimit; // 0x30
		public float distanceMin; // 0x34
		public float distanceMax; // 0x38
		public float smoothTime; // 0x3C
		private float rotationYAxis; // 0x40
		private float rotationXAxis; // 0x44
		private float velocityX; // 0x48
		private float velocityY; // 0x4C
	
		// Constructors
		public SciFiDragMouseOrbit(); // 0x0000000180B4F4B0-0x0000000180B4F4F0
	
		// Methods
		private void Start(); // 0x0000000180B4F3C0-0x0000000180B4F4B0
		private void LateUpdate(); // 0x0000000180B4EFC0-0x0000000180B4F3C0
		public static float ClampAngle(float angle, float min, float max); // 0x0000000180B4EF90-0x0000000180B4EFC0
	}
}
