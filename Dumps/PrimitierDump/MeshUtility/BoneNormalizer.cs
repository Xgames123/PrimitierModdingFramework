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
	public static class BoneNormalizer // TypeDefIndex: 5649
	{
		// Nested types
		public delegate Avatar CreateAvatarFunc(GameObject original, GameObject normalized, Dictionary<Transform, Transform> boneMap); // TypeDefIndex: 5641; 0x0000000180D50460-0x0000000180D50930
	
		private class BlendShapeReport // TypeDefIndex: 5644
		{
			// Fields
			private string m_name; // 0x10
			private int m_count; // 0x18
			private List<BlendShapeStat> m_stats; // 0x20
	
			// Properties
			public int Count { get; } // 0x0000000180D503F0-0x0000000180D50430 
	
			// Nested types
			private struct BlendShapeStat // TypeDefIndex: 5642
			{
				// Fields
				public int Index; // 0x00
				public string Name; // 0x08
				public int VertexCount; // 0x10
				public int NormalCount; // 0x14
				public int TangentCount; // 0x18
	
				// Methods
				public override string ToString(); // 0x00000001806D9320-0x00000001806D9590
			}
	
			[Serializable]
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private sealed class __c // TypeDefIndex: 5643
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<BlendShapeStat, string> __9__8_0; // 0x08
	
				// Constructors
				static __c(); // 0x00000001806E6C70-0x00000001806E6CD0
				public __c(); // 0x00000001802650F0-0x0000000180265100
	
				// Methods
				internal string _ToString_b__8_0(BlendShapeStat x); // 0x00000001806E5340-0x00000001806E5360
			}
	
			// Constructors
			public BlendShapeReport(Mesh mesh); // 0x0000000180D50350-0x0000000180D503F0
	
			// Methods
			public void SetCount(int index, string name, int v, int n, int t); // 0x0000000180D500D0-0x0000000180D50190
			public override string ToString(); // 0x0000000180D50190-0x0000000180D50350
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 5645
		{
			// Fields
			public BoneWeight[] newBoneWeights; // 0x10
			public int i; // 0x18
			public Action<int, float> __9__0; // 0x20
			public Action<int, float> __9__1; // 0x28
			public Action<int, float> __9__2; // 0x30
			public Action<int, float> __9__3; // 0x38
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _MapBoneWeight_b__0(int newIndex, float newWeight); // 0x0000000180D57F60-0x0000000180D57FF0
			internal void _MapBoneWeight_b__1(int newIndex, float newWeight); // 0x0000000180D57FF0-0x0000000180D58080
			internal void _MapBoneWeight_b__2(int newIndex, float newWeight); // 0x0000000180D58080-0x0000000180D58110
			internal void _MapBoneWeight_b__3(int newIndex, float newWeight); // 0x0000000180D58110-0x0000000180D581A0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 5646
		{
			// Fields
			public Dictionary<Transform, Transform> boneMap; // 0x10
			public Transform dst; // 0x18
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _NormalizeSkinnedMesh_b__0(Transform x); // 0x0000000180D58510-0x0000000180D585B0
			internal Transform _NormalizeSkinnedMesh_b__1(Transform x); // 0x0000000180D585B0-0x0000000180D58610
			internal Matrix4x4 _NormalizeSkinnedMesh_b__2(Transform x); // 0x0000000180D58610-0x0000000180D58750
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_1 // TypeDefIndex: 5647
		{
			// Fields
			public BoneWeight bw; // 0x10
	
			// Constructors
			public __c__DisplayClass6_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal BoneWeight _NormalizeSkinnedMesh_b__3(int x); // 0x00000001802BC140-0x00000001802BC160
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5648
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Vector3, bool> __9__6_4; // 0x08
			public static Func<Vector3, bool> __9__6_5; // 0x10
			public static Func<Vector4, Vector3> __9__6_6; // 0x18
	
			// Constructors
			static __c(); // 0x0000000180D58DF0-0x0000000180D58E50
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _NormalizeSkinnedMesh_b__6_4(Vector3 x); // 0x0000000180D56E00-0x0000000180D56E50
			internal bool _NormalizeSkinnedMesh_b__6_5(Vector3 x); // 0x0000000180D56E00-0x0000000180D56E50
			internal Vector3 _NormalizeSkinnedMesh_b__6_6(Vector4 x); // 0x00000001806E46F0-0x00000001806E4730
		}
	
		// Methods
		private static ValueTuple<GameObject, Dictionary<Transform, Transform>> NormalizeHierarchy(GameObject go, CreateAvatarFunc createAvatar); // 0x00000001810ADF70-0x00000001810AE1B0
		private static void CopyAndBuild(Transform src, Transform dst, Dictionary<Transform, Transform> boneMap); // 0x00000001810AD280-0x00000001810AD5A0
		private static bool CopyOrDropWeight(int[] indexMap, int srcIndex, float weight, Action<int, float> setter); // 0x00000001810AD5A0-0x00000001810AD670
		public static BoneWeight[] MapBoneWeight(BoneWeight[] src, Dictionary<Transform, Transform> boneMap, Transform[] srcBones, Transform[] dstBones); // 0x00000001810AD910-0x00000001810ADF70
		private static void NormalizeSkinnedMesh(Transform src, Transform dst, Dictionary<Transform, Transform> boneMap); // 0x00000001810AE450-0x00000001810AFE10
		private static void NormalizeNoneSkinnedMesh(Transform src, Transform dst); // 0x00000001810AE1B0-0x00000001810AE450
		public static ValueTuple<GameObject, Dictionary<Transform, Transform>> Execute(GameObject go, CreateAvatarFunc createAvatar); // 0x00000001810AD670-0x00000001810AD910
	}
}
