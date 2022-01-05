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
	public class Balloon : MonoBehaviour // TypeDefIndex: 7471
	{
		// Fields
		private Hand hand; // 0x18
		public GameObject popPrefab; // 0x20
		public float maxVelocity; // 0x28
		public float lifetime; // 0x2C
		public bool burstOnLifetimeEnd; // 0x30
		public GameObject lifetimeEndParticlePrefab; // 0x38
		public SoundPlayOneshot lifetimeEndSound; // 0x40
		private float destructTime; // 0x48
		private float releaseTime; // 0x4C
		public SoundPlayOneshot collisionSound; // 0x50
		private float lastSoundTime; // 0x58
		private float soundDelay; // 0x5C
		private Rigidbody balloonRigidbody; // 0x60
		private bool bParticlesSpawned; // 0x68
		private static float s_flLastDeathSound; // 0x00
	
		// Nested types
		public enum BalloonColor // TypeDefIndex: 7470
		{
			Red = 0,
			OrangeRed = 1,
			Orange = 2,
			YellowOrange = 3,
			Yellow = 4,
			GreenYellow = 5,
			Green = 6,
			BlueGreen = 7,
			Blue = 8,
			VioletBlue = 9,
			Violet = 10,
			RedViolet = 11,
			LightGray = 12,
			DarkGray = 13,
			Random = 14
		}
	
		// Constructors
		public Balloon(); // 0x0000000180586160-0x0000000180586190
		static Balloon(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		private void Start(); // 0x0000000180586020-0x00000001805860C0
		private void Update(); // 0x00000001805860C0-0x0000000180586160
		private void SpawnParticles(GameObject particlePrefab, SoundPlayOneshot sound); // 0x0000000180585D80-0x0000000180586020
		private void FixedUpdate(); // 0x0000000180585860-0x0000000180585940
		private void ApplyDamage(); // 0x0000000180585530-0x00000001805855B0
		private void OnCollisionEnter(Collision collision); // 0x0000000180585940-0x0000000180585CE0
		public void SetColor(BalloonColor color); // 0x0000000180585CE0-0x0000000180585D80
		private Color BalloonColorToRGB(BalloonColor balloonColorVar); // 0x00000001805855B0-0x0000000180585860
	}
}
