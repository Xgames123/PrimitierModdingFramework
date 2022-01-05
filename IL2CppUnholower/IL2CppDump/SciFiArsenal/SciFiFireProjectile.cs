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
	public class SciFiFireProjectile : MonoBehaviour // TypeDefIndex: 8771
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public GameObject[] projectiles; // 0x18
		[Header] // 0x000000018002EB60-0x000000018002EB90
		public Transform spawnPosition; // 0x20
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public int currentProjectile; // 0x28
		public float speed; // 0x2C
		private SciFiButtonScript selectedProjectileButton; // 0x30
		private RaycastHit hit; // 0x38
	
		// Constructors
		public SciFiFireProjectile(); // 0x0000000180B4FAD0-0x0000000180B4FAE0
	
		// Methods
		private void Start(); // 0x0000000180B4F4F0-0x0000000180B4F560
		private void Update(); // 0x0000000180B4F560-0x0000000180B4FAD0
		public void nextEffect(); // 0x0000000180B4FAE0-0x0000000180B4FB20
		public void previousEffect(); // 0x0000000180B4FB20-0x0000000180B4FB60
		public void AdjustSpeed(float newSpeed); // 0x000000018036B5F0-0x000000018036B600
	}
}
