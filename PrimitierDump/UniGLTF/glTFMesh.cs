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
	public class glTFMesh // TypeDefIndex: 5771
	{
		// Fields
		public string name; // 0x10
		[JsonSchema] // 0x0000000180027A10-0x0000000180027A40
		public List<glTFPrimitives> primitives; // 0x18
		[JsonSchema] // 0x0000000180028920-0x0000000180028950
		public float[] weights; // 0x20
		[JsonSchema] // 0x00000001800281F0-0x0000000180028220
		public glTFExtension extras; // 0x28
		public glTFExtension extensions; // 0x30
	
		// Constructors
		public glTFMesh(); // 0x0000000180D600E0-0x0000000180D60150
		public glTFMesh(string _name); // 0x0000000180D60150-0x0000000180D601D0
	}
}
