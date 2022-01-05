/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Linq
{
	[DefaultMember] // 0x0000000180015D20-0x0000000180015D90
	[IsReadOnly] // 0x0000000180015D20-0x0000000180015D90
	[Nullable] // 0x0000000180015D20-0x0000000180015D90
	[NullableContext] // 0x0000000180015D20-0x0000000180015D90
	public struct JEnumerable<T> : IEnumerable<T>, IEquatable<Newtonsoft.Json.Linq.JEnumerable<T>> // TypeDefIndex: 5491
		where T : JToken
	{
		// Fields
		[Nullable] // 0x0000000180015D90-0x0000000180015DF0
		public static readonly JEnumerable<T> Empty;
		private readonly IEnumerable<T> _enumerable;
	
		// Constructors
		public JEnumerable(IEnumerable<T> enumerable);
		static JEnumerable();
	
		// Methods
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public bool Equals([Nullable] /* 0x0000000180015DF0-0x0000000180015E50 */ JEnumerable<T> other);
		public override bool Equals(object obj);
		public override int GetHashCode();
	}
}
