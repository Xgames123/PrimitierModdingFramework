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

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[IsReadOnly] // 0x0000000180018C30-0x0000000180018CA0
	[Nullable] // 0x0000000180018C30-0x0000000180018CA0
	[NullableContext] // 0x0000000180018C30-0x0000000180018CA0
	internal struct StringReference // TypeDefIndex: 5415
	{
		// Fields
		private readonly char[] _chars; // 0x00
		private readonly int _startIndex; // 0x08
		private readonly int _length; // 0x0C
	
		// Properties
		public char this[int i] { get => default; } // 0x0000000180791670-0x00000001807916B0 
		public char[] Chars { get; } // 0x00000001802B6C10-0x00000001802B6C20 
		public int StartIndex { get; } // 0x00000001805D2620-0x00000001805D2630 
		public int Length { get; } // 0x00000001802D9050-0x00000001802D9060 
	
		// Constructors
		public StringReference(char[] chars, int startIndex, int length); // 0x0000000180781270-0x0000000180781280
	
		// Methods
		public override string ToString(); // 0x0000000180791640-0x0000000180791670
	}
}
