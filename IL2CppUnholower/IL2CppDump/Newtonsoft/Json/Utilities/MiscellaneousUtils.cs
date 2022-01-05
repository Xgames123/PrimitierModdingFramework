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
using System.Text.RegularExpressions;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal static class MiscellaneousUtils // TypeDefIndex: 5401
	{
		// Methods
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static bool ValueEquals(object objA, object objB); // 0x00000001806893C0-0x00000001806897E0
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message); // 0x0000000180689000-0x00000001806890F0
		public static string ToString([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value); // 0x0000000180689320-0x00000001806893C0
		public static int ByteArrayCompare(byte[] a1, byte[] a2); // 0x0000000180688F50-0x0000000180689000
		public static string GetPrefix(string qualifiedName); // 0x0000000180689160-0x00000001806891F0
		public static string GetLocalName(string qualifiedName); // 0x00000001806890F0-0x0000000180689160
		public static void GetQualifiedNameParts(string qualifiedName, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ out string prefix, out string localName); // 0x00000001806891F0-0x0000000180689290
		internal static RegexOptions GetRegexOptions(string optionsText); // 0x0000000180689290-0x0000000180689320
	}
}
