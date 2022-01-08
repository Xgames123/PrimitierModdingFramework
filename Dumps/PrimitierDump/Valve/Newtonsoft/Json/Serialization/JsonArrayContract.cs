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
	public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 7056
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private System.Type _CollectionItemType_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _IsMultidimensionalArray_k__BackingField; // 0xC8
		private readonly System.Type _genericCollectionDefinitionType; // 0xD0
		private System.Type _genericWrapperType; // 0xD8
		private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
		private Func<object> _genericTemporaryCollectionCreator; // 0xE8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _IsArray_k__BackingField; // 0xF0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _ShouldCreateWrapper_k__BackingField; // 0xF1
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _CanDeserialize_k__BackingField; // 0xF2
		private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
		private ObjectConstructor<object> _parameterizedCreator; // 0x100
		private ObjectConstructor<object> _overrideCreator; // 0x108
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _HasParameterizedCreator_k__BackingField; // 0x110
	
		// Properties
		public System.Type CollectionItemType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268300-0x0000000180268310 0x0000000180268380-0x0000000180268390
		public bool IsMultidimensionalArray { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180421080-0x0000000180421090 0x0000000180421150-0x0000000180421160
		internal bool IsArray { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180287CE0-0x0000000180287CF0 0x0000000180313A20-0x0000000180313A30
		internal bool ShouldCreateWrapper { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180421120-0x0000000180421130 0x0000000180421170-0x0000000180421180
		internal bool CanDeserialize { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180421030-0x0000000180421040 0x0000000180421130-0x0000000180421140
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x0000000180421090-0x0000000180421120 
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x0000000180377500-0x0000000180377510 0x0000000180421160-0x0000000180421170
		public bool HasParameterizedCreator { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421070-0x0000000180421080 0x0000000180421140-0x0000000180421150
		internal bool HasParameterizedCreatorInternal { get; } // 0x0000000180421040-0x0000000180421070 
	
		// Constructors
		public JsonArrayContract(System.Type underlyingType); // 0x0000000180420560-0x0000000180421030
	
		// Methods
		internal IWrappedCollection CreateWrapper(object list); // 0x00000001804200C0-0x0000000180420560
		internal IList CreateTemporaryCollection(); // 0x000000018041FE60-0x00000001804200C0
	}
}
