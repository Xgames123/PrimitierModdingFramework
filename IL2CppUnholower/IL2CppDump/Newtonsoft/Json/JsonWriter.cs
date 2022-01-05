/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
	public abstract class JsonWriter : IDisposable // TypeDefIndex: 5333
	{
		// Fields
		private static readonly State[][] StateArray; // 0x00
		internal static readonly State[][] StateArrayTempate; // 0x08
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private List<JsonPosition> _stack; // 0x10
		private JsonPosition _currentPosition; // 0x18
		private State _currentState; // 0x30
		private Formatting _formatting; // 0x34
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _CloseOutput_k__BackingField; // 0x38
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _AutoCompleteOnClose_k__BackingField; // 0x39
		private DateFormatHandling _dateFormatHandling; // 0x3C
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
		private StringEscapeHandling _stringEscapeHandling; // 0x44
		private FloatFormatHandling _floatFormatHandling; // 0x48
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private string _dateFormatString; // 0x50
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private CultureInfo _culture; // 0x58
	
		// Properties
		public bool CloseOutput { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018030F460-0x000000018030F470 0x000000018030F6E0-0x000000018030F6F0
		public bool AutoCompleteOnClose { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803AE130-0x00000001803AE140 0x0000000180687C60-0x0000000180687C70
		protected internal int Top { get; } // 0x0000000180687AB0-0x0000000180687B10 
		public WriteState WriteState { get; } // 0x0000000180687B10-0x0000000180687C60 
		internal string ContainerPath { get; } // 0x0000000180687860-0x0000000180687920 
		public string Path { get; } // 0x0000000180687980-0x0000000180687AB0 
		public Formatting Formatting { get; set; } // 0x000000018030D190-0x000000018030D1A0 0x0000000180687DC0-0x0000000180687E30
		public DateFormatHandling DateFormatHandling { get; set; } // 0x00000001804FE280-0x00000001804FE290 0x0000000180687C70-0x0000000180687CE0
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x00000001802C6D30-0x00000001802C6D40 0x0000000180687CE0-0x0000000180687D50
		public StringEscapeHandling StringEscapeHandling { get; set; } // 0x00000001805B1C00-0x00000001805B1C10 0x0000000180687E30-0x0000000180687EB0
		public FloatFormatHandling FloatFormatHandling { get; set; } // 0x00000001802BC0B0-0x00000001802BC0C0 0x0000000180687D50-0x0000000180687DC0
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public string DateFormatString { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ set; } // 0x00000001802BC110-0x00000001802BC120 0x00000001803DFE50-0x00000001803DFE60
		public CultureInfo Culture { get; set; } // 0x0000000180687920-0x0000000180687980 0x00000001802C6D60-0x00000001802C6D70
	
		// Nested types
		[NullableContext] // 0x0000000180015700-0x0000000180015720
		internal enum State // TypeDefIndex: 5332
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
		static JsonWriter(); // 0x00000001806873B0-0x0000000180687830
		protected JsonWriter(); // 0x0000000180687830-0x0000000180687860
	
		// Methods
		internal static State[][] BuildStateArray(); // 0x00000001806833E0-0x0000000180683610
		internal virtual void OnStringEscapeHandlingChanged(); // 0x0000000180265310-0x0000000180265320
		internal void UpdateScopeWithFinishedValue(); // 0x0000000180684410-0x0000000180684420
		private void Push(JsonContainerType value); // 0x0000000180683DC0-0x0000000180683EB0
		private JsonContainerType Pop(); // 0x0000000180683CC0-0x0000000180683DC0
		private JsonContainerType Peek(); // 0x0000000180268FB0-0x0000000180268FC0
		public virtual void Close(); // 0x0000000180683860-0x00000001806838D0
		public virtual void WriteStartObject(); // 0x00000001806847D0-0x00000001806847E0
		public virtual void WriteEndObject(); // 0x0000000180684500-0x0000000180684510
		public virtual void WriteStartArray(); // 0x00000001806847B0-0x00000001806847C0
		public virtual void WriteEndArray(); // 0x00000001806844E0-0x00000001806844F0
		public virtual void WriteStartConstructor(string name); // 0x00000001806847C0-0x00000001806847D0
		public virtual void WriteEndConstructor(); // 0x00000001806844F0-0x0000000180684500
		public virtual void WritePropertyName(string name); // 0x0000000180683AB0-0x0000000180683AC0
		public virtual void WritePropertyName(string name, bool escape); // 0x0000000180684740-0x0000000180684760
		public virtual void WriteEnd(); // 0x0000000180684510-0x0000000180684620
		public void WriteToken(JsonReader reader); // 0x00000001806847E0-0x0000000180684860
		public void WriteToken(JsonReader reader, bool writeChildren); // 0x0000000180684860-0x00000001806848E0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public void WriteToken(JsonToken token, object value); // 0x0000000180684C20-0x0000000180685520
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments); // 0x00000001806848E0-0x0000000180684C20
		private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth); // 0x0000000180683BF0-0x0000000180683CC0
		private int CalculateWriteTokenInitialDepth(JsonReader reader); // 0x00000001806837F0-0x0000000180683860
		private int CalculateWriteTokenFinalDepth(JsonReader reader); // 0x0000000180683780-0x00000001806837F0
		private void WriteConstructorDate(JsonReader reader); // 0x0000000180684420-0x00000001806844E0
		private void WriteEnd(JsonContainerType type); // 0x0000000180684620-0x0000000180684720
		private void AutoCompleteAll(); // 0x0000000180682D80-0x0000000180682DF0
		private JsonToken GetCloseTokenForType(JsonContainerType type); // 0x00000001806839B0-0x0000000180683A90
		private void AutoCompleteClose(JsonContainerType type); // 0x0000000180682DF0-0x0000000180683140
		private int CalculateLevelsToComplete(JsonContainerType type); // 0x0000000180683610-0x0000000180683780
		private void UpdateCurrentState(); // 0x0000000180684320-0x0000000180684410
		protected virtual void WriteEnd(JsonToken token); // 0x0000000180265310-0x0000000180265320
		protected virtual void WriteIndent(); // 0x0000000180265310-0x0000000180265320
		protected virtual void WriteValueDelimiter(); // 0x0000000180265310-0x0000000180265320
		protected virtual void WriteIndentSpace(); // 0x0000000180265310-0x0000000180265320
		internal void AutoComplete(JsonToken tokenBeingWritten); // 0x0000000180683140-0x00000001806833E0
		public virtual void WriteNull(); // 0x0000000180684720-0x0000000180684740
		public virtual void WriteUndefined(); // 0x0000000180685520-0x0000000180685540
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public virtual void WriteRaw(string json); // 0x0000000180265310-0x0000000180265320
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public virtual void WriteRawValue(string json); // 0x0000000180684760-0x00000001806847B0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public virtual void WriteValue(string value); // 0x00000001806855D0-0x00000001806855F0
		public virtual void WriteValue(int value); // 0x0000000180686A30-0x0000000180686A50
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(uint value); // 0x0000000180686A30-0x0000000180686A50
		public virtual void WriteValue(long value); // 0x0000000180686A30-0x0000000180686A50
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(ulong value); // 0x0000000180686A30-0x0000000180686A50
		public virtual void WriteValue(float value); // 0x0000000180686A10-0x0000000180686A30
		public virtual void WriteValue(double value); // 0x0000000180686A10-0x0000000180686A30
		public virtual void WriteValue(bool value); // 0x00000001806871E0-0x0000000180687200
		public virtual void WriteValue(short value); // 0x0000000180686A30-0x0000000180686A50
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(ushort value); // 0x0000000180686A30-0x0000000180686A50
		public virtual void WriteValue(char value); // 0x00000001806855D0-0x00000001806855F0
		public virtual void WriteValue(byte value); // 0x0000000180686A30-0x0000000180686A50
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(sbyte value); // 0x0000000180686A30-0x0000000180686A50
		public virtual void WriteValue(decimal value); // 0x0000000180686A10-0x0000000180686A30
		public virtual void WriteValue(DateTime value); // 0x0000000180686E50-0x0000000180686E70
		public virtual void WriteValue(DateTimeOffset value); // 0x0000000180686E50-0x0000000180686E70
		public virtual void WriteValue(Guid value); // 0x00000001806855D0-0x00000001806855F0
		public virtual void WriteValue(TimeSpan value); // 0x00000001806855D0-0x00000001806855F0
		public virtual void WriteValue(int? value); // 0x0000000180686E70-0x0000000180686EF0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(uint? value); // 0x0000000180686F60-0x0000000180686FE0
		public virtual void WriteValue(long? value); // 0x0000000180686910-0x0000000180686990
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(ulong? value); // 0x0000000180687060-0x00000001806870E0
		public virtual void WriteValue(float? value); // 0x0000000180686EF0-0x0000000180686F60
		public virtual void WriteValue(double? value); // 0x00000001806870E0-0x0000000180687160
		public virtual void WriteValue(bool? value); // 0x0000000180686990-0x0000000180686A10
		public virtual void WriteValue(short? value); // 0x0000000180686BD0-0x0000000180686C50
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(ushort? value); // 0x0000000180686FE0-0x0000000180687060
		public virtual void WriteValue(char? value); // 0x0000000180686AD0-0x0000000180686B50
		public virtual void WriteValue(byte? value); // 0x0000000180686B50-0x0000000180686BD0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public virtual void WriteValue(sbyte? value); // 0x0000000180687160-0x00000001806871E0
		public virtual void WriteValue(decimal? value); // 0x00000001806872A0-0x0000000180687330
		public virtual void WriteValue(DateTime? value); // 0x0000000180686A50-0x0000000180686AD0
		public virtual void WriteValue(DateTimeOffset? value); // 0x0000000180685540-0x00000001806855D0
		public virtual void WriteValue(Guid? value); // 0x0000000180686C50-0x0000000180686CE0
		public virtual void WriteValue(TimeSpan? value); // 0x0000000180687330-0x00000001806873B0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public virtual void WriteValue(byte[] value); // 0x00000001806855F0-0x0000000180685620
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public virtual void WriteValue(Uri value); // 0x0000000180687200-0x00000001806872A0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public virtual void WriteValue(object value); // 0x0000000180686CE0-0x0000000180686E50
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public virtual void WriteComment(string text); // 0x0000000180683A90-0x0000000180683AA0
		void IDisposable.Dispose(); // 0x00000001806842B0-0x0000000180684320
		protected virtual void Dispose(bool disposing); // 0x0000000180683980-0x00000001806839B0
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value); // 0x0000000180685620-0x0000000180686910
		private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value); // 0x0000000180683EB0-0x0000000180684060
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value); // 0x00000001806838D0-0x0000000180683980
		protected void SetWriteState(JsonToken token, object value); // 0x0000000180684060-0x00000001806842B0
		internal void InternalWriteEnd(JsonContainerType container); // 0x0000000180683AA0-0x0000000180683AB0
		internal void InternalWritePropertyName(string name); // 0x0000000180683AB0-0x0000000180683AC0
		internal void InternalWriteRaw(); // 0x0000000180265310-0x0000000180265320
		internal void InternalWriteStart(JsonToken token, JsonContainerType container); // 0x0000000180683AC0-0x0000000180683BD0
		internal void InternalWriteValue(JsonToken token); // 0x0000000180683BD0-0x0000000180683BF0
		internal void InternalWriteComment(); // 0x0000000180683A90-0x0000000180683AA0
	}
}
