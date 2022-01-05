/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x00000001800178F0-0x0000000180017930
	[NullableContext] // 0x00000001800178F0-0x0000000180017930
	internal static class DynamicUtils // TypeDefIndex: 5371
	{
		// Nested types
		[Nullable] // 0x0000000180015680-0x00000001800156A0
		internal static class BinderWrapper // TypeDefIndex: 5370
		{
			// Fields
			[Nullable] // 0x00000001800155E0-0x0000000180015600
			private static object _getCSharpArgumentInfoArray; // 0x00
			[Nullable] // 0x00000001800155E0-0x0000000180015600
			private static object _setCSharpArgumentInfoArray; // 0x08
			[Nullable] // 0x00000001800155E0-0x0000000180015600
			private static MethodCall<object, object> _getMemberCall; // 0x10
			[Nullable] // 0x00000001800155E0-0x0000000180015600
			private static MethodCall<object, object> _setMemberCall; // 0x18
			private static bool _init; // 0x20
	
			// Methods
			private static void Init(); // 0x000000018078EB00-0x000000018078ED40
			private static object CreateSharpArgumentInfoArray(params /* 0x0000000180014D50-0x0000000180014D60 */ int[] values); // 0x000000018078E590-0x000000018078E870
			private static void CreateMemberCalls(); // 0x000000018078DFA0-0x000000018078E590
			public static CallSiteBinder GetMember(string name, System.Type context); // 0x000000018078E870-0x000000018078EB00
			public static CallSiteBinder SetMember(string name, System.Type context); // 0x000000018078ED40-0x000000018078EFD0
		}
	
		// Extension methods
		public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider); // 0x00000001803DC1D0-0x00000001803DC2E0
	}
}
