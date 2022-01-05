/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class SimpleStorage : IStorage // TypeDefIndex: 5799
	{
		// Fields
		private ArraySegment<byte> m_bytes; // 0x10
	
		// Constructors
		public SimpleStorage(); // 0x0000000180BC1120-0x0000000180BC1150
		public SimpleStorage(ArraySegment<byte> bytes); // 0x0000000180BC1150-0x0000000180BC1180
	
		// Methods
		public ArraySegment<byte> Get(string url); // 0x00000001802D3F00-0x00000001802D3F10
		public string GetPath(string url); // 0x0000000180273F80-0x0000000180273F90
	}
}
