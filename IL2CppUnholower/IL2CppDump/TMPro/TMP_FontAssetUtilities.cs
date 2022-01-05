/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public class TMP_FontAssetUtilities // TypeDefIndex: 6121
	{
		// Fields
		private static readonly TMP_FontAssetUtilities s_Instance; // 0x00
		private static HashSet<int> k_SearchedAssets; // 0x08
		private static bool k_IsFontEngineInitialized; // 0x10
	
		// Properties
		public static TMP_FontAssetUtilities instance { get; } // 0x00000001803784F0-0x0000000180378550 
	
		// Constructors
		static TMP_FontAssetUtilities(); // 0x0000000180378490-0x00000001803784F0
		public TMP_FontAssetUtilities(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x0000000180377A90-0x0000000180377C20
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x0000000180377620-0x0000000180377A90
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x0000000180377C20-0x0000000180377F10
		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks); // 0x0000000180378110-0x0000000180378490
		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks); // 0x0000000180377F10-0x0000000180378110
	}
}
