/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace VRtone
{
	public class Mallet : MonoBehaviour // TypeDefIndex: 8720
	{
		// Fields
		private Board board; // 0x18
		private AudioSource audioSource; // 0x20
		private float assistOffset; // 0x28
		private readonly float frequencyRatio; // 0x2C
	
		// Constructors
		public Mallet(); // 0x0000000180485940-0x0000000180485980
	
		// Methods
		private void Start(); // 0x00000001804855A0-0x0000000180485610
		private void OnTriggerEnter(Collider other); // 0x0000000180485430-0x00000001804854C0
		private void OnTriggerExit(Collider other); // 0x00000001804854C0-0x00000001804855A0
		private void Update(); // 0x0000000180485610-0x0000000180485940
	}
}
