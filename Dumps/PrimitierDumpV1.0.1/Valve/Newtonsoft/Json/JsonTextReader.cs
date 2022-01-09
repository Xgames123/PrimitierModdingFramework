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
	public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 6964
	{
		// Fields
		private readonly TextReader _reader; // 0x78
		private char[] _chars; // 0x80
		private int _charsUsed; // 0x88
		private int _charPos; // 0x8C
		private int _lineStartPos; // 0x90
		private int _lineNumber; // 0x94
		private bool _isEndOfFile; // 0x98
		private StringBuffer _stringBuffer; // 0xA0
		private StringReference _stringReference; // 0xB0
		private IArrayPool<char> _arrayPool; // 0xC0
		internal PropertyNameTable NameTable; // 0xC8
	
		// Properties
		public int LineNumber { get; } // 0x000000018075F830-0x000000018075F880 
		public int LinePosition { get; } // 0x000000018075F880-0x000000018075F890 
	
		// Constructors
		public JsonTextReader(TextReader reader); // 0x000000018075F7B0-0x000000018075F830
	
		// Methods
		private void EnsureBufferNotEmpty(); // 0x0000000180757D50-0x0000000180757DB0
		private void OnNewLine(int pos); // 0x00000001807584E0-0x00000001807584F0
		private void ParseString(char quote, ReadType readType); // 0x000000018075AFD0-0x000000018075B370
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count); // 0x0000000180675B90-0x0000000180675BB0
		private void ShiftBufferIfNeeded(); // 0x000000018075F5E0-0x000000018075F6C0
		private int ReadData(bool append); // 0x000000018075D7C0-0x000000018075D7D0
		private int ReadData(bool append, int charsRequired); // 0x000000018075D520-0x000000018075D7C0
		private bool EnsureChars(int relativePosition, bool append); // 0x0000000180757E10-0x0000000180757EB0
		private bool ReadChars(int relativePosition, bool append); // 0x000000018075D490-0x000000018075D520
		public override bool Read(); // 0x000000018075F280-0x000000018075F5E0
		public override int? ReadAsInt32(); // 0x000000018075D3A0-0x000000018075D430
		public override DateTime? ReadAsDateTime(); // 0x000000018075D1C0-0x000000018075D260
		public override string ReadAsString(); // 0x000000018075D430-0x000000018075D490
		public override byte[] ReadAsBytes(); // 0x000000018075CB40-0x000000018075D120
		private object ReadStringValue(ReadType readType); // 0x000000018075E930-0x000000018075F280
		private JsonReaderException CreateUnexpectedCharacterException(char c); // 0x0000000180757B00-0x0000000180757BC0
		public override bool? ReadAsBoolean(); // 0x000000018075C2C0-0x000000018075CB40
		private void ProcessValueComma(); // 0x000000018075C260-0x000000018075C2C0
		private object ReadNumberValue(ReadType readType); // 0x000000018075DC20-0x000000018075E250
		public override DateTimeOffset? ReadAsDateTimeOffset(); // 0x000000018075D120-0x000000018075D1C0
		public override decimal? ReadAsDecimal(); // 0x000000018075D260-0x000000018075D300
		public override double? ReadAsDouble(); // 0x000000018075D300-0x000000018075D3A0
		private void HandleNull(); // 0x0000000180757EB0-0x0000000180757FE0
		private void ReadFinished(); // 0x000000018075D7D0-0x000000018075D950
		private bool ReadNullChar(); // 0x000000018075D950-0x000000018075D9A0
		private void EnsureBuffer(); // 0x0000000180757DB0-0x0000000180757E10
		private void ReadStringIntoBuffer(char quote); // 0x000000018075E250-0x000000018075E930
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition); // 0x000000018075F730-0x000000018075F7B0
		private char ParseUnicode(); // 0x000000018075B500-0x000000018075B610
		private void ReadNumberIntoBuffer(); // 0x000000018075D9A0-0x000000018075DC20
		private void ClearRecentString(); // 0x0000000180757A70-0x0000000180757A90
		private bool ParsePostValue(); // 0x000000018075A9A0-0x000000018075AC90
		private bool ParseObject(); // 0x000000018075A800-0x000000018075A9A0
		private bool ParseProperty(); // 0x000000018075AC90-0x000000018075AFD0
		private bool ValidIdentifierChar(char value); // 0x000000018075F6C0-0x000000018075F730
		private void ParseUnquotedProperty(); // 0x000000018075B610-0x000000018075B8B0
		private bool ParseValue(); // 0x000000018075B8B0-0x000000018075C1C0
		private void ProcessLineFeed(); // 0x000000018075C240-0x000000018075C260
		private void ProcessCarriageReturn(bool append); // 0x000000018075C1C0-0x000000018075C240
		private bool EatWhitespace(bool oneOrMore); // 0x0000000180757BC0-0x0000000180757D10
		private void ParseConstructor(); // 0x00000001807588C0-0x0000000180758D90
		private void ParseNumber(ReadType readType); // 0x0000000180759460-0x000000018075A800
		private void ParseComment(bool setToken); // 0x00000001807584F0-0x00000001807588C0
		private void EndComment(bool setToken, int initialPosition, int endPosition); // 0x0000000180757D10-0x0000000180757D50
		private bool MatchValue(string value); // 0x00000001807583F0-0x00000001807584E0
		private bool MatchValueWithTrailingSeparator(string value); // 0x0000000180758150-0x00000001807583F0
		private bool IsSeparator(char c); // 0x0000000180757FE0-0x0000000180758150
		private void ParseTrue(); // 0x000000018075B370-0x000000018075B450
		private void ParseNull(); // 0x0000000180758E70-0x0000000180758F20
		private void ParseUndefined(); // 0x000000018075B450-0x000000018075B500
		private void ParseFalse(); // 0x0000000180758D90-0x0000000180758E70
		private object ParseNumberNegativeInfinity(ReadType readType); // 0x00000001807590E0-0x00000001807592A0
		private object ParseNumberPositiveInfinity(ReadType readType); // 0x00000001807592A0-0x0000000180759460
		private object ParseNumberNaN(ReadType readType); // 0x0000000180758F20-0x00000001807590E0
		public override void Close(); // 0x0000000180757A90-0x0000000180757B00
		public bool HasLineInfo(); // 0x00000001802942D0-0x00000001802942E0
	}
}
