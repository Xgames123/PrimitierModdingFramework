/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal static class ConvertUtils // TypeDefIndex: 5358
	{
		// Fields
		private static readonly Dictionary<System.Type, PrimitiveTypeCode> TypeCodeMap; // 0x00
		private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x08
		[Nullable] // 0x0000000180017610-0x0000000180017670
		private static readonly ThreadSafeStore<StructMultiKey<System.Type, System.Type>, Func<object, object>> CastConverters; // 0x10
	
		// Nested types
		[NullableContext] // 0x0000000180015700-0x0000000180015720
		internal enum ConvertResult // TypeDefIndex: 5356
		{
			Success = 0,
			CannotConvertNull = 1,
			NotInstantiableType = 2,
			NoValidConversion = 3
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 5357
		{
			// Fields
			[Nullable] // 0x00000001800176D0-0x0000000180017730
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015660-0x0000000180015680
			internal object _CreateCastConverter_b__0(object o); // 0x0000000180797790-0x0000000180797860
		}
	
		// Constructors
		static ConvertUtils(); // 0x00000001803CA240-0x00000001803CB530
	
		// Methods
		public static PrimitiveTypeCode GetTypeCode(System.Type t); // 0x00000001803C8AB0-0x00000001803C8B10
		public static PrimitiveTypeCode GetTypeCode(System.Type t, out bool isEnum); // 0x00000001803C8820-0x00000001803C8AB0
		public static TypeInformation GetTypeInformation(IConvertible convertable); // 0x00000001803C8B10-0x00000001803C8BC0
		public static bool IsConvertible(System.Type t); // 0x00000001803C8BC0-0x00000001803C8C50
		public static TimeSpan ParseTimeSpan(string input); // 0x00000001803C8D70-0x00000001803C8E10
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private static Func<object, object> CreateCastConverter([Nullable] /* 0x0000000180017670-0x00000001800176D0 */ StructMultiKey<System.Type, System.Type> t); // 0x00000001803C7380-0x00000001803C7620
		internal static BigInteger ToBigInteger(object value); // 0x00000001803C8E10-0x00000001803C92F0
		public static object FromBigInteger(BigInteger i, System.Type targetType); // 0x00000001803C82D0-0x00000001803C8820
		private static bool TryConvert([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object initialValue, CultureInfo culture, System.Type targetType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ out object value); // 0x00000001803CA060-0x00000001803CA120
		private static ConvertResult TryConvertInternal([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object initialValue, CultureInfo culture, System.Type targetType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ out object value); // 0x00000001803C9370-0x00000001803CA060
		public static object ConvertOrCast([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object initialValue, CultureInfo culture, System.Type targetType); // 0x00000001803C71E0-0x00000001803C7380
		private static object EnsureTypeAssignable([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, System.Type initialType, System.Type targetType); // 0x00000001803C8040-0x00000001803C82D0
		public static bool VersionTryParse(string input, [Nullable] /* 0x0000000180015560-0x00000001800155A0 */ [NotNullWhen] /* 0x0000000180015560-0x00000001800155A0 */ out System.Version result); // 0x00000001803CA1D0-0x00000001803CA240
		public static bool IsInteger(object value); // 0x00000001803C8C50-0x00000001803C8D70
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value); // 0x0000000180385110-0x00000001803852E0
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value); // 0x00000001803852E0-0x0000000180385480
		public static ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value); // 0x00000001803C7620-0x00000001803C8040
		public static bool TryConvertGuid(string s, out Guid g); // 0x00000001803C92F0-0x00000001803C9370
		public static bool TryHexTextToInt(char[] text, int start, int end, out int value); // 0x00000001803CA120-0x00000001803CA1D0
	}
}
