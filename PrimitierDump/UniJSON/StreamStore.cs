/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public class StreamStore : IStore // TypeDefIndex: 5594
	{
		// Fields
		private Stream m_s; // 0x10
		private BinaryWriter m_w; // 0x18
	
		// Properties
		public ArraySegment<byte> Bytes { get; } // 0x0000000180BC1AD0-0x0000000180BC1C00 
	
		// Constructors
		public StreamStore(Stream s); // 0x0000000180BC1A60-0x0000000180BC1AD0
	
		// Methods
		public void Clear(); // 0x0000000180BC1660-0x0000000180BC1690
		public void Write(sbyte value); // 0x0000000180BC1970-0x0000000180BC19A0
		public void Write(byte value); // 0x0000000180BC19A0-0x0000000180BC19D0
		public void Write(char c); // 0x0000000180BC19D0-0x0000000180BC1A00
		public void Write(string src); // 0x0000000180BC1A00-0x0000000180BC1A60
		public void Write(ArraySegment<byte> bytes); // 0x0000000180BC18F0-0x0000000180BC1970
		public void WriteBigEndian(int value); // 0x0000000180BC17D0-0x0000000180BC1810
		public void WriteBigEndian(float value); // 0x0000000180BC1690-0x0000000180BC16D0
		public void WriteBigEndian(double value); // 0x0000000180BC1710-0x0000000180BC1750
		public void WriteBigEndian(long value); // 0x0000000180BC1810-0x0000000180BC1850
		public void WriteBigEndian(short value); // 0x0000000180BC1850-0x0000000180BC1890
		public void WriteBigEndian(uint value); // 0x0000000180BC1790-0x0000000180BC17D0
		public void WriteBigEndian(ulong value); // 0x0000000180BC16D0-0x0000000180BC1710
		public void WriteBigEndian(ushort value); // 0x0000000180BC1750-0x0000000180BC1790
		public void WriteLittleEndian(long value); // 0x0000000180643AE0-0x0000000180643B10
		public void WriteLittleEndian(uint value); // 0x0000000180643780-0x00000001806437B0
		public void WriteLittleEndian(short value); // 0x00000001806437E0-0x0000000180643810
		public void WriteLittleEndian(ulong value); // 0x0000000180643A80-0x0000000180643AB0
		public void WriteLittleEndian(double value); // 0x0000000180643750-0x0000000180643780
		public void WriteLittleEndian(float value); // 0x0000000180BC18C0-0x0000000180BC18F0
		public void WriteLittleEndian(int value); // 0x00000001806438D0-0x0000000180643900
		public void WriteLittleEndian(ushort value); // 0x0000000180BC1890-0x0000000180BC18C0
	}
}
