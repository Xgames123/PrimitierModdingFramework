/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class ArrayByteBuffer : IBytesBuffer // TypeDefIndex: 5792
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Uri_k__BackingField; // 0x10
		private byte[] m_bytes; // 0x18
		private int m_used; // 0x20
	
		// Properties
		public string Uri { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public ArraySegment<byte> Bytes { get; } // 0x00000001810AB580-0x00000001810AB600 
	
		// Constructors
		public ArrayByteBuffer(byte[] bytes = null); // 0x00000001810AB530-0x00000001810AB580
	
		// Methods
		public glTFBufferView Extend<T>(ArraySegment<T> array, glBufferTarget target)
			where T : struct;
		public glTFBufferView Extend(IntPtr p, int bytesLength, int stride, glBufferTarget target); // 0x00000001810AB370-0x00000001810AB530
		public void ExtendCapacity(int capacity); // 0x00000001810AB2E0-0x00000001810AB370
	}
}
