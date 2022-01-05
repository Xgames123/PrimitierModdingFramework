/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json.Serialization;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal class ReflectionObject // TypeDefIndex: 7021
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ObjectConstructor<object> _Creator_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private IDictionary<string, ReflectionMember> _Members_k__BackingField; // 0x18
	
		// Properties
		public ObjectConstructor<object> Creator { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public IDictionary<string, ReflectionMember> Members { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 7018
		{
			// Fields
			public Func<object> ctor; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _Create_b__0(object[] args); // 0x00000001808819F0-0x0000000180881A40
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass13_1 // TypeDefIndex: 7019
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public __c__DisplayClass13_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _Create_b__1(object target); // 0x0000000180881A40-0x0000000180881AC0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass13_2 // TypeDefIndex: 7020
		{
			// Fields
			public MethodCall<object, object> call; // 0x10
	
			// Constructors
			public __c__DisplayClass13_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _Create_b__2(object target, object arg); // 0x0000000180881AC0-0x0000000180881BA0
		}
	
		// Constructors
		public ReflectionObject(); // 0x0000000180878CE0-0x0000000180878D50
	
		// Methods
		public object GetValue(object target, string member); // 0x0000000180878C50-0x0000000180878CE0
		public System.Type GetType(string member); // 0x0000000180878BF0-0x0000000180878C50
		public static ReflectionObject Create(System.Type t, params /* 0x0000000180014D50-0x0000000180014D60 */ string[] memberNames); // 0x0000000180878BE0-0x0000000180878BF0
		public static ReflectionObject Create(System.Type t, MethodBase creator, params /* 0x0000000180014D50-0x0000000180014D60 */ string[] memberNames); // 0x00000001808781E0-0x0000000180878BE0
	}
}
