/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class JsonSerializer // TypeDefIndex: 5326
	{
		// Fields
		internal TypeNameHandling _typeNameHandling; // 0x10
		internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; // 0x14
		internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
		internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
		internal MissingMemberHandling _missingMemberHandling; // 0x20
		internal ObjectCreationHandling _objectCreationHandling; // 0x24
		internal NullValueHandling _nullValueHandling; // 0x28
		internal DefaultValueHandling _defaultValueHandling; // 0x2C
		internal ConstructorHandling _constructorHandling; // 0x30
		internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		internal JsonConverterCollection _converters; // 0x38
		internal IContractResolver _contractResolver; // 0x40
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		internal ITraceWriter _traceWriter; // 0x48
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		internal IEqualityComparer _equalityComparer; // 0x50
		internal ISerializationBinder _serializationBinder; // 0x58
		internal StreamingContext _context; // 0x60
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private IReferenceResolver _referenceResolver; // 0x70
		private Formatting? _formatting; // 0x78
		private DateFormatHandling? _dateFormatHandling; // 0x80
		private DateTimeZoneHandling? _dateTimeZoneHandling; // 0x88
		private DateParseHandling? _dateParseHandling; // 0x90
		private FloatFormatHandling? _floatFormatHandling; // 0x98
		private FloatParseHandling? _floatParseHandling; // 0xA0
		private StringEscapeHandling? _stringEscapeHandling; // 0xA8
		private CultureInfo _culture; // 0xB0
		private int? _maxDepth; // 0xB8
		private bool _maxDepthSet; // 0xC0
		private bool? _checkAdditionalContent; // 0xC1
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private string _dateFormatString; // 0xC8
		private bool _dateFormatStringSet; // 0xD0
		[CompilerGenerated] // 0x00000001800170A0-0x0000000180017110
		[Nullable] // 0x00000001800170A0-0x0000000180017110
		private EventHandler<ErrorEventArgs> Error; // 0xD8
	
		// Properties
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public virtual IReferenceResolver ReferenceResolver { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ set; } // 0x000000018051C780-0x000000018051C800
		public virtual ISerializationBinder SerializationBinder { set; } // 0x000000018051C800-0x000000018051C880
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public virtual ITraceWriter TraceWriter { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public virtual IEqualityComparer EqualityComparer { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ set; } // 0x00000001803DFE50-0x00000001803DFE60
		public virtual TypeNameHandling TypeNameHandling { set; } // 0x000000018051C8F0-0x000000018051C960
		public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; } // 0x000000018051C880-0x000000018051C8F0
		public virtual PreserveReferencesHandling PreserveReferencesHandling { set; } // 0x000000018051C6A0-0x000000018051C710
		public virtual ReferenceLoopHandling ReferenceLoopHandling { set; } // 0x000000018051C710-0x000000018051C780
		public virtual MissingMemberHandling MissingMemberHandling { set; } // 0x000000018051C550-0x000000018051C5C0
		public virtual NullValueHandling NullValueHandling { get; set; } // 0x00000001802B51E0-0x00000001802B51F0 0x000000018051C5C0-0x000000018051C630
		public virtual DefaultValueHandling DefaultValueHandling { set; } // 0x000000018051C470-0x000000018051C4E0
		public virtual ObjectCreationHandling ObjectCreationHandling { set; } // 0x000000018051C630-0x000000018051C6A0
		public virtual ConstructorHandling ConstructorHandling { set; } // 0x000000018051C340-0x000000018051C3B0
		public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; } // 0x000000018030D190-0x000000018030D1A0 0x000000018051C4E0-0x000000018051C550
		public virtual JsonConverterCollection Converters { get; } // 0x000000018051C240-0x000000018051C2A0 
		public virtual IContractResolver ContractResolver { get; set; } // 0x0000000180268310-0x0000000180268320 0x000000018051C3B0-0x000000018051C470
		public virtual StreamingContext Context { get; set; } // 0x0000000180439A40-0x0000000180439A50 0x0000000180439D10-0x0000000180439D20
		public virtual bool CheckAdditionalContent { get; } // 0x000000018051C200-0x000000018051C240 
	
		// Events
		[Nullable] // 0x00000001800172F0-0x0000000180017350
		public virtual event EventHandler<ErrorEventArgs> Error {
			add; // 0x000000018051C160-0x000000018051C200
			remove; // 0x000000018051C2A0-0x000000018051C340
		}
	
		// Constructors
		public JsonSerializer(); // 0x000000018051BFF0-0x000000018051C160
	
		// Methods
		public static JsonSerializer Create(); // 0x000000018051AA40-0x000000018051ABD0
		public static JsonSerializer Create([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonSerializerSettings settings); // 0x000000018051ABD0-0x000000018051AD80
		public static JsonSerializer CreateDefault(); // 0x000000018051A740-0x000000018051A9B0
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings); // 0x0000000180519FF0-0x000000018051A740
		[DebuggerStepThrough] // 0x0000000180014D50-0x0000000180014D60
		public T Deserialize<T>(JsonReader reader);
		[DebuggerStepThrough] // 0x0000000180016840-0x0000000180016870
		[NullableContext] // 0x0000000180016840-0x0000000180016870
		public object Deserialize([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, System.Type objectType); // 0x000000018051B040-0x000000018051B060
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal virtual object DeserializeInternal([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, System.Type objectType); // 0x000000018051AD80-0x000000018051B040
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private void SetupReader([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString); // 0x000000018051BBC0-0x000000018051BFF0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private void ResetReader([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString); // 0x000000018051B2C0-0x000000018051B5C0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public void Serialize([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonWriter jsonWriter, object value, System.Type objectType); // 0x000000018051BBA0-0x000000018051BBC0
		public void Serialize(JsonWriter jsonWriter, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value); // 0x000000018051BB70-0x000000018051BBA0
		private TraceJsonReader CreateTraceJsonReader(JsonReader reader); // 0x000000018051A9B0-0x000000018051AA40
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal virtual void SerializeInternal([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonWriter jsonWriter, object value, System.Type objectType); // 0x000000018051B5C0-0x000000018051BB70
		internal IReferenceResolver GetReferenceResolver(); // 0x000000018051B200-0x000000018051B260
		internal JsonConverter GetMatchingConverter(System.Type type); // 0x000000018051B130-0x000000018051B200
		internal static JsonConverter GetMatchingConverter([Nullable] /* 0x0000000180017290-0x00000001800172F0 */ IList<JsonConverter> converters, System.Type objectType); // 0x000000018051B060-0x000000018051B130
		internal void OnError(ErrorEventArgs e); // 0x000000018051B260-0x000000018051B2C0
	}
}
