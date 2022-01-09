/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public static class FormatterExtensions // TypeDefIndex: 5583
	{
		// Methods
		private static MethodInfo GetMethod<T>(Expression<Func<T>> expression);
	
		// Extension methods
		public static ArraySegment<byte> GetStoreBytes(this IFormatter f); // 0x00000001810B4730-0x00000001810B4820
		public static void Key(this IFormatter f, string x); // 0x00000001810B4820-0x00000001810B4930
		public static void Value(this IFormatter f, IEnumerable<byte> raw, int count); // 0x00000001810B4B10-0x00000001810B4C60
		public static void Value(this IFormatter f, byte[] bytes); // 0x00000001810B4930-0x00000001810B4A30
		public static void Value(this IFormatter f, Vector2 v); // 0x00000001810B4A30-0x00000001810B4B10
		public static void Value(this IFormatter f, Vector3 v); // 0x00000001810B4C60-0x00000001810B4D90
		public static void Value(this IFormatter f, Vector4 v); // 0x00000001810B4D90-0x00000001810B4EE0
	}
}
