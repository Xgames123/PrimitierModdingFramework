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
	public static class MeshExporter // TypeDefIndex: 5849
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 5846
		{
			// Fields
			public IAxisInverter axisInverter; // 0x10
			public MeshWithRenderer unityMesh; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Vector3 _ExportSharedVertexBuffer_b__2(Vector3 y); // 0x00000001806E5360-0x00000001806E5470
			internal UShort4 _ExportSharedVertexBuffer_b__6(BoneWeight y); // 0x00000001806E5470-0x00000001806E5530
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5847
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Vector3, Vector3, Vector3> __9__0_0; // 0x08
			public static Func<Vector3, Vector3, Vector3> __9__0_1; // 0x10
			public static Func<Vector2, Vector2> __9__0_3; // 0x18
			public static Func<Vector2, Vector2> __9__0_4; // 0x20
			public static Func<BoneWeight, Vector4> __9__0_5; // 0x28
			public static Func<Vector4, Vector3> __9__2_0; // 0x30
			public static Func<Vector3, Vector3, Vector3> __9__2_1; // 0x38
			public static Func<Vector3, Vector3, Vector3> __9__2_2; // 0x40
	
			// Constructors
			static __c(); // 0x00000001806E7210-0x00000001806E7270
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Vector3 _ExportSharedVertexBuffer_b__0_0(Vector3 a, Vector3 b); // 0x00000001806E4970-0x00000001806E4A90
			internal Vector3 _ExportSharedVertexBuffer_b__0_1(Vector3 a, Vector3 b); // 0x00000001806E4A90-0x00000001806E4BB0
			internal Vector2 _ExportSharedVertexBuffer_b__0_3(Vector2 y); // 0x00000001806E4BB0-0x00000001806E4BD0
			internal Vector2 _ExportSharedVertexBuffer_b__0_4(Vector2 y); // 0x00000001806E4BB0-0x00000001806E4BD0
			internal Vector4 _ExportSharedVertexBuffer_b__0_5(BoneWeight y); // 0x00000001806E4BD0-0x00000001806E4C70
			internal Vector3 _ExportMorphTarget_b__2_0(Vector4 y); // 0x00000001806E46F0-0x00000001806E4730
			internal Vector3 _ExportMorphTarget_b__2_1(Vector3 a, Vector3 b); // 0x00000001806E4730-0x00000001806E4850
			internal Vector3 _ExportMorphTarget_b__2_2(Vector3 a, Vector3 b); // 0x00000001806E4850-0x00000001806E4970
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 5848
		{
			// Fields
			public bool usePosition; // 0x10
			public Vector3[] blendShapeVertices; // 0x18
			public bool useNormal; // 0x20
			public Vector3[] blendShapeNormals; // 0x28
			public bool useTangent; // 0x30
			public Vector3[] blendShapeTangents; // 0x38
			public IAxisInverter axisInverter; // 0x40
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _ExportMorphTarget_b__3(int x); // 0x00000001806E5940-0x00000001806E5A70
			internal Vector3 _ExportMorphTarget_b__4(int x); // 0x00000001806E5A70-0x00000001806E5BA0
			internal Vector3 _ExportMorphTarget_b__5(int x); // 0x00000001806E5BA0-0x00000001806E5CD0
			internal Vector3 _ExportMorphTarget_b__6(int x); // 0x00000001806E5CD0-0x00000001806E5E00
		}
	
		// Methods
		private static glTFMesh ExportSharedVertexBuffer(glTF gltf, int bufferIndex, MeshWithRenderer unityMesh, List<Material> unityMaterials, IAxisInverter axisInverter, MeshExportSettings settings); // 0x0000000180BB9190-0x0000000180BBA1D0
		private static bool UseSparse(bool usePosition, Vector3 position, bool useNormal, Vector3 normal, bool useTangent, Vector3 tangent); // 0x0000000180BBA1D0-0x0000000180BBA300
		private static gltfMorphTarget ExportMorphTarget(glTF gltf, int bufferIndex, Mesh mesh, int j, bool useSparseAccessorForMorphTarget, bool exportOnlyBlendShapePosition, IAxisInverter axisInverter); // 0x0000000180BB8190-0x0000000180BB9190
		public static ValueTuple<glTFMesh, Dictionary<int, int>> ExportMesh(glTF gltf, int bufferIndex, MeshWithRenderer unityMesh, List<Material> unityMaterials, MeshExportSettings settings, IAxisInverter axisInverter); // 0x0000000180BB7E40-0x0000000180BB8190
	}
}
