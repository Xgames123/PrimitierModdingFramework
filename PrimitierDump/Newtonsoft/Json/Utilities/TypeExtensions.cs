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

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180018CA0-0x0000000180018CE0
	[NullableContext] // 0x0000000180018CA0-0x0000000180018CE0
	internal static class TypeExtensions // TypeDefIndex: 5421
	{
		// Extension methods
		public static MemberTypes MemberType(this MemberInfo memberInfo); // 0x0000000180795320-0x0000000180795350
		public static bool ContainsGenericParameters(this System.Type type); // 0x0000000180794F00-0x0000000180794F30
		public static bool IsInterface(this System.Type type); // 0x00000001807952A0-0x00000001807952C0
		public static bool IsGenericType(this System.Type type); // 0x0000000180795270-0x00000001807952A0
		public static bool IsGenericTypeDefinition(this System.Type type); // 0x0000000180795240-0x0000000180795270
		public static System.Type BaseType(this System.Type type); // 0x0000000180794ED0-0x0000000180794F00
		public static Assembly Assembly(this System.Type type); // 0x0000000180794BA0-0x0000000180794BD0
		public static bool IsEnum(this System.Type type); // 0x0000000180795210-0x0000000180795240
		public static bool IsClass(this System.Type type); // 0x00000001807951F0-0x0000000180795210
		public static bool IsSealed(this System.Type type); // 0x00000001807952C0-0x00000001807952E0
		public static bool IsAbstract(this System.Type type); // 0x00000001807951D0-0x00000001807951F0
		public static bool IsVisible(this System.Type type); // 0x0000000180795300-0x0000000180795320
		public static bool IsValueType(this System.Type type); // 0x00000001807952E0-0x0000000180795300
		public static bool AssignableToTypeName(this System.Type type, string fullTypeName, bool searchInterfaces, [Nullable] /* 0x0000000180015560-0x00000001800155A0 */ [NotNullWhen] /* 0x0000000180015560-0x00000001800155A0 */ out System.Type match); // 0x0000000180794D40-0x0000000180794ED0
		public static bool AssignableToTypeName(this System.Type type, string fullTypeName, bool searchInterfaces); // 0x0000000180794BD0-0x0000000180794D40
		public static bool ImplementInterface(this System.Type type, System.Type interfaceType); // 0x0000000180794F30-0x00000001807951D0
	}
}
