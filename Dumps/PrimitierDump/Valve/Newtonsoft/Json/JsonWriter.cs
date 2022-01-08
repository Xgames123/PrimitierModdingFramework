/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json
{
	public abstract class JsonWriter : IDisposable // TypeDefIndex: 6968
	{
		// Fields
		private static readonly State[][] StateArray; // 0x00
		internal static readonly State[][] StateArrayTempate; // 0x08
		private List<JsonPosition> _stack; // 0x10
		private JsonPosition _currentPosition; // 0x18
		private State _currentState; // 0x30
		private Formatting _formatting; // 0x34
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _CloseOutput_k__BackingField; // 0x38
		private DateFormatHandling _dateFormatHandling; // 0x3C
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
		private StringEscapeHandling _stringEscapeHandling; // 0x44
		private FloatFormatHandling _floatFormatHandling; // 0x48
		private string _dateFormatString; // 0x50
		private CultureInfo _culture; // 0x58
	
		// Properties
		public bool CloseOutput { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018030F460-0x000000018030F470 0x000000018030F6E0-0x000000018030F6F0
		protected internal int Top { get; } // 0x0000000180767970-0x00000001807679D0 
		public WriteState WriteState { get; } // 0x00000001807679D0-0x0000000180767AE0 
		internal string ContainerPath { get; } // 0x0000000180767720-0x00000001807677E0 
		public string Path { get; } // 0x0000000180767840-0x0000000180767970 
		public Formatting Formatting { get; set; } // 0x000000018030D190-0x000000018030D1A0 0x0000000180767C30-0x0000000180767CA0
		public DateFormatHandling DateFormatHandling { get; set; } // 0x00000001804FE280-0x00000001804FE290 0x0000000180767AE0-0x0000000180767B50
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x00000001802C6D30-0x00000001802C6D40 0x0000000180767B50-0x0000000180767BC0
		public StringEscapeHandling StringEscapeHandling { get; set; } // 0x00000001805B1C00-0x00000001805B1C10 0x0000000180767CA0-0x0000000180767D20
		public FloatFormatHandling FloatFormatHandling { get; set; } // 0x00000001802BC0B0-0x00000001802BC0C0 0x0000000180767BC0-0x0000000180767C30
		public string DateFormatString { get; set; } // 0x00000001802BC110-0x00000001802BC120 0x00000001803DFE50-0x00000001803DFE60
		public CultureInfo Culture { get; set; } // 0x00000001807677E0-0x0000000180767840 0x00000001802C6D60-0x00000001802C6D70
	
		// Nested types
		internal enum State // TypeDefIndex: 6967
		{
			Start = 0,
			Property = 1,
			ObjectStart = 2,
			Object = 3,
			ArrayStart = 4,
			Array = 5,
			ConstructorStart = 6,
			Constructor = 7,
			Closed = 8,
			Error = 9
		}
	
		// Constructors
		static JsonWriter(); // 0x0000000180766950-0x00000001807676F0
		protected JsonWriter(); // 0x00000001807676F0-0x0000000180767720
	
		// Methods
		internal static State[][] BuildStateArray(); // 0x0000000180763270-0x0000000180763600
		internal virtual void OnStringEscapeHandlingChanged(); // 0x0000000180265310-0x0000000180265320
		internal void UpdateScopeWithFinishedValue(); // 0x0000000180684410-0x0000000180684420
		private void Push(JsonContainerType value); // 0x00000001807639C0-0x0000000180763AB0
		private JsonContainerType Pop(); // 0x00000001807638C0-0x00000001807639C0
		private JsonContainerType Peek(); // 0x0000000180268FB0-0x0000000180268FC0
		public virtual void Close(); // 0x0000000180762B90-0x0000000180762C00
		public virtual void WriteStartObject(); // 0x0000000180764040-0x0000000180764050
		public virtual void WriteEndObject(); // 0x0000000180763DF0-0x0000000180763E00
		public virtual void WriteStartArray(); // 0x0000000180764020-0x0000000180764030
		public virtual void WriteEndArray(); // 0x0000000180763DD0-0x0000000180763DE0
		public virtual void WriteStartConstructor(string name); // 0x0000000180764030-0x0000000180764040
		public virtual void WriteEndConstructor(); // 0x0000000180763DE0-0x0000000180763DF0
		public virtual void WritePropertyName(string name); // 0x0000000180763780-0x0000000180763790
		public virtual void WritePropertyName(string name, bool escape); // 0x0000000180684740-0x0000000180684760
		public virtual void WriteEnd(); // 0x0000000180763ED0-0x0000000180763FB0
		public void WriteToken(JsonReader reader); // 0x0000000180764260-0x00000001807642E0
		public void WriteToken(JsonReader reader, bool writeChildren); // 0x00000001807642E0-0x0000000180764360
		public void WriteToken(JsonToken token, object value); // 0x0000000180764360-0x0000000180764BD0
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments); // 0x0000000180764050-0x0000000180764260
		private void WriteConstructorDate(JsonReader reader); // 0x0000000180763B20-0x0000000180763DD0
		private void WriteEnd(JsonContainerType type); // 0x0000000180763E00-0x0000000180763ED0
		private void AutoCompleteAll(); // 0x0000000180762B90-0x0000000180762C00
		private JsonToken GetCloseTokenForType(JsonContainerType type); // 0x00000001807636B0-0x0000000180763760
		private void AutoCompleteClose(JsonContainerType type); // 0x0000000180762C00-0x0000000180762FD0
		protected virtual void WriteEnd(JsonToken token); // 0x0000000180265310-0x0000000180265320
		protected virtual void WriteIndent(); // 0x0000000180265310-0x0000000180265320
		protected virtual void WriteValueDelimiter(); // 0x0000000180265310-0x0000000180265320
		protected virtual void WriteIndentSpace(); // 0x0000000180265310-0x0000000180265320
		internal void AutoComplete(JsonToken tokenBeingWritten); // 0x0000000180762FD0-0x0000000180763270
		public virtual void WriteNull(); // 0x0000000180763FB0-0x0000000180763FD0
		public virtual void WriteUndefined(); // 0x0000000180764BD0-0x0000000180764BF0
		public virtual void WriteRaw(string json); // 0x0000000180265310-0x0000000180265320
		public virtual void WriteRawValue(string json); // 0x0000000180763FD0-0x0000000180764020
		public virtual void WriteValue(string value); // 0x0000000180764C60-0x0000000180764C80
		public virtual void WriteValue(int value); // 0x0000000180764CC0-0x0000000180764CE0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(uint value); // 0x0000000180764CC0-0x0000000180764CE0
		public virtual void WriteValue(long value); // 0x0000000180764CC0-0x0000000180764CE0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(ulong value); // 0x0000000180764CC0-0x0000000180764CE0
		public virtual void WriteValue(float value); // 0x0000000180764CA0-0x0000000180764CC0
		public virtual void WriteValue(double value); // 0x0000000180764CA0-0x0000000180764CC0
		public virtual void WriteValue(bool value); // 0x0000000180766350-0x0000000180766370
		public virtual void WriteValue(short value); // 0x0000000180764CC0-0x0000000180764CE0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(ushort value); // 0x0000000180764CC0-0x0000000180764CE0
		public virtual void WriteValue(char value); // 0x0000000180764C60-0x0000000180764C80
		public virtual void WriteValue(byte value); // 0x0000000180764CC0-0x0000000180764CE0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(sbyte value); // 0x0000000180764CC0-0x0000000180764CE0
		public virtual void WriteValue(decimal value); // 0x0000000180764CA0-0x0000000180764CC0
		public virtual void WriteValue(DateTime value); // 0x0000000180764C80-0x0000000180764CA0
		public virtual void WriteValue(DateTimeOffset value); // 0x0000000180764C80-0x0000000180764CA0
		public virtual void WriteValue(Guid value); // 0x0000000180764C60-0x0000000180764C80
		public virtual void WriteValue(TimeSpan value); // 0x0000000180764C60-0x0000000180764C80
		public virtual void WriteValue(int? value); // 0x0000000180766370-0x00000001807663F0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(uint? value); // 0x0000000180766510-0x0000000180766590
		public virtual void WriteValue(long? value); // 0x00000001807668D0-0x0000000180766950
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(ulong? value); // 0x0000000180766590-0x0000000180766610
		public virtual void WriteValue(float? value); // 0x0000000180764BF0-0x0000000180764C60
		public virtual void WriteValue(double? value); // 0x0000000180766490-0x0000000180766510
		public virtual void WriteValue(bool? value); // 0x0000000180764EF0-0x0000000180764F70
		public virtual void WriteValue(short? value); // 0x0000000180764E70-0x0000000180764EF0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(ushort? value); // 0x0000000180766710-0x0000000180766790
		public virtual void WriteValue(char? value); // 0x0000000180766690-0x0000000180766710
		public virtual void WriteValue(byte? value); // 0x0000000180764CE0-0x0000000180764D60
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(sbyte? value); // 0x0000000180766610-0x0000000180766690
		public virtual void WriteValue(decimal? value); // 0x0000000180766790-0x0000000180766820
		public virtual void WriteValue(DateTime? value); // 0x0000000180766850-0x00000001807668D0
		public virtual void WriteValue(DateTimeOffset? value); // 0x00000001807662C0-0x0000000180766350
		public virtual void WriteValue(Guid? value); // 0x0000000180764D60-0x0000000180764DF0
		public virtual void WriteValue(TimeSpan? value); // 0x0000000180764DF0-0x0000000180764E70
		public virtual void WriteValue(byte[] value); // 0x0000000180766820-0x0000000180766850
		public virtual void WriteValue(Uri value); // 0x00000001807663F0-0x0000000180766490
		public virtual void WriteComment(string text); // 0x0000000180763760-0x0000000180763770
		void IDisposable.Dispose(); // 0x0000000180763AB0-0x0000000180763B20
		protected virtual void Dispose(bool disposing); // 0x0000000180683980-0x00000001806839B0
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value); // 0x0000000180764F70-0x00000001807662C0
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value); // 0x0000000180763600-0x00000001807636B0
		internal void InternalWriteEnd(JsonContainerType container); // 0x0000000180763770-0x0000000180763780
		internal void InternalWritePropertyName(string name); // 0x0000000180763780-0x0000000180763790
		internal void InternalWriteRaw(); // 0x0000000180265310-0x0000000180265320
		internal void InternalWriteStart(JsonToken token, JsonContainerType container); // 0x0000000180763790-0x00000001807638A0
		internal void InternalWriteValue(JsonToken token); // 0x00000001807638A0-0x00000001807638C0
		internal void InternalWriteComment(); // 0x0000000180763760-0x0000000180763770
	}
}
