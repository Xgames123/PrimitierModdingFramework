/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class FileSystemStorage : IStorage // TypeDefIndex: 5800
	{
		// Fields
		private string m_root; // 0x10
	
		// Constructors
		public FileSystemStorage(string root); // 0x00000001810B46C0-0x00000001810B4730
	
		// Methods
		public ArraySegment<byte> Get(string url); // 0x00000001810B45C0-0x00000001810B46C0
		public string GetPath(string url); // 0x00000001810B44C0-0x00000001810B45C0
	}
}
