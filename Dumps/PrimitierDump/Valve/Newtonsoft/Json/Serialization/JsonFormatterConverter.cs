/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 7067
	{
		// Fields
		private readonly JsonSerializerInternalReader _reader; // 0x10
		private readonly JsonISerializableContract _contract; // 0x18
		private readonly JsonProperty _member; // 0x20
	
		// Constructors
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member); // 0x0000000180424600-0x00000001804246A0
	
		// Methods
		private T GetTokenValue<T>(object value);
		public object Convert(object value, System.Type type); // 0x0000000180424340-0x0000000180424470
		public bool ToBoolean(object value); // 0x0000000180424470-0x00000001804244C0
		public int ToInt32(object value); // 0x00000001804244C0-0x0000000180424510
		public long ToInt64(object value); // 0x0000000180424510-0x0000000180424560
		public float ToSingle(object value); // 0x0000000180424560-0x00000001804245B0
		public string ToString(object value); // 0x00000001804245B0-0x0000000180424600
	}
}
