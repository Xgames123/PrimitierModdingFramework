/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 7082
	{
		// Fields
		private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
		private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
		private readonly JsonSerializer _serializer; // 0xF0
	
		// Properties
		public override IReferenceResolver ReferenceResolver { set; } // 0x00000001806755E0-0x0000000180675610
		public override ITraceWriter TraceWriter { get; set; } // 0x0000000180675360-0x0000000180675390 0x0000000180675640-0x0000000180675670
		public override IEqualityComparer EqualityComparer { set; } // 0x0000000180675490-0x00000001806754C0
		public override JsonConverterCollection Converters { get; } // 0x0000000180757310-0x0000000180757340 
		public override DefaultValueHandling DefaultValueHandling { set; } // 0x0000000180675520-0x0000000180675550
		public override IContractResolver ContractResolver { get; set; } // 0x00000001806752D0-0x0000000180675300 0x0000000180757410-0x0000000180757440
		public override MissingMemberHandling MissingMemberHandling { set; } // 0x00000001806754F0-0x0000000180675520
		public override NullValueHandling NullValueHandling { set; } // 0x00000001807574A0-0x00000001807574D0
		public override ObjectCreationHandling ObjectCreationHandling { set; } // 0x0000000180675460-0x0000000180675490
		public override ReferenceLoopHandling ReferenceLoopHandling { set; } // 0x00000001806755B0-0x00000001806755E0
		public override PreserveReferencesHandling PreserveReferencesHandling { set; } // 0x0000000180675580-0x00000001806755B0
		public override TypeNameHandling TypeNameHandling { set; } // 0x00000001806756A0-0x00000001806756D0
		public override MetadataPropertyHandling MetadataPropertyHandling { get; set; } // 0x0000000180757370-0x00000001807573A0 0x0000000180757470-0x00000001807574A0
		public override FormatterAssemblyStyle TypeNameAssemblyFormat { set; } // 0x0000000180675670-0x00000001806756A0
		public override ConstructorHandling ConstructorHandling { set; } // 0x0000000180675550-0x0000000180675580
		public override SerializationBinder Binder { set; } // 0x0000000180675610-0x0000000180675640
		public override StreamingContext Context { get; set; } // 0x00000001807572D0-0x0000000180757310 0x00000001807573D0-0x0000000180757410
		public override Formatting Formatting { get; set; } // 0x0000000180757340-0x0000000180757370 0x0000000180757440-0x0000000180757470
		public override bool CheckAdditionalContent { get; set; } // 0x00000001807572A0-0x00000001807572D0 0x00000001807573A0-0x00000001807573D0
	
		// Events
		public override event EventHandler<ErrorEventArgs> Error {
			add; // 0x0000000180675200-0x0000000180675230
			remove; // 0x0000000180675390-0x00000001806753C0
		}
	
		// Constructors
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader); // 0x00000001807571C0-0x0000000180757230
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter); // 0x0000000180757230-0x00000001807572A0
	
		// Methods
		internal JsonSerializerInternalBase GetInternalSerializer(); // 0x00000001806750B0-0x00000001806750D0
		internal override object DeserializeInternal(JsonReader reader, System.Type objectType); // 0x0000000180757120-0x0000000180757170
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, System.Type rootType); // 0x0000000180757170-0x00000001807571C0
	}
}
