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
	public class Key : MonoBehaviour // TypeDefIndex: 8719
	{
		// Fields
		public Color whiteKeyColor; // 0x18
		public Color blackKeyColor; // 0x28
		public Color activeKeyColor; // 0x38
		public float pressDepth; // 0x48
		[NonSerialized]
		public float activeLevel; // 0x4C
		private Renderer ren; // 0x50
		private Vector3 defaultLocalPos; // 0x58
		private Color inactiveKeyColor; // 0x64
	
		// Nested types
		public enum KeyColor // TypeDefIndex: 8718
		{
			White = 0,
			Black = 1
		}
	
		// Constructors
		public Key(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public void Initialize(KeyColor keyColor, float offset); // 0x0000000180475FF0-0x0000000180476190
		private void Update(); // 0x0000000180476190-0x0000000180476340
	}
}
