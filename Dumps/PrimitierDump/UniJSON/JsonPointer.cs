/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public struct JsonPointer // TypeDefIndex: 5605
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ArraySegment<Utf8String> _Path_k__BackingField; // 0x00
	
		// Properties
		public ArraySegment<Utf8String> Path { [CompilerGenerated] /* 0x0000000180016550-0x0000000180016580 */ [IsReadOnly] /* 0x0000000180016550-0x0000000180016580 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180461ED0-0x0000000180461EE0 0x0000000180461FC0-0x0000000180461FD0
		public int Count { get; } // 0x0000000180D2A8F0-0x0000000180D2A930 
		public Utf8String this[int index] { get => default; } // 0x0000000180D2A930-0x0000000180D2A9D0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5604
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<JsonNode, Utf8String> __9__9_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001806E6DF0-0x00000001806E6E50
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Utf8String _Create_b__9_0(JsonNode x); // 0x00000001806E45F0-0x00000001806E4630
		}
	
		// Constructors
		public JsonPointer(Utf8String pointer); // 0x0000000180D2A790-0x0000000180D2A8F0
	
		// Methods
		public JsonPointer Unshift(); // 0x0000000180D2A6E0-0x0000000180D2A790
		public static JsonPointer Create(JsonNode node); // 0x0000000180D2A260-0x0000000180D2A420
		public override string ToString(); // 0x0000000180D2A550-0x0000000180D2A6E0
		private static Utf8String GetKeyFromParent(JsonNode json); // 0x0000000180D2A420-0x0000000180D2A550
	}
}
