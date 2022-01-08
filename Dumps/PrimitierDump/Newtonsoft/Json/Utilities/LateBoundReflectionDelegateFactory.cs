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
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5398
	{
		// Fields
		private static readonly LateBoundReflectionDelegateFactory _instance; // 0x00
	
		// Properties
		internal static ReflectionDelegateFactory Instance { get; } // 0x0000000180688CB0-0x0000000180688D10 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 5391
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public ConstructorInfo c; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public MethodBase method; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _CreateParameterizedConstructor_b__0([Nullable] /* 0x00000001800184D0-0x0000000180018530 */ object[] a); // 0x0000000180796AD0-0x0000000180796AF0
			internal object _CreateParameterizedConstructor_b__1([Nullable] /* 0x0000000180018530-0x0000000180018590 */ object[] a); // 0x0000000180796AF0-0x0000000180796B20
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_0<T> // TypeDefIndex: 5392
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public ConstructorInfo c;
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public MethodBase method;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal object _CreateMethodCall_b__0(T o, [Nullable] /* 0x0000000180018590-0x00000001800185F0 */ object[] a);
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal object _CreateMethodCall_b__1(T o, [Nullable] /* 0x00000001800185F0-0x0000000180018650 */ object[] a);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass5_0<T> // TypeDefIndex: 5393
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public System.Type type;
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public ConstructorInfo constructorInfo;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal T _CreateDefaultConstructor_b__0();
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal T _CreateDefaultConstructor_b__1();
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_0<T> // TypeDefIndex: 5394
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public PropertyInfo propertyInfo;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal object _CreateGet_b__0(T o);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass7_0<T> // TypeDefIndex: 5395
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public FieldInfo fieldInfo;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal object _CreateGet_b__0(T o);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass8_0<T> // TypeDefIndex: 5396
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public FieldInfo fieldInfo;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal void _CreateSet_b__0(T o, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object v);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass9_0<T> // TypeDefIndex: 5397
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public PropertyInfo propertyInfo;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal void _CreateSet_b__0(T o, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object v);
		}
	
		// Constructors
		public LateBoundReflectionDelegateFactory(); // 0x00000001802650F0-0x0000000180265100
		static LateBoundReflectionDelegateFactory(); // 0x0000000180688C50-0x0000000180688CB0
	
		// Methods
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method); // 0x0000000180688B00-0x0000000180688C50
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		public override Func<T> CreateDefaultConstructor<T>(System.Type type);
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
