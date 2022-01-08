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
	public class BinaryConverter : JsonConverter // TypeDefIndex: 5511
	{
		// Fields
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private static ReflectionObject _reflectionObject; // 0x00
	
		// Constructors
		public BinaryConverter(); // 0x00000001802686E0-0x00000001802686F0
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer); // 0x00000001803C5380-0x00000001803C53F0
		private byte[] GetByteArray(object value); // 0x00000001803C4970-0x00000001803C4BC0
		private static void EnsureReflectionObject(System.Type t); // 0x00000001803C4790-0x00000001803C4970
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer); // 0x00000001803C4E50-0x00000001803C5380
		private byte[] ReadByteArray(JsonReader reader); // 0x00000001803C4BC0-0x00000001803C4E50
		public override bool CanConvert(System.Type objectType); // 0x00000001803C4660-0x00000001803C4790
	}
}
