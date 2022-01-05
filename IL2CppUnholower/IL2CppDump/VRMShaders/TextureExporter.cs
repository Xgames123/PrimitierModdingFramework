/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 34: VRMShaders.GLTF.IO.Runtime.dll - Assembly: VRMShaders.GLTF.IO.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5247-5278

namespace VRMShaders
{
	public class TextureExporter : IDisposable // TypeDefIndex: 5267
	{
		// Fields
		private Func<Texture, bool> m_useAsset; // 0x10
		private Dictionary<ExportKey, int> m_exportMap; // 0x18
		public readonly List<Texture2D> Exported; // 0x20
	
		// Nested types
		public enum ConvertTypes // TypeDefIndex: 5265
		{
			None = 0,
			OcclusionMetallicRoughness = 1,
			Normal = 2
		}
	
		private struct ExportKey // TypeDefIndex: 5266
		{
			// Fields
			public readonly Texture Src; // 0x00
			public readonly ConvertTypes TextureType; // 0x08
	
			// Constructors
			public ExportKey(Texture src, ConvertTypes type); // 0x00000001808A3820-0x00000001808A38E0
		}
	
		// Constructors
		public TextureExporter(Func<Texture, bool> useAsset); // 0x00000001808A7270-0x00000001808A7330
	
		// Methods
		public void Dispose(); // 0x0000000180265310-0x0000000180265320
		public int GetTextureIndex(Texture src, ConvertTypes textureType); // 0x00000001808A7180-0x00000001808A7270
		public int ExportSRGB(Texture src); // 0x00000001808A6D90-0x00000001808A7010
		public int ExportLinear(Texture src); // 0x00000001808A6600-0x00000001808A6640
		public int ExportMetallicSmoothnessOcclusion(Texture metallicSmoothTexture, float smoothness, Texture occlusionTexture); // 0x00000001808A6640-0x00000001808A6A30
		public int ExportNormal(Texture src); // 0x00000001808A6A30-0x00000001808A6D90
		public static ValueTuple<byte[], string> GetTextureBytesWithMime(Texture2D texture); // 0x00000001808A7010-0x00000001808A7180
	}
}
