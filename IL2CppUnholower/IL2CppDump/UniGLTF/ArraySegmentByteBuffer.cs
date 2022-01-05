/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class ArraySegmentByteBuffer : IBytesBuffer // TypeDefIndex: 5710
	{
		// Fields
		private ArraySegment<byte> m_bytes; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Uri_k__BackingField; // 0x20
	
		// Properties
		public string Uri { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public ArraySegment<byte> Bytes { get; } // 0x00000001802D3F00-0x00000001802D3F10 
	
		// Constructors
		public ArraySegmentByteBuffer(ArraySegment<byte> bytes); // 0x0000000180BC1150-0x0000000180BC1180
	
		// Methods
		public glTFBufferView Extend<T>(ArraySegment<T> array, glBufferTarget target)
			where T : struct;
		public void ExtendCapacity(int capacity); // 0x00000001810AB600-0x00000001810AB640
	}
}
