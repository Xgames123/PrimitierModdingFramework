/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VRMShaders;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class GltfMaterialImporter // TypeDefIndex: 5826
	{
		// Fields
		public readonly List<TryCreateMaterialParamFromGltf> GltfMaterialParamProcessors; // 0x10
	
		// Constructors
		public GltfMaterialImporter(); // 0x0000000180D147D0-0x0000000180D14900
	
		// Methods
		public static string MaterialName(int index, glTFMaterial src); // 0x0000000180D14740-0x0000000180D147D0
		public MaterialImportParam GetMaterialParam(GltfParser parser, int i); // 0x0000000180D14360-0x0000000180D145B0
		public static ValueTuple<Vector2, Vector2> GetTextureOffsetAndScale(glTFTextureInfo textureInfo); // 0x0000000180D145B0-0x0000000180D14740
		public static glTF CreateMaterialForTest(glTFMaterial material); // 0x0000000180D14130-0x0000000180D14360
	}
}
