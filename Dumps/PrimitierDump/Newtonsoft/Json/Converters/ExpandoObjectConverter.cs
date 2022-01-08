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
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class ExpandoObjectConverter : JsonConverter // TypeDefIndex: 5521
	{
		// Properties
		public override bool CanWrite { get; } // 0x0000000180295620-0x0000000180295630 
	
		// Constructors
		public ExpandoObjectConverter(); // 0x00000001802686E0-0x00000001802686F0
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer); // 0x0000000180265310-0x0000000180265320
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer); // 0x00000001803DE710-0x00000001803DE720
		private object ReadValue(JsonReader reader); // 0x00000001803DEA00-0x00000001803DECB0
		private object ReadList(JsonReader reader); // 0x00000001803DE720-0x00000001803DE840
		private object ReadObject(JsonReader reader); // 0x00000001803DE840-0x00000001803DEA00
		public override bool CanConvert(System.Type objectType); // 0x00000001803DE690-0x00000001803DE710
	}
}
