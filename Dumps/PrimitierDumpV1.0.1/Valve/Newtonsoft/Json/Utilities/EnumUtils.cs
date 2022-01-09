/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal static class EnumUtils // TypeDefIndex: 6999
	{
		// Fields
		private static readonly ThreadSafeStore<System.Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 6998
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<EnumMemberAttribute, string> __9__1_0; // 0x08
			public static Func<FieldInfo, bool> __9__5_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180882C20-0x0000000180882C80
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _InitializeEnumType_b__1_0(EnumMemberAttribute a); // 0x000000018054DB00-0x000000018054DB20
			internal bool _GetValues_b__5_0(FieldInfo f); // 0x00000001808819D0-0x00000001808819F0
		}
	
		// Constructors
		static EnumUtils(); // 0x0000000180393B70-0x0000000180393C40
	
		// Methods
		private static BidirectionalDictionary<string, string> InitializeEnumType(System.Type type); // 0x00000001803936B0-0x0000000180393B70
		public static IList<object> GetValues(System.Type enumType); // 0x0000000180393300-0x00000001803936B0
	}
}
