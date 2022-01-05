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
	public class glTFBuffer // TypeDefIndex: 5748
	{
		// Fields
		private IBytesBuffer m_buffer; // 0x10
		public string uri; // 0x18
		[JsonSchema] // 0x0000000180027AB0-0x0000000180027AE0
		public int byteLength; // 0x20
		public glTFExtension extensions; // 0x28
		public glTFExtension extras; // 0x30
		public string name; // 0x38
	
		// Properties
		public IBytesBuffer Buffer { get; } // 0x0000000180268FC0-0x0000000180268FD0 
	
		// Constructors
		public glTFBuffer(); // 0x00000001802650F0-0x0000000180265100
		public glTFBuffer(IBytesBuffer storage); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		public void OpenStorage(IStorage storage); // 0x0000000180D5C990-0x0000000180D5CAA0
		public glTFBufferView Append<T>(T[] array, glBufferTarget target)
			where T : struct;
		public glTFBufferView Append<T>(ArraySegment<T> segment, glBufferTarget target)
			where T : struct;
		public ArraySegment<byte> GetBytes(); // 0x0000000180D5C8C0-0x0000000180D5C990
	}
}
