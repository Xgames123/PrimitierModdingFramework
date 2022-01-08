/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public static class ArraySegmentExtensions // TypeDefIndex: 5577
	{
		// Extension methods
		public static T[] ArrayOrCopy<T>(this ArraySegment<T> self);
		public static IEnumerable<T> ToEnumerable<T>(this ArraySegment<T> self);
		public static void Set<T>(this ArraySegment<T> self, int index, T value);
		public static T Get<T>(this ArraySegment<T> self, int index);
		public static ArraySegment<T> Advance<T>(this ArraySegment<T> self, int n);
		public static ArraySegment<T> Take<T>(this ArraySegment<T> self, int n);
		public static T[] TakeReversedArray<T>(this ArraySegment<T> self, int n);
		public static byte[] Concat(this byte[] lhs, ArraySegment<byte> rhs); // 0x00000001810AB640-0x00000001810AB760
		public static byte[] Concat(this ArraySegment<byte> lhs, ArraySegment<byte> rhs); // 0x00000001810AB760-0x00000001810AB840
	}
}
