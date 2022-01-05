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
	public struct Utf8Iterator : IEnumerator<byte> // TypeDefIndex: 5628
	{
		// Fields
		private byte[] m_bytes; // 0x00
		private int m_offset; // 0x08
		private int m_start; // 0x0C
		private int m_position; // 0x10
		private int m_end; // 0x14
		public const uint Mask1 = 1; // Metadata: 0x003A1913
		public const uint Mask2 = 3; // Metadata: 0x003A1917
		public const uint Mask3 = 7; // Metadata: 0x003A191B
		public const uint Mask4 = 15; // Metadata: 0x003A191F
		public const uint Mask5 = 31; // Metadata: 0x003A1923
		public const uint Mask6 = 63; // Metadata: 0x003A1927
		public const uint Mask7 = 127; // Metadata: 0x003A192B
		public const uint Mask11 = 2047; // Metadata: 0x003A192F
		public const uint Head1 = 128; // Metadata: 0x003A1933
		public const uint Head2 = 192; // Metadata: 0x003A1937
		public const uint Head3 = 224; // Metadata: 0x003A193B
		public const uint Head4 = 240; // Metadata: 0x003A193F
	
		// Properties
		public int BytePosition { get; } // 0x0000000180BC9FE0-0x0000000180BC9FF0 
		public int CurrentByteLength { get; } // 0x0000000180BCA200-0x0000000180BCA2C0 
		public byte Current { get; } // 0x0000000180BCA2C0-0x0000000180BCA300 
		object IEnumerator.Current { get; } // 0x0000000180BC9EF0-0x0000000180BC9F60 
		public byte Second { get; } // 0x0000000180BCA340-0x0000000180BCA380 
		public byte Third { get; } // 0x0000000180BCA380-0x0000000180BCA3C0 
		public byte Fourth { get; } // 0x0000000180BCA300-0x0000000180BCA340 
		public uint Unicode { get; } // 0x0000000180BCA3C0-0x0000000180BCA630 
		public char Char { get; } // 0x0000000180BC9FF0-0x0000000180BCA200 
	
		// Constructors
		public Utf8Iterator(ArraySegment<byte> range, int start = 0 /* Metadata: 0x003A190F */); // 0x0000000180BC9F60-0x0000000180BC9FE0
	
		// Methods
		public static int ByteLengthFromChar(char c); // 0x0000000180BC9E80-0x0000000180BC9EA0
		public void Dispose(); // 0x0000000180265310-0x0000000180265320
		public bool MoveNext(); // 0x0000000180BC9EA0-0x0000000180BC9EE0
		public void Reset(); // 0x0000000180BC9EE0-0x0000000180BC9EF0
	}
}
