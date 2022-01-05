/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal struct DateTimeParser // TypeDefIndex: 6994
	{
		// Fields
		public int Year; // 0x00
		public int Month; // 0x04
		public int Day; // 0x08
		public int Hour; // 0x0C
		public int Minute; // 0x10
		public int Second; // 0x14
		public int Fraction; // 0x18
		public int ZoneHour; // 0x1C
		public int ZoneMinute; // 0x20
		public ParserTimeZone Zone; // 0x24
		private char[] _text; // 0x28
		private int _end; // 0x30
		private static readonly int[] Power10; // 0x00
		private static readonly int Lzyyyy; // 0x08
		private static readonly int Lzyyyy_; // 0x0C
		private static readonly int Lzyyyy_MM; // 0x10
		private static readonly int Lzyyyy_MM_; // 0x14
		private static readonly int Lzyyyy_MM_dd; // 0x18
		private static readonly int Lzyyyy_MM_ddT; // 0x1C
		private static readonly int LzHH; // 0x20
		private static readonly int LzHH_; // 0x24
		private static readonly int LzHH_mm; // 0x28
		private static readonly int LzHH_mm_; // 0x2C
		private static readonly int LzHH_mm_ss; // 0x30
		private static readonly int Lz_; // 0x34
		private static readonly int Lz_zz; // 0x38
	
		// Constructors
		static DateTimeParser(); // 0x00000001803881D0-0x00000001803884C0
	
		// Methods
		public bool Parse(char[] text, int startIndex, int length); // 0x0000000180388090-0x00000001803881D0
		private bool ParseDate(int start); // 0x00000001803878E0-0x0000000180387B10
		private bool ParseTimeAndZoneAndWhitespace(int start); // 0x0000000180387B10-0x0000000180387B50
		private bool ParseTime(ref int start); // 0x0000000180387B50-0x0000000180387ED0
		private bool ParseZone(int start); // 0x0000000180387ED0-0x0000000180388090
		private bool Parse4Digit(int start, out int num); // 0x0000000180387750-0x0000000180387890
		private bool Parse2Digit(int start, out int num); // 0x00000001803876C0-0x0000000180387750
		private bool ParseChar(int start, char ch); // 0x0000000180387890-0x00000001803878E0
	}
}
