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
	public class SoundBowClick : MonoBehaviour // TypeDefIndex: 7480
	{
		// Fields
		public AudioClip bowClick; // 0x18
		public AnimationCurve pitchTensionCurve; // 0x20
		public float minPitch; // 0x28
		public float maxPitch; // 0x2C
		private AudioSource thisAudioSource; // 0x30
	
		// Constructors
		public SoundBowClick(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x0000000180366450-0x0000000180366490
		public void PlayBowTensionClicks(float normalizedTension); // 0x0000000180366490-0x00000001803664F0
	}
}
