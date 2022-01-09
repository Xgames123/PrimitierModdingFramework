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
	public class glTFAccessor // TypeDefIndex: 5753
	{
		// Fields
		[JsonSchema] // 0x0000000180027650-0x0000000180027680
		public int bufferView; // 0x10
		[JsonSchema] // 0x0000000180027D20-0x0000000180027DA0
		public int byteOffset; // 0x14
		[JsonSchema] // 0x0000000180027DA0-0x0000000180027E80
		public string type; // 0x18
		[JsonSchema] // 0x0000000180027E80-0x0000000180027EB0
		public glComponentType componentType; // 0x20
		[JsonSchema] // 0x0000000180027AB0-0x0000000180027AE0
		public int count; // 0x24
		[JsonSchema] // 0x0000000180027EB0-0x0000000180027EE0
		public float[] max; // 0x28
		[JsonSchema] // 0x0000000180027EB0-0x0000000180027EE0
		public float[] min; // 0x30
		public bool normalized; // 0x38
		public glTFSparse sparse; // 0x40
		public string name; // 0x48
		public glTFExtension extensions; // 0x50
		public glTFExtension extras; // 0x58
	
		// Properties
		public int TypeCount { get; } // 0x0000000180D5BC70-0x0000000180D5BE70 
	
		// Constructors
		public glTFAccessor(); // 0x0000000180D5BC60-0x0000000180D5BC70
	
		// Methods
		public int GetStride(); // 0x0000000180D5BBA0-0x0000000180D5BC60
		public int CalcByteSize(); // 0x0000000180D5BAE0-0x0000000180D5BBA0
	}
}
