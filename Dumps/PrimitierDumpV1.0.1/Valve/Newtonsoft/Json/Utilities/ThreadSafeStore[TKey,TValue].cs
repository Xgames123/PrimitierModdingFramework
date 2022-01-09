/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 7030
	{
		// Fields
		private readonly object _lock;
		private Dictionary<TKey, TValue> _store;
		private readonly Func<TKey, TValue> _creator;
	
		// Constructors
		public ThreadSafeStore(Func<TKey, TValue> creator);
	
		// Methods
		public TValue Get(TKey key);
		private TValue AddValue(TKey key);
	}
}
