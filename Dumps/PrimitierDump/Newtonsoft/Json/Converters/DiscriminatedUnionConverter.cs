/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class DiscriminatedUnionConverter : JsonConverter // TypeDefIndex: 5519
	{
		// Fields
		private static readonly ThreadSafeStore<System.Type, Union> UnionCache; // 0x00
		private static readonly ThreadSafeStore<System.Type, System.Type> UnionTypeLookupCache; // 0x08
	
		// Nested types
		[Nullable] // 0x0000000180015680-0x00000001800156A0
		internal class Union // TypeDefIndex: 5515
		{
			// Fields
			public readonly FSharpFunction TagReader; // 0x10
			public readonly List<UnionCase> Cases; // 0x18
	
			// Constructors
			public Union(FSharpFunction tagReader, List<UnionCase> cases); // 0x000000018028A110-0x000000018028A150
		}
	
		[Nullable] // 0x0000000180015680-0x00000001800156A0
		internal class UnionCase // TypeDefIndex: 5516
		{
			// Fields
			public readonly int Tag; // 0x10
			public readonly string Name; // 0x18
			public readonly PropertyInfo[] Fields; // 0x20
			public readonly FSharpFunction FieldReader; // 0x28
			public readonly FSharpFunction Constructor; // 0x30
	
			// Constructors
			public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor); // 0x0000000180797B50-0x0000000180797BB0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 5517
		{
			// Fields
			public int tag; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _WriteJson_b__0(UnionCase c); // 0x0000000180797860-0x0000000180797880
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 5518
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public string caseName; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public Func<UnionCase, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _ReadJson_b__0(UnionCase c); // 0x0000000180797880-0x00000001807978B0
		}
	
		// Constructors
		public DiscriminatedUnionConverter(); // 0x00000001802686E0-0x00000001802686F0
		static DiscriminatedUnionConverter(); // 0x00000001803DC070-0x00000001803DC1D0
	
		// Methods
		private static System.Type CreateUnionTypeLookup(System.Type t); // 0x00000001803DA910-0x00000001803DABA0
		private static Union CreateUnion(System.Type t); // 0x00000001803DABA0-0x00000001803DB270
		public override void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer); // 0x00000001803DBAF0-0x00000001803DC070
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer); // 0x00000001803DB270-0x00000001803DBAF0
		public override bool CanConvert(System.Type objectType); // 0x00000001803DA670-0x00000001803DA910
	}
}
