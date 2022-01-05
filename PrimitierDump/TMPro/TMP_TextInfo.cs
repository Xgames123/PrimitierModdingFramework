/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	public class TMP_TextInfo // TypeDefIndex: 6201
	{
		// Fields
		internal static Vector2 k_InfinityVectorPositive; // 0x00
		internal static Vector2 k_InfinityVectorNegative; // 0x08
		public TMP_Text textComponent; // 0x10
		public int characterCount; // 0x18
		public int spriteCount; // 0x1C
		public int spaceCount; // 0x20
		public int wordCount; // 0x24
		public int linkCount; // 0x28
		public int lineCount; // 0x2C
		public int pageCount; // 0x30
		public int materialCount; // 0x34
		public TMP_CharacterInfo[] characterInfo; // 0x38
		public TMP_WordInfo[] wordInfo; // 0x40
		public TMP_LinkInfo[] linkInfo; // 0x48
		public TMP_LineInfo[] lineInfo; // 0x50
		public TMP_PageInfo[] pageInfo; // 0x58
		public TMP_MeshInfo[] meshInfo; // 0x60
		private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68
	
		// Constructors
		public TMP_TextInfo(); // 0x00000001803A46B0-0x00000001803A47A0
		internal TMP_TextInfo(int characterCount); // 0x00000001803A4460-0x00000001803A4560
		public TMP_TextInfo(TMP_Text textComponent); // 0x00000001803A4560-0x00000001803A46B0
		static TMP_TextInfo(); // 0x00000001803A4400-0x00000001803A4460
	
		// Methods
		public void Clear(); // 0x00000001803A3DB0-0x00000001803A3E30
		internal void ClearAllData(); // 0x00000001803A36D0-0x00000001803A37D0
		public void ClearMeshInfo(bool updateMesh); // 0x00000001803A3B70-0x00000001803A3C00
		public void ClearAllMeshInfo(); // 0x00000001803A37D0-0x00000001803A3850
		public void ResetVertexLayout(bool isVolumetric); // 0x00000001803A4370-0x00000001803A4400
		public void ClearUnusedVertices(MaterialReference[] materials); // 0x00000001803A3D30-0x00000001803A3DB0
		public void ClearLineInfo(); // 0x00000001803A3850-0x00000001803A3B70
		internal void ClearPageInfo(); // 0x00000001803A3C00-0x00000001803A3D30
		public TMP_MeshInfo[] CopyMeshInfoVertexData(); // 0x00000001803A3E30-0x00000001803A4370
		public static void Resize<T>(ref T[] array, int size);
		public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
	}
}
