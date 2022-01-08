/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal static class BufferUtils // TypeDefIndex: 7000
	{
		// Methods
		public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize); // 0x0000000180383680-0x0000000180383700
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer); // 0x0000000180383700-0x0000000180383760
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer); // 0x00000001803835E0-0x0000000180383680
	}
}
