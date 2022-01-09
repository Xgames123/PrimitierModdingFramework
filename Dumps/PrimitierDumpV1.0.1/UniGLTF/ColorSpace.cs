/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class ColorSpace // TypeDefIndex: 5875
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 5874
		{
			// Fields
			public int textureIndex; // 0x10
			public Func<glTFTextureInfo, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _TryGetglTFTextureType_b__0(glTFTextureInfo x); // 0x0000000180D576A0-0x0000000180D576C0
		}
	
		// Extension methods
		public static RenderTextureReadWrite GetColorSpace(this glTFTextureTypes textureType); // 0x00000001810B2C90-0x00000001810B2D00
		public static bool TryGetglTFTextureType(this glTF glTf, int textureIndex, out glTFTextureTypes textureType); // 0x00000001810B2D00-0x00000001810B2F90
		public static RenderTextureReadWrite GetColorSpace(this glTF gltf, int textureIndex); // 0x00000001810B2C00-0x00000001810B2C90
	}
}
