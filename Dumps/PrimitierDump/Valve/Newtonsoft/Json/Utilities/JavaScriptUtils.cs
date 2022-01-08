/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal static class JavaScriptUtils // TypeDefIndex: 7001
	{
		// Fields
		internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x00
		internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x08
		internal static readonly bool[] HtmlCharEscapeFlags; // 0x10
	
		// Constructors
		static JavaScriptUtils(); // 0x000000018041F5B0-0x000000018041FE60
	
		// Methods
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar); // 0x000000018041ECE0-0x000000018041EDD0
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags); // 0x000000018041EDD0-0x000000018041EE60
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer); // 0x000000018041F090-0x000000018041F5B0
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling); // 0x000000018041EE60-0x000000018041F090
	}
}
