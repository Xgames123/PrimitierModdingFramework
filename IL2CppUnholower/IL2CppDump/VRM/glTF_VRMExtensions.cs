/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public static class glTF_VRMExtensions // TypeDefIndex: 8009
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 8007
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Create_b__0(Transform x); // 0x000000018054EA00-0x000000018054EA40
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 8008
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MaterialValueBinding, glTF_VRM_MaterialValueBind> __9__3_0; // 0x08
			public static Func<Keyframe, IEnumerable<float>> __9__4_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180550440-0x00000001805504A0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal glTF_VRM_MaterialValueBind _Serialize_b__3_0(MaterialValueBinding y); // 0x000000018054DD40-0x000000018054DDE0
			internal IEnumerable<float> _Apply_b__4_0(Keyframe x); // 0x000000018054D630-0x000000018054D720
		}
	
		// Methods
		[Obsolete] // 0x00000001800355C0-0x00000001800355F0
		public static glTF_VRM_BlendShapeBind Cerate(Transform root, BlendShapeBinding binding, gltfExporter exporter); // 0x000000018055E240-0x000000018055E260
		public static glTF_VRM_BlendShapeBind Create(Transform root, BlendShapeBinding binding, gltfExporter exporter); // 0x000000018055E260-0x000000018055E8B0
	
		// Extension methods
		public static void Add(this glTF_VRM_BlendShapeMaster master, BlendShapeClip clip, gltfExporter exporter); // 0x000000018055E030-0x000000018055E0B0
		public static glTF_VRM_BlendShapeGroup Serialize(this BlendShapeClip clip, gltfExporter exporter); // 0x000000018055E8B0-0x000000018055EBF0
		public static void Apply(this glTF_VRM_DegreeMap map, CurveMapper mapper); // 0x000000018055E0B0-0x000000018055E240
	}
}
