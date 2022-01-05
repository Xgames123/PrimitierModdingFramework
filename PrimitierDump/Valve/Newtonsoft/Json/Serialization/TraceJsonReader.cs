/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 7092
	{
		// Fields
		private readonly JsonReader _innerReader; // 0x78
		private readonly JsonTextWriter _textWriter; // 0x80
		private readonly StringWriter _sw; // 0x88
	
		// Properties
		public override int Depth { get; } // 0x0000000180792C60-0x0000000180792C90 
		public override string Path { get; } // 0x0000000180792C90-0x0000000180792CC0 
		public override JsonToken TokenType { get; } // 0x0000000180792CC0-0x0000000180792CF0 
		public override object Value { get; } // 0x0000000180792D20-0x0000000180792D50 
		public override System.Type ValueType { get; } // 0x0000000180792CF0-0x0000000180792D20 
		int IJsonLineInfo.LineNumber { get; } // 0x000000018087F530-0x000000018087F590 
		int IJsonLineInfo.LinePosition { get; } // 0x000000018087F590-0x000000018087F5F0 
	
		// Constructors
		public TraceJsonReader(JsonReader innerReader); // 0x000000018087F5F0-0x000000018087F730
	
		// Methods
		public string GetDeserializedJsonMessage(); // 0x0000000180792540-0x0000000180792570
		public override bool Read(); // 0x0000000180792A60-0x0000000180792AD0
		public override int? ReadAsInt32(); // 0x0000000180792980-0x00000001807929F0
		public override string ReadAsString(); // 0x00000001807929F0-0x0000000180792A60
		public override byte[] ReadAsBytes(); // 0x0000000180792700-0x0000000180792770
		public override decimal? ReadAsDecimal(); // 0x0000000180792880-0x0000000180792900
		public override double? ReadAsDouble(); // 0x0000000180792900-0x0000000180792980
		public override bool? ReadAsBoolean(); // 0x0000000180792690-0x0000000180792700
		public override DateTime? ReadAsDateTime(); // 0x0000000180792800-0x0000000180792880
		public override DateTimeOffset? ReadAsDateTimeOffset(); // 0x0000000180792770-0x0000000180792800
		public override void Close(); // 0x0000000180792510-0x0000000180792540
		bool IJsonLineInfo.HasLineInfo(); // 0x000000018087F4D0-0x000000018087F530
	}
}
