/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Valve.Newtonsoft.Json.Serialization;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json
{
	public class JsonSerializer // TypeDefIndex: 6961
	{
		// Fields
		internal TypeNameHandling _typeNameHandling; // 0x10
		internal FormatterAssemblyStyle _typeNameAssemblyFormat; // 0x14
		internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
		internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
		internal MissingMemberHandling _missingMemberHandling; // 0x20
		internal ObjectCreationHandling _objectCreationHandling; // 0x24
		internal NullValueHandling _nullValueHandling; // 0x28
		internal DefaultValueHandling _defaultValueHandling; // 0x2C
		internal ConstructorHandling _constructorHandling; // 0x30
		internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
		internal JsonConverterCollection _converters; // 0x38
		internal IContractResolver _contractResolver; // 0x40
		internal ITraceWriter _traceWriter; // 0x48
		internal IEqualityComparer _equalityComparer; // 0x50
		internal SerializationBinder _binder; // 0x58
		internal StreamingContext _context; // 0x60
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
		private string _dateFormatString; // 0xC8
		private bool _dateFormatStringSet; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private EventHandler<ErrorEventArgs> Error; // 0xD8
	
		// Properties
		public virtual IReferenceResolver ReferenceResolver { set; } // 0x000000018043A150-0x000000018043A1D0
		public virtual SerializationBinder Binder { set; } // 0x0000000180439BC0-0x0000000180439C40
		public virtual ITraceWriter TraceWriter { get; set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
		public virtual IEqualityComparer EqualityComparer { set; } // 0x00000001803DFE50-0x00000001803DFE60
		public virtual TypeNameHandling TypeNameHandling { set; } // 0x000000018043A240-0x000000018043A2B0
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { set; } // 0x000000018043A1D0-0x000000018043A240
		public virtual PreserveReferencesHandling PreserveReferencesHandling { set; } // 0x000000018043A070-0x000000018043A0E0
		public virtual ReferenceLoopHandling ReferenceLoopHandling { set; } // 0x000000018043A0E0-0x000000018043A150
		public virtual MissingMemberHandling MissingMemberHandling { set; } // 0x0000000180439F20-0x0000000180439F90
		public virtual NullValueHandling NullValueHandling { set; } // 0x0000000180439F90-0x000000018043A000
		public virtual DefaultValueHandling DefaultValueHandling { set; } // 0x0000000180439DE0-0x0000000180439E50
		public virtual ObjectCreationHandling ObjectCreationHandling { set; } // 0x000000018043A000-0x000000018043A070
		public virtual ConstructorHandling ConstructorHandling { set; } // 0x0000000180439CA0-0x0000000180439D10
		public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; } // 0x000000018030D190-0x000000018030D1A0 0x0000000180439EB0-0x0000000180439F20
		public virtual JsonConverterCollection Converters { get; } // 0x0000000180439A50-0x0000000180439AD0 
		public virtual IContractResolver ContractResolver { get; set; } // 0x0000000180268310-0x0000000180268320 0x0000000180439D20-0x0000000180439DE0
		public virtual StreamingContext Context { get; set; } // 0x0000000180439A40-0x0000000180439A50 0x0000000180439D10-0x0000000180439D20
		public virtual Formatting Formatting { get; set; } // 0x0000000180439AD0-0x0000000180439B20 0x0000000180439E50-0x0000000180439EB0
		public virtual bool CheckAdditionalContent { get; set; } // 0x00000001804399F0-0x0000000180439A40 0x0000000180439C40-0x0000000180439CA0
	
		// Events
		public virtual event EventHandler<ErrorEventArgs> Error {
			add; // 0x0000000180439950-0x00000001804399F0
			remove; // 0x0000000180439B20-0x0000000180439BC0
		}
	
		// Constructors
		public JsonSerializer(); // 0x00000001804397E0-0x0000000180439950
	
		// Methods
		internal bool IsCheckAdditionalContentSet(); // 0x0000000180438AC0-0x0000000180438B00
		public static JsonSerializer Create(); // 0x0000000180438360-0x00000001804384F0
		public static JsonSerializer Create(JsonSerializerSettings settings); // 0x00000001804384F0-0x00000001804386A0
		public static JsonSerializer CreateDefault(); // 0x00000001804380B0-0x0000000180438320
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings); // 0x0000000180438320-0x0000000180438360
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings); // 0x0000000180437960-0x00000001804380B0
		public T Deserialize<T>(JsonReader reader);
		public object Deserialize(JsonReader reader, System.Type objectType); // 0x0000000180438960-0x0000000180438980
		internal virtual object DeserializeInternal(JsonReader reader, System.Type objectType); // 0x00000001804386A0-0x0000000180438960
		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString); // 0x00000001804393B0-0x00000001804397E0
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString); // 0x0000000180438B60-0x0000000180438DE0
		public void Serialize(JsonWriter jsonWriter, object value, System.Type objectType); // 0x0000000180439390-0x00000001804393B0
		public void Serialize(JsonWriter jsonWriter, object value); // 0x0000000180439360-0x0000000180439390
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, System.Type objectType); // 0x0000000180438DE0-0x0000000180439360
		internal IReferenceResolver GetReferenceResolver(); // 0x0000000180438A60-0x0000000180438AC0
		internal JsonConverter GetMatchingConverter(System.Type type); // 0x0000000180438A50-0x0000000180438A60
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, System.Type objectType); // 0x0000000180438980-0x0000000180438A50
		internal void OnError(ErrorEventArgs e); // 0x0000000180438B00-0x0000000180438B60
	}
}
