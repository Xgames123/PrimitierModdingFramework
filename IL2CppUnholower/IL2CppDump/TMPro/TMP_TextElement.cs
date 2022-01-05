/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	public class TMP_TextElement // TypeDefIndex: 6199
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TextElementType m_ElementType; // 0x10
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal uint m_Unicode; // 0x14
		internal TMP_Asset m_TextAsset; // 0x18
		internal Glyph m_Glyph; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal uint m_GlyphIndex; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal float m_Scale; // 0x2C
	
		// Properties
		public TextElementType elementType { get; } // 0x00000001802A2940-0x00000001802A2950 
		public uint unicode { get; set; } // 0x00000001802A6C70-0x00000001802A6C80 0x00000001802A6C80-0x00000001802A6C90
		public TMP_Asset textAsset { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public Glyph glyph { get; set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public uint glyphIndex { get; set; } // 0x00000001802B51E0-0x00000001802B51F0 0x00000001802B51F0-0x00000001802B5200
		public float scale { get; set; } // 0x000000018036B0F0-0x000000018036B100 0x000000018036B5F0-0x000000018036B600
	
		// Constructors
		public TMP_TextElement(); // 0x00000001802650F0-0x0000000180265100
	}
}
