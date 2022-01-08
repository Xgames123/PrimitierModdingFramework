/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal static class ConvertUtils // TypeDefIndex: 6992
	{
		// Fields
		private static readonly Dictionary<System.Type, PrimitiveTypeCode> TypeCodeMap; // 0x00
		private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x08
		private static readonly ThreadSafeStore<TypeConvertKey, Func<object, object>> CastConverters; // 0x10
	
		// Nested types
		internal struct TypeConvertKey : IEquatable<TypeConvertKey> // TypeDefIndex: 6989
		{
			// Fields
			private readonly System.Type _initialType; // 0x00
			private readonly System.Type _targetType; // 0x08
	
			// Properties
			public System.Type InitialType { get; } // 0x00000001802B6C10-0x00000001802B6C20 
			public System.Type TargetType { get; } // 0x00000001802D7BB0-0x00000001802D7BC0 
	
			// Constructors
			public TypeConvertKey(System.Type initialType, System.Type targetType); // 0x0000000180494FD0-0x0000000180494FE0
	
			// Methods
			public override int GetHashCode(); // 0x000000018087E7B0-0x000000018087E810
			public override bool Equals(object obj); // 0x0000000180880740-0x00000001808807E0
			public bool Equals(TypeConvertKey other); // 0x000000018087E790-0x000000018087E7B0
		}
	
		internal enum ConvertResult // TypeDefIndex: 6990
		{
			Success = 0,
			CannotConvertNull = 1,
			NotInstantiableType = 2,
			NoValidConversion = 3
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 6991
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _CreateCastConverter_b__0(object o); // 0x00000001808829D0-0x0000000180882AA0
		}
	
		// Constructors
		static ConvertUtils(); // 0x00000001803863F0-0x00000001803876C0
	
		// Methods
		public static PrimitiveTypeCode GetTypeCode(System.Type t); // 0x0000000180384BC0-0x0000000180384C20
		public static PrimitiveTypeCode GetTypeCode(System.Type t, out bool isEnum); // 0x0000000180384C20-0x0000000180384EB0
		public static TypeInformation GetTypeInformation(IConvertible convertable); // 0x0000000180384EB0-0x0000000180384F60
		public static bool IsConvertible(System.Type t); // 0x0000000180385480-0x0000000180385510
		public static TimeSpan ParseTimeSpan(string input); // 0x0000000180385630-0x0000000180385690
		private static Func<object, object> CreateCastConverter(TypeConvertKey t); // 0x0000000180384660-0x00000001803848E0
		private static bool TryConvert(object initialValue, CultureInfo culture, System.Type targetType, out object value); // 0x00000001803862A0-0x0000000180386360
		private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, System.Type targetType, out object value); // 0x0000000180385800-0x00000001803862A0
		public static object ConvertOrCast(object initialValue, CultureInfo culture, System.Type targetType); // 0x00000001803844D0-0x0000000180384660
		private static object EnsureTypeAssignable(object value, System.Type initialType, System.Type targetType); // 0x00000001803848E0-0x0000000180384B60
		internal static TypeConverter GetConverter(System.Type t); // 0x0000000180384B60-0x0000000180384BC0
		public static bool VersionTryParse(string input, out System.Version result); // 0x0000000180386360-0x00000001803863F0
		public static bool IsInteger(object value); // 0x0000000180385510-0x0000000180385630
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value); // 0x0000000180385110-0x00000001803852E0
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value); // 0x00000001803852E0-0x0000000180385480
		public static bool TryConvertGuid(string s, out Guid g); // 0x0000000180385690-0x0000000180385800
		public static int HexTextToInt(char[] text, int start, int end); // 0x0000000180385030-0x0000000180385110
		private static int HexCharToInt(char ch); // 0x0000000180384F60-0x0000000180385030
	}
}
