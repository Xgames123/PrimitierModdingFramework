/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 6197
	{
		// Fields
		[SerializeField] // 0x000000018003BFE0-0x000000018003C020
		[TextArea] // 0x000000018003BFE0-0x000000018003C020
		protected string m_text; // 0xD8
		private bool m_IsTextBackingStringDirty; // 0xE0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected ITextPreprocessor m_TextPreprocessor; // 0xE8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_isRightToLeft; // 0xF0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_FontAsset m_fontAsset; // 0xF8
		protected TMP_FontAsset m_currentFontAsset; // 0x100
		protected bool m_isSDFShader; // 0x108
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Material m_sharedMaterial; // 0x110
		protected Material m_currentMaterial; // 0x118
		protected static MaterialReference[] m_materialReferences; // 0x00
		protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x08
		protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
		protected int m_currentMaterialIndex; // 0x120
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Material[] m_fontSharedMaterials; // 0x128
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Material m_fontMaterial; // 0x130
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Material[] m_fontMaterials; // 0x138
		protected bool m_isMaterialDirty; // 0x140
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Color32 m_fontColor32; // 0x144
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Color m_fontColor; // 0x148
		protected static Color32 s_colorWhite; // 0x68
		protected Color32 m_underlineColor; // 0x158
		protected Color32 m_strikethroughColor; // 0x15C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_enableVertexGradient; // 0x160
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected ColorMode m_colorMode; // 0x164
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected VertexGradient m_fontColorGradient; // 0x168
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1A8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_SpriteAsset m_spriteAsset; // 0x1B0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_tintAllSprites; // 0x1B8
		protected bool m_tintSprite; // 0x1B9
		protected Color32 m_spriteColor; // 0x1BC
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_StyleSheet m_StyleSheet; // 0x1C0
		internal TMP_Style m_TextStyle; // 0x1C8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected int m_TextStyleHashCode; // 0x1D0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_overrideHtmlColors; // 0x1D4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Color32 m_faceColor; // 0x1D8
		protected Color32 m_outlineColor; // 0x1DC
		protected float m_outlineWidth; // 0x1E0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_fontSize; // 0x1E4
		protected float m_currentFontSize; // 0x1E8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_fontSizeBase; // 0x1EC
		protected TMP_TextProcessingStack<float> m_sizeStack; // 0x1F0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected FontWeight m_fontWeight; // 0x210
		protected FontWeight m_FontWeightInternal; // 0x214
		protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x218
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_enableAutoSizing; // 0x238
		protected float m_maxFontSize; // 0x23C
		protected float m_minFontSize; // 0x240
		protected int m_AutoSizeIterationCount; // 0x244
		protected int m_AutoSizeMaxIterationCount; // 0x248
		protected bool m_IsAutoSizePointSizeSet; // 0x24C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_fontSizeMin; // 0x250
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_fontSizeMax; // 0x254
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected FontStyles m_fontStyle; // 0x258
		protected FontStyles m_FontStyleInternal; // 0x25C
		protected TMP_FontStyleStack m_fontStyleStack; // 0x260
		protected bool m_isUsingBold; // 0x26A
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x26C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected VerticalAlignmentOptions m_VerticalAlignment; // 0x270
		[FormerlySerializedAs] // 0x000000018003C240-0x000000018003C280
		[SerializeField] // 0x000000018003C240-0x000000018003C280
		protected TextAlignmentOptions m_textAlignment; // 0x274
		protected HorizontalAlignmentOptions m_lineJustification; // 0x278
		protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x280
		protected Vector3[] m_textContainerLocalCorners; // 0x2A0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_characterSpacing; // 0x2A8
		protected float m_cSpacing; // 0x2AC
		protected float m_monoSpacing; // 0x2B0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_wordSpacing; // 0x2B4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_lineSpacing; // 0x2B8
		protected float m_lineSpacingDelta; // 0x2BC
		protected float m_lineHeight; // 0x2C0
		protected bool m_IsDrivenLineSpacing; // 0x2C4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_lineSpacingMax; // 0x2C8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_paragraphSpacing; // 0x2CC
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_charWidthMaxAdj; // 0x2D0
		protected float m_charWidthAdjDelta; // 0x2D4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_enableWordWrapping; // 0x2D8
		protected bool m_isCharacterWrappingEnabled; // 0x2D9
		protected bool m_isNonBreakingSpace; // 0x2DA
		protected bool m_isIgnoringAlignment; // 0x2DB
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_wordWrappingRatios; // 0x2DC
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TextOverflowModes m_overflowMode; // 0x2E0
		protected int m_firstOverflowCharacterIndex; // 0x2E4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_Text m_linkedTextComponent; // 0x2E8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal TMP_Text parentLinkedComponent; // 0x2F0
		protected bool m_isTextTruncated; // 0x2F8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_enableKerning; // 0x2F9
		protected float m_GlyphHorizontalAdvanceAdjustment; // 0x2FC
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_enableExtraPadding; // 0x300
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool checkPaddingRequired; // 0x301
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_isRichText; // 0x302
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_parseCtrlCharacters; // 0x303
		protected bool m_isOverlay; // 0x304
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_isOrthographic; // 0x305
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_isCullingEnabled; // 0x306
		protected bool m_isMaskingEnabled; // 0x307
		protected bool isMaskUpdateRequired; // 0x308
		protected bool m_ignoreCulling; // 0x309
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TextureMappingOptions m_horizontalMapping; // 0x30C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TextureMappingOptions m_verticalMapping; // 0x310
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_uvLineOffset; // 0x314
		protected TextRenderFlags m_renderMode; // 0x318
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected VertexSortingOrder m_geometrySortingOrder; // 0x31C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_IsTextObjectScaleStatic; // 0x320
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_VertexBufferAutoSizeReduction; // 0x321
		protected int m_firstVisibleCharacter; // 0x324
		protected int m_maxVisibleCharacters; // 0x328
		protected int m_maxVisibleWords; // 0x32C
		protected int m_maxVisibleLines; // 0x330
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_useMaxVisibleDescender; // 0x334
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected int m_pageToDisplay; // 0x338
		protected bool m_isNewPage; // 0x33C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Vector4 m_margin; // 0x340
		protected float m_marginLeft; // 0x350
		protected float m_marginRight; // 0x354
		protected float m_marginWidth; // 0x358
		protected float m_marginHeight; // 0x35C
		protected float m_width; // 0x360
		protected TMP_TextInfo m_textInfo; // 0x368
		protected bool m_havePropertiesChanged; // 0x370
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_isUsingLegacyAnimationComponent; // 0x371
		protected Transform m_transform; // 0x378
		protected RectTransform m_rectTransform; // 0x380
		protected Vector2 m_PreviousRectTransformSize; // 0x388
		protected Vector2 m_PreviousPivotPosition; // 0x390
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _autoSizeTextContainer_k__BackingField; // 0x398
		protected bool m_autoSizeTextContainer; // 0x399
		protected Mesh m_mesh; // 0x3A0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_isVolumetricText; // 0x3A8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Action<TMP_TextInfo> OnPreRenderText; // 0x3B0
		protected TMP_SpriteAnimator m_spriteAnimator; // 0x3B8
		protected float m_flexibleHeight; // 0x3C0
		protected float m_flexibleWidth; // 0x3C4
		protected float m_minWidth; // 0x3C8
		protected float m_minHeight; // 0x3CC
		protected float m_maxWidth; // 0x3D0
		protected float m_maxHeight; // 0x3D4
		protected LayoutElement m_LayoutElement; // 0x3D8
		protected float m_preferredWidth; // 0x3E0
		protected float m_renderedWidth; // 0x3E4
		protected bool m_isPreferredWidthDirty; // 0x3E8
		protected float m_preferredHeight; // 0x3EC
		protected float m_renderedHeight; // 0x3F0
		protected bool m_isPreferredHeightDirty; // 0x3F4
		protected bool m_isCalculatingPreferredValues; // 0x3F5
		protected int m_layoutPriority; // 0x3F8
		protected bool m_isLayoutDirty; // 0x3FC
		protected bool m_isAwake; // 0x3FD
		internal bool m_isWaitingOnResourceLoad; // 0x3FE
		internal TextInputSources m_inputSource; // 0x400
		protected float m_fontScaleMultiplier; // 0x404
		private static char[] m_htmlTag; // 0x80
		private static RichTextTagAttribute[] m_xmlAttribute; // 0x88
		private static float[] m_attributeParameterValues; // 0x90
		protected float tag_LineIndent; // 0x408
		protected float tag_Indent; // 0x40C
		protected TMP_TextProcessingStack<float> m_indentStack; // 0x410
		protected bool tag_NoParsing; // 0x430
		protected bool m_isParsingText; // 0x431
		protected Matrix4x4 m_FXMatrix; // 0x434
		protected bool m_isFXMatrixSet; // 0x474
		internal UnicodeChar[] m_TextProcessingArray; // 0x478
		internal int m_InternalTextProcessingArraySize; // 0x480
		private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x488
		protected int m_totalCharacterCount; // 0x490
		protected static WordWrapState m_SavedWordWrapState; // 0x98
		protected static WordWrapState m_SavedLineState; // 0x410
		protected static WordWrapState m_SavedEllipsisState; // 0x788
		protected static WordWrapState m_SavedLastValidState; // 0xB00
		protected static WordWrapState m_SavedSoftLineBreakState; // 0xE78
		internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x11F0
		protected int m_characterCount; // 0x494
		protected int m_firstCharacterOfLine; // 0x498
		protected int m_firstVisibleCharacterOfLine; // 0x49C
		protected int m_lastCharacterOfLine; // 0x4A0
		protected int m_lastVisibleCharacterOfLine; // 0x4A4
		protected int m_lineNumber; // 0x4A8
		protected int m_lineVisibleCharacterCount; // 0x4AC
		protected int m_pageNumber; // 0x4B0
		protected float m_PageAscender; // 0x4B4
		protected float m_maxTextAscender; // 0x4B8
		protected float m_maxCapHeight; // 0x4BC
		protected float m_ElementAscender; // 0x4C0
		protected float m_ElementDescender; // 0x4C4
		protected float m_maxLineAscender; // 0x4C8
		protected float m_maxLineDescender; // 0x4CC
		protected float m_startOfLineAscender; // 0x4D0
		protected float m_startOfLineDescender; // 0x4D4
		protected float m_lineOffset; // 0x4D8
		protected Extents m_meshExtents; // 0x4DC
		protected Color32 m_htmlColor; // 0x4EC
		protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x4F0
		protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x510
		protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x530
		protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x550
		protected TMP_ColorGradient m_colorGradientPreset; // 0x580
		protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x588
		protected bool m_colorGradientPresetIsTinted; // 0x5B0
		protected float m_tabSpacing; // 0x5B4
		protected float m_spacing; // 0x5B8
		protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x5C0
		protected int m_TextStyleStackDepth; // 0x5C8
		protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x5D0
		protected int m_ItalicAngle; // 0x5F0
		protected TMP_TextProcessingStack<int> m_actionStack; // 0x5F8
		protected float m_padding; // 0x618
		protected float m_baselineOffset; // 0x61C
		protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x620
		protected float m_xAdvance; // 0x640
		protected TMP_TextElementType m_textElementType; // 0x644
		protected TMP_TextElement m_cached_TextElement; // 0x648
		protected SpecialCharacter m_Ellipsis; // 0x650
		protected SpecialCharacter m_Underline; // 0x670
		protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x690
		protected TMP_SpriteAsset m_currentSpriteAsset; // 0x698
		protected int m_spriteCount; // 0x6A0
		protected int m_spriteIndex; // 0x6A4
		protected int m_spriteAnimationID; // 0x6A8
		private static ProfilerMarker k_ParseTextMarker; // 0x1588
		private static ProfilerMarker k_InsertNewLineMarker; // 0x1590
		protected bool m_ignoreActiveState; // 0x6AC
		private TextBackingContainer m_TextBackingArray; // 0x6B0
		private readonly decimal[] k_Power; // 0x6C0
		protected static Vector2 k_LargePositiveVector2; // 0x1598
		protected static Vector2 k_LargeNegativeVector2; // 0x15A0
		protected static float k_LargePositiveFloat; // 0x15A8
		protected static float k_LargeNegativeFloat; // 0x15AC
		protected static int k_LargePositiveInt; // 0x15B0
		protected static int k_LargeNegativeInt; // 0x15B4
	
		// Properties
		public virtual string text { get; set; } // 0x00000001802886E0-0x00000001802887D0 0x0000000180289DF0-0x0000000180289E80
		public ITextPreprocessor textPreprocessor { get; set; } // 0x00000001802885C0-0x00000001802885D0 0x0000000180289D80-0x0000000180289D90
		public bool isRightToLeftText { get; set; } // 0x0000000180287CE0-0x0000000180287CF0 0x00000001802895C0-0x0000000180289610
		public TMP_FontAsset font { get; set; } // 0x000000018026A2D0-0x000000018026A2E0 0x00000001802893C0-0x0000000180289480
		public virtual Material fontSharedMaterial { get; set; } // 0x0000000180287BF0-0x0000000180287C00 0x0000000180289150-0x0000000180289210
		public virtual Material[] fontSharedMaterials { get; set; } // 0x0000000180287C00-0x0000000180287C20 0x0000000180289100-0x0000000180289150
		public Material fontMaterial { get; set; } // 0x0000000180287BB0-0x0000000180287BD0 0x0000000180289000-0x0000000180289100
		public virtual Material[] fontMaterials { get; set; } // 0x0000000180287BD0-0x0000000180287BF0 0x0000000180289100-0x0000000180289150
		public override Color color { get; set; } // 0x0000000180287A00-0x0000000180287A10 0x0000000180288D30-0x0000000180288DA0
		public float alpha { get; set; } // 0x00000001802878C0-0x00000001802878D0 0x0000000180288BC0-0x0000000180288BF0
		public bool enableVertexGradient { get; set; } // 0x0000000180287A40-0x0000000180287A50 0x0000000180288E80-0x0000000180288EB0
		public VertexGradient colorGradient { get; set; } // 0x00000001802879D0-0x0000000180287A00 0x0000000180288CE0-0x0000000180288D30
		public TMP_ColorGradient colorGradientPreset { get; set; } // 0x00000001802879C0-0x00000001802879D0 0x0000000180288CC0-0x0000000180288CE0
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x0000000180288520-0x0000000180288530 0x0000000180289D00-0x0000000180289D40
		public bool tintAllSprites { get; set; } // 0x00000001802887D0-0x00000001802887E0 0x0000000180289E80-0x0000000180289EB0
		public TMP_StyleSheet styleSheet { get; set; } // 0x0000000180288530-0x0000000180288540 0x0000000180289D40-0x0000000180289D80
		public TMP_Style textStyle { get; set; } // 0x00000001802885D0-0x00000001802886E0 0x0000000180289D90-0x0000000180289DF0
		public bool overrideColorTags { get; set; } // 0x00000001802880C0-0x00000001802880D0 0x0000000180289B80-0x0000000180289BB0
		public Color32 faceColor { get; set; } // 0x0000000180287A70-0x0000000180287B70 0x0000000180288F50-0x0000000180288FD0
		public Color32 outlineColor { get; set; } // 0x0000000180287ED0-0x0000000180287FD0 0x0000000180289A60-0x0000000180289AD0
		public float outlineWidth { get; set; } // 0x0000000180287FD0-0x00000001802880B0 0x0000000180289AD0-0x0000000180289B30
		public float fontSize { get; set; } // 0x0000000180287C40-0x0000000180287C50 0x00000001802892B0-0x0000000180289320
		public FontWeight fontWeight { get; set; } // 0x0000000180287C60-0x0000000180287C70 0x0000000180289370-0x00000001802893C0
		public float pixelsPerUnit { get; } // 0x0000000180288100-0x0000000180288320 
		public bool enableAutoSizing { get; set; } // 0x0000000180287A10-0x0000000180287A20 0x0000000180288DA0-0x0000000180288DF0
		public float fontSizeMin { get; set; } // 0x0000000180287C30-0x0000000180287C40 0x0000000180289260-0x00000001802892B0
		public float fontSizeMax { get; set; } // 0x0000000180287C20-0x0000000180287C30 0x0000000180289210-0x0000000180289260
		public FontStyles fontStyle { get; set; } // 0x0000000180287C50-0x0000000180287C60 0x0000000180289320-0x0000000180289370
		public bool isUsingBold { get; } // 0x0000000180287D20-0x0000000180287D30 
		public HorizontalAlignmentOptions horizontalAlignment { get; set; } // 0x0000000180287C90-0x0000000180287CA0 0x00000001802894C0-0x00000001802894F0
		public VerticalAlignmentOptions verticalAlignment { get; set; } // 0x00000001802888A0-0x00000001802888B0 0x0000000180289F00-0x0000000180289F30
		public TextAlignmentOptions alignment { get; set; } // 0x00000001802878B0-0x00000001802878C0 0x0000000180288B80-0x0000000180288BC0
		public float characterSpacing { get; set; } // 0x00000001802879A0-0x00000001802879B0 0x0000000180288C00-0x0000000180288C60
		public float wordSpacing { get; set; } // 0x00000001802888C0-0x00000001802888D0 0x0000000180289F60-0x0000000180289FC0
		public float lineSpacing { get; set; } // 0x0000000180287E10-0x0000000180287E20 0x0000000180289790-0x00000001802897F0
		public float lineSpacingAdjustment { get; set; } // 0x0000000180287E00-0x0000000180287E10 0x0000000180289730-0x0000000180289790
		public float paragraphSpacing { get; set; } // 0x00000001802880E0-0x00000001802880F0 0x0000000180289BE0-0x0000000180289C40
		public float characterWidthAdjustment { get; set; } // 0x00000001802879B0-0x00000001802879C0 0x0000000180288C60-0x0000000180288CC0
		public bool enableWordWrapping { get; set; } // 0x0000000180287A50-0x0000000180287A60 0x0000000180288EB0-0x0000000180288F00
		public float wordWrappingRatios { get; set; } // 0x00000001802888D0-0x00000001802888E0 0x0000000180289FC0-0x000000018028A080
		public TextOverflowModes overflowMode { get; set; } // 0x00000001802880B0-0x00000001802880C0 0x0000000180289B30-0x0000000180289B80
		public bool isTextOverflowing { get; } // 0x0000000180287D00-0x0000000180287D10 
		public int firstOverflowCharacterIndex { get; } // 0x0000000180287B70-0x0000000180287B80 
		public TMP_Text linkedTextComponent { get; set; } // 0x0000000180287E20-0x0000000180287E30 0x00000001802897F0-0x00000001802898E0
		public bool isTextTruncated { get; } // 0x0000000180287D10-0x0000000180287D20 
		public bool enableKerning { get; set; } // 0x0000000180287A30-0x0000000180287A40 0x0000000180288E30-0x0000000180288E80
		public bool extraPadding { get; set; } // 0x0000000180287A60-0x0000000180287A70 0x0000000180288F00-0x0000000180288F50
		public bool richText { get; set; } // 0x0000000180288410-0x0000000180288420 0x0000000180289CB0-0x0000000180289D00
		public bool parseCtrlCharacters { get; set; } // 0x00000001802880F0-0x0000000180288100 0x0000000180289C40-0x0000000180289C90
		public bool isOverlay { get; set; } // 0x0000000180287CD0-0x0000000180287CE0 0x0000000180289570-0x00000001802895C0
		public bool isOrthographic { get; set; } // 0x0000000180287CC0-0x0000000180287CD0 0x0000000180289540-0x0000000180289570
		public bool enableCulling { get; set; } // 0x0000000180287A20-0x0000000180287A30 0x0000000180288DF0-0x0000000180288E30
		public bool ignoreVisibility { get; set; } // 0x0000000180287CB0-0x0000000180287CC0 0x0000000180289520-0x0000000180289540
		public TextureMappingOptions horizontalMapping { get; set; } // 0x0000000180287CA0-0x0000000180287CB0 0x00000001802894F0-0x0000000180289520
		public TextureMappingOptions verticalMapping { get; set; } // 0x00000001802888B0-0x00000001802888C0 0x0000000180289F30-0x0000000180289F60
		public float mappingUvLineOffset { get; set; } // 0x0000000180287E30-0x0000000180287E40 0x00000001802898E0-0x0000000180289910
		public TextRenderFlags renderMode { get; set; } // 0x0000000180288400-0x0000000180288410 0x0000000180289C90-0x0000000180289CB0
		public VertexSortingOrder geometrySortingOrder { get; set; } // 0x0000000180287C70-0x0000000180287C80 0x0000000180289480-0x00000001802894A0
		public bool isTextObjectScaleStatic { get; set; } // 0x0000000180287CF0-0x0000000180287D00 0x0000000180289610-0x00000001802896B0
		public bool vertexBufferAutoSizeReduction { get; set; } // 0x0000000180288890-0x00000001802888A0 0x0000000180289EE0-0x0000000180289F00
		public int firstVisibleCharacter { get; set; } // 0x0000000180287B80-0x0000000180287B90 0x0000000180288FD0-0x0000000180289000
		public int maxVisibleCharacters { get; set; } // 0x0000000180287E60-0x0000000180287E70 0x00000001802899D0-0x0000000180289A00
		public int maxVisibleWords { get; set; } // 0x0000000180287E80-0x0000000180287E90 0x0000000180289A30-0x0000000180289A60
		public int maxVisibleLines { get; set; } // 0x0000000180287E70-0x0000000180287E80 0x0000000180289A00-0x0000000180289A30
		public bool useMaxVisibleDescender { get; set; } // 0x0000000180288880-0x0000000180288890 0x0000000180289EB0-0x0000000180289EE0
		public int pageToDisplay { get; set; } // 0x00000001802880D0-0x00000001802880E0 0x0000000180289BB0-0x0000000180289BE0
		public virtual Vector4 margin { get; set; } // 0x0000000180287E40-0x0000000180287E50 0x0000000180289910-0x00000001802899D0
		public TMP_TextInfo textInfo { get; } // 0x00000001802885B0-0x00000001802885C0 
		public bool havePropertiesChanged { get; set; } // 0x0000000180287C80-0x0000000180287C90 0x00000001802894A0-0x00000001802894C0
		public bool isUsingLegacyAnimationComponent { get; set; } // 0x0000000180287D30-0x0000000180287D40 0x00000001802896B0-0x00000001802896C0
		public new Transform transform { get; } // 0x00000001802887E0-0x0000000180288880 
		public new RectTransform rectTransform { get; } // 0x0000000180288360-0x0000000180288400 
		public virtual bool autoSizeTextContainer { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802878D0-0x00000001802878E0 0x0000000180288BF0-0x0000000180288C00
		public virtual Mesh mesh { get; } // 0x0000000180287EA0-0x0000000180287EB0 
		public bool isVolumetricText { get; set; } // 0x0000000180287D40-0x0000000180287D50 0x00000001802896C0-0x0000000180289730
		public Bounds bounds { get; } // 0x00000001802878E0-0x00000001802879A0 
		public Bounds textBounds { get; } // 0x0000000180288540-0x00000001802885B0 
		protected TMP_SpriteAnimator spriteAnimator { get; } // 0x0000000180288420-0x0000000180288520 
		public float flexibleHeight { get; } // 0x0000000180287B90-0x0000000180287BA0 
		public float flexibleWidth { get; } // 0x0000000180287BA0-0x0000000180287BB0 
		public float minWidth { get; } // 0x0000000180287EC0-0x0000000180287ED0 
		public float minHeight { get; } // 0x0000000180287EB0-0x0000000180287EC0 
		public float maxWidth { get; } // 0x0000000180287E90-0x0000000180287EA0 
		public float maxHeight { get; } // 0x0000000180287E50-0x0000000180287E60 
		protected LayoutElement layoutElement { get; } // 0x0000000180287D50-0x0000000180287DF0 
		public virtual float preferredWidth { get; } // 0x0000000180288340-0x0000000180288360 
		public virtual float preferredHeight { get; } // 0x0000000180288320-0x0000000180288340 
		public virtual float renderedWidth { get; } // 0x0000000180274CA0-0x0000000180274D00 
		public virtual float renderedHeight { get; } // 0x0000000180274B60-0x0000000180274BC0 
		public int layoutPriority { get; } // 0x0000000180287DF0-0x0000000180287E00 
	
		// Events
		public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest {
			add; // 0x0000000180287610-0x0000000180287710
			remove; // 0x00000001802888E0-0x00000001802889E0
		}
		public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest {
			add; // 0x00000001802877B0-0x00000001802878B0
			remove; // 0x0000000180288A80-0x0000000180288B80
		}
		public virtual event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x0000000180287710-0x00000001802877B0
			remove; // 0x00000001802889E0-0x0000000180288A80
		}
	
		// Nested types
		protected struct CharacterSubstitution // TypeDefIndex: 6191
		{
			// Fields
			public int index; // 0x00
			public uint unicode; // 0x04
	
			// Constructors
			public CharacterSubstitution(int index, uint unicode); // 0x000000018036B690-0x000000018036B6A0
		}
	
		internal enum TextInputSources // TypeDefIndex: 6192
		{
			TextInputBox = 0,
			SetText = 1,
			SetTextArray = 2,
			TextString = 3
		}
	
		[DebuggerDisplay] // 0x000000018003C280-0x000000018003C2B0
		internal struct UnicodeChar // TypeDefIndex: 6193
		{
			// Fields
			public int unicode; // 0x00
			public int stringIndex; // 0x04
			public int length; // 0x08
		}
	
		protected struct SpecialCharacter // TypeDefIndex: 6194
		{
			// Fields
			public TMP_Character character; // 0x00
			public TMP_FontAsset fontAsset; // 0x08
			public Material material; // 0x10
			public int materialIndex; // 0x18
	
			// Constructors
			public SpecialCharacter(TMP_Character character, int materialIndex); // 0x0000000180883070-0x0000000180883170
		}
	
		private struct TextBackingContainer // TypeDefIndex: 6195
		{
			// Fields
			private uint[] m_Array; // 0x00
			private int m_Count; // 0x08
	
			// Properties
			public int Capacity { get; } // 0x0000000180883680-0x00000001808836A0 
			public int Count { get; set; } // 0x00000001805D2620-0x00000001805D2630 0x0000000180791460-0x0000000180791470
			public uint this[int index] { get => default; set {} } // 0x00000001808836A0-0x00000001808836E0 0x00000001808836E0-0x0000000180883780
	
			// Constructors
			public TextBackingContainer(int size); // 0x0000000180883630-0x0000000180883680
	
			// Methods
			public void Resize(int size); // 0x00000001808835E0-0x0000000180883630
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 6196
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<TMP_TextInfo> __9__622_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000180884FF0-0x0000000180885050
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _.ctor_b__622_0(TMP_TextInfo _p0_); // 0x0000000180265310-0x0000000180265320
		}
	
		// Constructors
		protected TMP_Text(); // 0x0000000180286950-0x0000000180287610
		static TMP_Text(); // 0x00000001802864C0-0x0000000180286950
	
		// Methods
		protected virtual void LoadFontAsset(); // 0x0000000180265310-0x0000000180265320
		protected virtual void SetSharedMaterial(Material mat); // 0x0000000180265310-0x0000000180265320
		protected virtual Material GetMaterial(Material mat); // 0x0000000180273F80-0x0000000180273F90
		protected virtual void SetFontBaseMaterial(Material mat); // 0x0000000180265310-0x0000000180265320
		protected virtual Material[] GetSharedMaterials(); // 0x0000000180273F80-0x0000000180273F90
		protected virtual void SetSharedMaterials(Material[] materials); // 0x0000000180265310-0x0000000180265320
		protected virtual Material[] GetMaterials(Material[] mats); // 0x0000000180273F80-0x0000000180273F90
		protected virtual Material CreateMaterialInstance(Material source); // 0x000000018026FED0-0x000000018026FF90
		protected void SetVertexColorGradient(TMP_ColorGradient gradient); // 0x000000018027ED50-0x000000018027EE00
		protected void SetTextSortingOrder(VertexSortingOrder order); // 0x0000000180265310-0x0000000180265320
		protected void SetTextSortingOrder(int[] order); // 0x0000000180265310-0x0000000180265320
		protected virtual void SetFaceColor(Color32 color); // 0x0000000180265310-0x0000000180265320
		protected virtual void SetOutlineColor(Color32 color); // 0x0000000180265310-0x0000000180265320
		protected virtual void SetOutlineThickness(float thickness); // 0x0000000180265310-0x0000000180265320
		protected virtual void SetShaderDepth(); // 0x0000000180265310-0x0000000180265320
		protected virtual void SetCulling(); // 0x0000000180265310-0x0000000180265320
		internal virtual void UpdateCulling(); // 0x0000000180265310-0x0000000180265320
		protected virtual float GetPaddingForMaterial(); // 0x0000000180273F90-0x00000001802740F0
		protected virtual float GetPaddingForMaterial(Material mat); // 0x00000001802740F0-0x0000000180274220
		protected virtual Vector3[] GetTextContainerLocalCorners(); // 0x0000000180273F80-0x0000000180273F90
		public virtual void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x003A237A */, bool forceTextReparsing = false /* Metadata: 0x003A237B */); // 0x0000000180265310-0x0000000180265320
		public virtual void UpdateGeometry(Mesh mesh, int index); // 0x0000000180265310-0x0000000180265320
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x0000000180265310-0x0000000180265320
		public virtual void UpdateVertexData(); // 0x0000000180265310-0x0000000180265320
		public virtual void SetVertices(Vector3[] vertices); // 0x0000000180265310-0x0000000180265320
		public virtual void UpdateMeshPadding(); // 0x0000000180265310-0x0000000180265320
		public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000180270000-0x00000001802700A0
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x000000018026FF90-0x0000000180270000
		protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000180265310-0x0000000180265320
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x0000000180265310-0x0000000180265320
		protected void ParseInputText(); // 0x0000000180279090-0x00000001802791D0
		private void PopulateTextBackingArray(string sourceText); // 0x00000001802792F0-0x0000000180279320
		private void PopulateTextBackingArray(string sourceText, int start, int length); // 0x0000000180279440-0x0000000180279550
		private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length); // 0x00000001802791D0-0x00000001802792F0
		private void PopulateTextBackingArray(char[] sourceText, int start, int length); // 0x0000000180279320-0x0000000180279440
		private void PopulateTextProcessingArray(); // 0x0000000180279550-0x000000018027A550
		private void SetTextInternal(string sourceText); // 0x000000018027E460-0x000000018027E4C0
		public void SetText(string sourceText, bool syncTextInputBox = true /* Metadata: 0x003A237C */); // 0x000000018027EA40-0x000000018027EAD0
		public void SetText(string sourceText, float arg0); // 0x000000018027E6F0-0x000000018027E730
		public void SetText(string sourceText, float arg0, float arg1); // 0x000000018027E640-0x000000018027E680
		public void SetText(string sourceText, float arg0, float arg1, float arg2); // 0x000000018027E9F0-0x000000018027EA40
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3); // 0x000000018027EC40-0x000000018027EC90
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4); // 0x000000018027EC90-0x000000018027ECF0
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5); // 0x000000018027ECF0-0x000000018027ED50
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6); // 0x000000018027E680-0x000000018027E6F0
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7); // 0x000000018027E730-0x000000018027E9F0
		public void SetText(StringBuilder sourceText); // 0x000000018027EAD0-0x000000018027EC40
		private void SetText(StringBuilder sourceText, int start, int length); // 0x000000018027E4D0-0x000000018027E640
		public void SetText(char[] sourceText); // 0x000000018027E430-0x000000018027E460
		public void SetText(char[] sourceText, int start, int length); // 0x000000018027E4C0-0x000000018027E4D0
		public void SetCharArray(char[] sourceText); // 0x000000018027E430-0x000000018027E460
		public void SetCharArray(char[] sourceText, int start, int length); // 0x000000018027E2C0-0x000000018027E430
		private TMP_Style GetStyle(int hashCode); // 0x0000000180274F80-0x00000001802750A0
		private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018027B4A0-0x000000018027B9C0
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018027AF80-0x000000018027B4A0
		private void ReplaceClosingStyleTag(ref TextBackingContainer sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018027A690-0x000000018027AB10
		private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018027AB10-0x000000018027AF80
		private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x0000000180278630-0x0000000180278A90
		private void InsertClosingStyleTag(ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x00000001802777B0-0x0000000180277C00
		private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex); // 0x0000000180273EA0-0x0000000180273F80
		private int GetMarkupTagHashCode(TextBackingContainer tagDefinition, int readIndex); // 0x0000000180273DE0-0x0000000180273EA0
		private int GetStyleHashCode(ref int[] text, int index, out int closeIndex); // 0x0000000180274E90-0x0000000180274F80
		private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex); // 0x0000000180274D90-0x0000000180274E90
		private void ResizeInternalArray<T>(ref T[] array);
		private void ResizeInternalArray<T>(ref T[] array, int size);
		private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex); // 0x000000018026C0B0-0x000000018026C550
		private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex); // 0x000000018026C550-0x000000018026C680
		private string InternalTextBackingArrayToString(); // 0x0000000180278A90-0x0000000180278B70
		internal virtual int SetArraySizes(UnicodeChar[] unicodeChars); // 0x0000000180273F80-0x0000000180273F90
		public Vector2 GetPreferredValues(); // 0x0000000180274610-0x0000000180274670
		public Vector2 GetPreferredValues(float width, float height); // 0x0000000180274740-0x00000001802747B0
		public Vector2 GetPreferredValues(string text); // 0x00000001802747B0-0x00000001802748E0
		public Vector2 GetPreferredValues(string text, float width, float height); // 0x0000000180274670-0x0000000180274740
		protected float GetPreferredWidth(); // 0x0000000180274960-0x0000000180274B00
		private float GetPreferredWidth(Vector2 margin); // 0x00000001802748E0-0x0000000180274960
		protected float GetPreferredHeight(); // 0x0000000180274400-0x0000000180274610
		private float GetPreferredHeight(Vector2 margin); // 0x0000000180274340-0x0000000180274400
		public Vector2 GetRenderedValues(); // 0x0000000180274C30-0x0000000180274CA0
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters); // 0x0000000180274BC0-0x0000000180274C30
		private float GetRenderedWidth(); // 0x0000000180274CA0-0x0000000180274D00
		protected float GetRenderedWidth(bool onlyVisibleCharacters); // 0x0000000180274D00-0x0000000180274D60
		private float GetRenderedHeight(); // 0x0000000180274B60-0x0000000180274BC0
		protected float GetRenderedHeight(bool onlyVisibleCharacters); // 0x0000000180274B00-0x0000000180274B60
		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled); // 0x000000018026CBC0-0x000000018026FCE0
		protected virtual Bounds GetCompoundBounds(); // 0x00000001802739E0-0x0000000180273A10
		internal virtual Rect GetCanvasSpaceClippingRect(); // 0x00000001802739B0-0x00000001802739E0
		protected Bounds GetTextBounds(); // 0x00000001802754B0-0x0000000180275860
		protected Bounds GetTextBounds(bool onlyVisibleCharacters); // 0x00000001802750A0-0x00000001802754B0
		protected void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x000000018026C680-0x000000018026CBC0
		protected void ResizeLineExtents(int size); // 0x000000018027BA40-0x000000018027BCE0
		public virtual TMP_TextInfo GetTextInfo(string text); // 0x0000000180273F80-0x0000000180273F90
		public virtual void ComputeMarginSize(); // 0x0000000180265310-0x0000000180265320
		protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender); // 0x0000000180277C00-0x0000000180278630
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count); // 0x000000018027DE10-0x000000018027E2C0
		protected int RestoreWordWrappingState(ref WordWrapState state); // 0x000000018027BCE0-0x000000018027C1D0
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor); // 0x000000018027C1D0-0x000000018027D3C0
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor); // 0x000000018027D3C0-0x000000018027DE10
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4); // 0x0000000180271C00-0x00000001802726E0
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric); // 0x00000001802726E0-0x00000001802738D0
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4); // 0x0000000180271C00-0x00000001802726E0
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor); // 0x0000000180270770-0x0000000180271C00
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor); // 0x00000001802700A0-0x0000000180270770
		protected void LoadDefaultSettings(); // 0x0000000180278C70-0x0000000180279010
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset); // 0x0000000180274D60-0x0000000180274D90
		protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset); // 0x0000000180273A10-0x0000000180273D20
		protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset); // 0x00000001802767C0-0x0000000180276940
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c); // 0x000000018027B9C0-0x000000018027BA40
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight); // 0x0000000180273D20-0x0000000180273DE0
		internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface); // 0x0000000180275860-0x0000000180275D70
		protected virtual void SetActiveSubMeshes(bool state); // 0x0000000180265310-0x0000000180265320
		protected virtual void DestroySubMeshObjects(); // 0x0000000180265310-0x0000000180265320
		public virtual void ClearMesh(); // 0x0000000180265310-0x0000000180265320
		public virtual void ClearMesh(bool uploadGeometry); // 0x0000000180265310-0x0000000180265320
		public virtual string GetParsedText(); // 0x0000000180274220-0x0000000180274340
		internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent); // 0x0000000180278B70-0x0000000180278C70
		internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent); // 0x000000018027A550-0x000000018027A690
		protected Vector2 PackUV(float x, float y, float scale); // 0x0000000180279050-0x0000000180279090
		protected float PackUV(float x, float y); // 0x0000000180279010-0x0000000180279050
		internal virtual void InternalUpdate(); // 0x0000000180265310-0x0000000180265320
		protected int HexToInt(char hex); // 0x00000001802776A0-0x00000001802777B0
		protected int GetUTF16(string text, int i); // 0x0000000180275F60-0x0000000180276040
		protected int GetUTF16(int[] text, int i); // 0x0000000180275D70-0x0000000180275E90
		internal int GetUTF16(uint[] text, int i); // 0x0000000180275D70-0x0000000180275E90
		protected int GetUTF16(StringBuilder text, int i); // 0x0000000180276040-0x0000000180276120
		private int GetUTF16(TextBackingContainer text, int i); // 0x0000000180275E90-0x0000000180275F60
		protected int GetUTF32(string text, int i); // 0x0000000180276120-0x00000001802762B0
		protected int GetUTF32(int[] text, int i); // 0x00000001802762B0-0x00000001802764D0
		internal int GetUTF32(uint[] text, int i); // 0x00000001802762B0-0x00000001802764D0
		protected int GetUTF32(StringBuilder text, int i); // 0x00000001802764D0-0x0000000180276660
		private int GetUTF32(TextBackingContainer text, int i); // 0x0000000180276660-0x00000001802767C0
		protected Color32 HexCharsToColor(char[] hexChars, int tagCount); // 0x0000000180276D30-0x00000001802776A0
		protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length); // 0x0000000180276940-0x0000000180276D30
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters); // 0x00000001802738D0-0x00000001802739B0
		protected float ConvertToFloat(char[] chars, int startIndex, int length); // 0x000000018026FEA0-0x000000018026FED0
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex); // 0x000000018026FCE0-0x000000018026FEA0
		internal bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex); // 0x000000018027EE00-0x00000001802864C0
	}
}
