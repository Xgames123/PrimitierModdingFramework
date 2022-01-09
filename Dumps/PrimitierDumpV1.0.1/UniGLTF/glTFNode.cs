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
	public class glTFNode // TypeDefIndex: 5772
	{
		// Fields
		public string name; // 0x10
		[ItemJsonSchema] // 0x0000000180027720-0x0000000180027770
		[JsonSchema] // 0x0000000180027720-0x0000000180027770
		public int[] children; // 0x18
		[JsonSchema] // 0x0000000180028950-0x0000000180028980
		public float[] matrix; // 0x20
		[JsonSchema] // 0x0000000180028980-0x00000001800289B0
		public float[] translation; // 0x28
		[ItemJsonSchema] // 0x00000001800289B0-0x0000000180028A20
		[JsonSchema] // 0x00000001800289B0-0x0000000180028A20
		public float[] rotation; // 0x30
		[JsonSchema] // 0x0000000180028980-0x00000001800289B0
		public float[] scale; // 0x38
		[JsonSchema] // 0x0000000180028A20-0x0000000180028A90
		public int mesh; // 0x40
		[JsonSchema] // 0x0000000180028A90-0x0000000180028B40
		public int skin; // 0x44
		[JsonSchema] // 0x0000000180028B40-0x0000000180028BC0
		public float[] weights; // 0x48
		[JsonSchema] // 0x0000000180028BC0-0x0000000180028C30
		public int camera; // 0x50
		public glTFExtension extensions; // 0x58
		public glTFExtension extras; // 0x60
	
		// Constructors
		public glTFNode(); // 0x0000000180D601D0-0x0000000180D601F0
	}
}
