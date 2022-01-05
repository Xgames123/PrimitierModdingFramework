/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class MeshImporter // TypeDefIndex: 5859
	{
		// Fields
		private const float FRAME_WEIGHT = 100f; // Metadata: 0x003A1B80
	
		// Nested types
		public class MeshContext // TypeDefIndex: 5857
		{
			// Fields
			private string m_name; // 0x10
			private readonly List<Vector3> m_positions; // 0x18
			private readonly List<Vector3> m_normals; // 0x20
			[Obsolete] // 0x0000000180027900-0x0000000180027910
			private readonly List<Vector4> m_tangents; // 0x28
			private readonly List<Vector2> m_uv; // 0x30
			private readonly List<Vector2> m_uv2; // 0x38
			private readonly List<Color> m_colors; // 0x40
			private readonly List<BoneWeight> m_boneWeights; // 0x48
			private readonly List<int[]> m_subMeshes; // 0x50
			private readonly List<int> m_materialIndices; // 0x58
			private readonly List<BlendShape> m_blendShapes; // 0x60
	
			// Properties
			public string name { get; } // 0x0000000180268FC0-0x0000000180268FD0 
			public List<Vector3> Positions { get; } // 0x0000000180268C10-0x0000000180268C20 
			public List<Vector3> Normals { get; } // 0x0000000180268FF0-0x0000000180269000 
			[Obsolete] // 0x0000000180027900-0x0000000180027910
			public List<Vector4> Tangetns { get; } // 0x0000000180268FD0-0x0000000180268FE0 
			public List<Vector2> UV { get; } // 0x00000001802684F0-0x0000000180268500 
			public List<Vector2> UV2 { get; } // 0x0000000180268FE0-0x0000000180268FF0 
			public List<Color> Colors { get; } // 0x0000000180268310-0x0000000180268320 
			public List<BoneWeight> BoneWeights { get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
			public List<int[]> SubMeshes { get; } // 0x00000001802BC110-0x00000001802BC120 
			public List<int> MaterialIndices { get; } // 0x00000001802BF820-0x00000001802BF890 
			public List<BlendShape> BlendShapes { get; } // 0x00000001802C6D20-0x00000001802C6D30 
	
			// Nested types
			[Serializable]
			private struct Float4 // TypeDefIndex: 5855
			{
				// Fields
				public float x; // 0x00
				public float y; // 0x04
				public float z; // 0x08
				public float w; // 0x0C
	
				// Methods
				public Float4 One(); // 0x00000001806D9590-0x00000001806D9600
			}
	
			[Serializable]
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private sealed class __c // TypeDefIndex: 5856
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<Vector2, Vector2> __9__38_0; // 0x08
				public static Func<Vector2, Vector2> __9__38_1; // 0x10
				public static Func<Vector2, Vector2> __9__38_2; // 0x18
				public static Func<Vector2, Vector2> __9__39_0; // 0x20
				public static Func<Vector2, Vector2> __9__39_1; // 0x28
				public static Func<Vector2, Vector2> __9__39_2; // 0x30
				public static Func<gltfMorphTarget, int, BlendShape> __9__39_3; // 0x38
				public static Func<int[], IEnumerable<int>> __9__42_0; // 0x40
	
				// Constructors
				static __c(); // 0x00000001806E6EB0-0x00000001806E6F10
				public __c(); // 0x00000001802650F0-0x0000000180265100
	
				// Methods
				internal Vector2 _ImportMeshIndependentVertexBuffer_b__38_0(Vector2 x); // 0x00000001806E4F70-0x00000001806E4F90
				internal Vector2 _ImportMeshIndependentVertexBuffer_b__38_1(Vector2 x); // 0x00000001806E4BB0-0x00000001806E4BD0
				internal Vector2 _ImportMeshIndependentVertexBuffer_b__38_2(Vector2 x); // 0x00000001806E4BB0-0x00000001806E4BD0
				internal Vector2 _ImportMeshSharingVertexBuffer_b__39_0(Vector2 x); // 0x00000001806E4F70-0x00000001806E4F90
				internal Vector2 _ImportMeshSharingVertexBuffer_b__39_1(Vector2 x); // 0x00000001806E4BB0-0x00000001806E4BD0
				internal Vector2 _ImportMeshSharingVertexBuffer_b__39_2(Vector2 x); // 0x00000001806E4BB0-0x00000001806E4BD0
				internal BlendShape _ImportMeshSharingVertexBuffer_b__39_3(gltfMorphTarget x, int i); // 0x00000001806E4F90-0x00000001806E5000
				internal IEnumerable<int> _DropUnusedVertices_b__42_0(int[] x); // 0x00000001802D5FD0-0x00000001802D5FE0
			}
	
			// Constructors
			public MeshContext(string name, int meshIndex); // 0x00000001806DD0C0-0x00000001806DD380
	
			// Methods
			private BlendShape GetOrCreateBlendShape(int i); // 0x00000001806DA610-0x00000001806DA780
			private static void FillZero<T>(IList<T> list, int fillLength);
			public static BoneWeight NormalizeBoneWeight(BoneWeight src); // 0x00000001806DCE20-0x00000001806DCF40
			public void ImportMeshIndependentVertexBuffer(glTF gltf, glTFMesh gltfMesh, IAxisInverter inverter); // 0x00000001806DA780-0x00000001806DBB40
			public void ImportMeshSharingVertexBuffer(glTF gltf, glTFMesh gltfMesh, IAxisInverter inverter); // 0x00000001806DBB40-0x00000001806DCE20
			public void RenameBlendShape(glTFMesh gltfMesh); // 0x00000001806DCF40-0x00000001806DD0C0
			private static void Truncate<T>(List<T> list, int maxIndex);
			public void DropUnusedVertices(); // 0x00000001806DA310-0x00000001806DA610
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _BuildMeshAsync_d__6 : IAsyncStateMachine // TypeDefIndex: 5858
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<MeshWithMaterials> __t__builder; // 0x08
			public MeshContext meshContext; // 0x20
			public IAwaitCaller awaitCaller; // 0x28
			public Func<int, Material> ctx; // 0x30
			private Mesh _mesh_5__2; // 0x38
			private MeshWithMaterials _result_5__3; // 0x40
			private TaskAwaiter __u__1; // 0x48
	
			// Methods
			private void MoveNext(); // 0x00000001806DDB60-0x00000001806DE100
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001806DE100-0x00000001806DE150
		}
	
		// Constructors
		public MeshImporter(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		private static bool HasSharedVertexBuffer(glTFMesh gltfMesh); // 0x0000000180BBACD0-0x0000000180BBAE70
		public MeshContext ReadMesh(glTF gltf, int meshIndex, IAxisInverter inverter); // 0x0000000180BBAE70-0x0000000180BBAF90
		private static ValueTuple<Mesh, bool> _BuildMesh(MeshContext meshContext); // 0x0000000180BBAF90-0x0000000180BBB320
		private static void BuildBlendShape(Mesh mesh, MeshContext meshContext, BlendShape blendShape, Vector3[] emptyVertices); // 0x0000000180BBA940-0x0000000180BBAB90
		public static async Task<MeshWithMaterials> BuildMeshAsync(IAwaitCaller awaitCaller, Func<int, Material> ctx, MeshContext meshContext); // 0x0000000180BBAB90-0x0000000180BBACD0
	}
}
