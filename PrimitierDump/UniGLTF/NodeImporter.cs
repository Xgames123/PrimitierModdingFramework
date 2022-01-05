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
	public static class NodeImporter // TypeDefIndex: 5870
	{
		// Nested types
		public class TransformWithSkin // TypeDefIndex: 5866
		{
			// Fields
			public Transform Transform; // 0x10
			public int? SkinIndex; // 0x18
	
			// Properties
			public GameObject GameObject { get; } // 0x00000001806DD380-0x00000001806DD3A0 
	
			// Constructors
			public TransformWithSkin(); // 0x00000001802650F0-0x0000000180265100
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5867
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TransformWithSkin, Transform> __9__3_0; // 0x08
			public static Func<TransformWithSkin, PosRot> __9__3_1; // 0x10
	
			// Constructors
			static __c(); // 0x00000001806E6A90-0x00000001806E6AF0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Transform _FixCoordinate_b__3_0(TransformWithSkin x); // 0x000000018054DB00-0x000000018054DB20
			internal PosRot _FixCoordinate_b__3_1(TransformWithSkin x); // 0x00000001806E4E50-0x00000001806E4EE0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 5868
		{
			// Fields
			public List<TransformWithSkin> nodes; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Transform _SetupSkinning_b__0(int y); // 0x00000001806E6680-0x00000001806E66F0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_1 // TypeDefIndex: 5869
		{
			// Fields
			public Transform meshCoords; // 0x10
	
			// Constructors
			public __c__DisplayClass4_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Matrix4x4 _SetupSkinning_b__1(Transform y); // 0x00000001806E66F0-0x00000001806E6810
		}
	
		// Methods
		public static GameObject ImportNode(glTFNode node, int nodeIndex); // 0x0000000180BBF880-0x0000000180BBFF20
		public static TransformWithSkin BuildHierarchy(glTF gltf, int i, List<Transform> nodes, List<MeshWithMaterials> meshes); // 0x0000000180BBEF70-0x0000000180BBF330
		public static void FixCoordinate(glTF gltf, List<TransformWithSkin> nodes, IAxisInverter inverter); // 0x0000000180BBF330-0x0000000180BBF880
		public static void SetupSkinning(glTF gltf, List<TransformWithSkin> nodes, int i, IAxisInverter inverter); // 0x0000000180BBFF20-0x0000000180BC04C0
	}
}
