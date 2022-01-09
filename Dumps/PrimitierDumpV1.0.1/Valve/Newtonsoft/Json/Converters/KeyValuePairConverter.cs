/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Converters
{
	public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 7116
	{
		// Fields
		private static readonly ThreadSafeStore<System.Type, ReflectionObject> ReflectionObjectPerType; // 0x00
	
		// Constructors
		public KeyValuePairConverter(); // 0x00000001802686E0-0x00000001802686F0
		static KeyValuePairConverter(); // 0x0000000180768700-0x00000001807687D0
	
		// Methods
		private static ReflectionObject InitializeReflectionObject(System.Type t); // 0x0000000180767E20-0x00000001807680A0
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180768490-0x0000000180768700
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer); // 0x00000001807680A0-0x0000000180768490
		public override bool CanConvert(System.Type objectType); // 0x0000000180767D20-0x0000000180767E20
	}
}
