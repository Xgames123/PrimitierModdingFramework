/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniJSON;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class gltf_mesh_extras_targetNames // TypeDefIndex: 5719
	{
		// Fields
		public const string ExtraName = "targetNames"; // Metadata: 0x003A19F8
		public static readonly Utf8String ExtraNameUtf8; // 0x00
	
		// Constructors
		static gltf_mesh_extras_targetNames(); // 0x0000000180D65E60-0x0000000180D65EF0
	
		// Methods
		private static List<string> Deserialize(JsonNode json); // 0x0000000180D64D80-0x0000000180D64FC0
		public static bool TryGet(glTFMesh mesh, out List<string> targetNames); // 0x0000000180D656D0-0x0000000180D65E60
		public static glTFExtension Serialize(params /* 0x0000000180014D50-0x0000000180014D60 */ string[] args); // 0x0000000180D65470-0x0000000180D656D0
		public static void Serialize(glTFMesh gltfMesh, IEnumerable<string> targetNames); // 0x0000000180D64FC0-0x0000000180D65470
	}
}
