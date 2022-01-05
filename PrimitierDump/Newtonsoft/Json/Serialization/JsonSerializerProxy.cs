/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
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
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 5474
	{
		// Fields
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
		private readonly JsonSerializer _serializer; // 0xF0
	
		// Properties
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override IReferenceResolver ReferenceResolver { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ set; } // 0x00000001806755E0-0x0000000180675610
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override ITraceWriter TraceWriter { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ set; } // 0x0000000180675360-0x0000000180675390 0x0000000180675640-0x0000000180675670
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override IEqualityComparer EqualityComparer { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ set; } // 0x0000000180675490-0x00000001806754C0
		public override JsonConverterCollection Converters { get; } // 0x00000001806752D0-0x0000000180675300 
		public override DefaultValueHandling DefaultValueHandling { set; } // 0x0000000180675460-0x0000000180675490
		public override IContractResolver ContractResolver { get; set; } // 0x00000001806752A0-0x00000001806752D0 0x0000000180675430-0x0000000180675460
		public override MissingMemberHandling MissingMemberHandling { set; } // 0x00000001806754F0-0x0000000180675520
		public override NullValueHandling NullValueHandling { get; set; } // 0x0000000180675330-0x0000000180675360 0x0000000180675520-0x0000000180675550
		public override ObjectCreationHandling ObjectCreationHandling { set; } // 0x0000000180675550-0x0000000180675580
		public override ReferenceLoopHandling ReferenceLoopHandling { set; } // 0x00000001806755B0-0x00000001806755E0
		public override PreserveReferencesHandling PreserveReferencesHandling { set; } // 0x0000000180675580-0x00000001806755B0
		public override TypeNameHandling TypeNameHandling { set; } // 0x00000001806756A0-0x00000001806756D0
		public override MetadataPropertyHandling MetadataPropertyHandling { get; set; } // 0x0000000180675300-0x0000000180675330 0x00000001806754C0-0x00000001806754F0
		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; } // 0x0000000180675670-0x00000001806756A0
		public override ConstructorHandling ConstructorHandling { set; } // 0x00000001806753C0-0x00000001806753F0
		public override ISerializationBinder SerializationBinder { set; } // 0x0000000180675610-0x0000000180675640
		public override StreamingContext Context { get; set; } // 0x0000000180675260-0x00000001806752A0 0x00000001806753F0-0x0000000180675430
		public override bool CheckAdditionalContent { get; } // 0x0000000180675230-0x0000000180675260 
	
		// Events
		[Nullable] // 0x00000001800158C0-0x0000000180015920
		public override event EventHandler<ErrorEventArgs> Error {
			add; // 0x0000000180675200-0x0000000180675230
			remove; // 0x0000000180675390-0x00000001806753C0
		}
	
		// Constructors
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader); // 0x0000000180675190-0x0000000180675200
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter); // 0x0000000180675120-0x0000000180675190
	
		// Methods
		internal JsonSerializerInternalBase GetInternalSerializer(); // 0x00000001806750B0-0x00000001806750D0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override object DeserializeInternal([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, System.Type objectType); // 0x0000000180675060-0x00000001806750B0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override void SerializeInternal([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonWriter jsonWriter, object value, System.Type rootType); // 0x00000001806750D0-0x0000000180675120
	}
}
