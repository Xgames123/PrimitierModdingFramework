/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace VRtone
{
	public class Board : MonoBehaviour // TypeDefIndex: 8717
	{
		// Fields
		public GameObject key; // 0x18
		public int keyCount; // 0x20
		public int centerKey; // 0x24
		public float keyWidth; // 0x28
		public float keyDepth; // 0x2C
		public float keyLength; // 0x30
		public float blackKeyOffset; // 0x34
		public float assistLevel; // 0x38
		private readonly float keyAppearanceWidthRatio; // 0x3C
		private readonly bool[] blackKeys; // 0x40
		private GameObject[] keys; // 0x48
		private Key[] keyScripts; // 0x50
		private List<GameObject> mallets; // 0x58
	
		// Constructors
		public Board(); // 0x0000000180533540-0x0000000180533600
	
		// Methods
		private void Start(); // 0x0000000180532C20-0x0000000180533260
		private void OnTriggerEnter(Collider other); // 0x0000000180532AE0-0x0000000180532B80
		private void OnTriggerExit(Collider other); // 0x0000000180532B80-0x0000000180532C20
		private void Update(); // 0x0000000180533260-0x0000000180533540
		private int Mod(int a, int b); // 0x0000000180532AA0-0x0000000180532AE0
	}
}
