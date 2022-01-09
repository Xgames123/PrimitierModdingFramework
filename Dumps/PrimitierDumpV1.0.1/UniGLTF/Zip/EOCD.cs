/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF.Zip
{
	internal class EOCD // TypeDefIndex: 5914
	{
		// Fields
		public ushort NumberOfThisDisk; // 0x10
		public ushort DiskWhereCentralDirectoryStarts; // 0x12
		public ushort NumberOfCentralDirectoryRecordsOnThisDisk; // 0x14
		public ushort TotalNumberOfCentralDirectoryRecords; // 0x16
		public int SizeOfCentralDirectoryBytes; // 0x18
		public int OffsetOfStartOfCentralDirectory; // 0x1C
		public string Comment; // 0x20
	
		// Constructors
		public EOCD(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public override string ToString(); // 0x00000001810B4010-0x00000001810B40B0
		private static int FindEOCD(byte[] bytes); // 0x00000001810B3AB0-0x00000001810B3BC0
		public static EOCD Parse(byte[] bytes); // 0x00000001810B3BC0-0x00000001810B4010
	}
}
