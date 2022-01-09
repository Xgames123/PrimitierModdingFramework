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
	internal abstract class ReflectionDelegateFactory // TypeDefIndex: 7016
	{
		// Constructors
		protected ReflectionDelegateFactory(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo);
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo);
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);
		public abstract Func<T> CreateDefaultConstructor<T>(System.Type type);
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
