/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class BytesReader // TypeDefIndex: 5798
	{
		// Fields
		private byte[] m_bytes; // 0x10
		private int m_pos; // 0x18
	
		// Constructors
		public BytesReader(byte[] bytes, int pos = 0 /* Metadata: 0x003A1B30 */); // 0x0000000180795350-0x0000000180795390
	
		// Methods
		public string ReadString(int count, Encoding encoding); // 0x00000001810B0890-0x00000001810B08E0
		public float ReadSingle(); // 0x00000001810B0810-0x00000001810B0890
		public byte ReadUInt8(); // 0x00000001810B07C0-0x00000001810B0810
		public ushort ReadUInt16(); // 0x00000001810B08E0-0x00000001810B0960
		public sbyte ReadInt8(); // 0x00000001810B07C0-0x00000001810B0810
		public short ReadInt16(); // 0x00000001810B06C0-0x00000001810B0740
		public int ReadInt32(); // 0x00000001810B0740-0x00000001810B07C0
		public void ReadToArray<T>(T[] dst)
			where T : struct;
		public T ReadStruct<T>()
			where T : struct;
	}
}
