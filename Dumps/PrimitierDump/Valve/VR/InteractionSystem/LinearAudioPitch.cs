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
	public class LinearAudioPitch : MonoBehaviour // TypeDefIndex: 7430
	{
		// Fields
		public LinearMapping linearMapping; // 0x18
		public AnimationCurve pitchCurve; // 0x20
		public float minPitch; // 0x28
		public float maxPitch; // 0x2C
		public bool applyContinuously; // 0x30
		private AudioSource audioSource; // 0x38
	
		// Constructors
		public LinearAudioPitch(); // 0x000000018035CE50-0x000000018035CE60
	
		// Methods
		private void Awake(); // 0x000000018035CD00-0x000000018035CDE0
		private void Update(); // 0x000000018035CDE0-0x000000018035CE50
		private void Apply(); // 0x000000018035CC90-0x000000018035CD00
	}
}
