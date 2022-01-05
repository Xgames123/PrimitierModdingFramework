/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public static class JsonString // TypeDefIndex: 5608
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 5606
		{
			// Fields
			public IStore w; // 0x10
			public int writeCount; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _Unescape_b__0(char c); // 0x00000001806E68B0-0x00000001806E6970
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 5607
		{
			// Fields
			public IStore w; // 0x10
			public int writeCount; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _Unescape_b__0(byte c); // 0x00000001806E6970-0x00000001806E6A30
		}
	
		// Methods
		public static void Escape(string s, IStore w); // 0x0000000180D2B3B0-0x0000000180D2B770
		public static void Escape(Utf8String s, IStore w); // 0x0000000180D2AF40-0x0000000180D2B300
		public static string Escape(string s); // 0x0000000180D2B300-0x0000000180D2B3B0
		public static void Quote(string s, IStore w); // 0x0000000180D2BA10-0x0000000180D2BA90
		public static void Quote(Utf8String s, IStore w); // 0x0000000180D2B880-0x0000000180D2B910
		public static string Quote(string s); // 0x0000000180D2B910-0x0000000180D2BA10
		public static Utf8String Quote(Utf8String s); // 0x0000000180D2B770-0x0000000180D2B880
		private static byte CheckHex(int b); // 0x0000000180D2ADD0-0x0000000180D2AF40
		public static int Unescape(string src, IStore w); // 0x0000000180D2C2D0-0x0000000180D2C680
		public static int Unescape(Utf8String s, IStore w); // 0x0000000180D2BA90-0x0000000180D2C220
		public static string Unescape(string src); // 0x0000000180D2C220-0x0000000180D2C2D0
		public static int Unquote(string src, IStore w); // 0x0000000180D2C990-0x0000000180D2C9D0
		public static int Unquote(Utf8String src, IStore w); // 0x0000000180D2C800-0x0000000180D2C860
		public static string Unquote(string src); // 0x0000000180D2C860-0x0000000180D2C990
		public static Utf8String Unquote(Utf8String src); // 0x0000000180D2C680-0x0000000180D2C800
	}
}
