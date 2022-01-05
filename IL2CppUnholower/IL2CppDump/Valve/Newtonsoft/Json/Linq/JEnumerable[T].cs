/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Linq
{
	[DefaultMember] // 0x00000001800239A0-0x00000001800239D0
	public struct JEnumerable<T> : IEnumerable<T>, IEquatable<Valve.Newtonsoft.Json.Linq.JEnumerable<T>> // TypeDefIndex: 7099
		where T : JToken
	{
		// Fields
		public static readonly JEnumerable<T> Empty;
		private readonly IEnumerable<T> _enumerable;
	
		// Constructors
		public JEnumerable(IEnumerable<T> enumerable);
		static JEnumerable();
	
		// Methods
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public bool Equals(JEnumerable<T> other);
		public override bool Equals(object obj);
		public override int GetHashCode();
	}
}
