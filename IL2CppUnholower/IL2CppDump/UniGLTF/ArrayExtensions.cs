/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class ArrayExtensions // TypeDefIndex: 5693
	{
		// Methods
		public static void Copy<TFrom, TTo>(ArraySegment<TFrom> src, ArraySegment<TTo> dst)
			where TFrom : struct
			where TTo : struct;
	
		// Extension methods
		public static int MarshalCopyTo<T>(this ArraySegment<byte> src, T[] dst)
			where T : struct;
		public static T[] SelectInplace<T>(this T[] src, Func<T, T> pred);
	}
}
