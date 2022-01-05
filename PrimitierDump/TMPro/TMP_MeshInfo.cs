/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public struct TMP_MeshInfo // TypeDefIndex: 6156
	{
		// Fields
		private static readonly Color32 s_DefaultColor; // 0x00
		private static readonly Vector3 s_DefaultNormal; // 0x04
		private static readonly Vector4 s_DefaultTangent; // 0x10
		private static readonly Bounds s_DefaultBounds; // 0x20
		public Mesh mesh; // 0x00
		public int vertexCount; // 0x08
		public Vector3[] vertices; // 0x10
		public Vector3[] normals; // 0x18
		public Vector4[] tangents; // 0x20
		public Vector2[] uvs0; // 0x28
		public Vector2[] uvs2; // 0x30
		public Color32[] colors32; // 0x38
		public int[] triangles; // 0x40
		public Material material; // 0x48
	
		// Constructors
		public TMP_MeshInfo(Mesh mesh, int size); // 0x00000001802641B0-0x00000001802647A0
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric); // 0x00000001802635E0-0x00000001802641B0
		static TMP_MeshInfo(); // 0x00000001802634E0-0x00000001802635E0
	
		// Methods
		public void ResizeMeshInfo(int size); // 0x0000000180261420-0x0000000180261A00
		public void ResizeMeshInfo(int size, bool isVolumetric); // 0x0000000180261A00-0x0000000180262820
		public void Clear(); // 0x0000000180261220-0x00000001802612D0
		public void Clear(bool uploadChanges); // 0x00000001802612D0-0x0000000180261420
		public void ClearUnusedVertices(); // 0x0000000180261120-0x0000000180261160
		public void ClearUnusedVertices(int startIndex); // 0x00000001802610F0-0x0000000180261120
		public void ClearUnusedVertices(int startIndex, bool updateMesh); // 0x0000000180261160-0x0000000180261220
		public void SortGeometry(VertexSortingOrder order); // 0x0000000180262970-0x00000001802629F0
		public void SortGeometry(IList<int> sortingOrder); // 0x0000000180262820-0x0000000180262970
		public void SwapVertexData(int src, int dst); // 0x00000001802629F0-0x00000001802634E0
	}
}
