/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal static class JavaScriptUtils // TypeDefIndex: 5389
	{
		// Fields
		internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x00
		internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x08
		internal static readonly bool[] HtmlCharEscapeFlags; // 0x10
	
		// Constructors
		static JavaScriptUtils(); // 0x00000001804C3980-0x00000001804C4230
	
		// Methods
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar); // 0x00000001804C2A00-0x00000001804C2AF0
		public static bool ShouldEscapeJavaScriptString([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string s, bool[] charEscapeFlags); // 0x000000018041EDD0-0x000000018041EE60
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static void WriteEscapedJavaScriptString([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ TextWriter writer, string s, char delimiter, bool appendDelimiters, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer); // 0x00000001804C3310-0x00000001804C3980
		public static string ToEscapedJavaScriptString([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling); // 0x00000001804C2AF0-0x00000001804C2D20
		private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling); // 0x00000001804C2940-0x00000001804C2A00
		public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, [NotNullWhen] /* 0x0000000180018490-0x00000001800184D0 */ [Nullable] /* 0x0000000180018490-0x00000001800184D0 */ out string errorMessage); // 0x00000001804C2F00-0x00000001804C3310
		private static bool TryGetDateConstructorValue(JsonReader reader, out long? integer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ out string errorMessage); // 0x00000001804C2D20-0x00000001804C2F00
	}
}
