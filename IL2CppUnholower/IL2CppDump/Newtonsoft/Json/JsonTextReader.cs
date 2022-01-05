/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
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
	public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5328
	{
		// Fields
		private readonly bool _safeAsync; // 0x78
		private readonly TextReader _reader; // 0x80
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private char[] _chars; // 0x88
		private int _charsUsed; // 0x90
		private int _charPos; // 0x94
		private int _lineStartPos; // 0x98
		private int _lineNumber; // 0x9C
		private bool _isEndOfFile; // 0xA0
		private StringBuffer _stringBuffer; // 0xA8
		private StringReference _stringReference; // 0xB8
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private IArrayPool<char> _arrayPool; // 0xC8
		[CompilerGenerated] // 0x0000000180017450-0x0000000180017480
		[Nullable] // 0x0000000180017450-0x0000000180017480
		private JsonNameTable _PropertyNameTable_k__BackingField; // 0xD0
	
		// Properties
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public JsonNameTable PropertyNameTable { [CompilerGenerated] /* 0x0000000180017480-0x00000001800174B0 */ [NullableContext] /* 0x0000000180017480-0x00000001800174B0 */ get; [NullableContext] /* 0x0000000180016840-0x0000000180016870 */ [CompilerGenerated] /* 0x0000000180016840-0x0000000180016870 */ set; } // 0x000000018031EBF0-0x000000018031EC00 0x000000018031EC50-0x000000018031EC60
		public int LineNumber { get; } // 0x000000018067E940-0x000000018067E990 
		public int LinePosition { get; } // 0x000000018067E990-0x000000018067E9A0 
	
		// Constructors
		public JsonTextReader(TextReader reader); // 0x000000018067E830-0x000000018067E940
	
		// Methods
		private void EnsureBufferNotEmpty(); // 0x00000001806760C0-0x0000000180676120
		private void SetNewLine(bool hasNextChar); // 0x000000018067E5A0-0x000000018067E610
		private void OnNewLine(int pos); // 0x0000000180676F40-0x0000000180676F50
		private void ParseString(char quote, ReadType readType); // 0x000000018067A570-0x000000018067A5D0
		private void ParseReadString(char quote, ReadType readType); // 0x000000018067A170-0x000000018067A570
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count); // 0x0000000180675B90-0x0000000180675BB0
		private void ShiftBufferIfNeeded(); // 0x000000018067E610-0x000000018067E6F0
		private int ReadData(bool append); // 0x000000018067C5C0-0x000000018067C5D0
		private void PrepareBufferForReadData(bool append, int charsRequired); // 0x000000018067B030-0x000000018067B220
		private int ReadData(bool append, int charsRequired); // 0x000000018067C500-0x000000018067C5C0
		private bool EnsureChars(int relativePosition, bool append); // 0x0000000180676180-0x00000001806762D0
		private bool ReadChars(int relativePosition, bool append); // 0x000000018067C3C0-0x000000018067C500
		public override bool Read(); // 0x000000018067E230-0x000000018067E5A0
		public override int? ReadAsInt32(); // 0x000000018067C2D0-0x000000018067C360
		public override DateTime? ReadAsDateTime(); // 0x000000018067C0F0-0x000000018067C190
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override string ReadAsString(); // 0x000000018067C360-0x000000018067C3C0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override byte[] ReadAsBytes(); // 0x000000018067BAA0-0x000000018067C050
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private object ReadStringValue(ReadType readType); // 0x000000018067D990-0x000000018067E050
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private object FinishReadQuotedStringValue(ReadType readType); // 0x0000000180676440-0x0000000180676700
		private JsonReaderException CreateUnexpectedCharacterException(char c); // 0x0000000180675E20-0x0000000180675EE0
		public override bool? ReadAsBoolean(); // 0x000000018067B340-0x000000018067BAA0
		private void ProcessValueComma(); // 0x000000018067B2C0-0x000000018067B340
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private object ReadNumberValue(ReadType readType); // 0x000000018067CBF0-0x000000018067D250
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private object FinishReadQuotedNumber(ReadType readType); // 0x00000001806762D0-0x0000000180676440
		public override DateTimeOffset? ReadAsDateTimeOffset(); // 0x000000018067C050-0x000000018067C0F0
		public override decimal? ReadAsDecimal(); // 0x000000018067C190-0x000000018067C230
		public override double? ReadAsDouble(); // 0x000000018067C230-0x000000018067C2D0
		private void HandleNull(); // 0x0000000180676820-0x0000000180676950
		private void ReadFinished(); // 0x000000018067C5D0-0x000000018067C750
		private bool ReadNullChar(); // 0x000000018067C750-0x000000018067C7A0
		private void EnsureBuffer(); // 0x0000000180676120-0x0000000180676180
		private void ReadStringIntoBuffer(char quote); // 0x000000018067D250-0x000000018067D990
		private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition); // 0x0000000180676700-0x0000000180676820
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition); // 0x000000018067E7B0-0x000000018067E830
		private char ConvertUnicode(bool enoughChars); // 0x0000000180675C50-0x0000000180675E20
		private char ParseUnicode(); // 0x000000018067A760-0x000000018067A790
		private void ReadNumberIntoBuffer(); // 0x000000018067C990-0x000000018067CBF0
		private bool ReadNumberCharIntoBuffer(char currentChar, int charPos); // 0x000000018067C7A0-0x000000018067C990
		private void ClearRecentString(); // 0x0000000180675BB0-0x0000000180675BD0
		private bool ParsePostValue(bool ignoreComments); // 0x0000000180678630-0x0000000180678970
		private bool ParseObject(); // 0x0000000180678490-0x0000000180678630
		private bool ParseProperty(); // 0x0000000180678970-0x0000000180678D90
		private bool ValidIdentifierChar(char value); // 0x000000018067E740-0x000000018067E7B0
		private void ParseUnquotedProperty(); // 0x000000018067A790-0x000000018067A8A0
		private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition); // 0x000000018067E050-0x000000018067E230
		private bool ParseValue(); // 0x000000018067A8A0-0x000000018067B030
		private void ProcessLineFeed(); // 0x000000018067B2A0-0x000000018067B2C0
		private void ProcessCarriageReturn(bool append); // 0x000000018067B220-0x000000018067B2A0
		private void EatWhitespace(); // 0x0000000180675EE0-0x0000000180676080
		private void ParseConstructor(); // 0x0000000180677320-0x00000001806777F0
		private void ParseNumber(ReadType readType); // 0x0000000180678400-0x0000000180678490
		private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition); // 0x0000000180678D90-0x000000018067A170
		private JsonReaderException ThrowReaderError(string message, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception ex = null); // 0x000000018067E6F0-0x000000018067E740
		private static object BigIntegerParse(string number, CultureInfo culture); // 0x0000000180675B00-0x0000000180675B90
		private void ParseComment(bool setToken); // 0x0000000180676F50-0x0000000180677320
		private void EndComment(bool setToken, int initialPosition, int endPosition); // 0x0000000180676080-0x00000001806760C0
		private bool MatchValue(string value); // 0x0000000180676E50-0x0000000180676F40
		private bool MatchValue(bool enoughChars, string value); // 0x0000000180676D60-0x0000000180676E50
		private bool MatchValueWithTrailingSeparator(string value); // 0x0000000180676AC0-0x0000000180676D60
		private bool IsSeparator(char c); // 0x0000000180676950-0x0000000180676AC0
		private void ParseTrue(); // 0x000000018067A5D0-0x000000018067A6B0
		private void ParseNull(); // 0x00000001806778D0-0x0000000180677980
		private void ParseUndefined(); // 0x000000018067A6B0-0x000000018067A760
		private void ParseFalse(); // 0x00000001806777F0-0x00000001806778D0
		private object ParseNumberNegativeInfinity(ReadType readType); // 0x0000000180677E90-0x0000000180678080
		private object ParseNumberNegativeInfinity(ReadType readType, bool matched); // 0x0000000180677D00-0x0000000180677E90
		private object ParseNumberPositiveInfinity(ReadType readType); // 0x0000000180678080-0x0000000180678270
		private object ParseNumberPositiveInfinity(ReadType readType, bool matched); // 0x0000000180678270-0x0000000180678400
		private object ParseNumberNaN(ReadType readType); // 0x0000000180677980-0x0000000180677B70
		private object ParseNumberNaN(ReadType readType, bool matched); // 0x0000000180677B70-0x0000000180677D00
		public override void Close(); // 0x0000000180675BD0-0x0000000180675C50
		public bool HasLineInfo(); // 0x00000001802942D0-0x00000001802942E0
	}
}
