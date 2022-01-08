/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x0000000180015720-0x0000000180015760
	[NullableContext] // 0x0000000180015720-0x0000000180015760
	public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 5462
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private MemberSerialization _MemberSerialization_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private MissingMemberHandling? _MissingMemberHandling_k__BackingField; // 0xC4
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Required? _ItemRequired_k__BackingField; // 0xCC
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private NullValueHandling? _ItemNullValueHandling_k__BackingField; // 0xD4
		[CompilerGenerated] // 0x000000018001A290-0x000000018001A2C0
		[Nullable] // 0x000000018001A290-0x000000018001A2C0
		private readonly JsonPropertyCollection _Properties_k__BackingField; // 0xE0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ExtensionDataSetter _ExtensionDataSetter_k__BackingField; // 0xE8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ExtensionDataGetter _ExtensionDataGetter_k__BackingField; // 0xF0
		[CompilerGenerated] // 0x000000018001A2C0-0x000000018001A330
		[Nullable] // 0x000000018001A2C0-0x000000018001A330
		private Func<string, string> _ExtensionDataNameResolver_k__BackingField; // 0xF8
		internal bool ExtensionDataIsJToken; // 0x100
		private bool? _hasRequiredOrDefaultValueProperties; // 0x101
		[Nullable] // 0x000000018001A330-0x000000018001BD60
		private ObjectConstructor<object> _overrideCreator; // 0x108
		[Nullable] // 0x0000000180014CF0-0x0000000180014D50
		private ObjectConstructor<object> _parameterizedCreator; // 0x110
		private JsonPropertyCollection _creatorParameters; // 0x118
		private System.Type _extensionDataValueType; // 0x120
	
		// Properties
		public MemberSerialization MemberSerialization { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180424C40-0x0000000180424C50 0x0000000180424D20-0x0000000180424D30
		public MissingMemberHandling? MissingMemberHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180424C30-0x0000000180424C40 0x0000000180424D10-0x0000000180424D20
		public Required? ItemRequired { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804C9A80-0x00000001804C9A90 0x00000001804C9B90-0x00000001804C9BA0
		public NullValueHandling? ItemNullValueHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804C9A70-0x00000001804C9A80 0x00000001804C9B80-0x00000001804C9B90
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public JsonPropertyCollection Properties { [NullableContext] /* 0x0000000180014D60-0x0000000180014D90 */ [CompilerGenerated] /* 0x0000000180014D60-0x0000000180014D90 */ get; } // 0x000000018026A6D0-0x000000018026A6E0 
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public JsonPropertyCollection CreatorParameters { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; } // 0x00000001804C96C0-0x00000001804C9740 
		[Nullable] // 0x0000000180014EF0-0x0000000180014F50
		public ObjectConstructor<object> OverrideCreator { get; set; } // 0x0000000180377500-0x0000000180377510 0x00000001804C9BA0-0x00000001804C9BB0
		[Nullable] // 0x0000000180014F50-0x0000000180014FB0
		internal ObjectConstructor<object> ParameterizedCreator { get; set; } // 0x0000000180287BF0-0x0000000180287C00 0x000000018026AA30-0x000000018026AA40
		public ExtensionDataSetter ExtensionDataSetter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802885C0-0x00000001802885D0 0x0000000180289D80-0x0000000180289D90
		public ExtensionDataGetter ExtensionDataGetter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802696B0-0x00000001802696C0 0x0000000180381630-0x0000000180381640
		public System.Type ExtensionDataValueType { set; } // 0x00000001804C9A90-0x00000001804C9B80
		[Nullable] // 0x0000000180014FB0-0x0000000180015010
		public Func<string, string> ExtensionDataNameResolver { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018026A2D0-0x000000018026A2E0 0x00000001803141A0-0x00000001803141B0
		internal bool HasRequiredOrDefaultValueProperties { get; } // 0x00000001804C9740-0x00000001804C9A70 
	
		// Constructors
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public JsonObjectContract(System.Type underlyingType); // 0x00000001804C9640-0x00000001804C96C0
	
		// Methods
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal object GetUninitializedObject(); // 0x00000001804C94F0-0x00000001804C9640
	}
}
