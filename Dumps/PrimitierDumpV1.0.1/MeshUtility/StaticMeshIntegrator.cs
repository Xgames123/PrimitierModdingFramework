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
	public static class StaticMeshIntegrator // TypeDefIndex: 5678
	{
		// Fields
		private const string ASSET_SUFFIX = ".mesh.asset"; // Metadata: 0x003A19A1
	
		// Nested types
		private class Integrator // TypeDefIndex: 5676
		{
			// Fields
			private List<Vector3> m_positions; // 0x10
			private List<Vector3> m_normals; // 0x18
			private List<Vector2> m_uv; // 0x20
			private List<int[]> m_subMeshes; // 0x28
			private List<Material> m_materials; // 0x30
	
			// Properties
			public List<Material> Materials { get; } // 0x00000001802684F0-0x0000000180268500 
	
			// Nested types
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private sealed class __c__DisplayClass7_0 // TypeDefIndex: 5675
			{
				// Fields
				public Matrix4x4 localToRoot; // 0x10
				public int offset; // 0x50
				public Func<int, int> __9__2; // 0x58
	
				// Constructors
				public __c__DisplayClass7_0(); // 0x00000001802650F0-0x0000000180265100
	
				// Methods
				internal Vector3 _Push_b__0(Vector3 x); // 0x00000001806E57F0-0x00000001806E5840
				internal Vector3 _Push_b__1(Vector3 x); // 0x00000001806E5840-0x00000001806E5890
				internal int _Push_b__2(int x); // 0x00000001806E68A0-0x00000001806E68B0
			}
	
			// Constructors
			public Integrator(); // 0x00000001806DA1D0-0x00000001806DA310
	
			// Methods
			public void Push(Matrix4x4 localToRoot, Mesh mesh, Material[] materials); // 0x00000001806D99E0-0x00000001806D9ED0
			public Mesh ToMesh(); // 0x00000001806D9ED0-0x00000001806DA1D0
		}
	
		public struct MeshWithMaterials // TypeDefIndex: 5677
		{
			// Fields
			public Mesh Mesh; // 0x00
			public Material[] Materials; // 0x08
		}
	
		// Methods
		public static MeshWithMaterials Integrate(Transform root); // 0x0000000180BC1180-0x0000000180BC1660
	}
}
