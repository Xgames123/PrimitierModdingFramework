/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public class BytesStore : IStore // TypeDefIndex: 5591
	{
		// Fields
		private byte[] m_buffer; // 0x10
		private int m_pos; // 0x18
		private char[] m_c; // 0x20
	
		// Properties
		public ArraySegment<byte> Bytes { get; } // 0x00000001810B2A10-0x00000001810B2A80 
	
		// Constructors
		public BytesStore(); // 0x00000001810B2890-0x00000001810B2920
		public BytesStore(int size); // 0x00000001810B2920-0x00000001810B29B0
		public BytesStore(byte[] buffer); // 0x00000001810B29B0-0x00000001810B2A10
	
		// Methods
		private void Require(int size); // 0x00000001810B0960-0x00000001810B0A80
		public void Clear(); // 0x00000001804FCA40-0x00000001804FCA50
		public void Write(char c); // 0x00000001810B2570-0x00000001810B2660
		public void Write(string src); // 0x00000001810B2660-0x00000001810B2750
		public void Write(ArraySegment<byte> bytes); // 0x00000001810B2800-0x00000001810B2890
		public void Write(sbyte value); // 0x00000001810B24C0-0x00000001810B2570
		public void Write(byte value); // 0x00000001810B2750-0x00000001810B2800
		public void WriteLittleEndian(short value); // 0x00000001810B1920-0x00000001810B1A20
		public void WriteLittleEndian(int value); // 0x00000001810B17D0-0x00000001810B1920
		public void WriteLittleEndian(long value); // 0x00000001810B2270-0x00000001810B24C0
		public void WriteLittleEndian(ushort value); // 0x00000001810B1DC0-0x00000001810B1EC0
		public void WriteLittleEndian(uint value); // 0x00000001810B1A20-0x00000001810B1B70
		public void WriteLittleEndian(ulong value); // 0x00000001810B1EC0-0x00000001810B2110
		public void WriteLittleEndian(float value); // 0x00000001810B2110-0x00000001810B2270
		public void WriteLittleEndian(double value); // 0x00000001810B1B70-0x00000001810B1DC0
		public void WriteBigEndian(short value); // 0x00000001810B0F40-0x00000001810B1040
		public void WriteBigEndian(int value); // 0x00000001810B1310-0x00000001810B1470
		public void WriteBigEndian(long value); // 0x00000001810B0A80-0x00000001810B0CE0
		public void WriteBigEndian(ushort value); // 0x00000001810B1470-0x00000001810B1570
		public void WriteBigEndian(uint value); // 0x00000001810B11B0-0x00000001810B1310
		public void WriteBigEndian(ulong value); // 0x00000001810B1570-0x00000001810B17D0
		public void WriteBigEndian(float value); // 0x00000001810B1040-0x00000001810B11B0
		public void WriteBigEndian(double value); // 0x00000001810B0CE0-0x00000001810B0F40
	}
}
