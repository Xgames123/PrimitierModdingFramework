/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5484
	{
		// Fields
		private readonly JsonReader _innerReader; // 0x78
		private readonly JsonTextWriter _textWriter; // 0x80
		private readonly StringWriter _sw; // 0x88
	
		// Properties
		public override int Depth { get; } // 0x0000000180792C60-0x0000000180792C90 
		public override string Path { get; } // 0x0000000180792C90-0x0000000180792CC0 
		public override JsonToken TokenType { get; } // 0x0000000180792CC0-0x0000000180792CF0 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override object Value { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x0000000180792D20-0x0000000180792D50 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override System.Type ValueType { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x0000000180792CF0-0x0000000180792D20 
		int IJsonLineInfo.LineNumber { get; } // 0x00000001807925D0-0x0000000180792630 
		int IJsonLineInfo.LinePosition { get; } // 0x0000000180792630-0x0000000180792690 
	
		// Constructors
		public TraceJsonReader(JsonReader innerReader); // 0x0000000180792B20-0x0000000180792C60
	
		// Methods
		public string GetDeserializedJsonMessage(); // 0x0000000180792540-0x0000000180792570
		public override bool Read(); // 0x0000000180792A60-0x0000000180792AD0
		public override int? ReadAsInt32(); // 0x0000000180792980-0x00000001807929F0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override string ReadAsString(); // 0x00000001807929F0-0x0000000180792A60
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override byte[] ReadAsBytes(); // 0x0000000180792700-0x0000000180792770
		public override decimal? ReadAsDecimal(); // 0x0000000180792880-0x0000000180792900
		public override double? ReadAsDouble(); // 0x0000000180792900-0x0000000180792980
		public override bool? ReadAsBoolean(); // 0x0000000180792690-0x0000000180792700
		public override DateTime? ReadAsDateTime(); // 0x0000000180792800-0x0000000180792880
		public override DateTimeOffset? ReadAsDateTimeOffset(); // 0x0000000180792770-0x0000000180792800
		public void WriteCurrentToken(); // 0x0000000180792AD0-0x0000000180792B20
		public override void Close(); // 0x0000000180792510-0x0000000180792540
		bool IJsonLineInfo.HasLineInfo(); // 0x0000000180792570-0x00000001807925D0
	}
}
