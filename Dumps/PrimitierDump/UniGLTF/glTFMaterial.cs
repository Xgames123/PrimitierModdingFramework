/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	[Serializable]
	public class glTFMaterial // TypeDefIndex: 5767
	{
		// Fields
		public string name; // 0x10
		public glTFPbrMetallicRoughness pbrMetallicRoughness; // 0x18
		public glTFMaterialNormalTextureInfo normalTexture; // 0x20
		public glTFMaterialOcclusionTextureInfo occlusionTexture; // 0x28
		public glTFMaterialEmissiveTextureInfo emissiveTexture; // 0x30
		[ItemJsonSchema] // 0x0000000180028040-0x00000001800280A0
		[JsonSchema] // 0x0000000180028040-0x00000001800280A0
		public float[] emissiveFactor; // 0x38
		[JsonSchema] // 0x00000001800280A0-0x0000000180028140
		public string alphaMode; // 0x40
		[JsonSchema] // 0x0000000180028140-0x00000001800281F0
		public float alphaCutoff; // 0x48
		public bool doubleSided; // 0x4C
		[JsonSchema] // 0x00000001800281F0-0x0000000180028220
		public glTFExtension extensions; // 0x50
		public glTFExtension extras; // 0x58
	
		// Constructors
		public glTFMaterial(); // 0x0000000180D60020-0x0000000180D600E0
	
		// Methods
		public glTFTextureInfo[] GetTextures(); // 0x0000000180D5FE00-0x0000000180D60020
	}
}
