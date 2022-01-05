/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 5459
	{
		// Fields
		private readonly JsonSerializerInternalReader _reader; // 0x10
		private readonly JsonISerializableContract _contract; // 0x18
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private readonly JsonProperty _member; // 0x20
	
		// Constructors
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member); // 0x00000001804C9410-0x00000001804C94B0
	
		// Methods
		private T GetTokenValue<T>(object value);
		public object Convert(object value, System.Type type); // 0x00000001804C9150-0x00000001804C9280
		public bool ToBoolean(object value); // 0x00000001804C9280-0x00000001804C92D0
		public int ToInt32(object value); // 0x00000001804C92D0-0x00000001804C9320
		public long ToInt64(object value); // 0x00000001804C9320-0x00000001804C9370
		public float ToSingle(object value); // 0x00000001804C9370-0x00000001804C93C0
		public string ToString(object value); // 0x00000001804C93C0-0x00000001804C9410
	}
}
