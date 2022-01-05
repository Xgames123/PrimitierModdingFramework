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
	public static class ListTreeNodeJsonPointerExtensions // TypeDefIndex: 5621
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Path_d__3 : IEnumerable<JsonNode>, IEnumerator<JsonNode> // TypeDefIndex: 5618
		{
			// Fields
			private int __1__state; // 0x10
			private JsonNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			private JsonNode self; // 0x30
			public JsonNode __3__self; // 0x40
			private IEnumerator<JsonNode> __7__wrap1; // 0x50
	
			// Properties
			JsonNode IEnumerator<UniJSON.JsonNode>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E2100-0x00000001806E2150 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Path_d__3(int __1__state); // 0x00000001806E1690-0x00000001806E16C0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806E2150-0x00000001806E21E0
			private bool MoveNext(); // 0x00000001806E1E40-0x00000001806E2020
			private void __m__Finally1(); // 0x00000001806E21E0-0x00000001806E2230
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E20C0-0x00000001806E2100
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator(); // 0x00000001806E2020-0x00000001806E20C0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E2020-0x00000001806E20C0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 5619
		{
			// Fields
			public JsonPointer jsonPointer; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetNodes_b__0(KeyValuePair<JsonNode, JsonNode> x); // 0x00000001806E64E0-0x00000001806E65B0
			internal bool _GetNodes_b__1(KeyValuePair<JsonNode, JsonNode> x); // 0x00000001806E65B0-0x00000001806E6680
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetNodes_d__4 : IEnumerable<JsonNode>, IEnumerator<JsonNode> // TypeDefIndex: 5620
		{
			// Fields
			private int __1__state; // 0x10
			private JsonNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			private JsonPointer jsonPointer; // 0x30
			public JsonPointer __3__jsonPointer; // 0x40
			private JsonNode self; // 0x50
			public JsonNode __3__self; // 0x60
			private __c__DisplayClass4_0 __8__1; // 0x70
			private IEnumerator<JsonNode> __7__wrap1; // 0x78
			private IEnumerator<JsonNode> __7__wrap2; // 0x80
			private IEnumerator<KeyValuePair<JsonNode, JsonNode>> __7__wrap3; // 0x88
	
			// Properties
			JsonNode IEnumerator<UniJSON.JsonNode>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E12E0-0x00000001806E1330 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetNodes_d__4(int __1__state); // 0x00000001806E1690-0x00000001806E16C0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806E1330-0x00000001806E1490
			private bool MoveNext(); // 0x00000001806E0770-0x00000001806E1200
			private void __m__Finally1(); // 0x00000001806E1490-0x00000001806E14E0
			private void __m__Finally2(); // 0x00000001806E14E0-0x00000001806E1540
			private void __m__Finally3(); // 0x00000001806E1540-0x00000001806E1590
			private void __m__Finally4(); // 0x00000001806E1590-0x00000001806E15F0
			private void __m__Finally5(); // 0x00000001806E15F0-0x00000001806E1640
			private void __m__Finally6(); // 0x00000001806E1640-0x00000001806E1690
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E12A0-0x00000001806E12E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator(); // 0x00000001806E1200-0x00000001806E12A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E1200-0x00000001806E12A0
		}
	
		// Extension methods
		public static void SetValue(this JsonNode self, Utf8String jsonPointer, ArraySegment<byte> bytes); // 0x0000000180BB4A80-0x0000000180BB4D00
		public static void RemoveValue(this JsonNode self, Utf8String jsonPointer); // 0x0000000180BB4760-0x0000000180BB4A80
		public static JsonPointer Pointer(this JsonNode self); // 0x0000000180BB4720-0x0000000180BB4760
		[IteratorStateMachine] // 0x0000000180026D10-0x0000000180026D80
		public static IEnumerable<JsonNode> Path(this JsonNode self); // 0x0000000180BB46B0-0x0000000180BB4720
		[IteratorStateMachine] // 0x0000000180026D80-0x0000000180026DF0
		public static IEnumerable<JsonNode> GetNodes(this JsonNode self, JsonPointer jsonPointer); // 0x0000000180BB4590-0x0000000180BB4610
		public static IEnumerable<JsonNode> GetNodes(this JsonNode self, Utf8String jsonPointer); // 0x0000000180BB4610-0x0000000180BB46B0
	}
}
