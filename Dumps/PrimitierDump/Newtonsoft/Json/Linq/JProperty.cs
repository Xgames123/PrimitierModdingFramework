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
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Linq
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class JProperty : JContainer // TypeDefIndex: 5498
	{
		// Fields
		private readonly JPropertyList _content; // 0x50
		private readonly string _name; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001802BC110-0x00000001802BC120 
		public string Name { [DebuggerStepThrough] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802BF820-0x00000001802BF890 
		public JToken Value { [DebuggerStepThrough] /* 0x0000000180014D50-0x0000000180014D60 */ get; set; } // 0x00000001804B2CE0-0x00000001804B2D00 0x00000001804B2D00-0x00000001804B2D80
		public override JTokenType Type { [DebuggerStepThrough] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018039A5A0-0x000000018039A5B0 
	
		// Nested types
		[Nullable] // 0x00000001800164B0-0x0000000180016500
		private class JPropertyList : IList<JToken> // TypeDefIndex: 5497
		{
			// Fields
			[Nullable] // 0x00000001800155E0-0x0000000180015600
			internal JToken _token; // 0x10
	
			// Properties
			public int Count { get; } // 0x000000018078F340-0x000000018078F350 
			public bool IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
			public JToken this[int index] { get => default; set {} } // 0x000000018078F350-0x000000018078F3B0 0x000000018078F3B0-0x000000018078F410
	
			// Nested types
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private sealed class _GetEnumerator_d__1 : IEnumerator<JToken> // TypeDefIndex: 5496
			{
				// Fields
				private int __1__state; // 0x10
				private JToken __2__current; // 0x18
				[Nullable] // 0x0000000180015680-0x00000001800156A0
				public JPropertyList __4__this; // 0x20
	
				// Properties
				JToken IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
				object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
				// Constructors
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				public _GetEnumerator_d__1(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
				// Methods
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
				private bool MoveNext(); // 0x0000000180795390-0x00000001807953E0
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				void IEnumerator.Reset(); // 0x00000001807953E0-0x0000000180795420
			}
	
			// Constructors
			public JPropertyList(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[IteratorStateMachine] // 0x0000000180016500-0x0000000180016550
			public IEnumerator<JToken> GetEnumerator(); // 0x000000018078F290-0x000000018078F2F0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018078F290-0x000000018078F2F0
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
		public JProperty(JProperty other); // 0x00000001804B2C60-0x00000001804B2CE0
		internal JProperty(string name); // 0x00000001804B2B90-0x00000001804B2C60
		public JProperty(string name, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object content); // 0x00000001804B29C0-0x00000001804B2B90
	
		// Methods
		internal override JToken GetItem(int index); // 0x00000001804B2000-0x00000001804B2070
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override void SetItem(int index, JToken item); // 0x00000001804B2690-0x00000001804B2920
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override bool RemoveItem(JToken item); // 0x00000001804B2580-0x00000001804B2690
		internal override void RemoveItemAt(int index); // 0x00000001804B2470-0x00000001804B2580
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override int IndexOfItem(JToken item); // 0x00000001804B2070-0x00000001804B20A0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override void InsertItem(int index, JToken item, bool skipParentCheck); // 0x00000001804B20A0-0x00000001804B2210
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override bool ContainsItem(JToken item); // 0x00000001804B1FE0-0x00000001804B2000
		internal override void ClearItems(); // 0x00000001804B1E20-0x00000001804B1F30
		internal override JToken CloneToken(); // 0x00000001804B1F30-0x00000001804B1FE0
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x00000001804B2920-0x00000001804B29C0
		public static JProperty Load(JsonReader reader, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonLoadSettings settings); // 0x00000001804B2210-0x00000001804B2470
	}
}
