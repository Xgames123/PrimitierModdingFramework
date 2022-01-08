/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public sealed class CacheEnum // TypeDefIndex: 5909
	{
		// Nested types
		private static class CacheParse<T> // TypeDefIndex: 5907
			where T : struct, Enum
		{
			// Fields
			private static Dictionary<string, T> _values;
			private static Dictionary<string, T> _ignoreCaseValues;
	
			// Constructors
			static CacheParse();
	
			// Methods
			public static T ParseIgnoreCase(string name);
			public static T Parse(string name);
		}
	
		private static class CacheValues<T> // TypeDefIndex: 5908
			where T : struct, Enum
		{
			// Fields
			public static readonly T[] Values;
	
			// Constructors
			static CacheValues();
		}
	
		// Constructors
		public CacheEnum(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static T Parse<T>(string name, bool ignoreCase = false /* Metadata: 0x003A1C31 */)
			where T : struct, Enum;
		public static T TryParseOrDefault<T>(string name, bool ignoreCase = false /* Metadata: 0x003A1C32 */, T defaultValue = default)
			where T : struct, Enum;
		public static T[] GetValues<T>()
			where T : struct, Enum;
	}
}
