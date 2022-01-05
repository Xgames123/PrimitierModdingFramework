/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public class ByteBuffer // TypeDefIndex: 5571
	{
		// Fields
		private byte[] m_buffer; // 0x10
		private int m_used; // 0x18
	
		// Properties
		public ArraySegment<byte> Bytes { get; } // 0x00000001810B0150-0x00000001810B01C0 
		public int Count { get; } // 0x0000000180268FB0-0x0000000180268FC0 
		public int Remain { get; } // 0x00000001810B01C0-0x00000001810B01E0 
	
		// Constructors
		public ByteBuffer(); // 0x00000001802650F0-0x0000000180265100
		public ByteBuffer(byte[] buffer); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		private void Ensure(int size); // 0x00000001810AFE10-0x00000001810AFEA0
		public void Push(byte b); // 0x00000001810AFF70-0x00000001810AFFD0
		public void Push(byte[] buffer); // 0x00000001810AFEA0-0x00000001810AFF70
		public void Push(ArraySegment<byte> buffer); // 0x00000001810AFFD0-0x00000001810B0060
		public void Unshift(int size); // 0x00000001810B0060-0x00000001810B0150
	}
}
