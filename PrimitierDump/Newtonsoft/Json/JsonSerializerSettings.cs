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
	[Nullable] // 0x0000000180015720-0x0000000180015760
	[NullableContext] // 0x0000000180015720-0x0000000180015760
	public class JsonSerializerSettings // TypeDefIndex: 5327
	{
		// Fields
		internal static readonly StreamingContext DefaultContext; // 0x00
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
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
		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling; // 0x6C
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
		[CompilerGenerated] // 0x0000000180017350-0x0000000180017380
		[Nullable] // 0x0000000180017350-0x0000000180017380
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
		private ISerializationBinder _SerializationBinder_k__BackingField; // 0x100
		[CompilerGenerated] // 0x0000000180017380-0x00000001800173F0
		[Nullable] // 0x0000000180017380-0x00000001800173F0
		private EventHandler<ErrorEventArgs> _Error_k__BackingField; // 0x108
	
		// Properties
		public ReferenceLoopHandling ReferenceLoopHandling { get; } // 0x00000001806759D0-0x0000000180675A10 
		public MissingMemberHandling MissingMemberHandling { get; } // 0x00000001806758D0-0x0000000180675910 
		public ObjectCreationHandling ObjectCreationHandling { get; } // 0x0000000180675950-0x0000000180675990 
		public NullValueHandling NullValueHandling { get; } // 0x0000000180675910-0x0000000180675950 
		public DefaultValueHandling DefaultValueHandling { get; } // 0x0000000180675850-0x0000000180675890 
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public IList<JsonConverter> Converters { [NullableContext] /* 0x0000000180014D60-0x0000000180014D90 */ [CompilerGenerated] /* 0x0000000180014D60-0x0000000180014D90 */ get; } // 0x000000018026A2F0-0x000000018026A300 
		public PreserveReferencesHandling PreserveReferencesHandling { get; } // 0x0000000180675990-0x00000001806759D0 
		public TypeNameHandling TypeNameHandling { get; } // 0x0000000180675A50-0x0000000180675A90 
		public MetadataPropertyHandling MetadataPropertyHandling { get; } // 0x0000000180675890-0x00000001806758D0 
		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; } // 0x0000000180675A10-0x0000000180675A50 
		public ConstructorHandling ConstructorHandling { get; } // 0x0000000180675750-0x0000000180675790 
		public IContractResolver ContractResolver { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018026A6D0-0x000000018026A6E0 
		public IEqualityComparer EqualityComparer { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802885C0-0x00000001802885D0 
		public Func<IReferenceResolver> ReferenceResolverProvider { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802696B0-0x00000001802696C0 
		public ITraceWriter TraceWriter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018026A2D0-0x000000018026A2E0 
		public ISerializationBinder SerializationBinder { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018026A2E0-0x000000018026A2F0 
		[Nullable] // 0x00000001800173F0-0x0000000180017450
		public EventHandler<ErrorEventArgs> Error { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180377500-0x0000000180377510 
		public StreamingContext Context { get; } // 0x0000000180675790-0x0000000180675850 
	
		// Constructors
		static JsonSerializerSettings(); // 0x00000001806756D0-0x0000000180675750
	}
}
