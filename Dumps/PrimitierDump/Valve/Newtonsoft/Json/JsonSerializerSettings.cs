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
	public class JsonSerializerSettings // TypeDefIndex: 6962
	{
		// Fields
		internal static readonly StreamingContext DefaultContext; // 0x00
		internal static readonly CultureInfo DefaultCulture; // 0x10
		internal Formatting? _formatting; // 0x10
		internal DateFormatHandling? _dateFormatHandling; // 0x18
		internal DateTimeZoneHandling? _dateTimeZoneHandling; // 0x20
		internal DateParseHandling? _dateParseHandling; // 0x28
		internal FloatFormatHandling? _floatFormatHandling; // 0x30
		internal FloatParseHandling? _floatParseHandling; // 0x38
		internal StringEscapeHandling? _stringEscapeHandling; // 0x40
		internal CultureInfo _culture; // 0x48
		internal bool? _checkAdditionalContent; // 0x50
		internal int? _maxDepth; // 0x54
		internal bool _maxDepthSet; // 0x5C
		internal string _dateFormatString; // 0x60
		internal bool _dateFormatStringSet; // 0x68
		internal FormatterAssemblyStyle? _typeNameAssemblyFormat; // 0x6C
		internal DefaultValueHandling? _defaultValueHandling; // 0x74
		internal PreserveReferencesHandling? _preserveReferencesHandling; // 0x7C
		internal NullValueHandling? _nullValueHandling; // 0x84
		internal ObjectCreationHandling? _objectCreationHandling; // 0x8C
		internal MissingMemberHandling? _missingMemberHandling; // 0x94
		internal ReferenceLoopHandling? _referenceLoopHandling; // 0x9C
		internal StreamingContext? _context; // 0xA8
		internal ConstructorHandling? _constructorHandling; // 0xC0
		internal TypeNameHandling? _typeNameHandling; // 0xC8
		internal MetadataPropertyHandling? _metadataPropertyHandling; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private IList<JsonConverter> _Converters_k__BackingField; // 0xD8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private IContractResolver _ContractResolver_k__BackingField; // 0xE0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private IEqualityComparer _EqualityComparer_k__BackingField; // 0xE8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Func<IReferenceResolver> _ReferenceResolverProvider_k__BackingField; // 0xF0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ITraceWriter _TraceWriter_k__BackingField; // 0xF8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SerializationBinder _Binder_k__BackingField; // 0x100
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private EventHandler<ErrorEventArgs> _Error_k__BackingField; // 0x108
	
		// Properties
		public ReferenceLoopHandling ReferenceLoopHandling { get; } // 0x00000001807578B0-0x0000000180757900 
		public MissingMemberHandling MissingMemberHandling { get; } // 0x0000000180757770-0x00000001807577C0 
		public ObjectCreationHandling ObjectCreationHandling { get; } // 0x0000000180757810-0x0000000180757860 
		public NullValueHandling NullValueHandling { get; set; } // 0x00000001807577C0-0x0000000180757810 0x00000001807579A0-0x0000000180757A00
		public DefaultValueHandling DefaultValueHandling { get; } // 0x00000001807576D0-0x0000000180757720 
		public IList<JsonConverter> Converters { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018026A2F0-0x000000018026A300 0x000000018026A920-0x000000018026A930
		public PreserveReferencesHandling PreserveReferencesHandling { get; } // 0x0000000180757860-0x00000001807578B0 
		public TypeNameHandling TypeNameHandling { get; } // 0x0000000180757950-0x00000001807579A0 
		public MetadataPropertyHandling MetadataPropertyHandling { get; } // 0x0000000180757720-0x0000000180757770 
		public FormatterAssemblyStyle TypeNameAssemblyFormat { get; } // 0x0000000180757900-0x0000000180757950 
		public ConstructorHandling ConstructorHandling { get; } // 0x00000001807575C0-0x0000000180757610 
		public IContractResolver ContractResolver { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018026A6D0-0x000000018026A6E0 
		public IEqualityComparer EqualityComparer { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802885C0-0x00000001802885D0 
		public Func<IReferenceResolver> ReferenceResolverProvider { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802696B0-0x00000001802696C0 
		public ITraceWriter TraceWriter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018026A2D0-0x000000018026A2E0 
		public SerializationBinder Binder { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018026A2E0-0x000000018026A2F0 
		public EventHandler<ErrorEventArgs> Error { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180377500-0x0000000180377510 
		public StreamingContext Context { get; } // 0x0000000180757610-0x00000001807576D0 
	
		// Constructors
		static JsonSerializerSettings(); // 0x00000001807574D0-0x0000000180757550
		public JsonSerializerSettings(); // 0x0000000180757550-0x00000001807575C0
	}
}
