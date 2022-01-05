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

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[IsReadOnly] // 0x0000000180017730-0x0000000180017770
	[Nullable] // 0x0000000180017730-0x0000000180017770
	[NullableContext] // 0x0000000180017730-0x0000000180017770
	internal struct StructMultiKey<T1, T2> : IEquatable<Newtonsoft.Json.Utilities.StructMultiKey<T1, T2>> // TypeDefIndex: 5419
	{
		// Fields
		public readonly T1 Value1;
		public readonly T2 Value2;
	
		// Constructors
		public StructMultiKey(T1 v1, T2 v2);
	
		// Methods
		public override int GetHashCode();
		public override bool Equals(object obj);
		public bool Equals([Nullable] /* 0x0000000180018DF0-0x0000000180018E50 */ StructMultiKey<T1, T2> other);
	}
}
