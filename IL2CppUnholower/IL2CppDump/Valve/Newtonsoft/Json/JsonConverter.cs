/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json
{
	public abstract class JsonConverter // TypeDefIndex: 6945
	{
		// Properties
		public virtual bool CanRead { get; } // 0x00000001802942D0-0x00000001802942E0 
		public virtual bool CanWrite { get; } // 0x00000001802942D0-0x00000001802942E0 
	
		// Constructors
		protected JsonConverter(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
		public abstract object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer);
		public abstract bool CanConvert(System.Type objectType);
	}
}
