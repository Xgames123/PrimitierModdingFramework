/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal class Base64Encoder // TypeDefIndex: 6981
	{
		// Fields
		private readonly char[] _charsLine; // 0x10
		private readonly TextWriter _writer; // 0x18
		private byte[] _leftOverBytes; // 0x20
		private int _leftOverBytesCount; // 0x28
	
		// Constructors
		public Base64Encoder(TextWriter writer); // 0x0000000180381B40-0x0000000180381BC0
	
		// Methods
		public void Encode(byte[] buffer, int index, int count); // 0x0000000180381650-0x0000000180381A40
		public void Flush(); // 0x0000000180381A40-0x0000000180381B10
		private void WriteChars(char[] chars, int index, int count); // 0x0000000180381B10-0x0000000180381B40
	}
}
