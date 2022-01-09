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

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public abstract class JsonConverter // TypeDefIndex: 5309
	{
		// Properties
		public virtual bool CanRead { get; } // 0x00000001802942D0-0x00000001802942E0 
		public virtual bool CanWrite { get; } // 0x00000001802942D0-0x00000001802942E0 
	
		// Constructors
		protected JsonConverter(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public abstract void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer);
		public abstract object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer);
		public abstract bool CanConvert(System.Type objectType);
	}
}
