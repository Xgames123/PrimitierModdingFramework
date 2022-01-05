/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public static class IValueNodeObjectExtensions // TypeDefIndex: 5624
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ObjectItems_d__0 : IEnumerable<KeyValuePair<JsonNode, JsonNode>>, IEnumerator<KeyValuePair<JsonNode, JsonNode>> // TypeDefIndex: 5622
		{
			// Fields
			private int __1__state; // 0x10
			private KeyValuePair<JsonNode, JsonNode> __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			private JsonNode self; // 0x40
			public JsonNode __3__self; // 0x50
			private IEnumerator<JsonNode> _it_5__2; // 0x60
	
			// Properties
			KeyValuePair<JsonNode, JsonNode> IEnumerator<System.Collections.Generic.KeyValuePair<UniJSON.JsonNode,UniJSON.JsonNode>>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054BFE0-0x000000018054C000 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D55910-0x0000000180D55960 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ObjectItems_d__0(int __1__state); // 0x000000018054C170-0x000000018054C1A0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180D55620-0x0000000180D55830
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D558D0-0x0000000180D55910
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<KeyValuePair<JsonNode, JsonNode>> IEnumerable<KeyValuePair<JsonNode, JsonNode>>.GetEnumerator(); // 0x0000000180D55830-0x0000000180D558D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D55830-0x0000000180D558D0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 5623
		{
			// Fields
			public Utf8String key; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _ContainsKey_b__0(KeyValuePair<JsonNode, JsonNode> x); // 0x0000000180D57EA0-0x0000000180D57F60
		}
	
		// Extension methods
		[IteratorStateMachine] // 0x0000000180026DF0-0x0000000180026E50
		public static IEnumerable<KeyValuePair<JsonNode, JsonNode>> ObjectItems(this JsonNode self); // 0x0000000180D225D0-0x0000000180D22640
		public static int GetObjectCount(this JsonNode self); // 0x0000000180D21E00-0x0000000180D21F00
		public static string GetObjectValueOrDefault(this JsonNode self, string key, string defualtValue); // 0x0000000180D22270-0x0000000180D22340
		public static JsonNode GetObjectItem(this JsonNode self, string key); // 0x0000000180D21F00-0x0000000180D21FB0
		public static JsonNode GetObjectItem(this JsonNode self, Utf8String key); // 0x0000000180D21FB0-0x0000000180D22270
		public static bool ContainsKey(this JsonNode self, Utf8String key); // 0x0000000180D21CD0-0x0000000180D21E00
		public static bool ContainsKey(this JsonNode self, string key); // 0x0000000180D21B50-0x0000000180D21CD0
		public static bool TryGet(this JsonNode self, Utf8String key, out JsonNode found); // 0x0000000180D226E0-0x0000000180D22970
		public static bool TryGet(this JsonNode self, string key, out JsonNode found); // 0x0000000180D22640-0x0000000180D226E0
		public static Utf8String KeyOf(this JsonNode self, JsonNode node); // 0x0000000180D22340-0x0000000180D225D0
	}
}
