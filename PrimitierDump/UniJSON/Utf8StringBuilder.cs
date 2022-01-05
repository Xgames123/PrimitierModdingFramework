/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public class Utf8StringBuilder // TypeDefIndex: 5631
	{
		// Fields
		private ByteBuffer m_buffer; // 0x10
		private static Encoding s_utf8; // 0x00
	
		// Constructors
		public Utf8StringBuilder(); // 0x0000000180BCADF0-0x0000000180BCAE50
		static Utf8StringBuilder(); // 0x0000000180BCAD80-0x0000000180BCADF0
	
		// Methods
		public void Ascii(char c); // 0x0000000180BCAC40-0x0000000180BCAC60
		public void Quote(string text); // 0x0000000180BCAC60-0x0000000180BCAD40
		public void Add(Utf8String str); // 0x0000000180BCAC10-0x0000000180BCAC40
		public Utf8String ToUtf8String(); // 0x0000000180BCAD40-0x0000000180BCAD80
	}
}
