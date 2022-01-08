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
	internal class MaterialValueBindingMerger // TypeDefIndex: 7988
	{
		// Fields
		private static DictionaryKeyMaterialValueBindingComparer comparer; // 0x00
		private Dictionary<string, Material> m_materialMap; // 0x10
		private Dictionary<MaterialValueBinding, float> m_materialValueMap; // 0x18
		private Dictionary<MaterialValueBinding, Setter> m_materialSetterMap; // 0x20
		private HashSet<MaterialTarget> m_used; // 0x28
	
		// Nested types
		private struct DictionaryKeyMaterialValueBindingComparer : IEqualityComparer<MaterialValueBinding> // TypeDefIndex: 7981
		{
			// Methods
			public bool Equals(MaterialValueBinding x, MaterialValueBinding y); // 0x0000000180549D50-0x0000000180549E90
			public int GetHashCode(MaterialValueBinding obj); // 0x0000000180549E90-0x0000000180549EB0
		}
	
		private delegate void Setter(float value, bool firstValue); // TypeDefIndex: 7982; 0x000000018054A650-0x000000018054A930
	
		private struct MaterialTarget : IEquatable<MaterialTarget> // TypeDefIndex: 7983
		{
			// Fields
			public string MaterialName; // 0x00
			public string ValueName; // 0x08
	
			// Methods
			public bool Equals(MaterialTarget other); // 0x0000000180549F90-0x0000000180549FE0
			public override bool Equals(object obj); // 0x0000000180549EE0-0x0000000180549F90
			public override int GetHashCode(); // 0x0000000180549FE0-0x000000018054A050
			public static MaterialTarget Create(MaterialValueBinding binding); // 0x0000000180549EB0-0x0000000180549EE0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 7984
		{
			// Fields
			public MaterialValueBinding binding; // 0x10
			public Material target; // 0x40
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _.ctor_b__3(float value, bool firstValue); // 0x000000018054FAA0-0x000000018054FD40
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_1 // TypeDefIndex: 7985
		{
			// Fields
			public string valueName; // 0x10
			public __c__DisplayClass6_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass6_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _.ctor_b__1(float value, bool firstValue); // 0x000000018054FD40-0x0000000180550060
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_2 // TypeDefIndex: 7986
		{
			// Fields
			public string valueName; // 0x10
			public __c__DisplayClass6_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass6_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _.ctor_b__2(float value, bool firstValue); // 0x0000000180550060-0x0000000180550380
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 7987
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Material, bool> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001805505C0-0x0000000180550620
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _.ctor_b__6_0(Material y); // 0x000000018054DE60-0x000000018054DEC0
		}
	
		// Constructors
		public MaterialValueBindingMerger(Dictionary<BlendShapeKey, BlendShapeClip> clipMap, Transform root); // 0x000000018033AD40-0x000000018033B940
		static MaterialValueBindingMerger(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public void RestoreMaterialInitialValues(IEnumerable<BlendShapeClip> clips); // 0x000000018033A9E0-0x000000018033AD40
		public void ImmediatelySetValue(BlendShapeClip clip, float value); // 0x000000018033A8E0-0x000000018033A9E0
		public void AccumulateValue(BlendShapeClip clip, float value); // 0x000000018033A1E0-0x000000018033A3A0
		public void Apply(); // 0x000000018033A3A0-0x000000018033A8E0
	}
}
