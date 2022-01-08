/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 61: MToon.dll - Assembly: MToon, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8104-8124

namespace MToon
{
	public static class Utils // TypeDefIndex: 8124
	{
		// Fields
		public const string ShaderName = "VRM/MToon"; // Metadata: 0x003A6248
		public const string PropVersion = "_MToonVersion"; // Metadata: 0x003A6255
		public const string PropDebugMode = "_DebugMode"; // Metadata: 0x003A6266
		public const string PropOutlineWidthMode = "_OutlineWidthMode"; // Metadata: 0x003A6274
		public const string PropOutlineColorMode = "_OutlineColorMode"; // Metadata: 0x003A6289
		public const string PropBlendMode = "_BlendMode"; // Metadata: 0x003A629E
		public const string PropCullMode = "_CullMode"; // Metadata: 0x003A62AC
		public const string PropOutlineCullMode = "_OutlineCullMode"; // Metadata: 0x003A62B9
		public const string PropCutoff = "_Cutoff"; // Metadata: 0x003A62CD
		public const string PropColor = "_Color"; // Metadata: 0x003A62D8
		public const string PropShadeColor = "_ShadeColor"; // Metadata: 0x003A62E2
		public const string PropMainTex = "_MainTex"; // Metadata: 0x003A62F1
		public const string PropShadeTexture = "_ShadeTexture"; // Metadata: 0x003A62FD
		public const string PropBumpScale = "_BumpScale"; // Metadata: 0x003A630E
		public const string PropBumpMap = "_BumpMap"; // Metadata: 0x003A631C
		public const string PropReceiveShadowRate = "_ReceiveShadowRate"; // Metadata: 0x003A6328
		public const string PropReceiveShadowTexture = "_ReceiveShadowTexture"; // Metadata: 0x003A633E
		public const string PropShadingGradeRate = "_ShadingGradeRate"; // Metadata: 0x003A6357
		public const string PropShadingGradeTexture = "_ShadingGradeTexture"; // Metadata: 0x003A636C
		public const string PropShadeShift = "_ShadeShift"; // Metadata: 0x003A6384
		public const string PropShadeToony = "_ShadeToony"; // Metadata: 0x003A6393
		public const string PropLightColorAttenuation = "_LightColorAttenuation"; // Metadata: 0x003A63A2
		public const string PropIndirectLightIntensity = "_IndirectLightIntensity"; // Metadata: 0x003A63BC
		public const string PropRimColor = "_RimColor"; // Metadata: 0x003A63D7
		public const string PropRimTexture = "_RimTexture"; // Metadata: 0x003A63E4
		public const string PropRimLightingMix = "_RimLightingMix"; // Metadata: 0x003A63F3
		public const string PropRimFresnelPower = "_RimFresnelPower"; // Metadata: 0x003A6406
		public const string PropRimLift = "_RimLift"; // Metadata: 0x003A641A
		public const string PropSphereAdd = "_SphereAdd"; // Metadata: 0x003A6426
		public const string PropEmissionColor = "_EmissionColor"; // Metadata: 0x003A6434
		public const string PropEmissionMap = "_EmissionMap"; // Metadata: 0x003A6446
		public const string PropOutlineWidthTexture = "_OutlineWidthTexture"; // Metadata: 0x003A6456
		public const string PropOutlineWidth = "_OutlineWidth"; // Metadata: 0x003A646E
		public const string PropOutlineScaledMaxDistance = "_OutlineScaledMaxDistance"; // Metadata: 0x003A647F
		public const string PropOutlineColor = "_OutlineColor"; // Metadata: 0x003A649C
		public const string PropOutlineLightingMix = "_OutlineLightingMix"; // Metadata: 0x003A64AD
		public const string PropUvAnimMaskTexture = "_UvAnimMaskTexture"; // Metadata: 0x003A64C4
		public const string PropUvAnimScrollX = "_UvAnimScrollX"; // Metadata: 0x003A64DA
		public const string PropUvAnimScrollY = "_UvAnimScrollY"; // Metadata: 0x003A64EC
		public const string PropUvAnimRotation = "_UvAnimRotation"; // Metadata: 0x003A64FE
		public const string PropSrcBlend = "_SrcBlend"; // Metadata: 0x003A6511
		public const string PropDstBlend = "_DstBlend"; // Metadata: 0x003A651E
		public const string PropZWrite = "_ZWrite"; // Metadata: 0x003A652B
		public const string PropAlphaToMask = "_AlphaToMask"; // Metadata: 0x003A6536
		public const string KeyNormalMap = "_NORMALMAP"; // Metadata: 0x003A6546
		public const string KeyAlphaTestOn = "_ALPHATEST_ON"; // Metadata: 0x003A6554
		public const string KeyAlphaBlendOn = "_ALPHABLEND_ON"; // Metadata: 0x003A6565
		public const string KeyAlphaPremultiplyOn = "_ALPHAPREMULTIPLY_ON"; // Metadata: 0x003A6577
		public const string KeyOutlineWidthWorld = "MTOON_OUTLINE_WIDTH_WORLD"; // Metadata: 0x003A658F
		public const string KeyOutlineWidthScreen = "MTOON_OUTLINE_WIDTH_SCREEN"; // Metadata: 0x003A65AC
		public const string KeyOutlineColorFixed = "MTOON_OUTLINE_COLOR_FIXED"; // Metadata: 0x003A65CA
		public const string KeyOutlineColorMixed = "MTOON_OUTLINE_COLOR_MIXED"; // Metadata: 0x003A65E7
		public const string KeyDebugNormal = "MTOON_DEBUG_NORMAL"; // Metadata: 0x003A6604
		public const string KeyDebugLitShadeRate = "MTOON_DEBUG_LITSHADERATE"; // Metadata: 0x003A661A
		public const string TagRenderTypeKey = "RenderType"; // Metadata: 0x003A6636
		public const string TagRenderTypeValueOpaque = "Opaque"; // Metadata: 0x003A6644
		public const string TagRenderTypeValueTransparentCutout = "TransparentCutout"; // Metadata: 0x003A664E
		public const string TagRenderTypeValueTransparent = "Transparent"; // Metadata: 0x003A6663
		public const int DisabledIntValue = 0; // Metadata: 0x003A6672
		public const int EnabledIntValue = 1; // Metadata: 0x003A6676
		public const string Implementation = "Santarh/MToon"; // Metadata: 0x003A667A
		public const int VersionNumber = 35; // Metadata: 0x003A668B
	
		// Methods
		public static RenderQueueRequirement GetRenderQueueRequirement(RenderMode renderMode); // 0x00000001808E5900-0x00000001808E5A50
		public static MToonDefinition GetMToonParametersFromMaterial(Material material); // 0x00000001808E4DB0-0x00000001808E5770
		private static float GetValue(Material material, string propertyName); // 0x00000001808E5AD0-0x00000001808E5AF0
		private static Color GetColor(Material material, string propertyName); // 0x00000001808E4CC0-0x00000001808E4CF0
		private static Texture2D GetTexture(Material material, string propertyName); // 0x00000001808E5A50-0x00000001808E5AD0
		private static RenderMode GetBlendMode(Material material); // 0x00000001808E4BC0-0x00000001808E4CC0
		private static CullMode GetCullMode(Material material); // 0x00000001808E4CF0-0x00000001808E4DB0
		private static OutlineWidthMode GetOutlineWidthMode(Material material); // 0x00000001808E57F0-0x00000001808E5870
		private static OutlineColorMode GetOutlineColorMode(Material material); // 0x00000001808E5770-0x00000001808E57F0
		private static RenderMode GetRenderQueueOriginMode(Material material); // 0x00000001808E58F0-0x00000001808E5900
		private static int GetRenderQueueOffset(Material material, RenderMode originMode); // 0x00000001808E5870-0x00000001808E58F0
		public static void SetMToonParametersToMaterial(Material material, MToonDefinition parameters); // 0x00000001808E5CE0-0x00000001808E62E0
		public static void ValidateProperties(Material material, bool isBlendModeChangedByUser = false /* Metadata: 0x003A6247 */); // 0x00000001808E6980-0x00000001808E6CC0
		private static void SetDebugMode(Material material, DebugMode debugMode); // 0x00000001808E5BF0-0x00000001808E5CE0
		private static void SetRenderMode(Material material, RenderMode renderMode, int renderQueueOffset, bool useDefaultRenderQueue); // 0x00000001808E6590-0x00000001808E6940
		private static void SetOutlineMode(Material material, OutlineWidthMode outlineWidthMode, OutlineColorMode outlineColorMode); // 0x00000001808E63E0-0x00000001808E6590
		private static void SetNormalMapping(Material material, Texture bumpMap, float bumpScale); // 0x00000001808E62E0-0x00000001808E63E0
		private static void SetCullMode(Material material, CullMode cullMode); // 0x00000001808E5B20-0x00000001808E5BF0
		private static void SetValue(Material material, string propertyName, float val); // 0x00000001808E6960-0x00000001808E6980
		private static void SetColor(Material material, string propertyName, Color color); // 0x00000001808E5AF0-0x00000001808E5B20
		private static void SetTexture(Material material, string propertyName, Texture texture); // 0x00000001808E6940-0x00000001808E6960
		private static void SetKeyword(Material mat, string keyword, bool required); // 0x000000018030CB30-0x000000018030CB60
	}
}
