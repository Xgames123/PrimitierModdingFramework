/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	public struct FontAssetCreationSettings // TypeDefIndex: 6110
	{
		// Fields
		public string sourceFontFileName; // 0x00
		public string sourceFontFileGUID; // 0x08
		public int pointSizeSamplingMode; // 0x10
		public int pointSize; // 0x14
		public int padding; // 0x18
		public int packingMode; // 0x1C
		public int atlasWidth; // 0x20
		public int atlasHeight; // 0x24
		public int characterSetSelectionMode; // 0x28
		public string characterSequence; // 0x30
		public string referencedFontAssetGUID; // 0x38
		public string referencedTextAssetGUID; // 0x40
		public int fontStyle; // 0x48
		public float fontStyleModifier; // 0x4C
		public int renderMode; // 0x50
		public bool includeFontFeatures; // 0x54
	
		// Constructors
		internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode); // 0x000000018036C1B0-0x000000018036C290
	}
}
