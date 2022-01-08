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
	public static class OcclusionMetallicRoughnessConverter // TypeDefIndex: 5258
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 5256
		{
			// Fields
			public float metallicFactor; // 0x10
			public float roughnessFactor; // 0x14
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Color32 _Import_b__0(Color32 x); // 0x00000001808AABB0-0x00000001808AAC00
			internal Color32 _Import_b__1(Color32 x); // 0x00000001808AAC00-0x00000001808AAC40
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 5257
		{
			// Fields
			public float smoothness; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Color32 _Export_b__0(Color32 x); // 0x00000001808AAC60-0x00000001808AACA0
			internal Color32 _Export_b__1(Color32 x); // 0x00000001808AACA0-0x00000001808AACE0
			internal Color32 _Export_b__2(Color32 x); // 0x00000001808AACE0-0x00000001808AAD20
		}
	
		// Methods
		public static Texture2D Import(Texture2D metallicRoughnessTexture, float metallicFactor, float roughnessFactor, Texture2D occlusionTexture); // 0x00000001808A5A40-0x00000001808A6020
		public static Color32 ImportPixel(Color32 metallicRoughness, float metallicFactor, float roughnessFactor, Color32 occlusion); // 0x00000001808A59F0-0x00000001808A5A40
		public static Texture2D Export(Texture metallicSmoothTexture, float smoothness, Texture occlusionTexture); // 0x00000001808A5510-0x00000001808A59F0
		public static Color32 ExportPixel(Color32 metallicSmooth, float smoothness, Color32 occlusion); // 0x00000001808A54D0-0x00000001808A5510
	}
}
