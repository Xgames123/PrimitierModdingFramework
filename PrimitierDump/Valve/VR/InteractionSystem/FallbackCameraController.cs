/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	[RequireComponent] // 0x0000000180024EE0-0x0000000180024F30
	public class FallbackCameraController : MonoBehaviour // TypeDefIndex: 7402
	{
		// Fields
		public float speed; // 0x18
		public float shiftSpeed; // 0x1C
		public bool showInstructions; // 0x20
		private Vector3 startEulerAngles; // 0x24
		private Vector3 startMousePosition; // 0x30
		private float realTime; // 0x3C
	
		// Constructors
		public FallbackCameraController(); // 0x0000000180590C20-0x0000000180590C40
	
		// Methods
		private void OnEnable(); // 0x00000001805907A0-0x00000001805907C0
		private void Update(); // 0x0000000180590880-0x0000000180590C20
		private void OnGUI(); // 0x00000001805907C0-0x0000000180590880
	}
}
