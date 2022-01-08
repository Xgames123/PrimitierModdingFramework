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
	public class SoundPlayOneshot : MonoBehaviour // TypeDefIndex: 7443
	{
		// Fields
		public AudioClip[] waveFiles; // 0x18
		private AudioSource thisAudioSource; // 0x20
		public float volMin; // 0x28
		public float volMax; // 0x2C
		public float pitchMin; // 0x30
		public float pitchMax; // 0x34
		public bool playOnAwake; // 0x38
	
		// Constructors
		public SoundPlayOneshot(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x0000000180366620-0x0000000180366680
		public void Play(); // 0x0000000180366700-0x0000000180366850
		public void Pause(); // 0x0000000180366680-0x0000000180366700
		public void UnPause(); // 0x0000000180366850-0x00000001803668D0
	}
}
