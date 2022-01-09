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
	public class glTFBufferView // TypeDefIndex: 5749
	{
		// Fields
		[JsonSchema] // 0x0000000180027940-0x0000000180027970
		public int buffer; // 0x10
		[JsonSchema] // 0x0000000180027650-0x0000000180027680
		public int byteOffset; // 0x14
		[JsonSchema] // 0x0000000180027AB0-0x0000000180027AE0
		public int byteLength; // 0x18
		[JsonSchema] // 0x0000000180027AE0-0x0000000180027B70
		public int byteStride; // 0x1C
		[JsonSchema] // 0x0000000180027B70-0x0000000180027C50
		public glBufferTarget target; // 0x20
		public glTFExtension extensions; // 0x28
		public glTFExtension extras; // 0x30
		public string name; // 0x38
	
		// Constructors
		public glTFBufferView(); // 0x00000001802650F0-0x0000000180265100
	}
}
