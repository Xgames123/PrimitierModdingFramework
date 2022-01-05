/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal class PropertyNameTable // TypeDefIndex: 7015
	{
		// Fields
		private static readonly int HashCodeRandomizer; // 0x00
		private int _count; // 0x10
		private Entry[] _entries; // 0x18
		private int _mask; // 0x20
	
		// Nested types
		private class Entry // TypeDefIndex: 7014
		{
			// Fields
			internal readonly string Value; // 0x10
			internal readonly int HashCode; // 0x18
			internal Entry Next; // 0x20
	
			// Constructors
			internal Entry(string value, int hashCode, Entry next); // 0x000000018078EFD0-0x000000018078F020
		}
	
		// Constructors
		static PropertyNameTable(); // 0x00000001808780A0-0x00000001808780E0
		public PropertyNameTable(); // 0x00000001808780E0-0x0000000180878140
	
		// Methods
		public string Get(char[] key, int start, int length); // 0x0000000180877D60-0x0000000180877F60
		public string Add(string key); // 0x0000000180877B90-0x0000000180877D60
		private string AddEntry(string str, int hashCode); // 0x0000000180877950-0x0000000180877B90
		private void Grow(); // 0x0000000180877F60-0x00000001808780A0
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length); // 0x00000001803D9680-0x00000001803D9710
	}
}
