/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[ExcludeFromPreset] // 0x0000000180014D50-0x0000000180014D60
	public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 6172
	{
		// Fields
		internal Dictionary<int, int> m_NameLookup; // 0x30
		internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_Version; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal FaceInfo m_FaceInfo; // 0x48
		public Texture spriteSheet; // 0xA8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
		internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0xC0
		internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
		public List<TMP_Sprite> spriteInfoList; // 0xD0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
		internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
		private static HashSet<int> k_searchedSpriteAssets; // 0x00
	
		// Properties
		public string version { get; internal set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		public FaceInfo faceInfo { get; internal set; } // 0x0000000180268250-0x0000000180268290 0x0000000180268320-0x0000000180268360
		public List<TMP_SpriteCharacter> spriteCharacterTable { get; internal set; } // 0x00000001802682C0-0x0000000180268300 0x0000000180268370-0x0000000180268380
		public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; internal set; } // 0x0000000180268290-0x00000001802682C0 0x0000000180268360-0x0000000180268370
		public List<TMP_SpriteGlyph> spriteGlyphTable { get; internal set; } // 0x0000000180268300-0x0000000180268310 0x0000000180268380-0x0000000180268390
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 6171
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_SpriteGlyph, uint> __9__40_0; // 0x08
			public static Func<TMP_SpriteCharacter, uint> __9__41_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180885050-0x00000001808850B0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal uint _SortGlyphTable_b__40_0(TMP_SpriteGlyph item); // 0x0000000180884C30-0x0000000180884C50
			internal uint _SortCharacterTable_b__41_0(TMP_SpriteCharacter c); // 0x0000000180884BD0-0x0000000180884BF0
		}
	
		// Constructors
		public TMP_SpriteAsset(); // 0x00000001802681A0-0x0000000180268250
	
		// Methods
		private void Awake(); // 0x0000000180266310-0x0000000180266390
		private Material GetDefaultSpriteMaterial(); // 0x0000000180266390-0x0000000180266480
		public void UpdateLookupTables(); // 0x0000000180267670-0x0000000180267BD0
		public int GetSpriteIndexFromHashcode(int hashCode); // 0x0000000180266480-0x0000000180266510
		public int GetSpriteIndexFromUnicode(uint unicode); // 0x00000001802665F0-0x0000000180266690
		public int GetSpriteIndexFromName(string name); // 0x0000000180266510-0x00000001802665F0
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x0000000180266EB0-0x00000001802670E0
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x0000000180266C50-0x0000000180266E00
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x0000000180266E00-0x0000000180266EB0
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex); // 0x00000001802668F0-0x0000000180266C50
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x0000000180266740-0x00000001802668F0
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x0000000180266690-0x0000000180266740
		public void SortGlyphTable(); // 0x0000000180267500-0x0000000180267670
		internal void SortCharacterTable(); // 0x00000001802670E0-0x0000000180267250
		internal void SortGlyphAndCharacterTables(); // 0x0000000180267250-0x0000000180267500
		private void UpgradeSpriteAsset(); // 0x0000000180267BD0-0x00000001802681A0
	}
}
