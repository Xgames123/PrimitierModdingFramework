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
	[Serializable]
	public class MeshPreviewItem // TypeDefIndex: 7992
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Path_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SkinnedMeshRenderer _SkinnedMeshRenderer_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Mesh _Mesh_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string[] _BlendShapeNames_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Material[] _Materials_k__BackingField; // 0x30
		private Transform m_transform; // 0x38
	
		// Properties
		public string Path { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public SkinnedMeshRenderer SkinnedMeshRenderer { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public Mesh Mesh { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public string[] BlendShapeNames { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
		public int BlendShapeCount { get; } // 0x000000018033CCA0-0x000000018033CCC0 
		public Material[] Materials { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		public Vector3 Position { get; } // 0x000000018033CCC0-0x000000018033CD00 
		public Quaternion Rotation { get; } // 0x000000018033CD00-0x000000018033CD40 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass29_0 // TypeDefIndex: 7990
		{
			// Fields
			public Func<Material, Material> getOrCreateMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass29_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Material _Create_b__0(Material x); // 0x000000018054F290-0x000000018054F2F0
			internal Material _Create_b__1(Material x); // 0x000000018054F2F0-0x000000018054F350
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass29_1 // TypeDefIndex: 7991
		{
			// Fields
			public Mesh sharedMesh; // 0x10
	
			// Constructors
			public __c__DisplayClass29_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _Create_b__2(int x); // 0x000000018054F350-0x000000018054F370
		}
	
		// Constructors
		private MeshPreviewItem(string path, Transform transform, Material[] materials); // 0x000000018033CC50-0x000000018033CCA0
	
		// Methods
		public void Bake(IEnumerable<BlendShapeBinding> values, float weight); // 0x000000018033C290-0x000000018033C750
		public static MeshPreviewItem Create(Transform t, Transform root, Func<Material, Material> getOrCreateMaterial); // 0x000000018033C750-0x000000018033CC50
	}
}
