/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal static class StringUtils // TypeDefIndex: 7029
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass13_0<TSource> // TypeDefIndex: 7028
		{
			// Fields
			public Func<TSource, string> valueSelector;
			public string testValue;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal bool _ForgivingCaseSensitiveFind_b__0(TSource s);
			internal bool _ForgivingCaseSensitiveFind_b__1(TSource s);
		}
	
		// Methods
		public static StringWriter CreateStringWriter(int capacity); // 0x000000018087EC30-0x000000018087ECF0
		public static void ToCharAsUnicode(char c, char[] buffer); // 0x000000018087F390-0x000000018087F4D0
		public static bool IsHighSurrogate(char c); // 0x000000018087F2D0-0x000000018087F330
		public static bool IsLowSurrogate(char c); // 0x000000018087F330-0x000000018087F390
	
		// Extension methods
		public static string FormatWith(this string format, IFormatProvider provider, object arg0); // 0x000000018087EEC0-0x000000018087EF80
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1); // 0x000000018087EF80-0x000000018087F0A0
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2); // 0x000000018087F150-0x000000018087F2D0
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3); // 0x000000018087ECF0-0x000000018087EEC0
		private static string FormatWith(this string format, IFormatProvider provider, params /* 0x0000000180014D50-0x0000000180014D60 */ object[] args); // 0x000000018087F0A0-0x000000018087F150
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue);
		public static bool StartsWith(this string source, char value); // 0x0000000180791E60-0x0000000180791EA0
		public static bool EndsWith(this string source, char value); // 0x0000000180791770-0x00000001807917B0
	}
}
