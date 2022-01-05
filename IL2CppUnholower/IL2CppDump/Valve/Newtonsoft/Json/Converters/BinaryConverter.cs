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
	public class BinaryConverter : JsonConverter // TypeDefIndex: 7114
	{
		// Fields
		private ReflectionObject _reflectionObject; // 0x10
	
		// Constructors
		public BinaryConverter(); // 0x00000001802686E0-0x00000001802686F0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180382660-0x00000001803826D0
		private byte[] GetByteArray(object value); // 0x0000000180381DD0-0x0000000180381F70
		private void EnsureReflectionObject(System.Type t); // 0x0000000180381C10-0x0000000180381DD0
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180382200-0x0000000180382660
		private byte[] ReadByteArray(JsonReader reader); // 0x0000000180381F70-0x0000000180382200
		public override bool CanConvert(System.Type objectType); // 0x0000000180381BC0-0x0000000180381C10
	}
}
