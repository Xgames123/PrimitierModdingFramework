/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class BlendShapeMerger // TypeDefIndex: 7978
	{
		// Fields
		private Dictionary<BlendShapeKey, BlendShapeClip> m_clipMap; // 0x10
		private Dictionary<BlendShapeKey, float> m_valueMap; // 0x18
		private BlendShapeBindingMerger m_blendShapeBindingMerger; // 0x20
		private MaterialValueBindingMerger m_materialValueBindingMerger; // 0x28
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 7977
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<BlendShapeClip, BlendShapeKey> __9__4_0; // 0x08
			public static Func<BlendShapeClip, BlendShapeClip> __9__4_1; // 0x10
	
			// Constructors
			static __c(); // 0x00000001805506E0-0x0000000180550740
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal BlendShapeKey _.ctor_b__4_0(BlendShapeClip x); // 0x000000018054DDE0-0x000000018054DE60
			internal BlendShapeClip _.ctor_b__4_1(BlendShapeClip x); // 0x00000001802D5FD0-0x00000001802D5FE0
		}
	
		// Constructors
		public BlendShapeMerger(IEnumerable<BlendShapeClip> clips, Transform root); // 0x00000001803386F0-0x00000001803389A0
	
		// Methods
		public void Apply(); // 0x0000000180338100-0x0000000180338140
		public void SetValues(IEnumerable<KeyValuePair<BlendShapeKey, float>> values); // 0x00000001803384F0-0x00000001803386F0
		public void AccumulateValue(BlendShapeKey key, float value); // 0x0000000180337D30-0x0000000180338100
		public void ImmediatelySetValue(BlendShapeKey key, float value); // 0x00000001803381D0-0x0000000180338490
		public void SetValue(BlendShapeKey key, float value, bool immediately); // 0x00000001803384B0-0x00000001803384F0
		public float GetValue(BlendShapeKey key); // 0x0000000180338140-0x00000001803381D0
		public void RestoreMaterialInitialValues(IEnumerable<BlendShapeClip> clips); // 0x0000000180338490-0x00000001803384B0
	}
}
