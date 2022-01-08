/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public static class ByteUnion // TypeDefIndex: 5590
	{
		// Nested types
		public struct WordValue // TypeDefIndex: 5587
		{
			// Fields
			public short Signed; // 0x00
			public ushort Unsigned; // 0x00
			public byte Byte0; // 0x00
			public byte Byte1; // 0x01
	
			// Methods
			public WordValue HostToNetworkOrder(); // 0x0000000180D5B960-0x0000000180D5B9C0
			public static WordValue Create(short value); // 0x0000000180C06CB0-0x0000000180C06CC0
			public static WordValue Create(ushort value); // 0x0000000180C06CB0-0x0000000180C06CC0
		}
	
		public struct DWordValue // TypeDefIndex: 5588
		{
			// Fields
			public int Signed; // 0x00
			public uint Unsigned; // 0x00
			public float Float; // 0x00
			public byte Byte0; // 0x00
			public byte Byte1; // 0x01
			public byte Byte2; // 0x02
			public byte Byte3; // 0x03
	
			// Methods
			public DWordValue HostToNetworkOrder(); // 0x0000000180D50940-0x0000000180D509A0
			public static DWordValue Create(int value); // 0x0000000180639EF0-0x0000000180639F00
			public static DWordValue Create(uint value); // 0x0000000180639EF0-0x0000000180639F00
			public static DWordValue Create(float value); // 0x0000000180D50930-0x0000000180D50940
		}
	
		public struct QWordValue // TypeDefIndex: 5589
		{
			// Fields
			public long Signed; // 0x00
			public ulong Unsigned; // 0x00
			public double Float; // 0x00
			public byte Byte0; // 0x00
			public byte Byte1; // 0x01
			public byte Byte2; // 0x02
			public byte Byte3; // 0x03
			public byte Byte4; // 0x04
			public byte Byte5; // 0x05
			public byte Byte6; // 0x06
			public byte Byte7; // 0x07
	
			// Methods
			public QWordValue HostToNetworkOrder(); // 0x0000000180D50AD0-0x0000000180D50B80
			public static QWordValue Create(long value); // 0x00000001804009C0-0x00000001804009D0
			public static QWordValue Create(ulong value); // 0x00000001804009C0-0x00000001804009D0
			public static QWordValue Create(double value); // 0x00000001805C19D0-0x00000001805C19E0
		}
	}
}
