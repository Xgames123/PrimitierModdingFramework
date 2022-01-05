/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal static class CollectionUtils // TypeDefIndex: 6983
	{
		// Methods
		public static bool IsNullOrEmpty<T>(ICollection<T> collection);
		public static bool IsDictionaryType(System.Type type); // 0x0000000180383D50-0x0000000180383E90
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType); // 0x0000000180383F60-0x0000000180384090
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType); // 0x0000000180384090-0x00000001803842F0
		private static IList<int> GetDimensions(IList values, int dimensionsCount); // 0x00000001803839C0-0x0000000180383D50
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices); // 0x0000000180383760-0x00000001803839C0
		private static object JaggedArrayGetValue(IList values, int[] indices); // 0x0000000180383E90-0x0000000180383F60
		public static Array ToMultidimensionalArray(IList values, System.Type type, int rank); // 0x00000001803842F0-0x00000001803844D0
	
		// Extension methods
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection);
		public static void AddRange<T>(this IList<T> initial, IEnumerable collection);
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate);
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer);
		public static int IndexOfReference<T>(this List<T> list, T item);
	}
}
