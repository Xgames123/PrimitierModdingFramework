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
	public static class JsonConvert // TypeDefIndex: 5308
	{
		// Fields
		[CompilerGenerated] // 0x0000000180016B20-0x0000000180016B90
		[Nullable] // 0x0000000180016B20-0x0000000180016B90
		private static Func<JsonSerializerSettings> _DefaultSettings_k__BackingField; // 0x00
		public static readonly string True; // 0x08
		public static readonly string False; // 0x10
		public static readonly string Null; // 0x18
		public static readonly string Undefined; // 0x20
		public static readonly string PositiveInfinity; // 0x28
		public static readonly string NegativeInfinity; // 0x30
		public static readonly string NaN; // 0x38
	
		// Properties
		[Nullable] // 0x0000000180016BD0-0x0000000180016C30
		public static Func<JsonSerializerSettings> DefaultSettings { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001804C7490-0x00000001804C74F0 
	
		// Constructors
		static JsonConvert(); // 0x00000001804C7360-0x00000001804C7490
	
		// Methods
		public static string ToString(bool value); // 0x00000001804C6F70-0x00000001804C7010
		public static string ToString(char value); // 0x00000001804C70F0-0x00000001804C7250
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x00000001804C6D50-0x00000001804C6E60
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x00000001804C6A00-0x00000001804C6B70
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x00000001804C6E60-0x00000001804C6F70
		private static string EnsureDecimalPlace(double value, string text); // 0x00000001804C68F0-0x00000001804C6A00
		private static string EnsureDecimalPlace(string text); // 0x00000001804C6880-0x00000001804C68F0
		public static string ToString(decimal value); // 0x00000001804C6B70-0x00000001804C6C60
		public static string ToString([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value); // 0x00000001804C7010-0x00000001804C70F0
		public static string ToString([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value, char delimiter); // 0x00000001804C7250-0x00000001804C7360
		public static string ToString([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value, char delimiter, StringEscapeHandling stringEscapeHandling); // 0x00000001804C6C60-0x00000001804C6D50
	}
}
