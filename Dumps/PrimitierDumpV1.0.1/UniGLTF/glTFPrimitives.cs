/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	[Serializable]
	public class glTFPrimitives // TypeDefIndex: 5770
	{
		// Fields
		[JsonSchema] // 0x00000001800286F0-0x0000000180028820
		public int mode; // 0x10
		[JsonSchema] // 0x0000000180028820-0x0000000180028890
		public int indices; // 0x14
		[JsonSchema] // 0x0000000180028890-0x00000001800288C0
		public glTFAttributes attributes; // 0x18
		[JsonSchema] // 0x0000000180027650-0x0000000180027680
		public int material; // 0x20
		[ItemJsonSchema] // 0x00000001800288C0-0x0000000180028920
		[JsonSchema] // 0x00000001800288C0-0x0000000180028920
		public List<gltfMorphTarget> targets; // 0x28
		public glTFExtension extras; // 0x30
		[JsonSchema] // 0x00000001800281F0-0x0000000180028220
		public glTFExtension extensions; // 0x38
	
		// Properties
		public bool HasVertexColor { get; } // 0x0000000180D60290-0x0000000180D602B0 
	
		// Constructors
		public glTFPrimitives(); // 0x0000000180D60210-0x0000000180D60290
	}
}
