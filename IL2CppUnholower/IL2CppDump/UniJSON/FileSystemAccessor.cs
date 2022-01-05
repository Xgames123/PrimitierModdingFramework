/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public class FileSystemAccessor : IFileSystemAccessor // TypeDefIndex: 5585
	{
		// Fields
		private string m_path; // 0x10
		private string m_baseDir; // 0x18
	
		// Constructors
		public FileSystemAccessor(string path); // 0x00000001810B4430-0x00000001810B44C0
	
		// Methods
		public override string ToString(); // 0x00000001810B43A0-0x00000001810B4430
		public string ReadAllText(); // 0x00000001810B4370-0x00000001810B43A0
		public string ReadAllText(string relativePath); // 0x00000001810B42F0-0x00000001810B4370
		public IFileSystemAccessor Get(string relativePath); // 0x00000001810B41F0-0x00000001810B42F0
	}
}
