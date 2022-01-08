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
	public class glTFExtensionExport : glTFExtension // TypeDefIndex: 5715
	{
		// Fields
		private readonly Dictionary<string, ArraySegment<byte>> m_serialized; // 0x10
	
		// Constructors
		public glTFExtensionExport(); // 0x0000000180D5D020-0x0000000180D5D0C0
	
		// Methods
		public override string ToString(); // 0x0000000180D5CF20-0x0000000180D5D020
		public glTFExtensionExport Add(string key, ArraySegment<byte> raw); // 0x0000000180D5CAA0-0x0000000180D5CB20
		public override void Serialize(JsonFormatter f); // 0x0000000180D5CD60-0x0000000180D5CF20
		public static glTFExtensionExport GetOrCreate(ref glTFExtension extension); // 0x0000000180D5CC80-0x0000000180D5CD60
		public override glTFExtensionImport Deserialize(); // 0x0000000180D5CB20-0x0000000180D5CC80
	}
}
