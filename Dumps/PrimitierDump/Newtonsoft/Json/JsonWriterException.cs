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

namespace Newtonsoft.Json
{
	[Serializable]
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class JsonWriterException : JsonException // TypeDefIndex: 5334
	{
		// Fields
		[CompilerGenerated] // 0x0000000180015E50-0x0000000180015E80
		[Nullable] // 0x0000000180015E50-0x0000000180015E80
		private readonly string _Path_k__BackingField; // 0x88
	
		// Constructors
		public JsonWriterException(); // 0x0000000180501E80-0x0000000180501E90
		public JsonWriterException(SerializationInfo info, StreamingContext context); // 0x0000000180501E60-0x0000000180501E80
		public JsonWriterException(string message, string path, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception innerException); // 0x0000000180682D50-0x0000000180682D80
	
		// Methods
		internal static JsonWriterException Create(JsonWriter writer, string message, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception ex); // 0x0000000180682BE0-0x0000000180682D50
		internal static JsonWriterException Create(string path, string message, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception ex); // 0x0000000180682B20-0x0000000180682BE0
	}
}
