/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public struct Glb // TypeDefIndex: 5781
	{
		// Fields
		public readonly GlbChunk Json; // 0x00
		public readonly GlbChunk Binary; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5780
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<byte, bool> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000180D58CD0-0x0000000180D58D30
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _TryParse_b__10_0(byte x); // 0x00000001806E5100-0x00000001806E5110
		}
	
		// Constructors
		public Glb(GlbChunk json, GlbChunk binary); // 0x00000001810B64A0-0x00000001810B6560
	
		// Methods
		public static Glb Create(ArraySegment<byte> json, ArraySegment<byte> bin); // 0x00000001810B5800-0x00000001810B5850
		public static Glb Create(string json, ArraySegment<byte> bin); // 0x00000001810B5850-0x00000001810B5930
		public byte[] ToBytes(); // 0x00000001810B5AB0-0x00000001810B5DC0
		public static GlbChunkType ToChunkType(string src); // 0x00000001810B5DC0-0x00000001810B5EA0
		public static Glb Parse(byte[] bytes); // 0x00000001810B59C0-0x00000001810B5AB0
		public static Glb Parse(ArraySegment<byte> bytes); // 0x00000001810B5930-0x00000001810B59C0
		public static bool TryParse(byte[] bytes, out Glb glb, out Exception ex); // 0x00000001810B5EA0-0x00000001810B5F30
		public static bool TryParse(ArraySegment<byte> bytes, out Glb glb, out Exception ex); // 0x00000001810B5F30-0x00000001810B64A0
	}
}
