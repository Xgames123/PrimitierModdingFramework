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
	public class JsonWriterException : JsonException // TypeDefIndex: 6969
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Path_k__BackingField; // 0x88
	
		// Properties
		private string Path { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802C46E0-0x00000001802C46F0
	
		// Constructors
		public JsonWriterException(); // 0x0000000180762B80-0x0000000180762B90
		public JsonWriterException(SerializationInfo info, StreamingContext context); // 0x0000000180762B60-0x0000000180762B80
		internal JsonWriterException(string message, Exception innerException, string path); // 0x0000000180762B30-0x0000000180762B60
	
		// Methods
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex); // 0x0000000180762A60-0x0000000180762B30
		internal static JsonWriterException Create(string path, string message, Exception ex); // 0x00000001807629A0-0x0000000180762A60
	}
}
