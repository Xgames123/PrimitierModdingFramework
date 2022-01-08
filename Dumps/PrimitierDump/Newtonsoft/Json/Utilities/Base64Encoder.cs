/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal class Base64Encoder // TypeDefIndex: 5347
	{
		// Fields
		private readonly char[] _charsLine; // 0x10
		private readonly TextWriter _writer; // 0x18
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private byte[] _leftOverBytes; // 0x20
		private int _leftOverBytesCount; // 0x28
	
		// Constructors
		public Base64Encoder(TextWriter writer); // 0x00000001803C45E0-0x00000001803C4660
	
		// Methods
		private void ValidateEncode(byte[] buffer, int index, int count); // 0x00000001803C4480-0x00000001803C45E0
		public void Encode(byte[] buffer, int index, int count); // 0x00000001803C3DE0-0x00000001803C41F0
		private void StoreLeftOverBytes(byte[] buffer, int index, ref int count); // 0x00000001803C4380-0x00000001803C4480
		private bool FulfillFromLeftover(byte[] buffer, int index, ref int count); // 0x00000001803C42C0-0x00000001803C4380
		public void Flush(); // 0x00000001803C41F0-0x00000001803C42C0
		private void WriteChars(char[] chars, int index, int count); // 0x0000000180381B10-0x0000000180381B40
	}
}
