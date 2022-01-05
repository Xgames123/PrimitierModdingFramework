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
	[Nullable] // 0x0000000180015050-0x0000000180015090
	[NullableContext] // 0x0000000180015050-0x0000000180015090
	public class JsonProperty // TypeDefIndex: 5464
	{
		// Fields
		internal Required? _required; // 0x10
		internal bool _hasExplicitDefaultValue; // 0x18
		private object _defaultValue; // 0x20
		private bool _hasGeneratedDefaultValue; // 0x28
		private string _propertyName; // 0x30
		internal bool _skipPropertyNameEscape; // 0x38
		private System.Type _propertyType; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonContract _PropertyContract_k__BackingField; // 0x48
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private System.Type _DeclaringType_k__BackingField; // 0x50
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private int? _Order_k__BackingField; // 0x58
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _UnderlyingName_k__BackingField; // 0x60
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private IValueProvider _ValueProvider_k__BackingField; // 0x68
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private IAttributeProvider _AttributeProvider_k__BackingField; // 0x70
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonConverter _Converter_k__BackingField; // 0x78
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Ignored_k__BackingField; // 0x80
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Readable_k__BackingField; // 0x81
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Writable_k__BackingField; // 0x82
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _HasMemberAttribute_k__BackingField; // 0x83
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool? _IsReference_k__BackingField; // 0x84
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private NullValueHandling? _NullValueHandling_k__BackingField; // 0x88
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private DefaultValueHandling? _DefaultValueHandling_k__BackingField; // 0x90
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ReferenceLoopHandling? _ReferenceLoopHandling_k__BackingField; // 0x98
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ObjectCreationHandling? _ObjectCreationHandling_k__BackingField; // 0xA0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private TypeNameHandling? _TypeNameHandling_k__BackingField; // 0xA8
		[CompilerGenerated] // 0x0000000180015090-0x0000000180015100
		[Nullable] // 0x0000000180015090-0x0000000180015100
		private Predicate<object> _ShouldSerialize_k__BackingField; // 0xB0
		[CompilerGenerated] // 0x0000000180015100-0x0000000180015170
		[Nullable] // 0x0000000180015100-0x0000000180015170
		private Predicate<object> _ShouldDeserialize_k__BackingField; // 0xB8
		[CompilerGenerated] // 0x0000000180015170-0x00000001800151E0
		[Nullable] // 0x0000000180015170-0x00000001800151E0
		private Predicate<object> _GetIsSpecified_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x00000001800151E0-0x0000000180015250
		[Nullable] // 0x00000001800151E0-0x0000000180015250
		private Action<object, object> _SetIsSpecified_k__BackingField; // 0xC8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonConverter _ItemConverter_k__BackingField; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool? _ItemIsReference_k__BackingField; // 0xD8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private TypeNameHandling? _ItemTypeNameHandling_k__BackingField; // 0xDC
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ReferenceLoopHandling? _ItemReferenceLoopHandling_k__BackingField; // 0xE4
	
		// Properties
		internal JsonContract PropertyContract { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
		public string PropertyName { get; set; } // 0x00000001802684F0-0x0000000180268500 0x0000000180501A20-0x0000000180501AB0
		public System.Type DeclaringType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802BC110-0x00000001802BC120 0x00000001803DFE50-0x00000001803DFE60
		public int? Order { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802BF820-0x00000001802BF890 0x00000001802C6D60-0x00000001802C6D70
		public string UnderlyingName { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C6D20-0x00000001802C6D30 0x000000018026C080-0x000000018026C090
		public IValueProvider ValueProvider { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C6D10-0x00000001802C6D20 0x00000001802C6D50-0x00000001802C6D60
		public IAttributeProvider AttributeProvider { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180422040-0x0000000180422050
		public System.Type PropertyType { get; set; } // 0x0000000180268310-0x0000000180268320 0x0000000180501AB0-0x0000000180501B30
		public JsonConverter Converter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C0E50-0x00000001802C0E60 0x00000001802C0E80-0x00000001802C0E90
		public bool Ignored { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180501930-0x0000000180501940 0x00000001805019E0-0x00000001805019F0
		public bool Readable { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180501970-0x0000000180501980 0x0000000180501B30-0x0000000180501B40
		public bool Writable { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001805019C0-0x00000001805019D0 0x0000000180501B40-0x0000000180501B50
		public bool HasMemberAttribute { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180501920-0x0000000180501930 0x00000001805019D0-0x00000001805019E0
		public object DefaultValue { get; set; } // 0x0000000180426390-0x00000001804263A0 0x0000000180426460-0x0000000180426470
		public Required Required { get; } // 0x0000000180501980-0x00000001805019C0 
		public bool? IsReference { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180501940-0x0000000180501950 0x00000001805019F0-0x0000000180501A00
		public NullValueHandling? NullValueHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AFA70-0x00000001802AFA80 0x00000001802C46E0-0x00000001802C46F0
		public DefaultValueHandling? DefaultValueHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AFA60-0x00000001802AFA70 0x00000001804264C0-0x00000001804264D0
		public ReferenceLoopHandling? ReferenceLoopHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AFA90-0x00000001802AFAA0 0x00000001802BF770-0x00000001802BF780
		public ObjectCreationHandling? ObjectCreationHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803FD790-0x00000001803FD7A0 0x0000000180421310-0x0000000180421320
		public TypeNameHandling? TypeNameHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802DC800-0x00000001802DC810 0x00000001804264D0-0x00000001804264E0
		[Nullable] // 0x0000000180015370-0x00000001800153D0
		public Predicate<object> ShouldSerialize { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180381510-0x0000000180381520 0x0000000180268370-0x0000000180268380
		[Nullable] // 0x00000001800153D0-0x0000000180015430
		public Predicate<object> ShouldDeserialize { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802DC810-0x00000001802DC820 
		[Nullable] // 0x0000000180015430-0x0000000180015490
		public Predicate<object> GetIsSpecified { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268300-0x0000000180268310 0x0000000180268380-0x0000000180268390
		[Nullable] // 0x0000000180015490-0x00000001800154F0
		public Action<object, object> SetIsSpecified { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018031E0A0-0x000000018031E0B0 0x000000018031EC40-0x000000018031EC50
		public JsonConverter ItemConverter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018031EBF0-0x000000018031EC00 0x000000018031EC50-0x000000018031EC60
		public bool? ItemIsReference { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180501950-0x0000000180501960 0x0000000180501A00-0x0000000180501A10
		public TypeNameHandling? ItemTypeNameHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180501960-0x0000000180501970 0x0000000180501A10-0x0000000180501A20
		public ReferenceLoopHandling? ItemReferenceLoopHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804263E0-0x00000001804263F0 0x00000001804264B0-0x00000001804264C0
	
		// Constructors
		public JsonProperty(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		internal object GetResolvedDefaultValue(); // 0x00000001805017B0-0x0000000180501880
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public override string ToString(); // 0x0000000180501880-0x00000001805018D0
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal void WritePropertyName(JsonWriter writer); // 0x00000001805018D0-0x0000000180501920
	}
}
