/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Obsolete] // 0x00000001800351E0-0x0000000180035210
	public class BlendShapeClipHandler // TypeDefIndex: 7975
	{
		// Fields
		private BlendShapeClip m_clip; // 0x10
		private SkinnedMeshRenderer[] m_renderers; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _LastValue_k__BackingField; // 0x20
	
		// Properties
		[Obsolete] // 0x0000000180035210-0x0000000180035240
		public BlendShapeClip Cilp { get; } // 0x0000000180268FC0-0x0000000180268FD0 
		public BlendShapeClip Clip { get; } // 0x0000000180268FC0-0x0000000180268FD0 
		public float LastValue { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001803374D0-0x00000001803374E0 0x00000001803374E0-0x00000001803374F0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 7974
		{
			// Fields
			public Transform transform; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal SkinnedMeshRenderer _.ctor_b__0(BlendShapeBinding x); // 0x000000018054FA40-0x000000018054FAA0
		}
	
		// Constructors
		public BlendShapeClipHandler(BlendShapeClip clip, Transform transform); // 0x0000000180337320-0x00000001803374D0
	
		// Methods
		public void Apply(float value); // 0x0000000180337180-0x0000000180337320
	}
}
