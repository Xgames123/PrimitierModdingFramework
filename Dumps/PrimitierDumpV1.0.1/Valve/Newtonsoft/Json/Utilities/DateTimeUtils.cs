/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal static class DateTimeUtils // TypeDefIndex: 6995
	{
		// Fields
		internal static readonly long InitialJavaScriptDateTicks; // 0x00
		private static readonly int[] DaysToMonth365; // 0x08
		private static readonly int[] DaysToMonth366; // 0x10
	
		// Constructors
		static DateTimeUtils(); // 0x000000018038B890-0x000000018038B970
	
		// Methods
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone); // 0x0000000180388890-0x0000000180388A70
		private static DateTime SwitchToLocalTime(DateTime value); // 0x0000000180388CE0-0x0000000180388D50
		private static DateTime SwitchToUtcTime(DateTime value); // 0x0000000180388D50-0x0000000180388DD0
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset); // 0x0000000180388DD0-0x0000000180388EF0
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset); // 0x00000001803884C0-0x0000000180388680
		private static long UniversialTicksToJavaScriptTicks(long universialTicks); // 0x000000018038A8E0-0x000000018038A960
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks); // 0x0000000180388680-0x0000000180388710
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt); // 0x0000000180388FF0-0x0000000180389430
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt); // 0x0000000180389670-0x0000000180389820
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser); // 0x0000000180388790-0x0000000180388890
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x0000000180389F10-0x000000018038A170
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x000000018038A170-0x000000018038A470
		internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x00000001803899A0-0x0000000180389BE0
		internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x0000000180389BE0-0x0000000180389F10
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind); // 0x000000018038A470-0x000000018038A760
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt); // 0x0000000180389430-0x00000001803895B0
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x0000000180388EF0-0x0000000180388FF0
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt); // 0x0000000180389820-0x00000001803899A0
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x00000001803895B0-0x0000000180389670
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset); // 0x000000018038A760-0x000000018038A8E0
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture); // 0x000000018038B210-0x000000018038B370
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format); // 0x000000018038ACB0-0x000000018038B210
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt); // 0x000000018038B370-0x000000018038B890
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits); // 0x0000000180388710-0x0000000180388790
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format); // 0x000000018038AB00-0x000000018038ACB0
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture); // 0x000000018038A960-0x000000018038AB00
		private static void GetDateValues(DateTime td, out int year, out int month, out int day); // 0x0000000180388A70-0x0000000180388C60
	
		// Extension methods
		public static TimeSpan GetUtcOffset(this DateTime d); // 0x0000000180388C60-0x0000000180388CE0
	}
}
