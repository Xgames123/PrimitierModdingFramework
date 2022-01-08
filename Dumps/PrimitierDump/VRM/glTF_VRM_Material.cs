/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UniJSON;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	[JsonSchema] // 0x0000000180036590-0x00000001800365C0
	public class glTF_VRM_Material // TypeDefIndex: 8040
	{
		// Fields
		public string name; // 0x10
		public string shader; // 0x18
		public int renderQueue; // 0x20
		public Dictionary<string, float> floatProperties; // 0x28
		public Dictionary<string, float[]> vectorProperties; // 0x30
		public Dictionary<string, int> textureProperties; // 0x38
		public Dictionary<string, bool> keywordMap; // 0x40
		public Dictionary<string, string> tagMap; // 0x48
		public static readonly string VRM_USE_GLTFSHADER; // 0x00
		private static Utf8String s_floatProperties; // 0x08
		private static Utf8String s_vectorProperties; // 0x18
		private static Utf8String s_keywordMap; // 0x28
		private static Utf8String s_tagMap; // 0x38
		private static Utf8String s_textureProperties; // 0x48
	
		// Constructors
		public glTF_VRM_Material(); // 0x000000018055F270-0x000000018055F3D0
		static glTF_VRM_Material(); // 0x000000018055F0F0-0x000000018055F270
	}
}
