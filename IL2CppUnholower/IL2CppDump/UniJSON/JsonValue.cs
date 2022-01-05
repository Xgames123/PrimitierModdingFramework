/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public struct JsonValue // TypeDefIndex: 5609
	{
		// Fields
		public Utf8String Segment; // 0x00
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ValueNodeType _ValueType_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private int _ParentIndex_k__BackingField; // 0x14
		private int _childCount; // 0x18
		private static Utf8String s_true; // 0x00
		private static Utf8String s_false; // 0x10
	
		// Properties
		public ArraySegment<byte> Bytes { get; } // 0x0000000180461ED0-0x0000000180461EE0 
		public ValueNodeType ValueType { [IsReadOnly] /* 0x0000000180016550-0x0000000180016580 */ [CompilerGenerated] /* 0x0000000180016550-0x0000000180016580 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180260E80-0x0000000180260F00 0x00000001802A2B90-0x00000001802A2BA0
		public int ParentIndex { [IsReadOnly] /* 0x0000000180016550-0x0000000180016580 */ [CompilerGenerated] /* 0x0000000180016550-0x0000000180016580 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802A6C70-0x00000001802A6C80 0x00000001802A6C80-0x00000001802A6C90
		public int ChildCount { get; } // 0x0000000180268FB0-0x0000000180268FC0 
	
		// Constructors
		public JsonValue(Utf8String segment, ValueNodeType valueType, int parentIndex); // 0x0000000180BB37D0-0x0000000180BB37F0
		static JsonValue(); // 0x0000000180BB3590-0x0000000180BB37D0
	
		// Methods
		public void SetBytesCount(int count); // 0x0000000180BB3490-0x0000000180BB3520
		public void SetChildCount(int count); // 0x00000001802AC1A0-0x00000001802AC1B0
		public JsonValue New(ArraySegment<byte> bytes, ValueNodeType valueType, int parentIndex); // 0x0000000180BB3470-0x0000000180BB3490
		public JsonValue Key(Utf8String key, int parentIndex); // 0x0000000180BB3410-0x0000000180BB3470
		public override string ToString(); // 0x0000000180BB3520-0x0000000180BB3590
		public bool GetBoolean(); // 0x0000000180BB2FB0-0x0000000180BB3180
		public sbyte GetSByte(); // 0x0000000180BB32B0-0x0000000180BB32D0
		public short GetInt16(); // 0x0000000180BB3250-0x0000000180BB3270
		public int GetInt32(); // 0x0000000180BB3270-0x0000000180BB3290
		public long GetInt64(); // 0x0000000180BB3290-0x0000000180BB32B0
		public byte GetByte(); // 0x0000000180BB3180-0x0000000180BB31A0
		public ushort GetUInt16(); // 0x0000000180BB3370-0x0000000180BB3390
		public uint GetUInt32(); // 0x0000000180BB3390-0x0000000180BB33B0
		public ulong GetUInt64(); // 0x0000000180BB33B0-0x0000000180BB33D0
		public float GetSingle(); // 0x0000000180BB32D0-0x0000000180BB3350
		public double GetDouble(); // 0x0000000180BB31A0-0x0000000180BB3250
		public string GetString(); // 0x0000000180BB3350-0x0000000180BB3370
		public Utf8String GetUtf8String(); // 0x0000000180BB33D0-0x0000000180BB3410
	}
}
