/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 7066
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Func<string, string> _DictionaryKeyResolver_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private System.Type _DictionaryKeyType_k__BackingField; // 0xC8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private System.Type _DictionaryValueType_k__BackingField; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonContract _KeyContract_k__BackingField; // 0xD8
		private readonly System.Type _genericCollectionDefinitionType; // 0xE0
		private System.Type _genericWrapperType; // 0xE8
		private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
		private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _ShouldCreateWrapper_k__BackingField; // 0x100
		private readonly ConstructorInfo _parameterizedConstructor; // 0x108
		private ObjectConstructor<object> _overrideCreator; // 0x110
		private ObjectConstructor<object> _parameterizedCreator; // 0x118
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _HasParameterizedCreator_k__BackingField; // 0x120
	
		// Properties
		public Func<string, string> DictionaryKeyResolver { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268300-0x0000000180268310 0x0000000180268380-0x0000000180268390
		public System.Type DictionaryKeyType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018031E0A0-0x000000018031E0B0 0x000000018031EC40-0x000000018031EC50
		public System.Type DictionaryValueType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018031EBF0-0x000000018031EC00 0x000000018031EC50-0x000000018031EC60
		internal JsonContract KeyContract { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018026A2F0-0x000000018026A300 0x000000018026A920-0x000000018026A930
		internal bool ShouldCreateWrapper { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180424130-0x0000000180424140 0x0000000180424150-0x0000000180424160
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x00000001804240A0-0x0000000180424130 
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x0000000180287BF0-0x0000000180287C00 0x000000018026AA30-0x000000018026AA40
		public bool HasParameterizedCreator { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180424090-0x00000001804240A0 0x0000000180424140-0x0000000180424150
		internal bool HasParameterizedCreatorInternal { get; } // 0x0000000180424060-0x0000000180424090 
	
		// Constructors
		public JsonDictionaryContract(System.Type underlyingType); // 0x0000000180423900-0x0000000180424060
	
		// Methods
		internal IWrappedDictionary CreateWrapper(object dictionary); // 0x00000001804235A0-0x0000000180423900
		internal IDictionary CreateTemporaryDictionary(); // 0x00000001804232C0-0x00000001804235A0
	}
}
