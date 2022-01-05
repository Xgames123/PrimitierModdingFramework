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
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class JsonReaderException : JsonException // TypeDefIndex: 5323
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly int _LineNumber_k__BackingField; // 0x88
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly int _LinePosition_k__BackingField; // 0x8C
		[CompilerGenerated] // 0x0000000180015E50-0x0000000180015E80
		[Nullable] // 0x0000000180015E50-0x0000000180015E80
		private readonly string _Path_k__BackingField; // 0x90
	
		// Constructors
		public JsonReaderException(); // 0x0000000180501E80-0x0000000180501E90
		public JsonReaderException(SerializationInfo info, StreamingContext context); // 0x0000000180501E60-0x0000000180501E80
		public JsonReaderException(string message, string path, int lineNumber, int linePosition, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception innerException); // 0x0000000180501E10-0x0000000180501E60
	
		// Methods
		internal static JsonReaderException Create(JsonReader reader, string message); // 0x0000000180501CD0-0x0000000180501CE0
		internal static JsonReaderException Create(JsonReader reader, string message, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception ex); // 0x0000000180501B50-0x0000000180501CD0
		internal static JsonReaderException Create([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ IJsonLineInfo lineInfo, string path, string message, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception ex); // 0x0000000180501CE0-0x0000000180501E10
	}
}
