/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public static class JsonParser // TypeDefIndex: 5603
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5602
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<byte, bool> __9__3_0; // 0x08
			public static Func<byte, bool> __9__3_1; // 0x10
			public static Func<byte, bool> __9__3_2; // 0x18
			public static Func<byte, bool> __9__4_1; // 0x20
			public static Func<byte, bool> __9__4_2; // 0x28
			public static Func<byte, bool> __9__4_3; // 0x30
			public static Func<byte, bool> __9__4_0; // 0x38
			public static Func<byte, bool> __9__4_4; // 0x40
			public static Func<byte, bool> __9__5_0; // 0x48
	
			// Constructors
			static __c(); // 0x00000001806E6AF0-0x00000001806E6B50
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _ParseArray_b__3_0(byte x); // 0x00000001806E5030-0x00000001806E5090
			internal bool _ParseArray_b__3_1(byte x); // 0x00000001806E5090-0x00000001806E50A0
			internal bool _ParseArray_b__3_2(byte x); // 0x00000001806E50A0-0x00000001806E5100
			internal bool _ParseObject_b__4_1(byte x); // 0x00000001806E5120-0x00000001806E5180
			internal bool _ParseObject_b__4_2(byte x); // 0x00000001806E5090-0x00000001806E50A0
			internal bool _ParseObject_b__4_3(byte x); // 0x00000001806E5180-0x00000001806E51E0
			internal bool _ParseObject_b__4_0(byte x); // 0x00000001806E5110-0x00000001806E5120
			internal bool _ParseObject_b__4_4(byte x); // 0x00000001806E51E0-0x00000001806E5240
			internal bool _Parse_b__5_0(byte x); // 0x00000001806E5240-0x00000001806E52A0
		}
	
		// Methods
		private static ValueNodeType GetValueType(Utf8String segment); // 0x0000000180D28520-0x0000000180D287E0
		private static JsonNode ParsePrimitive(JsonNode tree, Utf8String segment, ValueNodeType valueType); // 0x0000000180D297C0-0x0000000180D29970
		private static JsonNode ParseString(JsonNode tree, Utf8String segment); // 0x0000000180D29970-0x0000000180D29B00
		private static JsonNode ParseArray(JsonNode tree, Utf8String segment); // 0x0000000180D287E0-0x0000000180D28DD0
		private static JsonNode ParseObject(JsonNode tree, Utf8String segment); // 0x0000000180D28DD0-0x0000000180D297C0
		public static JsonNode Parse(JsonNode tree, Utf8String segment); // 0x0000000180D29B00-0x0000000180D2A160
		public static JsonNode Parse(string json); // 0x0000000180D2A1B0-0x0000000180D2A260
		public static JsonNode Parse(Utf8String json); // 0x0000000180D2A160-0x0000000180D2A1B0
	}
}
