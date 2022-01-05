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
	internal class CentralDirectoryFileHeader : CommonHeader // TypeDefIndex: 5916
	{
		// Fields
		public ushort VersionMadeBy; // 0x40
		public ushort FileCommentLength; // 0x42
		public ushort DiskNumberWhereFileStarts; // 0x44
		public ushort InternalFileAttributes; // 0x46
		public int ExternalFileAttributes; // 0x48
		public int RelativeOffsetOfLocalFileHeader; // 0x4C
	
		// Properties
		public override int Signature { get; } // 0x00000001810B2BF0-0x00000001810B2C00 
		public override int FixedFieldLength { get; } // 0x000000018056C630-0x000000018056C640 
		public string FileComment { get; } // 0x00000001810B2B60-0x00000001810B2BB0 
		public override int Length { get; } // 0x00000001810B2BB0-0x00000001810B2BF0 
	
		// Constructors
		public CentralDirectoryFileHeader(byte[] bytes, int offset); // 0x0000000180BB4D00-0x0000000180BB4D10
	
		// Methods
		public override void ReadBefore(BinaryReader r); // 0x00000001810B2B20-0x00000001810B2B60
		public override void ReadAfter(BinaryReader r); // 0x00000001810B2A80-0x00000001810B2B20
	}
}
