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
[assembly: AssemblyCompany] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyConfiguration] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyCopyright] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyDelaySign] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyDescription] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyFileVersion] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyInformationalVersion] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyKeyFile] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyProduct] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyTitle] // 0x00000001800161D0-0x00000001800164B0
[assembly: AssemblyTrademark] // 0x00000001800161D0-0x00000001800164B0
[assembly: CLSCompliant] // 0x00000001800161D0-0x00000001800164B0
[assembly: CompilationRelaxations] // 0x00000001800161D0-0x00000001800164B0
[assembly: ComVisible] // 0x00000001800161D0-0x00000001800164B0
[assembly: Debuggable] // 0x00000001800161D0-0x00000001800164B0
[assembly: Guid] // 0x00000001800161D0-0x00000001800164B0
[assembly: InternalsVisibleTo] // 0x00000001800161D0-0x00000001800164B0
[assembly: InternalsVisibleTo] // 0x00000001800161D0-0x00000001800164B0
[assembly: InternalsVisibleTo] // 0x00000001800161D0-0x00000001800164B0
[assembly: NeutralResourcesLanguage] // 0x00000001800161D0-0x00000001800164B0
[assembly: RuntimeCompatibility] // 0x00000001800161D0-0x00000001800164B0
[assembly: TargetFramework] // 0x00000001800161D0-0x00000001800164B0

namespace Newtonsoft.Json
{
	[Serializable]
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class JsonSerializationException : JsonException // TypeDefIndex: 5325
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
		public JsonSerializationException(); // 0x0000000180501E80-0x0000000180501E90
		public JsonSerializationException(string message); // 0x0000000180506F30-0x0000000180506F40
		public JsonSerializationException(string message, Exception innerException); // 0x0000000180506F40-0x0000000180506F50
		public JsonSerializationException(SerializationInfo info, StreamingContext context); // 0x0000000180501E60-0x0000000180501E80
		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception innerException); // 0x0000000180501E10-0x0000000180501E60
	
		// Methods
		internal static JsonSerializationException Create(JsonReader reader, string message); // 0x0000000180506D50-0x0000000180506D60
		internal static JsonSerializationException Create(JsonReader reader, string message, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception ex); // 0x0000000180506D60-0x0000000180506E00
		internal static JsonSerializationException Create([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ IJsonLineInfo lineInfo, string path, string message, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ Exception ex); // 0x0000000180506E00-0x0000000180506F30
	}
}
