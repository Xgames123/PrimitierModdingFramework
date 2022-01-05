/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public abstract class JsonContract // TypeDefIndex: 7065
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
		private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
		private IList<SerializationCallback> _onDeserializingCallbacks; // 0x38
		private IList<SerializationCallback> _onSerializedCallbacks; // 0x40
		private IList<SerializationCallback> _onSerializingCallbacks; // 0x48
		private IList<SerializationErrorCallback> _onErrorCallbacks; // 0x50
		private System.Type _createdType; // 0x58
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private System.Type _UnderlyingType_k__BackingField; // 0x60
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool? _IsReference_k__BackingField; // 0x68
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonConverter _Converter_k__BackingField; // 0x70
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonConverter _InternalConverter_k__BackingField; // 0x78
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Func<object> _DefaultCreator_k__BackingField; // 0x80
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _DefaultCreatorNonPublic_k__BackingField; // 0x88
	
		// Properties
		public System.Type UnderlyingType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802C6D20-0x00000001802C6D30 0x000000018026C080-0x000000018026C090
		public System.Type CreatedType { get; set; } // 0x00000001802BF820-0x00000001802BF890 0x0000000180422050-0x00000001804220A0
		public bool? IsReference { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421E00-0x0000000180421E10 0x00000001804220B0-0x00000001804220C0
		public JsonConverter Converter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802DC790-0x00000001802DC800 0x0000000180422040-0x0000000180422050
		internal JsonConverter InternalConverter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C0E50-0x00000001802C0E60 0x00000001802C0E80-0x00000001802C0E90
		public IList<SerializationCallback> OnDeserializedCallbacks { get; } // 0x0000000180421E10-0x0000000180421E80 
		public IList<SerializationCallback> OnDeserializingCallbacks { get; } // 0x0000000180421E80-0x0000000180421EF0 
		public IList<SerializationCallback> OnSerializedCallbacks { get; } // 0x0000000180421F60-0x0000000180421FD0 
		public IList<SerializationCallback> OnSerializingCallbacks { get; } // 0x0000000180421FD0-0x0000000180422040 
		public IList<SerializationErrorCallback> OnErrorCallbacks { get; } // 0x0000000180421EF0-0x0000000180421F60 
		public Func<object> DefaultCreator { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C0E60-0x00000001802C0E70 0x00000001802C0E90-0x00000001802C0EA0
		public bool DefaultCreatorNonPublic { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421DF0-0x0000000180421E00 0x00000001804220A0-0x00000001804220B0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass73_0 // TypeDefIndex: 7063
		{
			// Fields
			public MethodInfo callbackMethodInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass73_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _CreateSerializationCallback_b__0(object o, StreamingContext context); // 0x0000000180882780-0x0000000180882880
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 7064
		{
			// Fields
			public MethodInfo callbackMethodInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _CreateSerializationErrorCallback_b__0(object o, StreamingContext context, ErrorContext econtext); // 0x0000000180882880-0x00000001808829D0
		}
	
		// Constructors
		internal JsonContract(System.Type underlyingType); // 0x0000000180421C90-0x0000000180421DF0
	
		// Methods
		internal void InvokeOnSerializing(object o, StreamingContext context); // 0x0000000180421AE0-0x0000000180421C90
		internal void InvokeOnSerialized(object o, StreamingContext context); // 0x0000000180421930-0x0000000180421AE0
		internal void InvokeOnDeserializing(object o, StreamingContext context); // 0x00000001804215C0-0x0000000180421770
		internal void InvokeOnDeserialized(object o, StreamingContext context); // 0x0000000180421490-0x00000001804215C0
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext); // 0x0000000180421770-0x0000000180421930
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo); // 0x0000000180421350-0x00000001804213F0
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo); // 0x00000001804213F0-0x0000000180421490
	}
}
