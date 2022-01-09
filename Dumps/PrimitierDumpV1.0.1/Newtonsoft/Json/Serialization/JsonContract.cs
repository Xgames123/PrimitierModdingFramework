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
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public abstract class JsonContract // TypeDefIndex: 5456
	{
		// Fields
		internal bool IsNullable; // 0x10
		internal bool IsConvertable; // 0x11
		internal bool IsEnum; // 0x12
		internal System.Type NonNullableUnderlyingType; // 0x18
		internal ReadType InternalReadType; // 0x20
		internal JsonContractType ContractType; // 0x24
		internal bool IsReadOnlyOrFixedSize; // 0x28
		internal bool IsSealed; // 0x29
		internal bool IsInstantiable; // 0x2A
		[Nullable] // 0x00000001800198F0-0x0000000180019950
		private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
		[Nullable] // 0x0000000180019950-0x00000001800199B0
		private List<SerializationCallback> _onDeserializingCallbacks; // 0x38
		[Nullable] // 0x00000001800199B0-0x0000000180019A10
		private List<SerializationCallback> _onSerializedCallbacks; // 0x40
		[Nullable] // 0x0000000180019A10-0x0000000180019A70
		private List<SerializationCallback> _onSerializingCallbacks; // 0x48
		[Nullable] // 0x0000000180019A70-0x0000000180019AD0
		private List<SerializationErrorCallback> _onErrorCallbacks; // 0x50
		private System.Type _createdType; // 0x58
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly System.Type _UnderlyingType_k__BackingField; // 0x60
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool? _IsReference_k__BackingField; // 0x68
		[CompilerGenerated] // 0x0000000180015E50-0x0000000180015E80
		[Nullable] // 0x0000000180015E50-0x0000000180015E80
		private JsonConverter _Converter_k__BackingField; // 0x70
		[CompilerGenerated] // 0x0000000180015E50-0x0000000180015E80
		[Nullable] // 0x0000000180015E50-0x0000000180015E80
		private JsonConverter _InternalConverter_k__BackingField; // 0x78
		[CompilerGenerated] // 0x0000000180019AD0-0x0000000180019B40
		[Nullable] // 0x0000000180019AD0-0x0000000180019B40
		private Func<object> _DefaultCreator_k__BackingField; // 0x80
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _DefaultCreatorNonPublic_k__BackingField; // 0x88
	
		// Properties
		public System.Type UnderlyingType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802C6D20-0x00000001802C6D30 
		public System.Type CreatedType { get; set; } // 0x00000001802BF820-0x00000001802BF890 0x00000001804C67F0-0x00000001804C6880
		public bool? IsReference { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421E00-0x0000000180421E10 0x00000001804220B0-0x00000001804220C0
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public JsonConverter Converter { [NullableContext] /* 0x0000000180016840-0x0000000180016870 */ [CompilerGenerated] /* 0x0000000180016840-0x0000000180016870 */ get; [NullableContext] /* 0x0000000180016840-0x0000000180016870 */ [CompilerGenerated] /* 0x0000000180016840-0x0000000180016870 */ set; } // 0x00000001802DC790-0x00000001802DC800 0x0000000180422040-0x0000000180422050
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public JsonConverter InternalConverter { [NullableContext] /* 0x0000000180016840-0x0000000180016870 */ [CompilerGenerated] /* 0x0000000180016840-0x0000000180016870 */ get; [NullableContext] /* 0x0000000180016840-0x0000000180016870 */ [CompilerGenerated] /* 0x0000000180016840-0x0000000180016870 */ internal set; } // 0x00000001802C0E50-0x00000001802C0E60 0x00000001802C0E80-0x00000001802C0E90
		public IList<SerializationCallback> OnDeserializedCallbacks { get; } // 0x00000001804C65C0-0x00000001804C6630 
		public IList<SerializationCallback> OnDeserializingCallbacks { get; } // 0x00000001804C6630-0x00000001804C66A0 
		public IList<SerializationCallback> OnSerializedCallbacks { get; } // 0x00000001804C6710-0x00000001804C6780 
		public IList<SerializationCallback> OnSerializingCallbacks { get; } // 0x00000001804C6780-0x00000001804C67F0 
		public IList<SerializationErrorCallback> OnErrorCallbacks { get; } // 0x00000001804C66A0-0x00000001804C6710 
		[Nullable] // 0x0000000180019BA0-0x0000000180019C00
		public Func<object> DefaultCreator { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C0E60-0x00000001802C0E70 0x00000001802C0E90-0x00000001802C0EA0
		public bool DefaultCreatorNonPublic { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421DF0-0x0000000180421E00 0x00000001804220A0-0x00000001804220B0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass57_0 // TypeDefIndex: 5454
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public MethodInfo callbackMethodInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass57_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _CreateSerializationCallback_b__0(object o, StreamingContext context); // 0x0000000180797400-0x0000000180797500
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 5455
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public MethodInfo callbackMethodInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _CreateSerializationErrorCallback_b__0(object o, StreamingContext context, ErrorContext econtext); // 0x0000000180797500-0x0000000180797650
		}
	
		// Constructors
		internal JsonContract(System.Type underlyingType); // 0x00000001804C6480-0x00000001804C65C0
	
		// Methods
		internal void InvokeOnSerializing(object o, StreamingContext context); // 0x00000001804C6350-0x00000001804C6480
		internal void InvokeOnSerialized(object o, StreamingContext context); // 0x00000001804C6220-0x00000001804C6350
		internal void InvokeOnDeserializing(object o, StreamingContext context); // 0x00000001804C5FB0-0x00000001804C60E0
		internal void InvokeOnDeserialized(object o, StreamingContext context); // 0x00000001804C5E80-0x00000001804C5FB0
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext); // 0x00000001804C60E0-0x00000001804C6220
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo); // 0x00000001804C5D40-0x00000001804C5DE0
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo); // 0x00000001804C5DE0-0x00000001804C5E80
	}
}
