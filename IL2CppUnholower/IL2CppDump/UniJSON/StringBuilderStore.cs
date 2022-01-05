/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public class StringBuilderStore : IStore // TypeDefIndex: 5595
	{
		// Fields
		private StringBuilder m_sb; // 0x10
	
		// Properties
		public ArraySegment<byte> Bytes { get; } // 0x0000000180BC22E0-0x0000000180BC2390 
	
		// Constructors
		public StringBuilderStore(StringBuilder sb); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		public string Buffer(); // 0x00000001802D4AF0-0x00000001802D4B20
		public void Clear(); // 0x0000000180BC1C00-0x0000000180BC1C30
		public void Write(ArraySegment<byte> bytes); // 0x0000000180BC2200-0x0000000180BC22A0
		public void Write(byte value); // 0x0000000180BC22A0-0x0000000180BC22E0
		public void Write(sbyte value); // 0x0000000180BC21C0-0x0000000180BC2200
		public void Write(IEnumerable<char> src); // 0x0000000180BC2030-0x0000000180BC21C0
		public void Write(char c); // 0x00000001806EB1F0-0x00000001806EB210
		public void Write(string src); // 0x00000001802D4B50-0x00000001802D4B70
		public void WriteBigEndian(int value); // 0x0000000180BC1C30-0x0000000180BC1C70
		public void WriteBigEndian(float value); // 0x0000000180BC1DB0-0x0000000180BC1DF0
		public void WriteBigEndian(double value); // 0x0000000180BC1DF0-0x0000000180BC1E30
		public void WriteBigEndian(long value); // 0x0000000180BC1CF0-0x0000000180BC1D30
		public void WriteBigEndian(ulong value); // 0x0000000180BC1D70-0x0000000180BC1DB0
		public void WriteBigEndian(short value); // 0x0000000180BC1CB0-0x0000000180BC1CF0
		public void WriteBigEndian(uint value); // 0x0000000180BC1D30-0x0000000180BC1D70
		public void WriteBigEndian(ushort value); // 0x0000000180BC1C70-0x0000000180BC1CB0
		public void WriteLittleEndian(double value); // 0x0000000180BC1F70-0x0000000180BC1FB0
		public void WriteLittleEndian(short value); // 0x0000000180BC1EB0-0x0000000180BC1EF0
		public void WriteLittleEndian(int value); // 0x0000000180BC1FB0-0x0000000180BC1FF0
		public void WriteLittleEndian(float value); // 0x0000000180BC1EF0-0x0000000180BC1F30
		public void WriteLittleEndian(long value); // 0x0000000180BC1E70-0x0000000180BC1EB0
		public void WriteLittleEndian(ulong value); // 0x0000000180BC1E30-0x0000000180BC1E70
		public void WriteLittleEndian(uint value); // 0x0000000180BC1F30-0x0000000180BC1F70
		public void WriteLittleEndian(ushort value); // 0x0000000180BC1FF0-0x0000000180BC2030
	}
}
