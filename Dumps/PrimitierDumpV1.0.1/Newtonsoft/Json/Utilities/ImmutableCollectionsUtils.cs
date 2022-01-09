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
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal static class ImmutableCollectionsUtils // TypeDefIndex: 5387
	{
		// Fields
		private static readonly IList<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x00
		private static readonly IList<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x08
	
		// Nested types
		[Nullable] // 0x0000000180015680-0x00000001800156A0
		internal class ImmutableCollectionTypeInfo // TypeDefIndex: 5383
		{
			// Fields
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private string _ContractTypeName_k__BackingField; // 0x10
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private string _CreatedTypeName_k__BackingField; // 0x18
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private string _BuilderTypeName_k__BackingField; // 0x20
	
			// Properties
			public string ContractTypeName { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
			public string CreatedTypeName { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
			public string BuilderTypeName { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
	
			// Constructors
			public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName); // 0x000000018078F020-0x000000018078F070
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 5384
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _TryBuildImmutableForArrayContract_b__0(ImmutableCollectionTypeInfo d); // 0x000000018029E390-0x000000018029E3C0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5385
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static readonly __c __9; // 0x00
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<MethodInfo, bool> __9__24_1; // 0x08
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<MethodInfo, bool> __9__25_1; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180797970-0x00000001807979D0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _TryBuildImmutableForArrayContract_b__24_1(MethodInfo m); // 0x00000001807961B0-0x0000000180796240
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _TryBuildImmutableForDictionaryContract_b__25_1(MethodInfo m); // 0x0000000180796240-0x00000001807963E0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 5386
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _TryBuildImmutableForDictionaryContract_b__0(ImmutableCollectionTypeInfo d); // 0x000000018029E390-0x000000018029E3C0
		}
	
		// Constructors
		static ImmutableCollectionsUtils(); // 0x00000001804AAD70-0x00000001804AB2A0
	
		// Methods
		internal static bool TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, [Nullable] /* 0x0000000180015560-0x00000001800155A0 */ [NotNullWhen] /* 0x0000000180015560-0x00000001800155A0 */ out System.Type createdType, [Nullable] /* 0x00000001800183B0-0x0000000180018420 */ [NotNullWhen] /* 0x00000001800183B0-0x0000000180018420 */ out ObjectConstructor<object> parameterizedCreator); // 0x00000001804AA390-0x00000001804AA850
		internal static bool TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, [Nullable] /* 0x0000000180015560-0x00000001800155A0 */ [NotNullWhen] /* 0x0000000180015560-0x00000001800155A0 */ out System.Type createdType, [NotNullWhen] /* 0x0000000180018420-0x0000000180018490 */ [Nullable] /* 0x0000000180018420-0x0000000180018490 */ out ObjectConstructor<object> parameterizedCreator); // 0x00000001804AA850-0x00000001804AAD70
	}
}
