/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public static class SkeletonMeshUtility // TypeDefIndex: 5987
	{
		// Fields
		private static BoneHeadTail[] Bones; // 0x00
	
		// Nested types
		private class MeshBuilder // TypeDefIndex: 5984
		{
			// Fields
			private List<Vector3> m_positions; // 0x10
			private List<int> m_indices; // 0x18
			private List<BoneWeight> m_boneWeights; // 0x20
	
			// Constructors
			public MeshBuilder(); // 0x00000001812B8FE0-0x00000001812B90C0
	
			// Methods
			public void AddBone(Vector3 head, Vector3 tail, int boneIndex, float xWidth, float zWidth); // 0x00000001812B7540-0x00000001812B7890
			private void AddBox(Vector3 center, Vector3 xaxis, Vector3 yaxis, Vector3 zaxis, int boneIndex); // 0x00000001812B7890-0x00000001812B8B70
			private void AddQuad(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, int boneIndex, bool reverse = false /* Metadata: 0x003A1CB7 */); // 0x00000001812B8B70-0x00000001812B8F00
			public Mesh CreateMesh(); // 0x00000001812B8F00-0x00000001812B8FE0
		}
	
		private struct BoneHeadTail // TypeDefIndex: 5985
		{
			// Fields
			public HumanBodyBones Head; // 0x00
			public HumanBodyBones Tail; // 0x04
			public Vector3 TailOffset; // 0x08
			public float XWidth; // 0x14
			public float ZWidth; // 0x18
	
			// Constructors
			public BoneHeadTail(HumanBodyBones head, HumanBodyBones tail, float xWidth = 0.05f /* Metadata: 0x003A1CB8 */, float zWidth = 0.05f /* Metadata: 0x003A1CBC */); // 0x00000001812AB3D0-0x00000001812AB420
			public BoneHeadTail(HumanBodyBones head, Vector3 tailOffset, float xWidth = 0.05f /* Metadata: 0x003A1CC0 */, float zWidth = 0.05f /* Metadata: 0x003A1CC4 */); // 0x00000001812AB3A0-0x00000001812AB3D0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 5986
		{
			// Fields
			public Animator animator; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Matrix4x4 _CreateRenderer_b__0(Transform x); // 0x00000001812BDAF0-0x00000001812BDC30
		}
	
		// Constructors
		static SkeletonMeshUtility(); // 0x00000001812BABC0-0x00000001812BB580
	
		// Methods
		public static SkinnedMeshRenderer CreateRenderer(Animator animator); // 0x00000001812BA3D0-0x00000001812BABC0
	}
}
