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

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180018CE0-0x0000000180018D20
	[NullableContext] // 0x0000000180018CE0-0x0000000180018D20
	internal static class StringUtils // TypeDefIndex: 5418
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass14_0<TSource> // TypeDefIndex: 5417
		{
			// Fields
			[Nullable] // 0x0000000180018D90-0x0000000180018DF0
			public Func<TSource, string> valueSelector;
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public string testValue;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _ForgivingCaseSensitiveFind_b__0(TSource s);
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _ForgivingCaseSensitiveFind_b__1(TSource s);
		}
	
		// Methods
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static bool IsNullOrEmpty([NotNullWhen] /* 0x0000000180015700-0x0000000180015720 */ string value); // 0x0000000180791E50-0x0000000180791E60
		public static StringWriter CreateStringWriter(int capacity); // 0x00000001807916B0-0x0000000180791770
		public static void ToCharAsUnicode(char c, char[] buffer); // 0x0000000180792130-0x0000000180792240
		public static string ToCamelCase(string s); // 0x0000000180791EA0-0x0000000180792130
		private static char ToLower(char c); // 0x0000000180792240-0x00000001807922E0
		public static bool IsHighSurrogate(char c); // 0x0000000180791D90-0x0000000180791DF0
		public static bool IsLowSurrogate(char c); // 0x0000000180791DF0-0x0000000180791E50
	
		// Extension methods
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object arg0); // 0x0000000180791A30-0x0000000180791AF0
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object arg0, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object arg1); // 0x0000000180791C70-0x0000000180791D90
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object arg0, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object arg1, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object arg2); // 0x0000000180791AF0-0x0000000180791C70
		[NullableContext] // 0x0000000180016840-0x0000000180016870
		public static string FormatWith([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ this string format, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ IFormatProvider provider, object arg0, object arg1, object arg2, object arg3); // 0x00000001807917B0-0x0000000180791980
		private static string FormatWith(this string format, IFormatProvider provider, params /* 0x0000000180018D20-0x0000000180018D90 */ [Nullable] /* 0x0000000180018D20-0x0000000180018D90 */ object[] args); // 0x0000000180791980-0x0000000180791A30
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue);
		public static bool StartsWith(this string source, char value); // 0x0000000180791E60-0x0000000180791EA0
		public static bool EndsWith(this string source, char value); // 0x0000000180791770-0x00000001807917B0
		public static string Trim(this string s, int start, int length); // 0x00000001807922E0-0x0000000180792510
	}
}
