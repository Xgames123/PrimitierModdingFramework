/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class UriByteBuffer : IBytesBuffer // TypeDefIndex: 5887
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Uri_k__BackingField; // 0x10
		private byte[] m_bytes; // 0x18
		private const string DataPrefix = "data:application/octet-stream;base64,"; // Metadata: 0x003A1B84
		private const string DataPrefix2 = "data:application/gltf-buffer;base64,"; // Metadata: 0x003A1BAD
		private const string DataPrefix3 = "data:image/jpeg;base64,"; // Metadata: 0x003A1BD5
	
		// Properties
		public string Uri { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public ArraySegment<byte> Bytes { get; } // 0x0000000180BC9E20-0x0000000180BC9E80 
	
		// Constructors
		public UriByteBuffer(string baseDir, string uri); // 0x0000000180BC9D80-0x0000000180BC9E20
	
		// Methods
		[Obsolete] // 0x00000001800298E0-0x0000000180029910
		public static byte[] ReadEmbeded(string uri); // 0x0000000180BC9CF0-0x0000000180BC9D00
		public static byte[] ReadEmbedded(string uri); // 0x0000000180BC9C20-0x0000000180BC9CF0
		private byte[] ReadFromUri(string baseDir, string uri); // 0x0000000180BC9D00-0x0000000180BC9D80
		public glTFBufferView Extend<T>(ArraySegment<T> array, glBufferTarget target)
			where T : struct;
		public void ExtendCapacity(int capacity); // 0x0000000180BC9BE0-0x0000000180BC9C20
	}
}
