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
	internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 7093
	{
		// Fields
		private readonly JsonWriter _innerWriter; // 0x60
		private readonly JsonTextWriter _textWriter; // 0x68
		private readonly StringWriter _sw; // 0x70
	
		// Constructors
		public TraceJsonWriter(JsonWriter innerWriter); // 0x0000000180880560-0x0000000180880740
	
		// Methods
		public string GetSerializedJsonMessage(); // 0x0000000180792DA0-0x0000000180792DD0
		public override void WriteValue(decimal value); // 0x00000001808800C0-0x0000000180880150
		public override void WriteValue(bool value); // 0x00000001808804F0-0x0000000180880560
		public override void WriteValue(byte value); // 0x00000001808801C0-0x0000000180880230
		public override void WriteValue(byte? value); // 0x00000001808802A0-0x0000000180880310
		public override void WriteValue(char value); // 0x000000018087FE70-0x000000018087FEE0
		public override void WriteValue(byte[] value); // 0x0000000180880050-0x00000001808800C0
		public override void WriteValue(DateTime value); // 0x000000018087FE00-0x000000018087FE70
		public override void WriteValue(DateTimeOffset value); // 0x00000001808803F0-0x0000000180880480
		public override void WriteValue(double value); // 0x000000018087FCD0-0x000000018087FD40
		public override void WriteUndefined(); // 0x000000018087FBA0-0x000000018087FBF0
		public override void WriteNull(); // 0x000000018087F8E0-0x000000018087F930
		public override void WriteValue(float value); // 0x000000018087FC60-0x000000018087FCD0
		public override void WriteValue(Guid value); // 0x000000018087FEE0-0x000000018087FF70
		public override void WriteValue(int value); // 0x000000018087FDA0-0x000000018087FE00
		public override void WriteValue(long value); // 0x000000018087FF70-0x000000018087FFE0
		public override void WriteValue(sbyte value); // 0x0000000180880150-0x00000001808801C0
		public override void WriteValue(short value); // 0x0000000180880310-0x0000000180880380
		public override void WriteValue(string value); // 0x000000018087FBF0-0x000000018087FC60
		public override void WriteValue(TimeSpan value); // 0x000000018087FFE0-0x0000000180880050
		public override void WriteValue(uint value); // 0x000000018087FD40-0x000000018087FDA0
		public override void WriteValue(ulong value); // 0x0000000180880230-0x00000001808802A0
		public override void WriteValue(Uri value); // 0x0000000180880480-0x00000001808804F0
		public override void WriteValue(ushort value); // 0x0000000180880380-0x00000001808803F0
		public override void WriteComment(string text); // 0x000000018087F780-0x000000018087F7F0
		public override void WriteStartArray(); // 0x000000018087FA90-0x000000018087FAE0
		public override void WriteEndArray(); // 0x000000018087F7F0-0x000000018087F840
		public override void WriteStartConstructor(string name); // 0x000000018087FAE0-0x000000018087FB50
		public override void WriteEndConstructor(); // 0x000000018087F840-0x000000018087F890
		public override void WritePropertyName(string name); // 0x000000018087F930-0x000000018087F9A0
		public override void WritePropertyName(string name, bool escape); // 0x000000018087F9A0-0x000000018087FA20
		public override void WriteStartObject(); // 0x000000018087FB50-0x000000018087FBA0
		public override void WriteEndObject(); // 0x000000018087F890-0x000000018087F8E0
		public override void WriteRawValue(string json); // 0x000000018087FA20-0x000000018087FA90
		public override void WriteRaw(string json); // 0x00000001807930E0-0x0000000180793150
		public override void Close(); // 0x000000018087F730-0x000000018087F780
	}
}
