/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal class ReflectionObject // TypeDefIndex: 5407
	{
		// Fields
		[CompilerGenerated] // 0x0000000180018980-0x00000001800189F0
		[Nullable] // 0x0000000180018980-0x00000001800189F0
		private readonly ObjectConstructor<object> _Creator_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly IDictionary<string, ReflectionMember> _Members_k__BackingField; // 0x18
	
		// Properties
		[Nullable] // 0x0000000180018A50-0x0000000180018AB0
		public ObjectConstructor<object> Creator { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268FC0-0x0000000180268FD0 
		public IDictionary<string, ReflectionMember> Members { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 5404
		{
			// Fields
			[Nullable] // 0x0000000180018AB0-0x0000000180018B10
			public Func<object> ctor; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _Create_b__0([Nullable] /* 0x0000000180018B10-0x0000000180018B70 */ object[] args); // 0x00000001807963E0-0x0000000180796430
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass11_1 // TypeDefIndex: 5405
		{
			// Fields
			[Nullable] // 0x0000000180018B70-0x0000000180018BD0
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public __c__DisplayClass11_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _Create_b__1(object target); // 0x0000000180796430-0x00000001807964B0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass11_2 // TypeDefIndex: 5406
		{
			// Fields
			[Nullable] // 0x0000000180018BD0-0x0000000180018C30
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public __c__DisplayClass11_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _Create_b__2(object target, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object arg); // 0x00000001807964B0-0x0000000180796590
		}
	
		// Constructors
		private ReflectionObject([Nullable] /* 0x00000001800189F0-0x0000000180018A50 */ ObjectConstructor<object> creator); // 0x000000018068AB50-0x000000018068ABD0
	
		// Methods
		public object GetValue(object target, string member); // 0x000000018068AA20-0x000000018068AAB0
		public void SetValue(object target, string member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value); // 0x000000018068AAB0-0x000000018068AB50
		public System.Type GetType(string member); // 0x000000018068A9C0-0x000000018068AA20
		public static ReflectionObject Create(System.Type t, params /* 0x0000000180014D50-0x0000000180014D60 */ string[] memberNames); // 0x000000018068A9B0-0x000000018068A9C0
		public static ReflectionObject Create(System.Type t, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ MethodBase creator, params /* 0x0000000180014D50-0x0000000180014D60 */ string[] memberNames); // 0x000000018068A0E0-0x000000018068A9B0
	}
}
