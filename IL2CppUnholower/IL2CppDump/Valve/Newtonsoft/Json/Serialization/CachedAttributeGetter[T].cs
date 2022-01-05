/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal static class CachedAttributeGetter<T> // TypeDefIndex: 7033
		where T : Attribute
	{
		// Fields
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;
	
		// Constructors
		static CachedAttributeGetter();
	
		// Methods
		public static T GetAttribute(object type);
	}
}
