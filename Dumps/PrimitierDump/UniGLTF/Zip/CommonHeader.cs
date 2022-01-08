/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF.Zip
{
	internal abstract class CommonHeader // TypeDefIndex: 5915
	{
		// Fields
		public Encoding Encoding; // 0x10
		public byte[] Bytes; // 0x18
		public int Offset; // 0x20
		public ushort VersionNeededToExtract; // 0x24
		public ushort GeneralPurposeBitFlag; // 0x26
		public CompressionMethod CompressionMethod; // 0x28
		public ushort FileLastModificationTime; // 0x2A
		public ushort FileLastModificationDate; // 0x2C
		public int CRC32; // 0x30
		public int CompressedSize; // 0x34
		public int UncompressedSize; // 0x38
		public ushort FileNameLength; // 0x3C
		public ushort ExtraFieldLength; // 0x3E
	
		// Properties
		public abstract int Signature { get; }
		public abstract int FixedFieldLength { get; }
		public abstract int Length { get; }
		public string FileName { get; } // 0x00000001810B3720-0x00000001810B37A0 
		public ArraySegment<byte> ExtraField { get; } // 0x00000001810B3680-0x00000001810B3720 
	
		// Constructors
		protected CommonHeader(byte[] bytes, int offset); // 0x00000001810B3300-0x00000001810B3680
	
		// Methods
		public override string ToString(); // 0x00000001810B30A0-0x00000001810B3300
		public abstract void ReadBefore(BinaryReader r);
		public void Read(BinaryReader r); // 0x00000001810B2F90-0x00000001810B30A0
		public abstract void ReadAfter(BinaryReader r);
	}
}
