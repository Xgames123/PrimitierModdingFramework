/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UniGLTF;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF.Zip
{
	internal class ZipArchiveStorage : IStorage // TypeDefIndex: 5920
	{
		// Fields
		public List<CentralDirectoryFileHeader> Entries; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5918
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CentralDirectoryFileHeader, string> __9__0_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001806E6F70-0x00000001806E6FD0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _ToString_b__0_0(CentralDirectoryFileHeader x); // 0x00000001806E52E0-0x00000001806E5340
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 5919
		{
			// Fields
			public string url; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Get_b__0(CentralDirectoryFileHeader x); // 0x00000001806E6810-0x00000001806E6850
		}
	
		// Constructors
		public ZipArchiveStorage(); // 0x0000000180BCFCF0-0x0000000180BCFD60
	
		// Methods
		public override string ToString(); // 0x0000000180BCFB60-0x0000000180BCFCF0
		public static ZipArchiveStorage Parse(byte[] bytes); // 0x0000000180BCFA10-0x0000000180BCFB60
		public byte[] Extract(CentralDirectoryFileHeader header); // 0x0000000180BCF500-0x0000000180BCF780
		public string ExtractToString(CentralDirectoryFileHeader header, Encoding encoding); // 0x0000000180BCF250-0x0000000180BCF500
		public ArraySegment<byte> Get(string url); // 0x0000000180BCF780-0x0000000180BCFA10
		public string GetPath(string url); // 0x0000000180273F80-0x0000000180273F90
	}
}
