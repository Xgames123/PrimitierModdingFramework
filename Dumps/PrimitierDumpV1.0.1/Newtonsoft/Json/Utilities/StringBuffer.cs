/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015720-0x0000000180015760
	[NullableContext] // 0x0000000180015720-0x0000000180015760
	internal struct StringBuffer // TypeDefIndex: 5414
	{
		// Fields
		private char[] _buffer; // 0x00
		private int _position; // 0x08
	
		// Properties
		public int Position { get; set; } // 0x00000001805D2620-0x00000001805D2630 0x0000000180791460-0x0000000180791470
		public bool IsEmpty { get; } // 0x00000001806254B0-0x00000001806254C0 
		public char[] InternalBuffer { get; } // 0x00000001802B6C10-0x00000001802B6C20 
	
		// Constructors
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize); // 0x0000000180791430-0x0000000180791460
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		private StringBuffer(char[] buffer); // 0x0000000180791420-0x0000000180791430
	
		// Methods
		public void Append(IArrayPool<char> bufferPool, char value); // 0x0000000180791250-0x0000000180791310
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public void Append([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count); // 0x0000000180791190-0x0000000180791250
		public void Clear(IArrayPool<char> bufferPool); // 0x0000000180791310-0x0000000180791350
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength); // 0x0000000180791350-0x00000001807913C0
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public override string ToString(); // 0x00000001807913F0-0x0000000180791420
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public string ToString(int start, int length); // 0x00000001807913C0-0x00000001807913F0
	}
}
