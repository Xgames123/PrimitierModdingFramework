/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public struct GlbChunk // TypeDefIndex: 5779
	{
		// Fields
		public GlbChunkType ChunkType; // 0x00
		public ArraySegment<byte> Bytes; // 0x08
	
		// Constructors
		public GlbChunk(string json); // 0x00000001810B5360-0x00000001810B53F0
		public GlbChunk(ArraySegment<byte> bytes); // 0x00000001810B5400-0x00000001810B5410
		public GlbChunk(GlbChunkType type, ArraySegment<byte> bytes); // 0x00000001810B53F0-0x00000001810B5400
	
		// Methods
		public static GlbChunk CreateJson(string json); // 0x00000001810B4F20-0x00000001810B4FD0
		public static GlbChunk CreateJson(ArraySegment<byte> bytes); // 0x00000001810B4F00-0x00000001810B4F20
		public static GlbChunk CreateBin(ArraySegment<byte> bytes); // 0x00000001810B4EE0-0x00000001810B4F00
		private byte GetPaddingByte(); // 0x00000001810B4FD0-0x00000001810B50B0
		public int WriteTo(Stream s); // 0x00000001810B50B0-0x00000001810B5360
	}
}
