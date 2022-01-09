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
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Linq
{
	public class JProperty : JContainer // TypeDefIndex: 7104
	{
		// Fields
		private readonly JPropertyList _content; // 0x40
		private readonly string _name; // 0x48
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x0000000180268310-0x0000000180268320 
		public string Name { [DebuggerStepThrough] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
		public JToken Value { [DebuggerStepThrough] /* 0x0000000180014D50-0x0000000180014D60 */ get; set; } // 0x000000018039A5B0-0x000000018039A5D0 0x000000018039A5D0-0x000000018039A650
		public override JTokenType Type { [DebuggerStepThrough] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018039A5A0-0x000000018039A5B0 
	
		// Nested types
		private class JPropertyList : IList<JToken> // TypeDefIndex: 7103
		{
			// Fields
			internal JToken _token; // 0x10
	
			// Properties
			public int Count { get; } // 0x000000018078F340-0x000000018078F350 
			public bool IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
			public JToken this[int index] { get => default; set {} } // 0x0000000180877080-0x0000000180877090 0x000000018078F300-0x000000018078F310
	
			// Nested types
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private sealed class _GetEnumerator_d__1 : IEnumerator<JToken> // TypeDefIndex: 7102
			{
				// Fields
				private int __1__state; // 0x10
				private JToken __2__current; // 0x18
				public JPropertyList __4__this; // 0x20
	
				// Properties
				JToken IEnumerator<Valve.Newtonsoft.Json.Linq.JToken>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
				object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
				// Constructors
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				public _GetEnumerator_d__1(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
				// Methods
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
				private bool MoveNext(); // 0x0000000180795390-0x00000001807953E0
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				void IEnumerator.Reset(); // 0x0000000180880D40-0x0000000180880D80
			}
	
			// Constructors
			public JPropertyList(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public IEnumerator<JToken> GetEnumerator(); // 0x0000000180877020-0x0000000180877080
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180877020-0x0000000180877080
			public void Add(JToken item); // 0x000000018028FF80-0x000000018028FF90
			public void Clear(); // 0x000000018078F1F0-0x000000018078F200
			public bool Contains(JToken item); // 0x000000018078F200-0x000000018078F210
			public void CopyTo(JToken[] array, int arrayIndex); // 0x000000018078F210-0x000000018078F290
			public bool Remove(JToken item); // 0x000000018078F320-0x000000018078F340
			public int IndexOf(JToken item); // 0x000000018078F2F0-0x000000018078F300
			public void Insert(int index, JToken item); // 0x000000018078F300-0x000000018078F310
			public void RemoveAt(int index); // 0x000000018078F310-0x000000018078F320
		}
	
		// Constructors
		public JProperty(JProperty other); // 0x000000018039A520-0x000000018039A5A0
		internal JProperty(string name); // 0x000000018039A450-0x000000018039A520
		public JProperty(string name, object content); // 0x000000018039A280-0x000000018039A450
	
		// Methods
		internal override JToken GetItem(int index); // 0x0000000180399A20-0x0000000180399A90
		internal override void SetItem(int index, JToken item); // 0x000000018039A0A0-0x000000018039A1E0
		internal override bool RemoveItem(JToken item); // 0x0000000180399F90-0x000000018039A0A0
		internal override void RemoveItemAt(int index); // 0x0000000180399E80-0x0000000180399F90
		internal override int IndexOfItem(JToken item); // 0x0000000180399A90-0x0000000180399AB0
		internal override void InsertItem(int index, JToken item, bool skipParentCheck); // 0x0000000180399AB0-0x0000000180399C20
		internal override bool ContainsItem(JToken item); // 0x0000000180399A00-0x0000000180399A20
		internal override void ClearItems(); // 0x0000000180399840-0x0000000180399950
		internal override JToken CloneToken(); // 0x0000000180399950-0x0000000180399A00
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x000000018039A1E0-0x000000018039A280
		public static JProperty Load(JsonReader reader, JsonLoadSettings settings); // 0x0000000180399C20-0x0000000180399E80
	}
}
