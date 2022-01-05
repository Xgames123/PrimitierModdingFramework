/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Valve.Newtonsoft.Json;
using Valve.Newtonsoft.Json.Bson;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Converters
{
	public class RegexConverter : JsonConverter // TypeDefIndex: 7117
	{
		// Constructors
		public RegexConverter(); // 0x00000001802686E0-0x00000001802686F0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x000000018087E4C0-0x000000018087E6F0
		private bool HasFlag(RegexOptions options, RegexOptions flag); // 0x0000000180432500-0x0000000180432510
		private void WriteBson(BsonWriter writer, Regex regex); // 0x000000018087E1B0-0x000000018087E2F0
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer); // 0x000000018087E2F0-0x000000018087E4C0
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer); // 0x000000018087DB70-0x000000018087DD60
		private object ReadRegexString(JsonReader reader); // 0x000000018087E050-0x000000018087E1B0
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer); // 0x000000018087DD60-0x000000018087E050
		public override bool CanConvert(System.Type objectType); // 0x000000018087DAF0-0x000000018087DB70
	}
}
