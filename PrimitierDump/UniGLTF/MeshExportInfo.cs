/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	[Serializable]
	public struct MeshExportInfo // TypeDefIndex: 5844
	{
		// Fields
		public Renderer Renderer; // 0x00
		public Mesh Mesh; // 0x08
		public bool IsRendererActive; // 0x10
		public bool Skinned; // 0x11
		public VertexColorState VertexColor; // 0x14
		public int VertexCount; // 0x18
		public int ExportVertexSize; // 0x1C
		public int IndexCount; // 0x20
		public int ExportBlendShapeVertexSize; // 0x24
		public int TotalBlendShapeCount; // 0x28
		public int ExportBlendShapeCount; // 0x2C
		public string Summary; // 0x30
	
		// Properties
		public bool HasNormal { get; } // 0x0000000180BB6A40-0x0000000180BB6B00 
		public bool HasUV { get; } // 0x0000000180BB6B70-0x0000000180BB6C30 
		public bool HasVertexColor { get; } // 0x0000000180BB6C30-0x0000000180BB6CB0 
		public bool HasSkinning { get; } // 0x0000000180BB6B00-0x0000000180BB6B70 
		public int IndicesSize { get; } // 0x0000000180BB6CB0-0x0000000180BB6CC0 
		public int ExportByteSize { get; } // 0x0000000180BB6A20-0x0000000180BB6A40 
	
		// Nested types
		public enum VertexColorState // TypeDefIndex: 5843
		{
			None = 0,
			ExistsAndIsUsed = 1,
			ExistsButNotUsed = 2,
			ExistsAndMixed = 3
		}
	
		// Methods
		private static bool MaterialUseVertexColor(Material m); // 0x0000000180BB6960-0x0000000180BB6A20
		public static VertexColorState DetectVertexColor(Mesh mesh, Material[] materials); // 0x0000000180BB6700-0x0000000180BB6960
	}
}
