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

namespace Valve.Newtonsoft.Json
{
	[Serializable]
	public class JsonSerializationException : JsonException // TypeDefIndex: 6960
	{
		// Constructors
		public JsonSerializationException(); // 0x0000000180424160-0x00000001804241C0
		public JsonSerializationException(string message); // 0x00000001804242C0-0x0000000180424330
		public JsonSerializationException(string message, Exception innerException); // 0x0000000180424240-0x00000001804242C0
		public JsonSerializationException(SerializationInfo info, StreamingContext context); // 0x00000001804241C0-0x0000000180424240
	
		// Methods
		internal static JsonSerializationException Create(JsonReader reader, string message); // 0x000000018042B680-0x000000018042B690
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex); // 0x000000018042B5E0-0x000000018042B680
		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex); // 0x000000018042B690-0x000000018042B780
	}
}
