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

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json
{
	public abstract class JsonReader : IDisposable // TypeDefIndex: 6957
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
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x00000001802BC0B0-0x00000001802BC0C0 0x000000018042B430-0x000000018042B4A0
		public DateParseHandling DateParseHandling { get; set; } // 0x000000018042B1C0-0x000000018042B1D0 0x000000018042B3C0-0x000000018042B430
		public FloatParseHandling FloatParseHandling { get; set; } // 0x000000018030F320-0x000000018030F330 0x000000018042B4A0-0x000000018042B510
		public string DateFormatString { get; set; } // 0x00000001802C6D20-0x00000001802C6D30 0x000000018026C080-0x000000018026C090
		public int? MaxDepth { get; set; } // 0x000000018042B240-0x000000018042B250 0x000000018042B510-0x000000018042B5D0
		public virtual JsonToken TokenType { get; } // 0x0000000180260E80-0x0000000180260F00 
		public virtual object Value { get; } // 0x0000000180268C10-0x0000000180268C20 
		public virtual System.Type ValueType { get; } // 0x000000018042B390-0x000000018042B3B0 
		public virtual int Depth { get; } // 0x000000018042B1D0-0x000000018042B240 
		public virtual string Path { get; } // 0x000000018042B250-0x000000018042B380 
		public CultureInfo Culture { get; set; } // 0x000000018042B160-0x000000018042B1C0 0x0000000180268390-0x00000001802683A0
	
		// Nested types
		protected internal enum State // TypeDefIndex: 6956
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
		internal JsonPosition GetPosition(int depth); // 0x0000000180426C70-0x0000000180426D20
		private void Push(JsonContainerType value); // 0x0000000180426FB0-0x00000001804272B0
		private JsonContainerType Pop(); // 0x0000000180426E90-0x0000000180426FB0
		private JsonContainerType Peek(); // 0x00000001802B51E0-0x00000001802B51F0
		public abstract bool Read();
		public virtual int? ReadAsInt32(); // 0x0000000180428E20-0x0000000180429180
		internal int? ReadInt32String(string s); // 0x000000018042A3F0-0x000000018042A660
		public virtual string ReadAsString(); // 0x0000000180429180-0x00000001804294F0
		public virtual byte[] ReadAsBytes(); // 0x00000001804279E0-0x0000000180427F80
		internal byte[] ReadArrayIntoByteArray(); // 0x0000000180427370-0x0000000180427660
		public virtual double? ReadAsDouble(); // 0x0000000180428A80-0x0000000180428E20
		internal double? ReadDoubleString(string s); // 0x000000018042A130-0x000000018042A3F0
		public virtual bool? ReadAsBoolean(); // 0x0000000180427660-0x00000001804279E0
		internal bool? ReadBooleanString(string s); // 0x00000001804294F0-0x0000000180429740
		public virtual decimal? ReadAsDecimal(); // 0x00000001804286C0-0x0000000180428A80
		internal decimal? ReadDecimalString(string s); // 0x0000000180429E40-0x000000018042A130
		public virtual DateTime? ReadAsDateTime(); // 0x0000000180428340-0x00000001804286C0
		internal DateTime? ReadDateTimeString(string s); // 0x0000000180429B10-0x0000000180429E40
		public virtual DateTimeOffset? ReadAsDateTimeOffset(); // 0x0000000180427F80-0x0000000180428340
		internal DateTimeOffset? ReadDateTimeOffsetString(string s); // 0x0000000180429740-0x0000000180429B10
		internal void ReaderReadAndAssert(); // 0x000000018042A920-0x000000018042A970
		internal JsonReaderException CreateUnexpectedEndException(); // 0x0000000180426B90-0x0000000180426BD0
		internal void ReadIntoWrappedTypeObject(); // 0x000000018042A660-0x000000018042A920
		public void Skip(); // 0x000000018042ACD0-0x000000018042AD80
		protected void SetToken(JsonToken newToken); // 0x000000018042ACB0-0x000000018042ACD0
		protected void SetToken(JsonToken newToken, object value); // 0x000000018042AC90-0x000000018042ACB0
		internal void SetToken(JsonToken newToken, object value, bool updateIndex); // 0x000000018042AAF0-0x000000018042AC90
		internal void SetPostValueState(bool updateIndex); // 0x000000018042A990-0x000000018042A9C0
		private void UpdateScopeWithFinishedValue(); // 0x000000018042ADF0-0x000000018042AE00
		private void ValidateEnd(JsonToken endToken); // 0x000000018042AE00-0x000000018042B120
		protected void SetStateBasedOnCurrent(); // 0x000000018042A9C0-0x000000018042AAF0
		private void SetFinished(); // 0x000000018042A970-0x000000018042A990
		private JsonContainerType GetTypeForCloseToken(JsonToken token); // 0x0000000180426D20-0x0000000180426E30
		void IDisposable.Dispose(); // 0x000000018042AD80-0x000000018042ADF0
		protected virtual void Dispose(bool disposing); // 0x0000000180426BD0-0x0000000180426C00
		public virtual void Close(); // 0x0000000180426B70-0x0000000180426B90
		internal void ReadAndAssert(); // 0x00000001804272B0-0x0000000180427310
		internal bool ReadAndMoveToContent(); // 0x0000000180427310-0x0000000180427370
		internal bool MoveToContent(); // 0x0000000180426E30-0x0000000180426E90
		private JsonToken GetContentToken(); // 0x0000000180426C00-0x0000000180426C70
	}
}
