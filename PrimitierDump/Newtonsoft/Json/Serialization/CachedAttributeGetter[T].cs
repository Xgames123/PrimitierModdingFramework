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
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	internal static class CachedAttributeGetter<T> // TypeDefIndex: 5423
		where T : Attribute
	{
		// Fields
		[Nullable] // 0x0000000180018E50-0x0000000180018EB0
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;
	
		// Constructors
		static CachedAttributeGetter();
	
		// Methods
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public static T GetAttribute(object type);
	}
}
