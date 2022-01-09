/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal struct StringBuffer // TypeDefIndex: 7025
	{
		// Fields
		private char[] _buffer; // 0x00
		private int _position; // 0x08
	
		// Properties
		public int Position { get; set; } // 0x00000001805D2620-0x00000001805D2630 0x0000000180791460-0x0000000180791470
		public bool IsEmpty { get; } // 0x00000001806254B0-0x00000001806254C0 
		public char[] InternalBuffer { get; } // 0x00000001802B6C10-0x00000001802B6C20 
	
		// Constructors
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize); // 0x000000018087EB70-0x000000018087EBA0
		private StringBuffer(char[] buffer); // 0x0000000180791420-0x0000000180791430
	
		// Methods
		public void Append(IArrayPool<char> bufferPool, char value); // 0x000000018087E940-0x000000018087EA00
		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count); // 0x000000018087EA00-0x000000018087EAC0
		public void Clear(IArrayPool<char> bufferPool); // 0x000000018087EAC0-0x000000018087EB00
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength); // 0x000000018087EB00-0x000000018087EB70
		public override string ToString(); // 0x00000001807913F0-0x0000000180791420
		public string ToString(int start, int length); // 0x00000001807913C0-0x00000001807913F0
	}
}
