/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 34: VRMShaders.GLTF.IO.Runtime.dll - Assembly: VRMShaders.GLTF.IO.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5247-5278

namespace VRMShaders
{
	public static class TextureConverter // TypeDefIndex: 5264
	{
		// Nested types
		public delegate Color32 ColorConversion(Color32 color); // TypeDefIndex: 5261; 0x00000001808A34F0-0x00000001808A37B0
	
		private struct ColorSpaceScope : IDisposable // TypeDefIndex: 5262
		{
			// Fields
			private bool m_sRGBWrite; // 0x00
	
			// Constructors
			public ColorSpaceScope(RenderTextureReadWrite colorSpace); // 0x00000001808A37F0-0x00000001808A3820
			public ColorSpaceScope(bool sRGBWrite); // 0x00000001808A37C0-0x00000001808A37F0
	
			// Methods
			public void Dispose(); // 0x00000001808A37B0-0x00000001808A37C0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 5263
		{
			// Fields
			public ColorConversion colorConversion; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Color32 _Convert_b__0(Color32 x); // 0x00000001808AAC40-0x00000001808AAC60
		}
	
		// Methods
		public static Texture2D Convert(Texture texture, TextureImportTypes textureType, ColorConversion colorConversion, Material convertMaterial); // 0x00000001808A6020-0x00000001808A61A0
		public static Texture2D CopyTexture(Texture src, TextureImportTypes textureType, Material material); // 0x00000001808A61A0-0x00000001808A6600
	}
}
