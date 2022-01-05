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
	public static class ShaderUtilities // TypeDefIndex: 6167
	{
		// Fields
		public static int ID_MainTex; // 0x00
		public static int ID_FaceTex; // 0x04
		public static int ID_FaceColor; // 0x08
		public static int ID_FaceDilate; // 0x0C
		public static int ID_Shininess; // 0x10
		public static int ID_UnderlayColor; // 0x14
		public static int ID_UnderlayOffsetX; // 0x18
		public static int ID_UnderlayOffsetY; // 0x1C
		public static int ID_UnderlayDilate; // 0x20
		public static int ID_UnderlaySoftness; // 0x24
		public static int ID_UnderlayOffset; // 0x28
		public static int ID_UnderlayIsoPerimeter; // 0x2C
		public static int ID_WeightNormal; // 0x30
		public static int ID_WeightBold; // 0x34
		public static int ID_OutlineTex; // 0x38
		public static int ID_OutlineWidth; // 0x3C
		public static int ID_OutlineSoftness; // 0x40
		public static int ID_OutlineColor; // 0x44
		public static int ID_Outline2Color; // 0x48
		public static int ID_Outline2Width; // 0x4C
		public static int ID_Padding; // 0x50
		public static int ID_GradientScale; // 0x54
		public static int ID_ScaleX; // 0x58
		public static int ID_ScaleY; // 0x5C
		public static int ID_PerspectiveFilter; // 0x60
		public static int ID_Sharpness; // 0x64
		public static int ID_TextureWidth; // 0x68
		public static int ID_TextureHeight; // 0x6C
		public static int ID_BevelAmount; // 0x70
		public static int ID_GlowColor; // 0x74
		public static int ID_GlowOffset; // 0x78
		public static int ID_GlowPower; // 0x7C
		public static int ID_GlowOuter; // 0x80
		public static int ID_GlowInner; // 0x84
		public static int ID_LightAngle; // 0x88
		public static int ID_EnvMap; // 0x8C
		public static int ID_EnvMatrix; // 0x90
		public static int ID_EnvMatrixRotation; // 0x94
		public static int ID_MaskCoord; // 0x98
		public static int ID_ClipRect; // 0x9C
		public static int ID_MaskSoftnessX; // 0xA0
		public static int ID_MaskSoftnessY; // 0xA4
		public static int ID_VertexOffsetX; // 0xA8
		public static int ID_VertexOffsetY; // 0xAC
		public static int ID_UseClipRect; // 0xB0
		public static int ID_StencilID; // 0xB4
		public static int ID_StencilOp; // 0xB8
		public static int ID_StencilComp; // 0xBC
		public static int ID_StencilReadMask; // 0xC0
		public static int ID_StencilWriteMask; // 0xC4
		public static int ID_ShaderFlags; // 0xC8
		public static int ID_ScaleRatio_A; // 0xCC
		public static int ID_ScaleRatio_B; // 0xD0
		public static int ID_ScaleRatio_C; // 0xD4
		public static string Keyword_Bevel; // 0xD8
		public static string Keyword_Glow; // 0xE0
		public static string Keyword_Underlay; // 0xE8
		public static string Keyword_Ratios; // 0xF0
		public static string Keyword_MASK_SOFT; // 0xF8
		public static string Keyword_MASK_HARD; // 0x100
		public static string Keyword_MASK_TEX; // 0x108
		public static string Keyword_Outline; // 0x110
		public static string ShaderTag_ZTestMode; // 0x118
		public static string ShaderTag_CullMode; // 0x120
		private static float m_clamp; // 0x128
		public static bool isInitialized; // 0x12C
		private static Shader k_ShaderRef_MobileSDF; // 0x130
		private static Shader k_ShaderRef_MobileBitmap; // 0x138
	
		// Properties
		internal static Shader ShaderRef_MobileSDF { get; } // 0x0000000180371A60-0x0000000180371B80 
		internal static Shader ShaderRef_MobileBitmap { get; } // 0x0000000180371940-0x0000000180371A60 
	
		// Constructors
		static ShaderUtilities(); // 0x0000000180371750-0x0000000180371940
	
		// Methods
		public static void GetShaderPropertyIDs(); // 0x00000001803703A0-0x0000000180370EE0
		public static void UpdateShaderRatios(Material mat); // 0x00000001803710D0-0x0000000180371750
		public static Vector4 GetFontExtent(Material material); // 0x000000018036E990-0x000000018036E9C0
		public static bool IsMaskingEnabled(Material material); // 0x0000000180370EE0-0x00000001803710D0
		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold); // 0x000000018036E9C0-0x000000018036F470
		public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold); // 0x000000018036F470-0x00000001803703A0
	}
}
