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
	public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 6173
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_Name; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int m_HashCode; // 0x38
	
		// Properties
		public string name { get; set; } // 0x00000001802684F0-0x0000000180268500 0x0000000180268500-0x0000000180268580
		public int hashCode { get; } // 0x00000001802684E0-0x00000001802684F0 
	
		// Constructors
		public TMP_SpriteCharacter(); // 0x00000001802683A0-0x00000001802683C0
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph); // 0x0000000180268430-0x0000000180268490
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph); // 0x00000001802683C0-0x0000000180268430
		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex); // 0x0000000180268490-0x00000001802684E0
	}
}
