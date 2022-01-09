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
	public static class glbImporter // TypeDefIndex: 5894
	{
		// Fields
		public const string GLB_MAGIC = "glTF"; // Metadata: 0x003A1BF0
		public const float GLB_VERSION = 2f; // Metadata: 0x003A1BF8
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5893
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<byte, bool> __9__4_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001806E71B0-0x00000001806E7210
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _ParseGlbChunks_b__4_0(byte x); // 0x00000001806E5100-0x00000001806E5110
		}
	
		// Methods
		public static GlbChunkType ToChunkType(string src); // 0x0000000180D62BD0-0x0000000180D62CB0
		[Obsolete] // 0x0000000180029910-0x0000000180029940
		public static List<GlbChunk> ParseGlbChanks(byte[] bytes); // 0x0000000180D62640-0x0000000180D62650
		public static List<GlbChunk> ParseGlbChunks(byte[] bytes); // 0x0000000180D62650-0x0000000180D62BD0
	}
}
