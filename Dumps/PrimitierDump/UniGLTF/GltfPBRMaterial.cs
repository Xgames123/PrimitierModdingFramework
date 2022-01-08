/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VRMShaders;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class GltfPBRMaterial // TypeDefIndex: 5830
	{
		// Fields
		public const string ShaderName = "Standard"; // Metadata: 0x003A1B34
	
		// Nested types
		private enum BlendMode // TypeDefIndex: 5827
		{
			Opaque = 0,
			Cutout = 1,
			Fade = 2,
			Transparent = 3
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 5828
		{
			// Fields
			public glTFMaterial src; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _TryCreateParam_b__2(Material material); // 0x0000000180D581A0-0x0000000180D58510
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5829
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<Material> __9__5_0; // 0x08
			public static Action<Material> __9__5_3; // 0x10
			public static Action<Material> __9__5_1; // 0x18
	
			// Constructors
			static __c(); // 0x0000000180D58B50-0x0000000180D58BB0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _TryCreateParam_b__5_0(Material material); // 0x0000000180D56F00-0x0000000180D56F50
			internal void _TryCreateParam_b__5_3(Material material); // 0x0000000180D56FC0-0x0000000180D57010
			internal void _TryCreateParam_b__5_1(Material material); // 0x0000000180D56F50-0x0000000180D56FC0
		}
	
		// Methods
		public static ValueTuple<SubAssetKey, TextureImportParam> BaseColorTexture(GltfParser parser, glTFMaterial src); // 0x0000000180D14900-0x0000000180D14A40
		public static ValueTuple<SubAssetKey, TextureImportParam> StandardTexture(GltfParser parser, glTFMaterial src); // 0x0000000180D14B60-0x0000000180D14E60
		public static ValueTuple<SubAssetKey, TextureImportParam> NormalTexture(GltfParser parser, glTFMaterial src); // 0x0000000180D14A40-0x0000000180D14B60
		public static bool TryCreateParam(GltfParser parser, int i, out MaterialImportParam param); // 0x0000000180D14E60-0x0000000180D15D40
	}
}
