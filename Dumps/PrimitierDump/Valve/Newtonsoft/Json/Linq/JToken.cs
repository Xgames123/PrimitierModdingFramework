/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Linq
{
	[DefaultMember] // 0x00000001800239A0-0x00000001800239D0
	public abstract class JToken : IEnumerable<JToken>, IJsonLineInfo, ICloneable // TypeDefIndex: 7109
	{
		// Fields
		private JContainer _parent; // 0x10
		private JToken _previous; // 0x18
		private JToken _next; // 0x20
		private object _annotations; // 0x28
		private static readonly JTokenType[] BooleanTypes; // 0x00
		private static readonly JTokenType[] NumberTypes; // 0x08
		private static readonly JTokenType[] StringTypes; // 0x10
		private static readonly JTokenType[] GuidTypes; // 0x18
		private static readonly JTokenType[] TimeSpanTypes; // 0x20
		private static readonly JTokenType[] UriTypes; // 0x28
		private static readonly JTokenType[] CharTypes; // 0x30
		private static readonly JTokenType[] DateTimeTypes; // 0x38
		private static readonly JTokenType[] BytesTypes; // 0x40
	
		// Properties
		public JContainer Parent { [DebuggerStepThrough] /* 0x0000000180014D50-0x0000000180014D60 */ get; internal set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public JToken Root { get; } // 0x000000018039D860-0x000000018039D890 
		public abstract JTokenType Type { get; }
		public abstract bool HasValues { get; }
		public JToken Next { get; internal set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public JToken Previous { get; internal set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public string Path { get; } // 0x000000018039D5C0-0x000000018039D860 
		public virtual JToken First { get; } // 0x000000018039D440-0x000000018039D500 
		public virtual JToken Last { get; } // 0x000000018039D500-0x000000018039D5C0 
		int IJsonLineInfo.LineNumber { get; } // 0x000000018039CB50-0x000000018039CBA0 
		int IJsonLineInfo.LinePosition { get; } // 0x000000018039CBA0-0x000000018039CBF0 
	
		// Nested types
		private class LineInfoAnnotation // TypeDefIndex: 7108
		{
			// Fields
			internal readonly int LineNumber; // 0x10
			internal readonly int LinePosition; // 0x14
	
			// Constructors
			public LineInfoAnnotation(int lineNumber, int linePosition); // 0x000000018078F450-0x000000018078F490
		}
	
		// Constructors
		internal JToken(); // 0x00000001802650F0-0x0000000180265100
		static JToken(); // 0x000000018039CBF0-0x000000018039D440
	
		// Methods
		internal abstract JToken CloneToken();
		public virtual JEnumerable<JToken> Children(); // 0x000000018039AB90-0x000000018039ABF0
		public void Remove(); // 0x000000018039B340-0x000000018039B3C0
		public void Replace(JToken value); // 0x000000018039B3C0-0x000000018039B440
		public abstract void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters);
		public override string ToString(); // 0x000000018039C9E0-0x000000018039CA30
		public string ToString(Formatting formatting, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x000000018039C850-0x000000018039C9E0
		private static JValue EnsureValue(JToken value); // 0x000000018039AC50-0x000000018039AE00
		private static string GetType(JToken token); // 0x000000018039AE00-0x000000018039AF90
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable); // 0x000000018039CA30-0x000000018039CB10
		public static explicit operator bool(JToken value); // 0x000000018039DE50-0x000000018039E0A0
		public static explicit operator DateTimeOffset(JToken value); // 0x000000018039F210-0x000000018039F5A0
		public static explicit operator bool?(JToken value); // 0x000000018039E7B0-0x000000018039EA20
		public static explicit operator long(JToken value); // 0x00000001803A3210-0x00000001803A3460
		public static explicit operator DateTime?(JToken value); // 0x000000018039F830-0x000000018039FB50
		public static explicit operator DateTimeOffset?(JToken value); // 0x000000018039FB50-0x000000018039FF40
		public static explicit operator decimal?(JToken value); // 0x000000018039FF40-0x00000001803A0200
		public static explicit operator double?(JToken value); // 0x000000018039F5A0-0x000000018039F830
		public static explicit operator char?(JToken value); // 0x000000018039E2F0-0x000000018039E560
		public static explicit operator int(JToken value); // 0x00000001803A2D70-0x00000001803A2FC0
		public static explicit operator short(JToken value); // 0x00000001803A20E0-0x00000001803A2330
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator ushort(JToken value); // 0x00000001803A2FC0-0x00000001803A3210
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator char(JToken value); // 0x00000001803A0200-0x00000001803A0450
		public static explicit operator byte(JToken value); // 0x00000001803A0450-0x00000001803A06A0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator sbyte(JToken value); // 0x00000001803A1620-0x00000001803A1870
		public static explicit operator int?(JToken value); // 0x00000001803A1870-0x00000001803A1AE0
		public static explicit operator short?(JToken value); // 0x000000018039EA20-0x000000018039EC90
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator ushort?(JToken value); // 0x000000018039DBE0-0x000000018039DE50
		public static explicit operator byte?(JToken value); // 0x00000001803A0930-0x00000001803A0BA0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator sbyte?(JToken value); // 0x00000001803A1110-0x00000001803A1380
		public static explicit operator DateTime(JToken value); // 0x000000018039EC90-0x000000018039EF70
		public static explicit operator long?(JToken value); // 0x00000001803A06A0-0x00000001803A0930
		public static explicit operator float?(JToken value); // 0x00000001803A3460-0x00000001803A36D0
		public static explicit operator decimal(JToken value); // 0x00000001803A2B00-0x00000001803A2D70
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator uint?(JToken value); // 0x00000001803A0BA0-0x00000001803A0E10
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator ulong?(JToken value); // 0x00000001803A2330-0x00000001803A25C0
		public static explicit operator double(JToken value); // 0x00000001803A1E90-0x00000001803A20E0
		public static explicit operator float(JToken value); // 0x000000018039E0A0-0x000000018039E2F0
		public static explicit operator string(JToken value); // 0x00000001803A1380-0x00000001803A1620
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator uint(JToken value); // 0x000000018039E560-0x000000018039E7B0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator ulong(JToken value); // 0x00000001803A28B0-0x00000001803A2B00
		public static explicit operator Guid(JToken value); // 0x000000018039D890-0x000000018039DBE0
		public static explicit operator Guid?(JToken value); // 0x00000001803A1AE0-0x00000001803A1E90
		public static explicit operator TimeSpan(JToken value); // 0x00000001803A25C0-0x00000001803A28B0
		public static explicit operator TimeSpan?(JToken value); // 0x00000001803A0E10-0x00000001803A1110
		public static explicit operator Uri(JToken value); // 0x000000018039EF70-0x000000018039F210
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018039B610-0x000000018039B650
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator(); // 0x000000018039B5B0-0x000000018039B610
		public JsonReader CreateReader(); // 0x000000018039ABF0-0x000000018039AC50
		public object ToObject(System.Type objectType); // 0x000000018039B760-0x000000018039C850
		public object ToObject(System.Type objectType, JsonSerializer jsonSerializer); // 0x000000018039B650-0x000000018039B760
		public static JToken ReadFrom(JsonReader reader); // 0x000000018039AF90-0x000000018039AFF0
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings); // 0x000000018039AFF0-0x000000018039B340
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings); // 0x000000018039B4C0-0x000000018039B5B0
		internal void SetLineInfo(int lineNumber, int linePosition); // 0x000000018039B440-0x000000018039B4C0
		bool IJsonLineInfo.HasLineInfo(); // 0x000000018039CB10-0x000000018039CB50
		object ICloneable.Clone(); // 0x000000018031CCC0-0x000000018031CCE0
		public JToken DeepClone(); // 0x000000018031CCC0-0x000000018031CCE0
		public void AddAnnotation(object annotation); // 0x000000018039A8E0-0x000000018039AB90
		public T Annotation<T>()
			where T : class;
	}
}
