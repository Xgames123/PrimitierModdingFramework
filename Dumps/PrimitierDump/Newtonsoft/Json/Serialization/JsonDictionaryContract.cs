/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x0000000180015720-0x0000000180015760
	[NullableContext] // 0x0000000180015720-0x0000000180015760
	public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 5457
	{
		// Fields
		[CompilerGenerated] // 0x0000000180019C00-0x0000000180019C70
		[Nullable] // 0x0000000180019C00-0x0000000180019C70
		private Func<string, string> _DictionaryKeyResolver_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly System.Type _DictionaryKeyType_k__BackingField; // 0xC8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly System.Type _DictionaryValueType_k__BackingField; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonContract _KeyContract_k__BackingField; // 0xD8
		private readonly System.Type _genericCollectionDefinitionType; // 0xE0
		private System.Type _genericWrapperType; // 0xE8
		[Nullable] // 0x0000000180019C70-0x0000000180019CD0
		private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
		[Nullable] // 0x0000000180019CD0-0x0000000180019D30
		private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly bool _ShouldCreateWrapper_k__BackingField; // 0x100
		private readonly ConstructorInfo _parameterizedConstructor; // 0x108
		[Nullable] // 0x0000000180019D30-0x0000000180019D90
		private ObjectConstructor<object> _overrideCreator; // 0x110
		[Nullable] // 0x0000000180019D90-0x0000000180019DF0
		private ObjectConstructor<object> _parameterizedCreator; // 0x118
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _HasParameterizedCreator_k__BackingField; // 0x120
	
		// Properties
		[Nullable] // 0x0000000180019EB0-0x0000000180019F10
		public Func<string, string> DictionaryKeyResolver { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268300-0x0000000180268310 0x0000000180268380-0x0000000180268390
		public System.Type DictionaryKeyType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018031E0A0-0x000000018031E0B0 
		public System.Type DictionaryValueType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018031EBF0-0x000000018031EC00 
		internal JsonContract KeyContract { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018026A2F0-0x000000018026A300 0x000000018026A920-0x000000018026A930
		internal bool ShouldCreateWrapper { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180424130-0x0000000180424140 
		[Nullable] // 0x0000000180019F10-0x0000000180019F70
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x00000001804C8890-0x00000001804C8970 
		[Nullable] // 0x0000000180019F70-0x0000000180019FD0
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x0000000180287BF0-0x0000000180287C00 0x000000018026AA30-0x000000018026AA40
		public bool HasParameterizedCreator { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180424090-0x00000001804240A0 0x0000000180424140-0x0000000180424150
		internal bool HasParameterizedCreatorInternal { get; } // 0x00000001804C8810-0x00000001804C8890 
	
		// Constructors
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public JsonDictionaryContract(System.Type underlyingType); // 0x00000001804C7B70-0x00000001804C8810
	
		// Methods
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal IWrappedDictionary CreateWrapper(object dictionary); // 0x00000001804C7810-0x00000001804C7B70
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal IDictionary CreateTemporaryDictionary(); // 0x00000001804C7530-0x00000001804C7810
	}
}
