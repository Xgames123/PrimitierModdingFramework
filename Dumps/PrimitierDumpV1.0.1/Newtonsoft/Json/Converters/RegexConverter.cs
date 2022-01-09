/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class RegexConverter : JsonConverter // TypeDefIndex: 5523
	{
		// Constructors
		public RegexConverter(); // 0x00000001802686E0-0x00000001802686F0
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer); // 0x00000001807903C0-0x0000000180790620
		private bool HasFlag(RegexOptions options, RegexOptions flag); // 0x0000000180432500-0x0000000180432510
		private void WriteBson(BsonWriter writer, Regex regex); // 0x00000001807900B0-0x00000001807901F0
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer); // 0x00000001807901F0-0x00000001807903C0
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer); // 0x000000018078FA80-0x000000018078FC70
		private object ReadRegexString(JsonReader reader); // 0x000000018078FF40-0x00000001807900B0
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer); // 0x000000018078FC70-0x000000018078FF40
		public override bool CanConvert(System.Type objectType); // 0x000000018078F970-0x000000018078FA00
		private bool IsRegex(System.Type objectType); // 0x000000018078FA00-0x000000018078FA80
	}
}
