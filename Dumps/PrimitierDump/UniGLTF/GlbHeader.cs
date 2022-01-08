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
	public struct GlbHeader // TypeDefIndex: 5778
	{
		// Fields
		public static readonly byte[] GLB_MAGIC; // 0x00
		public static readonly byte[] GLB_VERSION; // 0x08
	
		// Constructors
		static GlbHeader(); // 0x00000001810B5730-0x00000001810B5800
	
		// Methods
		public static void WriteTo(Stream s); // 0x00000001810B5660-0x00000001810B5730
		public static int TryParse(ArraySegment<byte> bytes, out int pos, out Exception message); // 0x00000001810B5410-0x00000001810B5660
	}
}
