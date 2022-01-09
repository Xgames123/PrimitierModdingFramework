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

namespace Newtonsoft.Json
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class DefaultJsonNameTable : JsonNameTable // TypeDefIndex: 5298
	{
		// Fields
		private static readonly int HashCodeRandomizer; // 0x00
		private int _count; // 0x10
		private Entry[] _entries; // 0x18
		private int _mask; // 0x20
	
		// Nested types
		[Nullable] // 0x0000000180015680-0x00000001800156A0
		private class Entry // TypeDefIndex: 5297
		{
			// Fields
			internal readonly string Value; // 0x10
			internal readonly int HashCode; // 0x18
			internal Entry Next; // 0x20
	
			// Constructors
			internal Entry(string value, int hashCode, Entry next); // 0x000000018078EFD0-0x000000018078F020
		}
	
		// Constructors
		static DefaultJsonNameTable(); // 0x00000001803D9710-0x00000001803D9750
		public DefaultJsonNameTable(); // 0x00000001803D9750-0x00000001803D97B0
	
		// Methods
		public override string Get(char[] key, int start, int length); // 0x00000001803D9340-0x00000001803D9540
		public string Add(string key); // 0x00000001803D9170-0x00000001803D9340
		private string AddEntry(string str, int hashCode); // 0x00000001803D8F10-0x00000001803D9170
		private void Grow(); // 0x00000001803D9540-0x00000001803D9680
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length); // 0x00000001803D9680-0x00000001803D9710
	}
}
