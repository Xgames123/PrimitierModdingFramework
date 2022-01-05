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
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 5522
	{
		// Fields
		private static readonly ThreadSafeStore<System.Type, ReflectionObject> ReflectionObjectPerType; // 0x00
	
		// Constructors
		public KeyValuePairConverter(); // 0x00000001802686E0-0x00000001802686F0
		static KeyValuePairConverter(); // 0x0000000180688A30-0x0000000180688B00
	
		// Methods
		private static ReflectionObject InitializeReflectionObject(System.Type t); // 0x0000000180687FC0-0x0000000180688240
		public override void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer); // 0x0000000180688730-0x0000000180688A30
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer); // 0x0000000180688240-0x0000000180688730
		public override bool CanConvert(System.Type objectType); // 0x0000000180687EB0-0x0000000180687FC0
	}
}
