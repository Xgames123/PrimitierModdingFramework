/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class MeshExporterDivided // TypeDefIndex: 5854
	{
		// Nested types
		private class BlendShapeBuffer // TypeDefIndex: 5850
		{
			// Fields
			private readonly List<Vector3> m_positions; // 0x10
			private readonly List<Vector3> m_normals; // 0x18
	
			// Constructors
			public BlendShapeBuffer(int reserve); // 0x00000001806D9280-0x00000001806D9320
	
			// Methods
			public void Push(Vector3 position, Vector3 normal); // 0x00000001806D9070-0x00000001806D9110
			public gltfMorphTarget ToGltf(glTF gltf, int bufferIndex, bool useNormal); // 0x00000001806D9110-0x00000001806D9280
		}
	
		private class VertexBuffer // TypeDefIndex: 5851
		{
			// Fields
			private readonly List<Vector3> m_positions; // 0x10
			private readonly List<Vector3> m_normals; // 0x18
			private readonly List<Vector2> m_uv; // 0x20
			private readonly Func<int, int> m_getJointIndex; // 0x28
			private readonly List<UShort4> m_joints; // 0x30
			private readonly List<Vector4> m_weights; // 0x38
	
			// Constructors
			public VertexBuffer(int reserve, Func<int, int> getJointIndex); // 0x00000001806E82C0-0x00000001806E8430
	
			// Methods
			public void Push(Vector3 position, Vector3 normal, Vector2 uv); // 0x00000001806E7CA0-0x00000001806E7D80
			public void Push(BoneWeight boneWeight); // 0x00000001806E7D80-0x00000001806E7F20
			public glTFPrimitives ToGltf(glTF gltf, int bufferIndex, int materialIndex, IReadOnlyList<uint> indices); // 0x00000001806E7F20-0x00000001806E82C0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 5852
		{
			// Fields
			public Mesh mesh; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _Export_b__0(int x); // 0x000000018054F350-0x000000018054F370
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5853
		{
			// Fields
			public static readonly __c __9; // 0x00
			[TupleElementNames] // 0x0000000180029360-0x00000001800293E0
			public static Func<int, int, ValueTuple<int, int>> __9__2_1; // 0x08
			[TupleElementNames] // 0x00000001800293E0-0x0000000180029460
			public static Func<ValueTuple<int, int>, int> __9__2_2; // 0x10
			[TupleElementNames] // 0x0000000180029460-0x00000001800294E0
			public static Func<ValueTuple<int, int>, uint> __9__2_3; // 0x18
	
			// Constructors
			static __c(); // 0x00000001806E6CD0-0x00000001806E6D30
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<int, int> _Export_b__2_1(int used, int index); // 0x00000001806E4C70-0x00000001806E4CD0
			internal int _Export_b__2_2([TupleElementNames] /* 0x00000001800294E0-0x0000000180029560 */ ValueTuple<int, int> x); // 0x0000000180333550-0x0000000180333560
			internal uint _Export_b__2_3([TupleElementNames] /* 0x0000000180029560-0x00000001800295E0 */ ValueTuple<int, int> x); // 0x00000001806E4CD0-0x00000001806E4CE0
		}
	
		// Methods
		public static glTFMesh Export(glTF gltf, int bufferIndex, MeshWithRenderer unityMesh, List<Material> unityMaterials, IAxisInverter axisInverter, MeshExportSettings settings); // 0x0000000180BB6CC0-0x0000000180BB7E40
	}
}
