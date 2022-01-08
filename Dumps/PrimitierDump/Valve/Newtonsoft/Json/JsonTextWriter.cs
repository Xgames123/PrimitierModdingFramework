/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json
{
	public class JsonTextWriter : JsonWriter // TypeDefIndex: 6965
	{
		// Fields
		private readonly TextWriter _writer; // 0x60
		private Base64Encoder _base64Encoder; // 0x68
		private char _indentChar; // 0x70
		private int _indentation; // 0x74
		private char _quoteChar; // 0x78
		private bool _quoteName; // 0x7A
		private bool[] _charEscapeFlags; // 0x80
		private char[] _writeBuffer; // 0x88
		private IArrayPool<char> _arrayPool; // 0x90
		private char[] _indentChars; // 0x98
	
		// Properties
		private Base64Encoder Base64Encoder { get; } // 0x0000000180761620-0x0000000180761690 
		public char QuoteChar { get; } // 0x0000000180761690-0x00000001807616A0 
	
		// Constructors
		public JsonTextWriter(TextWriter textWriter); // 0x0000000180761530-0x0000000180761620
	
		// Methods
		public override void Close(); // 0x000000018075F890-0x000000018075F940
		public override void WriteStartObject(); // 0x0000000180760300-0x0000000180760350
		public override void WriteStartArray(); // 0x0000000180760200-0x0000000180760250
		public override void WriteStartConstructor(string name); // 0x0000000180760250-0x0000000180760300
		protected override void WriteEnd(JsonToken token); // 0x000000018075FAD0-0x000000018075FBD0
		public override void WritePropertyName(string name); // 0x0000000180760160-0x00000001807601D0
		public override void WritePropertyName(string name, bool escape); // 0x0000000180760080-0x0000000180760160
		internal override void OnStringEscapeHandlingChanged(); // 0x000000018075F980-0x000000018075F990
		private void UpdateCharEscapeFlags(); // 0x000000018075F990-0x000000018075FA10
		protected override void WriteIndent(); // 0x000000018075FCF0-0x000000018075FE20
		protected override void WriteValueDelimiter(); // 0x00000001807603F0-0x0000000180760420
		protected override void WriteIndentSpace(); // 0x000000018075FCC0-0x000000018075FCF0
		private void WriteValueInternal(string value, JsonToken token); // 0x00000001807601D0-0x0000000180760200
		public override void WriteNull(); // 0x000000018075FFE0-0x0000000180760080
		public override void WriteUndefined(); // 0x0000000180760350-0x00000001807603F0
		public override void WriteRaw(string json); // 0x00000001807601D0-0x0000000180760200
		public override void WriteValue(string value); // 0x00000001807607F0-0x00000001807608C0
		private void WriteEscapedString(string value, bool quote); // 0x000000018075FBD0-0x000000018075FCC0
		public override void WriteValue(int value); // 0x00000001807608C0-0x0000000180760900
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(uint value); // 0x0000000180760AE0-0x0000000180760B20
		public override void WriteValue(long value); // 0x0000000180760460-0x00000001807604A0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(ulong value); // 0x0000000180761060-0x00000001807610A0
		public override void WriteValue(float value); // 0x0000000180760900-0x00000001807609D0
		public override void WriteValue(float? value); // 0x0000000180760B20-0x0000000180760C20
		public override void WriteValue(double value); // 0x0000000180760EB0-0x0000000180760F80
		public override void WriteValue(double? value); // 0x00000001807609D0-0x0000000180760AE0
		public override void WriteValue(bool value); // 0x0000000180760CE0-0x0000000180760D80
		public override void WriteValue(short value); // 0x00000001807613F0-0x0000000180761430
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(ushort value); // 0x0000000180760E70-0x0000000180760EB0
		public override void WriteValue(char value); // 0x00000001807610A0-0x0000000180761140
		public override void WriteValue(byte value); // 0x0000000180760D80-0x0000000180760DC0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(sbyte value); // 0x0000000180760420-0x0000000180760460
		public override void WriteValue(decimal value); // 0x0000000180760DC0-0x0000000180760E70
		public override void WriteValue(DateTime value); // 0x0000000180760540-0x00000001807607F0
		public override void WriteValue(byte[] value); // 0x0000000180760F80-0x0000000180761060
		public override void WriteValue(DateTimeOffset value); // 0x0000000180761140-0x00000001807613F0
		public override void WriteValue(Guid value); // 0x0000000180761430-0x0000000180761530
		public override void WriteValue(TimeSpan value); // 0x00000001807604A0-0x0000000180760540
		public override void WriteValue(Uri value); // 0x0000000180760C20-0x0000000180760CE0
		public override void WriteComment(string text); // 0x000000018075FA10-0x000000018075FAD0
		private void EnsureWriteBuffer(); // 0x000000018075F940-0x000000018075F980
		private void WriteIntegerValue(long value); // 0x000000018075FF50-0x000000018075FFE0
		private void WriteIntegerValue(ulong uvalue); // 0x000000018075FE20-0x000000018075FF50
	}
}
