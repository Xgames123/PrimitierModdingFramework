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
	public class JsonReaderException : JsonException // TypeDefIndex: 6958
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private int _LineNumber_k__BackingField; // 0x88
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private int _LinePosition_k__BackingField; // 0x8C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Path_k__BackingField; // 0x90
	
		// Properties
		private int LineNumber { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180426B50-0x0000000180426B60
		private int LinePosition { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180426B60-0x0000000180426B70
		private string Path { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804264C0-0x00000001804264D0
	
		// Constructors
		public JsonReaderException(); // 0x0000000180424160-0x00000001804241C0
		public JsonReaderException(SerializationInfo info, StreamingContext context); // 0x00000001804241C0-0x0000000180424240
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition); // 0x0000000180426AB0-0x0000000180426B50
	
		// Methods
		internal static JsonReaderException Create(JsonReader reader, string message); // 0x0000000180426900-0x0000000180426AB0
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex); // 0x00000001804265F0-0x00000001804267A0
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex); // 0x00000001804267A0-0x0000000180426900
	}
}
