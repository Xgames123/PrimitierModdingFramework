/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 35: VRMShaders.GLTF.UniUnlit.Runtime.dll - Assembly: VRMShaders.GLTF.UniUnlit.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5279-5283

namespace UniGLTF.UniUnlit
{
	public static class Utils // TypeDefIndex: 5283
	{
		// Fields
		public const string ShaderName = "UniGLTF/UniUnlit"; // Metadata: 0x003A11D8
		public const string PropNameMainTex = "_MainTex"; // Metadata: 0x003A11EC
		public const string PropNameColor = "_Color"; // Metadata: 0x003A11F8
		public const string PropNameCutoff = "_Cutoff"; // Metadata: 0x003A1202
		public const string PropNameBlendMode = "_BlendMode"; // Metadata: 0x003A120D
		public const string PropNameCullMode = "_CullMode"; // Metadata: 0x003A121B
		[Obsolete] // 0x000000018009EA90-0x000000018009F790
		public const string PropeNameVColBlendMode = "_VColBlendMode"; // Metadata: 0x003A1228
		public const string PropNameVColBlendMode = "_VColBlendMode"; // Metadata: 0x003A123A
		public const string PropNameSrcBlend = "_SrcBlend"; // Metadata: 0x003A124C
		public const string PropNameDstBlend = "_DstBlend"; // Metadata: 0x003A1259
		public const string PropNameZWrite = "_ZWrite"; // Metadata: 0x003A1266
		public const string PropNameStandardShadersRenderMode = "_Mode"; // Metadata: 0x003A1271
		public const string KeywordAlphaTestOn = "_ALPHATEST_ON"; // Metadata: 0x003A127A
		public const string KeywordAlphaBlendOn = "_ALPHABLEND_ON"; // Metadata: 0x003A128B
		public const string KeywordVertexColMul = "_VERTEXCOL_MUL"; // Metadata: 0x003A129D
		public const string TagRenderTypeKey = "RenderType"; // Metadata: 0x003A12AF
		public const string TagRenderTypeValueOpaque = "Opaque"; // Metadata: 0x003A12BD
		public const string TagRenderTypeValueTransparentCutout = "TransparentCutout"; // Metadata: 0x003A12C7
		public const string TagRenderTypeValueTransparent = "Transparent"; // Metadata: 0x003A12DC
	
		// Methods
		public static void SetRenderMode(Material material, UniUnlitRenderMode mode); // 0x00000001808FF470-0x00000001808FF4D0
		public static void SetCullMode(Material material, UniUnlitCullMode mode); // 0x00000001808FF410-0x00000001808FF470
		public static void SetVColBlendMode(Material material, UniUnlitVertexColorBlendOp mode); // 0x00000001808FF4D0-0x00000001808FF530
		public static UniUnlitRenderMode GetRenderMode(Material material); // 0x00000001808FF370-0x00000001808FF3C0
		public static UniUnlitCullMode GetCullMode(Material material); // 0x00000001808FF320-0x00000001808FF370
		public static UniUnlitVertexColorBlendOp GetVColBlendMode(Material material); // 0x00000001808FF3C0-0x00000001808FF410
		public static void ValidateProperties(Material material, bool isRenderModeChangedByUser = false /* Metadata: 0x003A11D6 */); // 0x00000001808FF850-0x00000001808FF930
		private static void SetupBlendMode(Material material, UniUnlitRenderMode renderMode, bool isRenderModeChangedByUser = false /* Metadata: 0x003A11D7 */); // 0x00000001808FF530-0x00000001808FF7D0
		private static void SetupVertexColorBlendOp(Material material, UniUnlitVertexColorBlendOp vColBlendOp); // 0x00000001808FF7D0-0x00000001808FF850
		private static void SetKeyword(Material mat, string keyword, bool required); // 0x000000018030CB30-0x000000018030CB60
	}
}
