/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public struct JsonNode // TypeDefIndex: 5614
	{
		// Fields
		private List<JsonValue> m_Values; // 0x00
		private int _valueIndex; // 0x08
	
		// Properties
		public bool IsValid { get; } // 0x000000018036B840-0x000000018036B850 
		public int ValueIndex { get; } // 0x0000000180D28470-0x0000000180D28480 
		public JsonNode Prev { get; } // 0x0000000180D28430-0x0000000180D28470 
		public JsonValue Value { get; } // 0x0000000180D28480-0x0000000180D28520 
		public int ChildCount { get; } // 0x0000000180D27ED0-0x0000000180D27F50 
		public IEnumerable<JsonNode> Children { [IteratorStateMachine] /* 0x0000000180026C20-0x0000000180026C70 */ get; } // 0x0000000180D27F50-0x0000000180D27FC0 
		public JsonNode this[string key] { get => default; } // 0x0000000180D28130-0x0000000180D281E0 
		public JsonNode this[Utf8String key] { get => default; } // 0x0000000180D280F0-0x0000000180D28130 
		public JsonNode this[int index] { get => default; } // 0x0000000180BB3C10-0x0000000180BB3C50 
		public bool HasParent { get; } // 0x0000000180D27FC0-0x0000000180D280F0 
		public JsonNode Parent { get; } // 0x0000000180D281E0-0x0000000180D28430 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5610
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<JsonNode, JsonNode>, Utf8String> __9__1_0; // 0x08
			public static Func<KeyValuePair<JsonNode, JsonNode>, Utf8String> __9__1_1; // 0x10
			public static Func<KeyValuePair<JsonNode, JsonNode>, string> __9__3_0; // 0x18
			public static Func<KeyValuePair<JsonNode, JsonNode>, JsonNode> __9__5_0; // 0x20
			public static Func<KeyValuePair<JsonNode, JsonNode>, JsonNode> __9__5_1; // 0x28
			public static Func<KeyValuePair<JsonNode, JsonNode>, JsonNode> __9__5_2; // 0x30
			public static Func<KeyValuePair<JsonNode, JsonNode>, JsonNode> __9__5_3; // 0x38
	
			// Constructors
			static __c(); // 0x0000000180D58BB0-0x0000000180D58C10
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Utf8String _Equals_b__1_0(KeyValuePair<JsonNode, JsonNode> x); // 0x0000000180D56B30-0x0000000180D56B90
			internal Utf8String _Equals_b__1_1(KeyValuePair<JsonNode, JsonNode> x); // 0x0000000180D56B90-0x0000000180D56BF0
			internal string _ToString_b__3_0(KeyValuePair<JsonNode, JsonNode> x); // 0x0000000180D56EC0-0x0000000180D56F00
			internal JsonNode _Diff_b__5_0(KeyValuePair<JsonNode, JsonNode> x); // 0x0000000180D56A10-0x0000000180D56A50
			internal JsonNode _Diff_b__5_1(KeyValuePair<JsonNode, JsonNode> x); // 0x0000000180D56A50-0x0000000180D56AA0
			internal JsonNode _Diff_b__5_2(KeyValuePair<JsonNode, JsonNode> x); // 0x0000000180D56AA0-0x0000000180D56AE0
			internal JsonNode _Diff_b__5_3(KeyValuePair<JsonNode, JsonNode> x); // 0x0000000180D56AE0-0x0000000180D56B30
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ToString_d__3 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 5611
		{
			// Fields
			private int __1__state; // 0x10
			private string __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public JsonNode __4__this; // 0x28
			public JsonNode __3____4__this; // 0x38
			private bool value; // 0x48
			public bool __3__value; // 0x49
			private string indent; // 0x50
			public string __3__indent; // 0x58
			private int level; // 0x60
			public int __3__level; // 0x64
			private bool _isFirst_5__2; // 0x68
			private int _childLevel_5__3; // 0x6C
			private int _i_5__4; // 0x70
			private IEnumerator<JsonNode> __7__wrap4; // 0x78
			private JsonNode _x_5__6; // 0x80
			private IEnumerator<string> __7__wrap6; // 0x90
			private IEnumerator<KeyValuePair<JsonNode, JsonNode>> __7__wrap7; // 0x98
			private KeyValuePair<JsonNode, JsonNode> _kv_5__9; // 0xA0
	
			// Properties
			string IEnumerator<System.String>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ToString_d__3(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180D566E0-0x0000000180D567E0
			private bool MoveNext(); // 0x0000000180D55C10-0x0000000180D565F0
			private void __m__Finally1(); // 0x0000000180D567E0-0x0000000180D56830
			private void __m__Finally2(); // 0x0000000180D56830-0x0000000180D56890
			private void __m__Finally3(); // 0x0000000180D56890-0x0000000180D568F0
			private void __m__Finally4(); // 0x0000000180D568F0-0x0000000180D56950
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D566A0-0x0000000180D566E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x0000000180D565F0-0x0000000180D566A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D565F0-0x0000000180D566A0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Diff_d__5 : IEnumerable<JsonDiff>, IEnumerator<JsonDiff> // TypeDefIndex: 5612
		{
			// Fields
			private int __1__state; // 0x10
			private JsonDiff __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public JsonNode __4__this; // 0x40
			public JsonNode __3____4__this; // 0x50
			private JsonNode rhs; // 0x60
			public JsonNode __3__rhs; // 0x70
			private Dictionary<JsonNode, JsonNode> _r_5__2; // 0x80
			private Dictionary<JsonNode, JsonNode> __7__wrap2; // 0x88
			private IEnumerator<JsonDiff> __7__wrap3; // 0xC0
			private IEnumerator<JsonNode> _ll_5__5; // 0xC8
			private IEnumerator<JsonNode> _rr_5__6; // 0xD0
	
			// Properties
			JsonDiff IEnumerator<UniJSON.JsonDiff>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054BFE0-0x000000018054C000 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D52660-0x0000000180D526B0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Diff_d__5(int __1__state); // 0x000000018054C170-0x000000018054C1A0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180D526B0-0x0000000180D527F0
			private bool MoveNext(); // 0x0000000180D51530-0x0000000180D52580
			private void __m__Finally1(); // 0x0000000180D527F0-0x0000000180D52840
			private void __m__Finally2(); // 0x0000000180D52840-0x0000000180D528A0
			private void __m__Finally3(); // 0x0000000180D528A0-0x0000000180D528F0
			private void __m__Finally4(); // 0x0000000180D528F0-0x0000000180D52950
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D52620-0x0000000180D52660
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<JsonDiff> IEnumerable<JsonDiff>.GetEnumerator(); // 0x0000000180D52580-0x0000000180D52620
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D52580-0x0000000180D52620
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _get_Children_d__20 : IEnumerable<JsonNode>, IEnumerator<JsonNode> // TypeDefIndex: 5613
		{
			// Fields
			private int __1__state; // 0x10
			private JsonNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			public JsonNode __4__this; // 0x30
			public JsonNode __3____4__this; // 0x40
			private int _count_5__2; // 0x50
			private int _i_5__3; // 0x54
	
			// Properties
			JsonNode IEnumerator<UniJSON.JsonNode>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D5B910-0x0000000180D5B960 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _get_Children_d__20(int __1__state); // 0x00000001806E1690-0x00000001806E16C0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180D5B6D0-0x0000000180D5B830
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D5B8D0-0x0000000180D5B910
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator(); // 0x0000000180D5B830-0x0000000180D5B8D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D5B830-0x0000000180D5B8D0
		}
	
		// Constructors
		public JsonNode(List<JsonValue> values, int index = 0 /* Metadata: 0x003A190B */); // 0x0000000180D27EC0-0x0000000180D27ED0
	
		// Methods
		public override int GetHashCode(); // 0x0000000180D27890-0x0000000180D278F0
		public override bool Equals(object obj); // 0x0000000180D27100-0x0000000180D27890
		public override string ToString(); // 0x0000000180D27C50-0x0000000180D27E20
		[IteratorStateMachine] // 0x0000000180026B80-0x0000000180026BD0
		private IEnumerable<string> ToString(string indent, int level, bool value = false /* Metadata: 0x003A190A */); // 0x0000000180D27E20-0x0000000180D27EC0
		public string ToString(string indent); // 0x0000000180D27BD0-0x0000000180D27C50
		[IteratorStateMachine] // 0x0000000180026BD0-0x0000000180026C20
		public IEnumerable<JsonDiff> Diff(JsonNode rhs, JsonPointer path = default); // 0x0000000180D27080-0x0000000180D27100
		public void SetValue(JsonValue value); // 0x0000000180D27B50-0x0000000180D27BD0
		public JsonNode AddKey(Utf8String key); // 0x0000000180D26E20-0x0000000180D26EC0
		public JsonNode AddValue(ArraySegment<byte> bytes, ValueNodeType valueType); // 0x0000000180D26EC0-0x0000000180D26F70
		public JsonNode AddValue(JsonValue value); // 0x0000000180D26F70-0x0000000180D27080
		private void IncrementChildCount(); // 0x0000000180D278F0-0x0000000180D27A10
		public void SetValueBytesCount(int count); // 0x0000000180D27A10-0x0000000180D27B50
	}
}
