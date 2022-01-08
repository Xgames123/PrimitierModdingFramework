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
	public static class ListTreeNodeExtensions // TypeDefIndex: 5617
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Traverse_d__20 : IEnumerable<JsonNode>, IEnumerator<JsonNode> // TypeDefIndex: 5616
		{
			// Fields
			private int __1__state; // 0x10
			private JsonNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			private JsonNode self; // 0x30
			public JsonNode __3__self; // 0x40
			private IEnumerator<JsonNode> __7__wrap1; // 0x50
			private IEnumerator<JsonNode> __7__wrap2; // 0x58
			private IEnumerator<KeyValuePair<JsonNode, JsonNode>> __7__wrap3; // 0x60
	
			// Properties
			JsonNode IEnumerator<UniJSON.JsonNode>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E3B80-0x00000001806E3BD0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Traverse_d__20(int __1__state); // 0x00000001806E1690-0x00000001806E16C0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806E3BD0-0x00000001806E3CC0
			private bool MoveNext(); // 0x00000001806E35C0-0x00000001806E39C0
			private void __m__Finally1(); // 0x00000001806E3DB0-0x00000001806E3E00
			private void __m__Finally2(); // 0x00000001806E3EB0-0x00000001806E3F00
			private void __m__Finally3(); // 0x00000001806E3F00-0x00000001806E3F50
			private void __m__Finally4(); // 0x00000001806E3F50-0x00000001806E3FA0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E3B40-0x00000001806E3B80
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator(); // 0x00000001806E39C0-0x00000001806E3A60
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E39C0-0x00000001806E3A60
		}
	
		// Extension methods
		public static bool IsNull(this JsonNode self); // 0x0000000180BB44C0-0x0000000180BB44F0
		public static bool IsBoolean(this JsonNode self); // 0x0000000180BB43B0-0x0000000180BB43E0
		public static bool IsString(this JsonNode self); // 0x0000000180BB44F0-0x0000000180BB4520
		public static bool IsInteger(this JsonNode self); // 0x0000000180BB4460-0x0000000180BB4490
		public static bool IsFloat(this JsonNode self); // 0x0000000180BB43E0-0x0000000180BB4460
		public static bool IsArray(this JsonNode self); // 0x0000000180BB4380-0x0000000180BB43B0
		public static bool IsMap(this JsonNode self); // 0x0000000180BB4490-0x0000000180BB44C0
		public static bool GetBoolean(this JsonNode self); // 0x0000000180BB3F40-0x0000000180BB3F90
		public static string GetString(this JsonNode self); // 0x0000000180BB4230-0x0000000180BB4270
		public static Utf8String GetUtf8String(this JsonNode self); // 0x0000000180BB4330-0x0000000180BB4380
		public static sbyte GetSByte(this JsonNode self); // 0x0000000180BB4160-0x0000000180BB41A0
		public static short GetInt16(this JsonNode self); // 0x0000000180BB40A0-0x0000000180BB40E0
		public static int GetInt32(this JsonNode self); // 0x0000000180BB40E0-0x0000000180BB4120
		public static long GetInt64(this JsonNode self); // 0x0000000180BB4120-0x0000000180BB4160
		public static byte GetByte(this JsonNode self); // 0x0000000180BB3F90-0x0000000180BB3FD0
		public static ushort GetUInt16(this JsonNode self); // 0x0000000180BB4270-0x0000000180BB42B0
		public static uint GetUInt32(this JsonNode self); // 0x0000000180BB42B0-0x0000000180BB42F0
		public static ulong GetUInt64(this JsonNode self); // 0x0000000180BB42F0-0x0000000180BB4330
		public static float GetSingle(this JsonNode self); // 0x0000000180BB41A0-0x0000000180BB4230
		public static double GetDouble(this JsonNode self); // 0x0000000180BB3FD0-0x0000000180BB40A0
		[IteratorStateMachine] // 0x0000000180026CB0-0x0000000180026D10
		public static IEnumerable<JsonNode> Traverse(this JsonNode self); // 0x0000000180BB4520-0x0000000180BB4590
	}
}
