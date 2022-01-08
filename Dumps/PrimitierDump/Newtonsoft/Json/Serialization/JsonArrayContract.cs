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
	[Nullable] // 0x0000000180015050-0x0000000180015090
	[NullableContext] // 0x0000000180015050-0x0000000180015090
	public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 5447
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly System.Type _CollectionItemType_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly bool _IsMultidimensionalArray_k__BackingField; // 0xC8
		private readonly System.Type _genericCollectionDefinitionType; // 0xD0
		private System.Type _genericWrapperType; // 0xD8
		[Nullable] // 0x0000000180019650-0x00000001800196B0
		private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
		[Nullable] // 0x00000001800196B0-0x0000000180019710
		private Func<object> _genericTemporaryCollectionCreator; // 0xE8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly bool _IsArray_k__BackingField; // 0xF0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly bool _ShouldCreateWrapper_k__BackingField; // 0xF1
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _CanDeserialize_k__BackingField; // 0xF2
		private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
		[Nullable] // 0x0000000180019710-0x0000000180019770
		private ObjectConstructor<object> _parameterizedCreator; // 0x100
		[Nullable] // 0x0000000180019770-0x00000001800197D0
		private ObjectConstructor<object> _overrideCreator; // 0x108
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _HasParameterizedCreator_k__BackingField; // 0x110
	
		// Properties
		public System.Type CollectionItemType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268300-0x0000000180268310 
		public bool IsMultidimensionalArray { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180421080-0x0000000180421090 
		internal bool IsArray { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180287CE0-0x0000000180287CF0 
		internal bool ShouldCreateWrapper { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180421120-0x0000000180421130 
		internal bool CanDeserialize { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180421030-0x0000000180421040 0x0000000180421130-0x0000000180421140
		[Nullable] // 0x0000000180019830-0x0000000180019890
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x00000001804C5B20-0x00000001804C5C00 
		[Nullable] // 0x0000000180019890-0x00000001800198F0
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x0000000180377500-0x0000000180377510 0x0000000180421160-0x0000000180421170
		public bool HasParameterizedCreator { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421070-0x0000000180421080 0x0000000180421140-0x0000000180421150
		internal bool HasParameterizedCreatorInternal { get; } // 0x00000001804C5AA0-0x00000001804C5B20 
	
		// Constructors
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public JsonArrayContract(System.Type underlyingType); // 0x00000001804C4A60-0x00000001804C5AA0
	
		// Methods
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal IWrappedCollection CreateWrapper(object list); // 0x00000001804C44C0-0x00000001804C4970
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal IList CreateTemporaryCollection(); // 0x00000001804C4230-0x00000001804C44C0
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		private void StoreFSharpListCreatorIfNecessary(System.Type underlyingType); // 0x00000001804C4970-0x00000001804C4A60
	}
}
