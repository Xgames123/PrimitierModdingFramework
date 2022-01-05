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
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class JsonTextWriter : JsonWriter // TypeDefIndex: 5330
	{
		// Fields
		private readonly bool _safeAsync; // 0x60
		private readonly TextWriter _writer; // 0x68
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private Base64Encoder _base64Encoder; // 0x70
		private char _indentChar; // 0x78
		private int _indentation; // 0x7C
		private char _quoteChar; // 0x80
		private bool _quoteName; // 0x82
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private bool[] _charEscapeFlags; // 0x88
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private char[] _writeBuffer; // 0x90
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private IArrayPool<char> _arrayPool; // 0x98
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private char[] _indentChars; // 0xA0
	
		// Properties
		private Base64Encoder Base64Encoder { get; } // 0x00000001806814E0-0x0000000180681550 
		public char QuoteChar { get; } // 0x0000000180681550-0x0000000180681560 
	
		// Constructors
		public JsonTextWriter(TextWriter textWriter); // 0x0000000180681370-0x00000001806814E0
	
		// Methods
		public override void Close(); // 0x000000018067EA00-0x000000018067EAB0
		private void CloseBufferAndWriter(); // 0x000000018067E9A0-0x000000018067EA00
		public override void WriteStartObject(); // 0x000000018067FA90-0x000000018067FAE0
		public override void WriteStartArray(); // 0x000000018067F990-0x000000018067F9E0
		public override void WriteStartConstructor(string name); // 0x000000018067F9E0-0x000000018067FA90
		protected override void WriteEnd(JsonToken token); // 0x000000018067ED50-0x000000018067EE80
		public override void WritePropertyName(string name); // 0x000000018067F800-0x000000018067F870
		public override void WritePropertyName(string name, bool escape); // 0x000000018067F870-0x000000018067F960
		internal override void OnStringEscapeHandlingChanged(); // 0x000000018067EAF0-0x000000018067EB00
		private void UpdateCharEscapeFlags(); // 0x000000018067EC10-0x000000018067EC90
		protected override void WriteIndent(); // 0x000000018067EFA0-0x000000018067F1E0
		private int SetIndentChars(); // 0x000000018067EB00-0x000000018067EC10
		protected override void WriteValueDelimiter(); // 0x000000018067FB80-0x000000018067FBB0
		protected override void WriteIndentSpace(); // 0x000000018067EF70-0x000000018067EFA0
		private void WriteValueInternal(string value, JsonToken token); // 0x000000018067F960-0x000000018067F990
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteValue(object value); // 0x0000000180680080-0x00000001806802F0
		public override void WriteNull(); // 0x000000018067F540-0x000000018067F5E0
		public override void WriteUndefined(); // 0x000000018067FAE0-0x000000018067FB80
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteRaw(string json); // 0x000000018067F960-0x000000018067F990
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteValue(string value); // 0x000000018067FFB0-0x0000000180680080
		private void WriteEscapedString(string value, bool quote); // 0x000000018067EE80-0x000000018067EF70
		public override void WriteValue(int value); // 0x00000001806807D0-0x0000000180680810
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(uint value); // 0x00000001806812F0-0x0000000180681370
		public override void WriteValue(long value); // 0x0000000180681260-0x00000001806812F0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(ulong value); // 0x00000001806802F0-0x0000000180680330
		public override void WriteValue(float value); // 0x0000000180680DD0-0x0000000180680EA0
		public override void WriteValue(float? value); // 0x000000018067FEB0-0x000000018067FFB0
		public override void WriteValue(double value); // 0x0000000180680660-0x0000000180680730
		public override void WriteValue(double? value); // 0x0000000180680510-0x0000000180680620
		public override void WriteValue(bool value); // 0x00000001806803F0-0x0000000180680490
		public override void WriteValue(short value); // 0x0000000180680810-0x0000000180680850
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(ushort value); // 0x0000000180680490-0x00000001806804D0
		public override void WriteValue(char value); // 0x0000000180680730-0x00000001806807D0
		public override void WriteValue(byte value); // 0x00000001806804D0-0x0000000180680510
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(sbyte value); // 0x0000000180680620-0x0000000180680660
		public override void WriteValue(decimal value); // 0x0000000180680D20-0x0000000180680DD0
		public override void WriteValue(DateTime value); // 0x0000000180680A30-0x0000000180680D20
		private int WriteValueToBuffer(DateTime value); // 0x000000018067FBB0-0x000000018067FD20
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteValue(byte[] value); // 0x0000000180680850-0x0000000180680940
		public override void WriteValue(DateTimeOffset value); // 0x0000000180680FA0-0x0000000180681260
		private int WriteValueToBuffer(DateTimeOffset value); // 0x000000018067FD20-0x000000018067FEB0
		public override void WriteValue(Guid value); // 0x0000000180680EA0-0x0000000180680FA0
		public override void WriteValue(TimeSpan value); // 0x0000000180680940-0x0000000180680A30
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteValue(Uri value); // 0x0000000180680330-0x00000001806803F0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void WriteComment(string text); // 0x000000018067EC90-0x000000018067ED50
		private void EnsureWriteBuffer(); // 0x000000018067EAB0-0x000000018067EAF0
		private void WriteIntegerValue(long value); // 0x000000018067F4E0-0x000000018067F540
		private void WriteIntegerValue(ulong value, bool negative); // 0x000000018067F1E0-0x000000018067F380
		private int WriteNumberToBuffer(ulong value, bool negative); // 0x000000018067F5E0-0x000000018067F710
		private void WriteIntegerValue(int value); // 0x000000018067F380-0x000000018067F450
		private void WriteIntegerValue(uint value, bool negative); // 0x000000018067F450-0x000000018067F4E0
		private int WriteNumberToBuffer(uint value, bool negative); // 0x000000018067F710-0x000000018067F800
	}
}
