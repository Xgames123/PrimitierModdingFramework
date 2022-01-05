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
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 5485
	{
		// Fields
		private readonly JsonWriter _innerWriter; // 0x60
		private readonly JsonTextWriter _textWriter; // 0x68
		private readonly StringWriter _sw; // 0x70
	
		// Constructors
		public TraceJsonWriter(JsonWriter innerWriter); // 0x00000001807949C0-0x0000000180794BA0
	
		// Methods
		public string GetSerializedJsonMessage(); // 0x0000000180792DA0-0x0000000180792DD0
		public override void WriteValue(decimal value); // 0x0000000180793FB0-0x0000000180794040
		public override void WriteValue(decimal? value); // 0x00000001807932B0-0x0000000180793390
		public override void WriteValue(bool value); // 0x0000000180793E10-0x0000000180793E80
		public override void WriteValue(bool? value); // 0x0000000180793820-0x00000001807938D0
		public override void WriteValue(byte value); // 0x0000000180794810-0x0000000180794880
		public override void WriteValue(byte? value); // 0x0000000180794700-0x00000001807947B0
		public override void WriteValue(char value); // 0x0000000180793DA0-0x0000000180793E10
		public override void WriteValue(char? value); // 0x0000000180794650-0x0000000180794700
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteValue(byte[] value); // 0x0000000180793940-0x00000001807939C0
		public override void WriteValue(DateTime value); // 0x0000000180793610-0x0000000180793680
		public override void WriteValue(DateTime? value); // 0x0000000180793EF0-0x0000000180793FB0
		public override void WriteValue(DateTimeOffset value); // 0x0000000180794880-0x0000000180794910
		public override void WriteValue(DateTimeOffset? value); // 0x00000001807942E0-0x00000001807943C0
		public override void WriteValue(double value); // 0x0000000180793E80-0x0000000180793EF0
		public override void WriteValue(double? value); // 0x0000000180794040-0x0000000180794100
		public override void WriteUndefined(); // 0x0000000180793260-0x00000001807932B0
		public override void WriteNull(); // 0x0000000180792F30-0x0000000180792F80
		public override void WriteValue(float value); // 0x00000001807938D0-0x0000000180793940
		public override void WriteValue(float? value); // 0x0000000180794910-0x00000001807949C0
		public override void WriteValue(Guid value); // 0x00000001807944F0-0x0000000180794580
		public override void WriteValue(Guid? value); // 0x0000000180793680-0x0000000180793760
		public override void WriteValue(int value); // 0x00000001807947B0-0x0000000180794810
		public override void WriteValue(int? value); // 0x00000001807934F0-0x00000001807935A0
		public override void WriteValue(long value); // 0x0000000180793CC0-0x0000000180793D30
		public override void WriteValue(long? value); // 0x0000000180793760-0x0000000180793820
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteValue(object value); // 0x0000000180793B50-0x0000000180793C60
		public override void WriteValue(sbyte value); // 0x0000000180793D30-0x0000000180793DA0
		public override void WriteValue(sbyte? value); // 0x0000000180793390-0x0000000180793440
		public override void WriteValue(short value); // 0x00000001807939C0-0x0000000180793A30
		public override void WriteValue(short? value); // 0x0000000180793A30-0x0000000180793AE0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteValue(string value); // 0x0000000180794270-0x00000001807942E0
		public override void WriteValue(TimeSpan value); // 0x0000000180793AE0-0x0000000180793B50
		public override void WriteValue(TimeSpan? value); // 0x00000001807941B0-0x0000000180794270
		public override void WriteValue(uint value); // 0x0000000180793C60-0x0000000180793CC0
		public override void WriteValue(uint? value); // 0x0000000180793440-0x00000001807934F0
		public override void WriteValue(ulong value); // 0x0000000180794480-0x00000001807944F0
		public override void WriteValue(ulong? value); // 0x00000001807943C0-0x0000000180794480
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteValue(Uri value); // 0x0000000180794580-0x0000000180794650
		public override void WriteValue(ushort value); // 0x00000001807935A0-0x0000000180793610
		public override void WriteValue(ushort? value); // 0x0000000180794100-0x00000001807941B0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteComment(string text); // 0x0000000180792DD0-0x0000000180792E40
		public override void WriteStartArray(); // 0x0000000180793150-0x00000001807931A0
		public override void WriteEndArray(); // 0x0000000180792E40-0x0000000180792E90
		public override void WriteStartConstructor(string name); // 0x00000001807931A0-0x0000000180793210
		public override void WriteEndConstructor(); // 0x0000000180792E90-0x0000000180792EE0
		public override void WritePropertyName(string name); // 0x0000000180793000-0x0000000180793070
		public override void WritePropertyName(string name, bool escape); // 0x0000000180792F80-0x0000000180793000
		public override void WriteStartObject(); // 0x0000000180793210-0x0000000180793260
		public override void WriteEndObject(); // 0x0000000180792EE0-0x0000000180792F30
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteRawValue(string json); // 0x0000000180793070-0x00000001807930E0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteRaw(string json); // 0x00000001807930E0-0x0000000180793150
		public override void Close(); // 0x0000000180792D50-0x0000000180792DA0
	}
}
