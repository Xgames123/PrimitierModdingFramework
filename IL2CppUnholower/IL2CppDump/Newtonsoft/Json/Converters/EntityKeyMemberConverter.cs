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
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class EntityKeyMemberConverter : JsonConverter // TypeDefIndex: 5520
	{
		// Fields
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private static ReflectionObject _reflectionObject; // 0x00
	
		// Constructors
		public EntityKeyMemberConverter(); // 0x00000001802686E0-0x00000001802686F0
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer); // 0x00000001803DC840-0x00000001803DCBC0
		private static void ReadAndAssertProperty(JsonReader reader, string propertyName); // 0x00000001803DC480-0x00000001803DC5B0
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer); // 0x00000001803DC5B0-0x00000001803DC840
		private static void EnsureReflectionObject(System.Type objectType); // 0x00000001803DC320-0x00000001803DC480
		public override bool CanConvert(System.Type objectType); // 0x00000001803DC2E0-0x00000001803DC320
	}
}
