/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace MeshUtility
{
	public class MeshIntegrator // TypeDefIndex: 5669
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Vector3> _Positions_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Vector3> _Normals_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Vector2> _UV_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Vector4> _Tangents_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<BoneWeight> _BoneWeights_k__BackingField; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<SubMesh> _SubMeshes_k__BackingField; // 0x38
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Matrix4x4> _BindPoses_k__BackingField; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Transform> _Bones_k__BackingField; // 0x48
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<BlendShape> _BlendShapes_k__BackingField; // 0x50
	
		// Properties
		public List<Vector3> Positions { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public List<Vector3> Normals { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public List<Vector2> UV { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public List<Vector4> Tangents { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
		public List<BoneWeight> BoneWeights { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		public List<SubMesh> SubMeshes { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FE0-0x0000000180268FF0 0x00000001802A43D0-0x00000001802A43E0
		public List<Matrix4x4> BindPoses { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		public List<Transform> Bones { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
		public List<BlendShape> BlendShapes { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802BC110-0x00000001802BC120 0x00000001803DFE50-0x00000001803DFE60
	
		// Nested types
		public struct SubMesh // TypeDefIndex: 5661
		{
			// Fields
			public List<int> Indices; // 0x00
			public Material Material; // 0x08
		}
	
		public class BlendShape // TypeDefIndex: 5662
		{
			// Fields
			public int VertexOffset; // 0x10
			public string Name; // 0x18
			public float FrameWeight; // 0x20
			public Vector3[] Positions; // 0x28
			public Vector3[] Normals; // 0x30
			public Vector3[] Tangents; // 0x38
	
			// Constructors
			public BlendShape(); // 0x00000001802650F0-0x0000000180265100
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 5663
		{
			// Fields
			public MeshRenderer renderer; // 0x10
			public MeshIntegrator __4__this; // 0x18
			public int indexOffset; // 0x20
			public Func<int, int> __9__4; // 0x28
	
			// Constructors
			public __c__DisplayClass41_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Vector3 _Push_b__0(Vector3 x); // 0x00000001806E6210-0x00000001806E6280
			internal Vector3 _Push_b__1(Vector3 x); // 0x00000001806E6280-0x00000001806E62F0
			internal Vector4 _Push_b__2(Vector4 t); // 0x00000001806E62F0-0x00000001806E63B0
			internal BoneWeight _Push_b__3(int x); // 0x00000001806E63B0-0x00000001806E6450
			internal int _Push_b__4(int x); // 0x00000001806E6450-0x00000001806E6460
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass41_1 // TypeDefIndex: 5664
		{
			// Fields
			public Material mat; // 0x10
	
			// Constructors
			public __c__DisplayClass41_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Push_b__5(SubMesh x); // 0x00000001806E6460-0x00000001806E6480
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 5665
		{
			// Fields
			public int boneIndexOffset; // 0x10
			public int indexOffset; // 0x14
			public Func<int, int> __9__2; // 0x18
	
			// Constructors
			public __c__DisplayClass42_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal BoneWeight _Push_b__0(BoneWeight x); // 0x00000001806E6480-0x00000001806E64D0
			internal int _Push_b__2(int x); // 0x00000001806E64D0-0x00000001806E64E0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass42_1 // TypeDefIndex: 5666
		{
			// Fields
			public BoneWeight rigidBoneWeight; // 0x10
	
			// Constructors
			public __c__DisplayClass42_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal BoneWeight _Push_b__1(int x); // 0x00000001802BC140-0x00000001802BC160
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass42_2 // TypeDefIndex: 5667
		{
			// Fields
			public Material mat; // 0x10
	
			// Constructors
			public __c__DisplayClass42_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Push_b__3(SubMesh x); // 0x00000001806E6460-0x00000001806E6480
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5668
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Vector4, Vector3> __9__42_4; // 0x08
	
			// Constructors
			static __c(); // 0x00000001806E6A30-0x00000001806E6A90
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Vector3 _Push_b__42_4(Vector4 x); // 0x00000001806E46F0-0x00000001806E4730
		}
	
		// Constructors
		public MeshIntegrator(); // 0x0000000180BBE050-0x0000000180BBE280
	
		// Methods
		public void AddBlendShapesToMesh(Mesh mesh); // 0x0000000180BBC380-0x0000000180BBC9F0
		private static BoneWeight AddBoneIndexOffset(BoneWeight bw, int boneIndexOffset); // 0x0000000180BBC9F0-0x0000000180BBCAE0
		public void Push(MeshRenderer renderer); // 0x0000000180BBCAE0-0x0000000180BBD500
		public void Push(SkinnedMeshRenderer renderer); // 0x0000000180BBD500-0x0000000180BBE050
	}
}
