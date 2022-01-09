/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	public struct TMP_GlyphValueRecord // TypeDefIndex: 6125
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal float m_XPlacement; // 0x00
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal float m_YPlacement; // 0x04
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal float m_XAdvance; // 0x08
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal float m_YAdvance; // 0x0C
	
		// Properties
		public float xPlacement { get; set; } // 0x0000000180264990-0x00000001802649A0 0x0000000180264B90-0x0000000180264BA0
		public float yPlacement { get; set; } // 0x00000001802649A0-0x00000001802649B0 0x0000000180264BA0-0x0000000180264BB0
		public float xAdvance { get; set; } // 0x00000001802649B0-0x00000001802649C0 0x0000000180264BB0-0x0000000180264BC0
		public float yAdvance { get; set; } // 0x0000000180264980-0x0000000180264990 0x0000000180264B70-0x0000000180264B80
	
		// Constructors
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance); // 0x0000000180264940-0x0000000180264960
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord); // 0x000000018051D700-0x000000018051D730
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord); // 0x000000018036C2E0-0x000000018036C340
	
		// Methods
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b); // 0x000000018051D730-0x000000018051D790
	}
}
