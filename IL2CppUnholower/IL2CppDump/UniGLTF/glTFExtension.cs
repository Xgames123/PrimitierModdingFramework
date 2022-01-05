/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UniJSON;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public abstract class glTFExtension // TypeDefIndex: 5714
	{
		// Fields
		private static Encoding Utf8; // 0x00
	
		// Constructors
		protected glTFExtension(); // 0x00000001802650F0-0x0000000180265100
		static glTFExtension(); // 0x0000000180D5D3B0-0x0000000180D5D420
	
		// Methods
		public virtual glTFExtensionImport Deserialize(); // 0x0000000180D5D330-0x0000000180D5D370
		public virtual void Serialize(JsonFormatter f); // 0x0000000180D5D370-0x0000000180D5D3B0
	}
}
