/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	public class CameraControllerFPS : MonoBehaviour // TypeDefIndex: 8272
	{
		// Fields
		public float rotationSensitivity; // 0x18
		public float yMinLimit; // 0x1C
		public float yMaxLimit; // 0x20
		private float x; // 0x24
		private float y; // 0x28
	
		// Constructors
		public CameraControllerFPS(); // 0x00000001807CF220-0x00000001807CF240
	
		// Methods
		private void Awake(); // 0x00000001807CEFF0-0x00000001807CF040
		public void LateUpdate(); // 0x00000001807CF080-0x00000001807CF220
		private float ClampAngle(float angle, float min, float max); // 0x00000001807CF040-0x00000001807CF080
	}
}
