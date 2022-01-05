/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json
{
	public static class JsonConvert // TypeDefIndex: 6944
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static Func<JsonSerializerSettings> _DefaultSettings_k__BackingField; // 0x00
		public static readonly string True; // 0x08
		public static readonly string False; // 0x10
		public static readonly string Null; // 0x18
		public static readonly string Undefined; // 0x20
		public static readonly string PositiveInfinity; // 0x28
		public static readonly string NegativeInfinity; // 0x30
		public static readonly string NaN; // 0x38
	
		// Properties
		public static Func<JsonSerializerSettings> DefaultSettings { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180423220-0x0000000180423280 
	
		// Constructors
		static JsonConvert(); // 0x00000001804230F0-0x0000000180423220
	
		// Methods
		public static string ToString(bool value); // 0x0000000180422D40-0x0000000180422DE0
		public static string ToString(char value); // 0x00000001804229F0-0x0000000180422B50
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x0000000180422FE0-0x00000001804230F0
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x00000001804223E0-0x0000000180422550
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable); // 0x0000000180422C30-0x0000000180422D40
		private static string EnsureDecimalPlace(double value, string text); // 0x00000001804222D0-0x00000001804223E0
		private static string EnsureDecimalPlace(string text); // 0x0000000180422260-0x00000001804222D0
		public static string ToString(decimal value); // 0x0000000180422DE0-0x0000000180422ED0
		public static string ToString(string value); // 0x0000000180422B50-0x0000000180422C30
		public static string ToString(string value, char delimiter); // 0x0000000180422ED0-0x0000000180422FE0
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling); // 0x0000000180422900-0x00000001804229F0
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings); // 0x0000000180422730-0x0000000180422830
		public static string SerializeObject(object value, System.Type type, Formatting formatting, JsonSerializerSettings settings); // 0x0000000180422830-0x0000000180422900
		private static string SerializeObjectInternal(object value, System.Type type, JsonSerializer jsonSerializer); // 0x0000000180422550-0x0000000180422730
		public static T DeserializeObject<T>(string value);
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings);
		public static object DeserializeObject(string value, System.Type type, JsonSerializerSettings settings); // 0x00000001804220C0-0x0000000180422260
	}
}
