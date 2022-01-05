/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public class JsonProperty // TypeDefIndex: 7072
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
		private JsonConverter _MemberConverter_k__BackingField; // 0x80
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Ignored_k__BackingField; // 0x88
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Readable_k__BackingField; // 0x89
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Writable_k__BackingField; // 0x8A
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _HasMemberAttribute_k__BackingField; // 0x8B
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool? _IsReference_k__BackingField; // 0x8C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private NullValueHandling? _NullValueHandling_k__BackingField; // 0x90
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private DefaultValueHandling? _DefaultValueHandling_k__BackingField; // 0x98
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ReferenceLoopHandling? _ReferenceLoopHandling_k__BackingField; // 0xA0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ObjectCreationHandling? _ObjectCreationHandling_k__BackingField; // 0xA8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private TypeNameHandling? _TypeNameHandling_k__BackingField; // 0xB0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Predicate<object> _ShouldSerialize_k__BackingField; // 0xB8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Predicate<object> _ShouldDeserialize_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Predicate<object> _GetIsSpecified_k__BackingField; // 0xC8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Action<object, object> _SetIsSpecified_k__BackingField; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonConverter _ItemConverter_k__BackingField; // 0xD8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool? _ItemIsReference_k__BackingField; // 0xE0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private TypeNameHandling? _ItemTypeNameHandling_k__BackingField; // 0xE4
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ReferenceLoopHandling? _ItemReferenceLoopHandling_k__BackingField; // 0xEC
	
		// Properties
		internal JsonContract PropertyContract { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
		public string PropertyName { get; set; } // 0x00000001802684F0-0x0000000180268500 0x00000001804264E0-0x00000001804265C0
		public System.Type DeclaringType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802BC110-0x00000001802BC120 0x00000001803DFE50-0x00000001803DFE60
		public int? Order { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802BF820-0x00000001802BF890 0x00000001802C6D60-0x00000001802C6D70
		public string UnderlyingName { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C6D20-0x00000001802C6D30 0x000000018026C080-0x000000018026C090
		public IValueProvider ValueProvider { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C6D10-0x00000001802C6D20 0x00000001802C6D50-0x00000001802C6D60
		public IAttributeProvider AttributeProvider { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180422040-0x0000000180422050
		public System.Type PropertyType { get; set; } // 0x0000000180268310-0x0000000180268320 0x00000001804265C0-0x00000001804265D0
		public JsonConverter Converter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C0E50-0x00000001802C0E60 0x00000001802C0E80-0x00000001802C0E90
		public JsonConverter MemberConverter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C0E60-0x00000001802C0E70 0x00000001802C0E90-0x00000001802C0EA0
		public bool Ignored { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421DF0-0x0000000180421E00 0x00000001804220A0-0x00000001804220B0
		public bool Readable { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804263F0-0x0000000180426400 0x00000001804265D0-0x00000001804265E0
		public bool Writable { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180426450-0x0000000180426460 0x00000001804265E0-0x00000001804265F0
		public bool HasMemberAttribute { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804263A0-0x00000001804263B0 0x0000000180426470-0x0000000180426480
		public object DefaultValue { get; set; } // 0x0000000180426390-0x00000001804263A0 0x0000000180426460-0x0000000180426470
		public Required Required { get; } // 0x0000000180426400-0x0000000180426450 
		public bool? IsReference { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804263B0-0x00000001804263C0 0x0000000180426480-0x0000000180426490
		public NullValueHandling? NullValueHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AFA60-0x00000001802AFA70 0x00000001804264C0-0x00000001804264D0
		public DefaultValueHandling? DefaultValueHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AFA90-0x00000001802AFAA0 0x00000001802BF770-0x00000001802BF780
		public ReferenceLoopHandling? ReferenceLoopHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803FD790-0x00000001803FD7A0 0x0000000180421310-0x0000000180421320
		public ObjectCreationHandling? ObjectCreationHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802DC800-0x00000001802DC810 0x00000001804264D0-0x00000001804264E0
		public TypeNameHandling? TypeNameHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180381510-0x0000000180381520 0x0000000180268370-0x0000000180268380
		public Predicate<object> ShouldSerialize { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802DC810-0x00000001802DC820 0x0000000180268360-0x0000000180268370
		public Predicate<object> ShouldDeserialize { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268300-0x0000000180268310 
		public Predicate<object> GetIsSpecified { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018031E0A0-0x000000018031E0B0 0x000000018031EC40-0x000000018031EC50
		public Action<object, object> SetIsSpecified { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018031EBF0-0x000000018031EC00 0x000000018031EC50-0x000000018031EC60
		public JsonConverter ItemConverter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018026A2F0-0x000000018026A300 0x000000018026A920-0x000000018026A930
		public bool? ItemIsReference { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804263C0-0x00000001804263D0 0x0000000180426490-0x00000001804264A0
		public TypeNameHandling? ItemTypeNameHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804263E0-0x00000001804263F0 0x00000001804264B0-0x00000001804264C0
		public ReferenceLoopHandling? ItemReferenceLoopHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804263D0-0x00000001804263E0 0x00000001804264A0-0x00000001804264B0
	
		// Constructors
		public JsonProperty(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		internal object GetResolvedDefaultValue(); // 0x00000001804262B0-0x0000000180426340
		public override string ToString(); // 0x00000001802684F0-0x0000000180268500
		internal void WritePropertyName(JsonWriter writer); // 0x0000000180426340-0x0000000180426390
	}
}
