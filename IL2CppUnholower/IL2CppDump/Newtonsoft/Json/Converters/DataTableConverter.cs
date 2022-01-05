/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class DataTableConverter : JsonConverter // TypeDefIndex: 5514
	{
		// Constructors
		public DataTableConverter(); // 0x00000001802686E0-0x00000001802686F0
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer); // 0x00000001803CC790-0x00000001803CCD40
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer); // 0x00000001803CC430-0x00000001803CC790
		private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer); // 0x00000001803CBD40-0x00000001803CC200
		private static System.Type GetColumnDataType(JsonReader reader); // 0x00000001803CC200-0x00000001803CC430
		public override bool CanConvert(System.Type valueType); // 0x00000001803CBCB0-0x00000001803CBD40
	}
}
