/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json.Serialization;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 7010
	{
		// Fields
		private static readonly LateBoundReflectionDelegateFactory _instance; // 0x00
	
		// Properties
		internal static ReflectionDelegateFactory Instance { get; } // 0x0000000180877280-0x00000001808772E0 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 7003
		{
			// Fields
			public ConstructorInfo c; // 0x10
			public MethodBase method; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _CreateParameterizedConstructor_b__0(object[] a); // 0x0000000180796AD0-0x0000000180796AF0
			internal object _CreateParameterizedConstructor_b__1(object[] a); // 0x0000000180796AF0-0x0000000180796B20
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_0<T> // TypeDefIndex: 7004
		{
			// Fields
			public ConstructorInfo c;
			public MethodBase method;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal object _CreateMethodCall_b__0(T o, object[] a);
			internal object _CreateMethodCall_b__1(T o, object[] a);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass5_0<T> // TypeDefIndex: 7005
		{
			// Fields
			public System.Type type;
			public ConstructorInfo constructorInfo;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal T _CreateDefaultConstructor_b__0();
			internal T _CreateDefaultConstructor_b__1();
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_0<T> // TypeDefIndex: 7006
		{
			// Fields
			public PropertyInfo propertyInfo;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal object _CreateGet_b__0(T o);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass7_0<T> // TypeDefIndex: 7007
		{
			// Fields
			public FieldInfo fieldInfo;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal object _CreateGet_b__0(T o);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass8_0<T> // TypeDefIndex: 7008
		{
			// Fields
			public FieldInfo fieldInfo;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _CreateSet_b__0(T o, object v);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass9_0<T> // TypeDefIndex: 7009
		{
			// Fields
			public PropertyInfo propertyInfo;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _CreateSet_b__0(T o, object v);
		}
	
		// Constructors
		public LateBoundReflectionDelegateFactory(); // 0x00000001802650F0-0x0000000180265100
		static LateBoundReflectionDelegateFactory(); // 0x0000000180877220-0x0000000180877280
	
		// Methods
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method); // 0x0000000180877090-0x0000000180877220
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		public override Func<T> CreateDefaultConstructor<T>(System.Type type);
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
