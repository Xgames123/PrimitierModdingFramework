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
	public struct WordWrapState // TypeDefIndex: 6224
	{
		// Fields
		public int previous_WordBreak; // 0x00
		public int total_CharacterCount; // 0x04
		public int visible_CharacterCount; // 0x08
		public int visible_SpriteCount; // 0x0C
		public int visible_LinkCount; // 0x10
		public int firstCharacterIndex; // 0x14
		public int firstVisibleCharacterIndex; // 0x18
		public int lastCharacterIndex; // 0x1C
		public int lastVisibleCharIndex; // 0x20
		public int lineNumber; // 0x24
		public float maxCapHeight; // 0x28
		public float maxAscender; // 0x2C
		public float maxDescender; // 0x30
		public float startOfLineAscender; // 0x34
		public float maxLineAscender; // 0x38
		public float maxLineDescender; // 0x3C
		public float pageAscender; // 0x40
		public HorizontalAlignmentOptions horizontalAlignment; // 0x44
		public float marginLeft; // 0x48
		public float marginRight; // 0x4C
		public float xAdvance; // 0x50
		public float preferredWidth; // 0x54
		public float preferredHeight; // 0x58
		public float previousLineScale; // 0x5C
		public int wordCount; // 0x60
		public FontStyles fontStyle; // 0x64
		public int italicAngle; // 0x68
		public float fontScaleMultiplier; // 0x6C
		public float currentFontSize; // 0x70
		public float baselineOffset; // 0x74
		public float lineOffset; // 0x78
		public bool isDrivenLineSpacing; // 0x7C
		public float glyphHorizontalAdvanceAdjustment; // 0x80
		public float cSpace; // 0x84
		public float mSpace; // 0x88
		public TMP_TextInfo textInfo; // 0x90
		public TMP_LineInfo lineInfo; // 0x98
		public Color32 vertexColor; // 0xF4
		public Color32 underlineColor; // 0xF8
		public Color32 strikethroughColor; // 0xFC
		public Color32 highlightColor; // 0x100
		public TMP_FontStyleStack basicStyleStack; // 0x104
		public TMP_TextProcessingStack<int> italicAngleStack; // 0x110
		public TMP_TextProcessingStack<Color32> colorStack; // 0x130
		public TMP_TextProcessingStack<Color32> underlineColorStack; // 0x150
		public TMP_TextProcessingStack<Color32> strikethroughColorStack; // 0x170
		public TMP_TextProcessingStack<Color32> highlightColorStack; // 0x190
		public TMP_TextProcessingStack<HighlightState> highlightStateStack; // 0x1B0
		public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack; // 0x1E0
		public TMP_TextProcessingStack<float> sizeStack; // 0x208
		public TMP_TextProcessingStack<float> indentStack; // 0x228
		public TMP_TextProcessingStack<FontWeight> fontWeightStack; // 0x248
		public TMP_TextProcessingStack<int> styleStack; // 0x268
		public TMP_TextProcessingStack<float> baselineStack; // 0x288
		public TMP_TextProcessingStack<int> actionStack; // 0x2A8
		public TMP_TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2C8
		public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack; // 0x320
		public int spriteAnimationID; // 0x340
		public TMP_FontAsset currentFontAsset; // 0x348
		public TMP_SpriteAsset currentSpriteAsset; // 0x350
		public Material currentMaterial; // 0x358
		public int currentMaterialIndex; // 0x360
		public Extents meshExtents; // 0x364
		public bool tagNoParsing; // 0x374
		public bool isNonBreakingSpace; // 0x375
	}
}
