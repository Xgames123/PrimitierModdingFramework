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
	internal class BlendShapeBindingMerger // TypeDefIndex: 7970
	{
		// Fields
		private static DictionaryKeyBlendShapeBindingComparer comparer; // 0x00
		private Dictionary<BlendShapeBinding, float> m_blendShapeValueMap; // 0x10
		private Dictionary<BlendShapeBinding, Action<float>> m_blendShapeSetterMap; // 0x18
	
		// Nested types
		private class DictionaryKeyBlendShapeBindingComparer : IEqualityComparer<BlendShapeBinding> // TypeDefIndex: 7968
		{
			// Constructors
			public DictionaryKeyBlendShapeBindingComparer(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public bool Equals(BlendShapeBinding x, BlendShapeBinding y); // 0x0000000180549CB0-0x0000000180549D10
			public int GetHashCode(BlendShapeBinding obj); // 0x0000000180549D10-0x0000000180549D50
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 7969
		{
			// Fields
			public BlendShapeBinding binding; // 0x10
			public SkinnedMeshRenderer target; // 0x20
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _.ctor_b__0(float x); // 0x000000018054FA10-0x000000018054FA40
		}
	
		// Constructors
		public BlendShapeBindingMerger(Dictionary<BlendShapeKey, BlendShapeClip> clipMap, Transform root); // 0x0000000180336910-0x0000000180336F60
		static BlendShapeBindingMerger(); // 0x00000001803368B0-0x0000000180336910
	
		// Methods
		public void ImmediatelySetValue(BlendShapeClip clip, float value); // 0x00000001803367B0-0x00000001803368B0
		public void AccumulateValue(BlendShapeClip clip, float value); // 0x00000001803363F0-0x0000000180336570
		public void Apply(); // 0x0000000180336570-0x00000001803367B0
	}
}
