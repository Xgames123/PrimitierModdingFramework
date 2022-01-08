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
	internal abstract class ReflectionDelegateFactory // TypeDefIndex: 5402
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
