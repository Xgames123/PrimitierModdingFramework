/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class TargetMeasurement : MonoBehaviour // TypeDefIndex: 7533
	{
		// Fields
		public GameObject visualWrapper; // 0x18
		public Transform measurementTape; // 0x20
		public Transform endPoint; // 0x28
		public UnityEngine.UI.Text measurementTextM; // 0x30
		public UnityEngine.UI.Text measurementTextFT; // 0x38
		public float maxDistanceToDraw; // 0x40
		public bool drawTape; // 0x44
		private float lastDistance; // 0x48
	
		// Constructors
		public TargetMeasurement(); // 0x0000000180C78BC0-0x0000000180C78BD0
	
		// Methods
		private void Update(); // 0x0000000180C787A0-0x0000000180C78BC0
	}
}
