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
	public struct TextureImportParam // TypeDefIndex: 5276
	{
		// Fields
		public const string NORMAL_PROP = "_BumpMap"; // Metadata: 0x003A1178
		public const string METALLIC_GLOSS_PROP = "_MetallicGlossMap"; // Metadata: 0x003A1184
		public const string OCCLUSION_PROP = "_OcclusionMap"; // Metadata: 0x003A1199
		public readonly string UnityObjectName; // 0x00
		public readonly string Ext; // 0x08
		public readonly string Uri; // 0x10
		public Vector2 Offset; // 0x18
		public Vector2 Scale; // 0x20
		public SamplerParam Sampler; // 0x28
		public readonly TextureImportTypes TextureType; // 0x38
		public readonly float MetallicFactor; // 0x3C
		public readonly float RoughnessFactor; // 0x40
		public readonly GetTextureBytesAsync Index0; // 0x48
		public readonly GetTextureBytesAsync Index1; // 0x50
		public readonly GetTextureBytesAsync Index2; // 0x58
		public readonly GetTextureBytesAsync Index3; // 0x60
		public readonly GetTextureBytesAsync Index4; // 0x68
		public readonly GetTextureBytesAsync Index5; // 0x70
	
		// Properties
		public bool ExtractConverted { get; } // 0x00000001808A8820-0x00000001808A8830 
	
		// Constructors
		public TextureImportParam(string name, string ext, string uri, Vector2 offset, Vector2 scale, SamplerParam sampler, TextureImportTypes textureType, float metallicFactor, float roughnessFactor, GetTextureBytesAsync i0, GetTextureBytesAsync i1, GetTextureBytesAsync i2, GetTextureBytesAsync i3, GetTextureBytesAsync i4, GetTextureBytesAsync i5); // 0x00000001808A8780-0x00000001808A8820
	}
}
