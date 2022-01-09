/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal struct JsonPosition // TypeDefIndex: 5319
	{
		// Fields
		private static readonly char[] SpecialCharacters; // 0x00
		internal JsonContainerType Type; // 0x00
		internal int Position; // 0x04
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		internal string PropertyName; // 0x08
		internal bool HasIndex; // 0x10
	
		// Constructors
		public JsonPosition(JsonContainerType type); // 0x00000001804CA510-0x00000001804CA5F0
		static JsonPosition(); // 0x00000001804CA490-0x00000001804CA510
	
		// Methods
		internal int CalculateLength(); // 0x00000001804C9FA0-0x00000001804CA040
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal void WriteTo([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ StringBuilder sb, ref StringWriter writer, ref char[] buffer); // 0x00000001804CA280-0x00000001804CA490
		internal static bool TypeHasIndex(JsonContainerType type); // 0x0000000180425530-0x0000000180425540
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition); // 0x00000001804C9BB0-0x00000001804C9FA0
		internal static string FormatMessage([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ IJsonLineInfo lineInfo, string path, string message); // 0x00000001804CA040-0x00000001804CA280
	}
}
