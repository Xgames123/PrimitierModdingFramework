/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x00000001800175D0-0x0000000180017610
	[NullableContext] // 0x00000001800175D0-0x0000000180017610
	internal static class CollectionUtils // TypeDefIndex: 5350
	{
		// Nested types
		[NullableContext] // 0x0000000180015700-0x0000000180015720
		private static class EmptyArrayContainer<T> // TypeDefIndex: 5349
		{
			// Fields
			[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
			public static readonly T[] Empty;
	
			// Constructors
			static EmptyArrayContainer();
		}
	
		// Methods
		public static bool IsNullOrEmpty<T>(ICollection<T> collection);
		public static bool IsDictionaryType(System.Type type); // 0x00000001803C6900-0x00000001803C6AB0
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType); // 0x00000001803C6E50-0x00000001803C6F80
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType); // 0x00000001803C6B80-0x00000001803C6E50
		private static IList<int> GetDimensions(IList values, int dimensionsCount); // 0x00000001803C65A0-0x00000001803C6900
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices); // 0x00000001803C6340-0x00000001803C65A0
		private static object JaggedArrayGetValue(IList values, int[] indices); // 0x00000001803C6AB0-0x00000001803C6B80
		public static Array ToMultidimensionalArray(IList values, System.Type type, int rank); // 0x00000001803C6F80-0x00000001803C71E0
		public static T[] ArrayEmpty<T>();
	
		// Extension methods
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection);
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate);
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer);
		public static int IndexOfReference<T>(this List<T> list, T item);
		public static void FastReverse<T>(this List<T> list);
	}
}
