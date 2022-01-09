/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 5420
	{
		// Fields
		private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore;
		private readonly Func<TKey, TValue> _creator;
	
		// Constructors
		public ThreadSafeStore(Func<TKey, TValue> creator);
	
		// Methods
		public TValue Get(TKey key);
	}
}
