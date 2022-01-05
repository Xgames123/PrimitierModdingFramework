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
using System.Xml;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180017730-0x0000000180017770
	[NullableContext] // 0x0000000180017730-0x0000000180017770
	internal static class DateTimeUtils // TypeDefIndex: 5361
	{
		// Fields
		internal static readonly long InitialJavaScriptDateTicks; // 0x00
		private static readonly int[] DaysToMonth365; // 0x08
		private static readonly int[] DaysToMonth366; // 0x10
	
		// Constructors
		static DateTimeUtils(); // 0x00000001803D0B40-0x00000001803D0C20
	
		// Methods
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind); // 0x00000001803CDF70-0x00000001803CE020
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone); // 0x00000001803CDB70-0x00000001803CDD50
		private static DateTime SwitchToLocalTime(DateTime value); // 0x0000000180388CE0-0x0000000180388D50
		private static DateTime SwitchToUtcTime(DateTime value); // 0x0000000180388D50-0x0000000180388DD0
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset); // 0x00000001803CE020-0x00000001803CE140
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset); // 0x00000001803CD920-0x00000001803CDAE0
		private static long UniversialTicksToJavaScriptTicks(long universialTicks); // 0x00000001803CFB60-0x00000001803CFBE0
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks); // 0x00000001803CDAE0-0x00000001803CDB70
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt); // 0x00000001803CE240-0x00000001803CE6B0
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt); // 0x00000001803CE8F0-0x00000001803CEAA0
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser); // 0x0000000180388790-0x0000000180388890
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string dateFormatString, CultureInfo culture, out DateTime dt); // 0x00000001803CF490-0x00000001803CF6F0
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string dateFormatString, CultureInfo culture, out DateTime dt); // 0x00000001803CF190-0x00000001803CF490
		internal static bool TryParseDateTimeOffset(StringReference s, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x00000001803CEC20-0x00000001803CEE60
		internal static bool TryParseDateTimeOffset(string s, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x00000001803CEE60-0x00000001803CF190
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind); // 0x00000001803CF6F0-0x00000001803CF9E0
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt); // 0x00000001803CE6B0-0x00000001803CE830
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt); // 0x00000001803CE140-0x00000001803CE240
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt); // 0x00000001803CEAA0-0x00000001803CEC20
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt); // 0x00000001803CE830-0x00000001803CE8F0
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset); // 0x00000001803CF9E0-0x00000001803CFB60
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string formatString, CultureInfo culture); // 0x00000001803D04C0-0x00000001803D0620
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format); // 0x00000001803CFF30-0x00000001803D04C0
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt); // 0x00000001803D0620-0x00000001803D0B40
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits); // 0x0000000180388710-0x0000000180388790
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format); // 0x00000001803CFD80-0x00000001803CFF30
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string formatString, CultureInfo culture); // 0x00000001803CFBE0-0x00000001803CFD80
		private static void GetDateValues(DateTime td, out int year, out int month, out int day); // 0x00000001803CDD50-0x00000001803CDF40
	
		// Extension methods
		public static TimeSpan GetUtcOffset(this DateTime d); // 0x00000001803CDF40-0x00000001803CDF70
	}
}
