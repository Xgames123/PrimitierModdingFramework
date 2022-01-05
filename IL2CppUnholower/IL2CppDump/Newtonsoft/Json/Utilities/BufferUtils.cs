/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015720-0x0000000180015760
	[NullableContext] // 0x0000000180015720-0x0000000180015760
	internal static class BufferUtils // TypeDefIndex: 5388
	{
		// Methods
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public static char[] RentBuffer([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ IArrayPool<char> bufferPool, int minSize); // 0x00000001803C6250-0x00000001803C62D0
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer); // 0x00000001803C62D0-0x00000001803C6330
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer); // 0x00000001803C61B0-0x00000001803C6250
	}
}
