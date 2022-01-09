/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public class MaterialReferenceManager // TypeDefIndex: 6075
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get; } // 0x000000018036DD50-0x000000018036DED0 
	
		// Constructors
		public MaterialReferenceManager(); // 0x000000018036DC30-0x000000018036DD50
	
		// Methods
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x000000018036D310-0x000000018036D3D0
		private void AddFontAssetInternal(TMP_FontAsset fontAsset); // 0x000000018036D260-0x000000018036D310
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset); // 0x000000018036D620-0x000000018036D6E0
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset); // 0x000000018036D570-0x000000018036D620
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset); // 0x000000018036D6E0-0x000000018036D7B0
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset); // 0x000000018036D4B0-0x000000018036D570
		public static void AddFontMaterial(int hashCode, Material material); // 0x000000018036D440-0x000000018036D4B0
		private void AddFontMaterialInternal(int hashCode, Material material); // 0x000000018036D3D0-0x000000018036D440
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset); // 0x000000018036D1C0-0x000000018036D260
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset); // 0x000000018036D130-0x000000018036D1C0
		public bool Contains(TMP_FontAsset font); // 0x000000018036D7B0-0x000000018036D810
		public bool Contains(TMP_SpriteAsset sprite); // 0x000000018036D810-0x000000018036D870
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset); // 0x000000018036D9D0-0x000000018036DA50
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset); // 0x000000018036D960-0x000000018036D9D0
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x000000018036DBB0-0x000000018036DC30
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x000000018036DB40-0x000000018036DBB0
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset); // 0x000000018036D8E0-0x000000018036D960
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset); // 0x000000018036D870-0x000000018036D8E0
		public static bool TryGetMaterial(int hashCode, out Material material); // 0x000000018036DAC0-0x000000018036DB40
		private bool TryGetMaterialInternal(int hashCode, out Material material); // 0x000000018036DA50-0x000000018036DAC0
	}
}
