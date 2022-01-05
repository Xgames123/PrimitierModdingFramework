/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json
{
	internal struct JsonPosition // TypeDefIndex: 6954
	{
		// Fields
		private static readonly char[] SpecialCharacters; // 0x00
		internal JsonContainerType Type; // 0x00
		internal int Position; // 0x04
		internal string PropertyName; // 0x08
		internal bool HasIndex; // 0x10
	
		// Constructors
		public JsonPosition(JsonContainerType type); // 0x0000000180425730-0x00000001804257B0
		static JsonPosition(); // 0x00000001804256B0-0x0000000180425730
	
		// Methods
		internal int CalculateLength(); // 0x0000000180425250-0x00000001804252F0
		internal void WriteTo(StringBuilder sb); // 0x0000000180425540-0x00000001804256B0
		internal static bool TypeHasIndex(JsonContainerType type); // 0x0000000180425530-0x0000000180425540
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition); // 0x0000000180424E90-0x0000000180425250
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message); // 0x00000001804252F0-0x0000000180425530
	}
}
