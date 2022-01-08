/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal static class EnumUtils // TypeDefIndex: 5377
	{
		// Fields
		[Nullable] // 0x0000000180017930-0x0000000180017990
		private static readonly ThreadSafeStore<StructMultiKey<System.Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; // 0x00
		private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x08
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5376
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static readonly __c __9; // 0x00
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<EnumMemberAttribute, string> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000180797A90-0x0000000180797AF0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal string _InitializeValuesAndNames_b__3_0(EnumMemberAttribute a); // 0x000000018054DB00-0x000000018054DB20
		}
	
		// Constructors
		static EnumUtils(); // 0x00000001803DE510-0x00000001803DE610
	
		// Methods
		private static EnumInfo InitializeValuesAndNames([Nullable] /* 0x0000000180017990-0x00000001800179F0 */ StructMultiKey<System.Type, NamingStrategy> key); // 0x00000001803DCDD0-0x00000001803DD360
		public static bool TryToString(System.Type enumType, object value, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ NamingStrategy namingStrategy, [Nullable] /* 0x0000000180015560-0x00000001800155A0 */ [NotNullWhen] /* 0x0000000180015560-0x00000001800155A0 */ out string name); // 0x00000001803DE360-0x00000001803DE510
		private static string InternalFlagsFormat(EnumInfo entry, ulong result); // 0x00000001803DD360-0x00000001803DD590
		public static EnumInfo GetEnumValuesAndNames(System.Type enumType); // 0x00000001803DCD00-0x00000001803DCDD0
		private static ulong ToUInt64(object value); // 0x00000001803DDFC0-0x00000001803DE360
		public static object ParseEnum(System.Type enumType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ NamingStrategy namingStrategy, string value, bool disallowNumber); // 0x00000001803DD690-0x00000001803DDFC0
		private static int? MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison); // 0x00000001803DD590-0x00000001803DD690
		private static int? FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison); // 0x00000001803DCC10-0x00000001803DCD00
	}
}
