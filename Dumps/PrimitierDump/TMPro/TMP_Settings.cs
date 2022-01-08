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
	[Serializable]
	[ExcludeFromPreset] // 0x0000000180014D50-0x0000000180014D60
	public class TMP_Settings : ScriptableObject // TypeDefIndex: 6166
	{
		// Fields
		private static TMP_Settings s_Instance; // 0x00
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_enableWordWrapping; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_enableKerning; // 0x19
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_enableExtraPadding; // 0x1A
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_enableTintAllSprites; // 0x1B
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_enableParseEscapeCharacters; // 0x1C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_EnableRaycastTarget; // 0x1D
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_GetFontFeaturesAtRuntime; // 0x1E
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int m_missingGlyphCharacter; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_warningsDisabled; // 0x24
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_FontAsset m_defaultFontAsset; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_defaultFontAssetPath; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_defaultFontSize; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_defaultAutoSizeMinRatio; // 0x3C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_defaultAutoSizeMaxRatio; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_autoSizeTextContainer; // 0x54
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_IsTextObjectScaleStatic; // 0x55
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_matchMaterialPreset; // 0x60
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_defaultSpriteAssetPath; // 0x70
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_enableEmojiSupport; // 0x78
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private uint m_MissingCharacterSpriteUnicode; // 0x7C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_defaultColorGradientPresetsPath; // 0x80
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_StyleSheet m_defaultStyleSheet; // 0x88
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_StyleSheetsResourcePath; // 0x90
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TextAsset m_leadingCharacters; // 0x98
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TextAsset m_followingCharacters; // 0xA0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private LineBreakingTable m_linebreakingRules; // 0xA8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_UseModernHangulLineBreakingRules; // 0xB0
	
		// Properties
		public static string version { get; } // 0x0000000180265F10-0x0000000180265F40 
		public static bool enableWordWrapping { get; } // 0x0000000180265B20-0x0000000180265B40 
		public static bool enableKerning { get; } // 0x0000000180265AA0-0x0000000180265AC0 
		public static bool enableExtraPadding { get; } // 0x0000000180265A80-0x0000000180265AA0 
		public static bool enableTintAllSprites { get; } // 0x0000000180265B00-0x0000000180265B20 
		public static bool enableParseEscapeCharacters { get; } // 0x0000000180265AC0-0x0000000180265AE0 
		public static bool enableRaycastTarget { get; } // 0x0000000180265AE0-0x0000000180265B00 
		public static bool getFontFeaturesAtRuntime { get; } // 0x0000000180265B90-0x0000000180265BB0 
		public static int missingGlyphCharacter { get; set; } // 0x0000000180265E90-0x0000000180265EB0 0x0000000180265FF0-0x0000000180266020
		public static bool warningsDisabled { get; } // 0x0000000180265F40-0x0000000180265F60 
		public static TMP_FontAsset defaultFontAsset { get; } // 0x0000000180265910-0x0000000180265930 
		public static string defaultFontAssetPath { get; } // 0x00000001802658F0-0x0000000180265910 
		public static float defaultFontSize { get; } // 0x0000000180265930-0x0000000180265950 
		public static float defaultTextAutoSizingMinRatio { get; } // 0x00000001802659E0-0x0000000180265A00 
		public static float defaultTextAutoSizingMaxRatio { get; } // 0x00000001802659C0-0x00000001802659E0 
		public static Vector2 defaultTextMeshProTextContainerSize { get; } // 0x0000000180265A00-0x0000000180265A30 
		public static Vector2 defaultTextMeshProUITextContainerSize { get; } // 0x0000000180265A30-0x0000000180265A60 
		public static bool autoSizeTextContainer { get; } // 0x00000001802658A0-0x00000001802658C0 
		public static bool isTextObjectScaleStatic { get; set; } // 0x0000000180265C80-0x0000000180265CA0 0x0000000180265F90-0x0000000180265FC0
		public static List<TMP_FontAsset> fallbackFontAssets { get; } // 0x0000000180265B40-0x0000000180265B60 
		public static bool matchMaterialPreset { get; } // 0x0000000180265E50-0x0000000180265E70 
		public static TMP_SpriteAsset defaultSpriteAsset { get; } // 0x0000000180265970-0x0000000180265990 
		public static string defaultSpriteAssetPath { get; } // 0x0000000180265950-0x0000000180265970 
		public static bool enableEmojiSupport { get; set; } // 0x0000000180265A60-0x0000000180265A80 0x0000000180265F60-0x0000000180265F90
		public static uint missingCharacterSpriteUnicode { get; set; } // 0x0000000180265E70-0x0000000180265E90 0x0000000180265FC0-0x0000000180265FF0
		public static string defaultColorGradientPresetsPath { get; } // 0x00000001802658C0-0x00000001802658F0 
		public static TMP_StyleSheet defaultStyleSheet { get; } // 0x0000000180265990-0x00000001802659C0 
		public static string styleSheetsResourcePath { get; } // 0x0000000180265EB0-0x0000000180265EE0 
		public static TextAsset leadingCharacters { get; } // 0x0000000180265CA0-0x0000000180265CD0 
		public static TextAsset followingCharacters { get; } // 0x0000000180265B60-0x0000000180265B90 
		public static LineBreakingTable linebreakingRules { get; } // 0x0000000180265CD0-0x0000000180265E50 
		public static bool useModernHangulLineBreakingRules { get; set; } // 0x0000000180265EE0-0x0000000180265F10 0x0000000180266020-0x0000000180266050
		public static TMP_Settings instance { get; } // 0x0000000180265BB0-0x0000000180265C80 
	
		// Nested types
		public class LineBreakingTable // TypeDefIndex: 6165
		{
			// Fields
			public Dictionary<int, char> leadingCharacters; // 0x10
			public Dictionary<int, char> followingCharacters; // 0x18
	
			// Constructors
			public LineBreakingTable(); // 0x00000001802650F0-0x0000000180265100
		}
	
		// Constructors
		public TMP_Settings(); // 0x0000000180265890-0x00000001802658A0
	
		// Methods
		public static TMP_Settings LoadDefaultSettings(); // 0x0000000180265650-0x0000000180265750
		public static TMP_Settings GetSettings(); // 0x00000001802654D0-0x0000000180265540
		public static TMP_FontAsset GetFontAsset(); // 0x0000000180265450-0x00000001802654D0
		public static TMP_SpriteAsset GetSpriteAsset(); // 0x0000000180265540-0x00000001802655C0
		public static TMP_StyleSheet GetStyleSheet(); // 0x00000001802655C0-0x0000000180265650
		public static void LoadLinebreakingRules(); // 0x0000000180265750-0x0000000180265890
		private static Dictionary<int, char> GetCharacters(TextAsset file); // 0x0000000180265330-0x0000000180265450
	}
}
