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
	[RequireComponent] // 0x0000000180025590-0x00000001800255E0
	public class PlaySound : MonoBehaviour // TypeDefIndex: 7436
	{
		// Fields
		[Tooltip] // 0x00000001800255E0-0x0000000180025610
		public AudioClip[] waveFile; // 0x18
		[Tooltip] // 0x0000000180025610-0x0000000180025640
		public bool stopOnPlay; // 0x20
		[Tooltip] // 0x0000000180025640-0x0000000180025670
		public bool disableOnEnd; // 0x21
		[Tooltip] // 0x0000000180025670-0x00000001800256A0
		public bool looping; // 0x22
		[Tooltip] // 0x00000001800256A0-0x00000001800256D0
		public bool stopOnEnd; // 0x23
		[Tooltip] // 0x00000001800256D0-0x0000000180025700
		public bool playOnAwakeWithDelay; // 0x24
		[Header] // 0x0000000180025700-0x0000000180025730
		public bool useRandomVolume; // 0x25
		[Range] // 0x0000000180025730-0x0000000180025790
		[Tooltip] // 0x0000000180025730-0x0000000180025790
		public float volMin; // 0x28
		[Range] // 0x0000000180025790-0x00000001800257F0
		[Tooltip] // 0x0000000180025790-0x00000001800257F0
		public float volMax; // 0x2C
		[Header] // 0x00000001800257F0-0x0000000180025850
		[Tooltip] // 0x00000001800257F0-0x0000000180025850
		public bool useRandomPitch; // 0x30
		[Range] // 0x0000000180025850-0x00000001800258B0
		[Tooltip] // 0x0000000180025850-0x00000001800258B0
		public float pitchMin; // 0x34
		[Range] // 0x00000001800258B0-0x0000000180025910
		[Tooltip] // 0x00000001800258B0-0x0000000180025910
		public float pitchMax; // 0x38
		[Header] // 0x0000000180025910-0x0000000180025970
		[Tooltip] // 0x0000000180025910-0x0000000180025970
		public bool useRetriggerTime; // 0x3C
		[Range] // 0x0000000180025970-0x00000001800259C0
		[Tooltip] // 0x0000000180025970-0x00000001800259C0
		public float timeInitial; // 0x40
		[Range] // 0x00000001800259C0-0x0000000180025A10
		[Tooltip] // 0x00000001800259C0-0x0000000180025A10
		public float timeMin; // 0x44
		[Range] // 0x0000000180025A10-0x0000000180025A60
		[Tooltip] // 0x0000000180025A10-0x0000000180025A60
		public float timeMax; // 0x48
		[Header] // 0x0000000180025A60-0x0000000180025AC0
		[Tooltip] // 0x0000000180025A60-0x0000000180025AC0
		public bool useRandomSilence; // 0x4C
		[Range] // 0x0000000180025AC0-0x0000000180025B10
		[Tooltip] // 0x0000000180025AC0-0x0000000180025B10
		public float percentToNotPlay; // 0x50
		[Header] // 0x0000000180025B10-0x0000000180025B70
		[Tooltip] // 0x0000000180025B10-0x0000000180025B70
		public float delayOffsetTime; // 0x54
		private AudioSource audioSource; // 0x58
		private AudioClip clip; // 0x60
	
		// Constructors
		public PlaySound(); // 0x000000018035FFF0-0x0000000180360020
	
		// Methods
		private void Awake(); // 0x000000018035FA30-0x000000018035FB60
		public void Play(); // 0x000000018035FD40-0x000000018035FEA0
		public void PlayWithDelay(float delayTime); // 0x000000018035FCD0-0x000000018035FD40
		public AudioClip PlayOneShotSound(); // 0x000000018035FC10-0x000000018035FCD0
		public AudioClip PlayLooping(); // 0x000000018035FB60-0x000000018035FC10
		public void Disable(); // 0x0000000180355980-0x00000001803559B0
		public void Stop(); // 0x000000018035FFD0-0x000000018035FFF0
		private void SetAudioSource(); // 0x000000018035FEA0-0x000000018035FFD0
	}
}
