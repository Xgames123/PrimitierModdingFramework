/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF.Zip
{
	internal class LocalFileHeader : CommonHeader // TypeDefIndex: 5917
	{
		// Properties
		public override int FixedFieldLength { get; } // 0x000000018056A5D0-0x000000018056A5E0 
		public override int Signature { get; } // 0x0000000180BB4D40-0x0000000180BB4D50 
		public override int Length { get; } // 0x0000000180BB4D10-0x0000000180BB4D40 
	
		// Constructors
		public LocalFileHeader(byte[] bytes, int offset); // 0x0000000180BB4D00-0x0000000180BB4D10
	
		// Methods
		public override void ReadBefore(BinaryReader r); // 0x0000000180265310-0x0000000180265320
		public override void ReadAfter(BinaryReader r); // 0x0000000180265310-0x0000000180265320
	}
}
