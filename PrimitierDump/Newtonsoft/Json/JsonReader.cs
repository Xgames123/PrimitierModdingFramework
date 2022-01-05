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
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json
{
	[Nullable] // 0x0000000180015720-0x0000000180015760
	[NullableContext] // 0x0000000180015720-0x0000000180015760
	public abstract class JsonReader : IDisposable // TypeDefIndex: 5322
	{
		// Fields
		private JsonToken _tokenType; // 0x10
		private object _value; // 0x18
		internal char _quoteChar; // 0x20
		internal State _currentState; // 0x24
		private JsonPosition _currentPosition; // 0x28
		private CultureInfo _culture; // 0x40
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
		private int? _maxDepth; // 0x4C
		private bool _hasExceededMaxDepth; // 0x54
		internal DateParseHandling _dateParseHandling; // 0x58
		internal FloatParseHandling _floatParseHandling; // 0x5C
		private string _dateFormatString; // 0x60
		private List<JsonPosition> _stack; // 0x68
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _CloseInput_k__BackingField; // 0x70
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _SupportMultipleContent_k__BackingField; // 0x71
	
		// Properties
		protected State CurrentState { get; } // 0x000000018036C890-0x000000018036C8A0 
		public bool CloseInput { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018042B150-0x000000018042B160 0x000000018042B3B0-0x000000018042B3C0
		public bool SupportMultipleContent { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018042B380-0x000000018042B390 0x000000018042B5D0-0x000000018042B5E0
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x00000001802BC0B0-0x00000001802BC0C0 0x0000000180506BB0-0x0000000180506C20
		public DateParseHandling DateParseHandling { get; set; } // 0x000000018042B1C0-0x000000018042B1D0 0x0000000180506B40-0x0000000180506BB0
		public FloatParseHandling FloatParseHandling { get; set; } // 0x000000018030F320-0x000000018030F330 0x0000000180506C20-0x0000000180506C90
		public string DateFormatString { get; set; } // 0x00000001802C6D20-0x00000001802C6D30 0x000000018026C080-0x000000018026C090
		public int? MaxDepth { get; set; } // 0x000000018042B240-0x000000018042B250 0x0000000180506C90-0x0000000180506D50
		public virtual JsonToken TokenType { get; } // 0x0000000180260E80-0x0000000180260F00 
		public virtual object Value { get; } // 0x0000000180268C10-0x0000000180268C20 
		public virtual System.Type ValueType { get; } // 0x000000018042B390-0x000000018042B3B0 
		public virtual int Depth { get; } // 0x00000001805069A0-0x0000000180506A10 
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public virtual string Path { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; } // 0x0000000180506A10-0x0000000180506B40 
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public CultureInfo Culture { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ set; } // 0x0000000180506940-0x00000001805069A0 0x0000000180268390-0x00000001802683A0
	
		// Nested types
		[NullableContext] // 0x0000000180015700-0x0000000180015720
		protected internal enum State // TypeDefIndex: 5321
		{
			Start = 0,
			Complete = 1,
			Property = 2,
			ObjectStart = 3,
			Object = 4,
			ArrayStart = 5,
			Array = 6,
			Closed = 7,
			PostValue = 8,
			ConstructorStart = 9,
			Constructor = 10,
			Error = 11,
			Finished = 12
		}
	
		// Constructors
		protected JsonReader(); // 0x000000018042B120-0x000000018042B150
	
		// Methods
		internal JsonPosition GetPosition(int depth); // 0x0000000180501F40-0x0000000180501FF0
		private void Push(JsonContainerType value); // 0x0000000180502220-0x0000000180502480
		private JsonContainerType Pop(); // 0x0000000180502100-0x0000000180502220
		private JsonContainerType Peek(); // 0x00000001802B51E0-0x00000001802B51F0
		public abstract bool Read();
		public virtual int? ReadAsInt32(); // 0x0000000180504230-0x00000001805046E0
		internal int? ReadInt32String(string s); // 0x0000000180505CE0-0x0000000180505F50
		public virtual string ReadAsString(); // 0x00000001805046E0-0x00000001805049F0
		public virtual byte[] ReadAsBytes(); // 0x0000000180502C40-0x0000000180503230
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal byte[] ReadArrayIntoByteArray(); // 0x0000000180502700-0x0000000180502820
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer); // 0x00000001805024E0-0x0000000180502700
		public virtual double? ReadAsDouble(); // 0x0000000180503E20-0x0000000180504230
		internal double? ReadDoubleString(string s); // 0x00000001805056D0-0x0000000180505980
		public virtual bool? ReadAsBoolean(); // 0x0000000180502820-0x0000000180502C40
		internal bool? ReadBooleanString(string s); // 0x00000001805049F0-0x0000000180504C30
		public virtual decimal? ReadAsDecimal(); // 0x0000000180503900-0x0000000180503E20
		internal decimal? ReadDecimalString(string s); // 0x0000000180505310-0x00000001805056D0
		public virtual DateTime? ReadAsDateTime(); // 0x00000001805035C0-0x0000000180503900
		internal DateTime? ReadDateTimeString(string s); // 0x0000000180504FF0-0x0000000180505310
		public virtual DateTimeOffset? ReadAsDateTimeOffset(); // 0x0000000180503230-0x00000001805035C0
		internal DateTimeOffset? ReadDateTimeOffsetString(string s); // 0x0000000180504C30-0x0000000180504FF0
		internal void ReaderReadAndAssert(); // 0x0000000180506200-0x0000000180506250
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal JsonReaderException CreateUnexpectedEndException(); // 0x0000000180501E90-0x0000000180501ED0
		internal void ReadIntoWrappedTypeObject(); // 0x0000000180505F50-0x0000000180506200
		public void Skip(); // 0x000000018042ACD0-0x000000018042AD80
		protected void SetToken(JsonToken newToken); // 0x00000001805063F0-0x0000000180506410
		protected void SetToken(JsonToken newToken, object value); // 0x00000001805063D0-0x00000001805063F0
		protected void SetToken(JsonToken newToken, object value, bool updateIndex); // 0x0000000180506410-0x00000001805065B0
		internal void SetPostValueState(bool updateIndex); // 0x0000000180506270-0x00000001805062A0
		private void UpdateScopeWithFinishedValue(); // 0x000000018042ADF0-0x000000018042AE00
		private void ValidateEnd(JsonToken endToken); // 0x0000000180506620-0x0000000180506940
		protected void SetStateBasedOnCurrent(); // 0x00000001805062A0-0x00000001805063D0
		private void SetFinished(); // 0x0000000180506250-0x0000000180506270
		private JsonContainerType GetTypeForCloseToken(JsonToken token); // 0x0000000180501FF0-0x0000000180502100
		void IDisposable.Dispose(); // 0x00000001805065B0-0x0000000180506620
		protected virtual void Dispose(bool disposing); // 0x0000000180426BD0-0x0000000180426C00
		public virtual void Close(); // 0x0000000180426B70-0x0000000180426B90
		internal void ReadAndAssert(); // 0x0000000180502480-0x00000001805024E0
		internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter); // 0x0000000180505980-0x00000001805059D0
		internal bool ReadForType(JsonContract contract, bool hasConverter); // 0x00000001805059D0-0x0000000180505CE0
		internal bool ReadAndMoveToContent(); // 0x0000000180427310-0x0000000180427370
		internal bool MoveToContent(); // 0x0000000180426E30-0x0000000180426E90
		private JsonToken GetContentToken(); // 0x0000000180501ED0-0x0000000180501F40
	}
}
