/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	[ExcludeFromPreset] // 0x0000000180014D50-0x0000000180014D60
	public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 6107
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_Version; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal string m_SourceFontFileGUID; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Font m_SourceFontFile; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal FaceInfo m_FaceInfo; // 0x50
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal List<Glyph> m_GlyphTable; // 0xB0
		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal List<TMP_Character> m_CharacterTable; // 0xC0
		internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC8
		internal Texture2D m_AtlasTexture; // 0xD0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal Texture2D[] m_AtlasTextures; // 0xD8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal int m_AtlasTextureIndex; // 0xE0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_IsMultiAtlasTexturesEnabled; // 0xE4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_ClearDynamicDataOnBuild; // 0xE5
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<GlyphRect> m_UsedGlyphRects; // 0xE8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<GlyphRect> m_FreeGlyphRects; // 0xF0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private FaceInfo_Legacy m_fontInfo; // 0xF8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Texture2D atlas; // 0x100
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal int m_AtlasWidth; // 0x108
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal int m_AtlasHeight; // 0x10C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal int m_AtlasPadding; // 0x110
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal GlyphRenderMode m_AtlasRenderMode; // 0x114
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal List<TMP_Glyph> m_glyphInfoList; // 0x118
		[FormerlySerializedAs] // 0x000000018003BE60-0x000000018003BEB0
		[SerializeField] // 0x000000018003BE60-0x000000018003BEB0
		internal KerningTable m_KerningTable; // 0x120
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal TMP_FontFeatureTable m_FontFeatureTable; // 0x128
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<TMP_FontAsset> fallbackFontAssets; // 0x130
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x138
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal FontAssetCreationSettings m_CreationSettings; // 0x140
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_FontWeightPair[] m_FontWeightTable; // 0x198
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_FontWeightPair[] fontWeights; // 0x1A0
		public float normalStyle; // 0x1A8
		public float normalSpacingOffset; // 0x1AC
		public float boldStyle; // 0x1B0
		public float boldSpacing; // 0x1B4
		public byte italicStyle; // 0x1B8
		public byte tabSize; // 0x1B9
		internal bool IsFontAssetLookupTablesDirty; // 0x1BA
		private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x00
		private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x08
		private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
		private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
		private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
		private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x28
		private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x30
		private static string s_DefaultMaterialSuffix; // 0x38
		internal HashSet<int> FallbackSearchQueryLookup; // 0x1C0
		private static HashSet<int> k_SearchedFontAssetLookup; // 0x40
		private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
		private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
		private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
		private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
		private List<Glyph> m_GlyphsToRender; // 0x1C8
		private List<Glyph> m_GlyphsRendered; // 0x1D0
		private List<uint> m_GlyphIndexList; // 0x1D8
		private List<uint> m_GlyphIndexListNewlyAdded; // 0x1E0
		internal List<uint> m_GlyphsToAdd; // 0x1E8
		internal HashSet<uint> m_GlyphsToAddLookup; // 0x1F0
		internal List<TMP_Character> m_CharactersToAdd; // 0x1F8
		internal HashSet<uint> m_CharactersToAddLookup; // 0x200
		internal List<uint> s_MissingCharacterList; // 0x208
		internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x210
		internal static uint[] k_GlyphIndexArray; // 0x68
	
		// Properties
		public string version { get; internal set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		public Font sourceFontFile { get; internal set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		public AtlasPopulationMode atlasPopulationMode { get; set; } // 0x00000001802BC0B0-0x00000001802BC0C0 0x00000001802BC170-0x00000001802BC180
		public FaceInfo faceInfo { get; set; } // 0x0000000180381480-0x00000001803814C0 0x00000001803815D0-0x0000000180381610
		public List<Glyph> glyphTable { get; internal set; } // 0x0000000180381510-0x0000000180381520 0x0000000180268370-0x0000000180268380
		public Dictionary<uint, Glyph> glyphLookupTable { get; } // 0x00000001803814E0-0x0000000180381510 
		public List<TMP_Character> characterTable { get; internal set; } // 0x0000000180268300-0x0000000180268310 0x0000000180268380-0x0000000180268390
		public Dictionary<uint, TMP_Character> characterLookupTable { get; } // 0x00000001803813F0-0x0000000180381420 
		public Texture2D atlasTexture { get; } // 0x0000000180381330-0x00000001803813E0 
		public Texture2D[] atlasTextures { get; set; } // 0x000000018026A2F0-0x000000018026A300 0x000000018026A920-0x000000018026A930
		public int atlasTextureCount { get; } // 0x0000000180381320-0x0000000180381330 
		public bool isMultiAtlasTexturesEnabled { get; set; } // 0x0000000180381520-0x0000000180381530 0x0000000180381640-0x0000000180381650
		internal bool clearDynamicDataOnBuild { get; set; } // 0x0000000180381420-0x0000000180381430 0x0000000180381570-0x0000000180381580
		internal List<GlyphRect> usedGlyphRects { get; set; } // 0x00000001802885C0-0x00000001802885D0 0x0000000180289D80-0x0000000180289D90
		internal List<GlyphRect> freeGlyphRects { get; set; } // 0x00000001802696B0-0x00000001802696C0 0x0000000180381630-0x0000000180381640
		[Obsolete] // 0x000000018003BEB0-0x000000018003BEE0
		public FaceInfo_Legacy fontInfo { get; } // 0x000000018026A2D0-0x000000018026A2E0 
		public int atlasWidth { get; internal set; } // 0x00000001803813E0-0x00000001803813F0 0x0000000180381560-0x0000000180381570
		public int atlasHeight { get; internal set; } // 0x00000001803812F0-0x0000000180381300 0x0000000180381530-0x0000000180381540
		public int atlasPadding { get; internal set; } // 0x0000000180381300-0x0000000180381310 0x0000000180381540-0x0000000180381550
		public GlyphRenderMode atlasRenderMode { get; internal set; } // 0x0000000180381310-0x0000000180381320 0x0000000180381550-0x0000000180381560
		public TMP_FontFeatureTable fontFeatureTable { get; internal set; } // 0x00000001803814C0-0x00000001803814D0 0x0000000180381610-0x0000000180381620
		public List<TMP_FontAsset> fallbackFontAssetTable { get; set; } // 0x0000000180377520-0x0000000180377530 0x00000001803775B0-0x00000001803775C0
		public FontAssetCreationSettings creationSettings { get; set; } // 0x0000000180381430-0x0000000180381480 0x0000000180381580-0x00000001803815D0
		public TMP_FontWeightPair[] fontWeightTable { get; internal set; } // 0x00000001803814D0-0x00000001803814E0 0x0000000180381620-0x0000000180381630
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 6106
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_Character, uint> __9__124_0; // 0x08
			public static Func<Glyph, uint> __9__125_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001808850B0-0x0000000180885110
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal uint _SortCharacterTable_b__124_0(TMP_Character c); // 0x0000000180884BD0-0x0000000180884BF0
			internal uint _SortGlyphTable_b__125_0(Glyph c); // 0x0000000180884C30-0x0000000180884C50
		}
	
		// Constructors
		public TMP_FontAsset(); // 0x0000000180380F70-0x00000001803812F0
		static TMP_FontAsset(); // 0x0000000180380CA0-0x0000000180380F70
	
		// Methods
		public static TMP_FontAsset CreateFontAsset(Font font); // 0x00000001803793B0-0x0000000180379440
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x003A1EFF */, bool enableMultiAtlasSupport = true /* Metadata: 0x003A1F03 */); // 0x0000000180379440-0x0000000180379C30
		private void Awake(); // 0x0000000180378C70-0x0000000180378CF0
		public void ReadFontAssetDefinition(); // 0x000000018037B730-0x000000018037B9B0
		internal void InitializeDictionaryLookupTables(); // 0x000000018037B290-0x000000018037B2C0
		internal void InitializeGlyphLookupDictionary(); // 0x000000018037B2C0-0x000000018037B550
		internal void InitializeCharacterLookupDictionary(); // 0x000000018037B060-0x000000018037B290
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(); // 0x000000018037B550-0x000000018037B730
		internal void AddSynthesizedCharactersAndFaceMetrics(); // 0x00000001803788E0-0x0000000180378C70
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false /* Metadata: 0x003A1F04 */); // 0x0000000180378600-0x00000001803788E0
		internal void AddCharacterToLookupCache(uint unicode, TMP_Character character); // 0x0000000180378550-0x0000000180378600
		internal void SortCharacterTable(); // 0x000000018037C130-0x000000018037C2A0
		internal void SortGlyphTable(); // 0x000000018037C2D0-0x000000018037C440
		internal void SortFontFeatureTable(); // 0x000000018037C2A0-0x000000018037C2D0
		internal void SortAllTables(); // 0x000000018037BE60-0x000000018037C130
		public bool HasCharacter(int character); // 0x000000018037A1A0-0x000000018037A200
		public bool HasCharacter(char character, bool searchFallbacks = false /* Metadata: 0x003A1F05 */, bool tryAddCharacter = false /* Metadata: 0x003A1F06 */); // 0x000000018037A200-0x000000018037A7B0
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false /* Metadata: 0x003A1F07 */, bool tryAddCharacter = false /* Metadata: 0x003A1F08 */); // 0x0000000180379F60-0x000000018037A1A0
		public bool HasCharacters(string text, out List<char> missingCharacters); // 0x000000018037A7B0-0x000000018037A900
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false /* Metadata: 0x003A1F09 */, bool tryAddCharacter = false /* Metadata: 0x003A1F0A */); // 0x000000018037A9B0-0x000000018037B060
		public bool HasCharacters(string text); // 0x000000018037A900-0x000000018037A9B0
		public static string GetCharacters(TMP_FontAsset fontAsset); // 0x0000000180379D40-0x0000000180379E30
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset); // 0x0000000180379C30-0x0000000180379D40
		internal uint GetGlyphIndex(uint unicode); // 0x0000000180379E30-0x0000000180379F60
		internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset); // 0x000000018037BAC0-0x000000018037BBD0
		internal static void UpdateFontFeaturesForFontAssetsInQueue(); // 0x000000018037F280-0x000000018037F410
		internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset); // 0x000000018037B9B0-0x000000018037BAC0
		internal static void UpdateAtlasTexturesForFontAssetsInQueue(); // 0x000000018037EF80-0x000000018037F100
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false /* Metadata: 0x003A1F0B */); // 0x000000018037CDB0-0x000000018037CDE0
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false /* Metadata: 0x003A1F0C */); // 0x000000018037CDE0-0x000000018037D900
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false /* Metadata: 0x003A1F0D */); // 0x000000018037E400-0x000000018037E430
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false /* Metadata: 0x003A1F0E */); // 0x000000018037D900-0x000000018037E400
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character); // 0x000000018037C440-0x000000018037CDB0
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character); // 0x000000018037E820-0x000000018037ED80
		internal void TryAddGlyphsToAtlasTextures(); // 0x0000000180265310-0x0000000180265320
		private bool TryAddGlyphsToNewAtlasTexture(); // 0x000000018037E430-0x000000018037E820
		private void SetupNewAtlasTexture(); // 0x000000018037BBD0-0x000000018037BE60
		internal void UpdateAtlasTexture(); // 0x000000018037ED80-0x000000018037EF80
		internal void UpdateGlyphAdjustmentRecords(); // 0x000000018037F410-0x000000018037F760
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes); // 0x000000018037F760-0x000000018037FA90
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes); // 0x0000000180265310-0x0000000180265320
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes); // 0x0000000180265310-0x0000000180265320
		private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray);
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x003A1F0F */); // 0x00000001803791D0-0x0000000180379210
		internal void ClearFontAssetDataInternal(); // 0x00000001803791A0-0x00000001803791D0
		internal void UpdateFontAssetData(); // 0x000000018037F100-0x000000018037F280
		internal void ClearFontAssetTables(); // 0x0000000180379210-0x00000001803793B0
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false /* Metadata: 0x003A1F10 */); // 0x0000000180378CF0-0x00000001803791A0
		internal void UpgradeFontAsset(); // 0x000000018037FA90-0x0000000180380880
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable(); // 0x0000000180380880-0x0000000180380CA0
	}
}
