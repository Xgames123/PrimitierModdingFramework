/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Linq
{
	[Nullable] // 0x0000000180015CC0-0x0000000180015D20
	[NullableContext] // 0x0000000180015CC0-0x0000000180015D20
	public abstract class JToken : IEnumerable<JToken>, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider // TypeDefIndex: 5504
	{
		// Fields
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private JContainer _parent; // 0x10
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private JToken _previous; // 0x18
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private JToken _next; // 0x20
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private object _annotations; // 0x28
		private static readonly JTokenType[] BooleanTypes; // 0x00
		private static readonly JTokenType[] NumberTypes; // 0x08
		private static readonly JTokenType[] BigIntegerTypes; // 0x10
		private static readonly JTokenType[] StringTypes; // 0x18
		private static readonly JTokenType[] GuidTypes; // 0x20
		private static readonly JTokenType[] TimeSpanTypes; // 0x28
		private static readonly JTokenType[] UriTypes; // 0x30
		private static readonly JTokenType[] CharTypes; // 0x38
		private static readonly JTokenType[] DateTimeTypes; // 0x40
		private static readonly JTokenType[] BytesTypes; // 0x48
	
		// Properties
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public JContainer Parent { [NullableContext] /* 0x0000000180016840-0x0000000180016870 */ [DebuggerStepThrough] /* 0x0000000180016840-0x0000000180016870 */ get; [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ internal set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public JToken Root { get; } // 0x000000018039D860-0x000000018039D890 
		public abstract JTokenType Type { get; }
		public abstract bool HasValues { get; }
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public JToken Next { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ internal set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public JToken Previous { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ internal set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public string Path { get; } // 0x00000001804B8610-0x00000001804B8930 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public virtual JToken this[object key] { get => default; set {} } // 0x00000001804B8490-0x00000001804B8550 0x00000001804BF770-0x00000001804BF830
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public virtual JToken First { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x00000001804B83D0-0x00000001804B8490 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public virtual JToken Last { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x00000001804B8550-0x00000001804B8610 
		int IJsonLineInfo.LineNumber { get; } // 0x00000001804B5F20-0x00000001804B5F70 
		int IJsonLineInfo.LinePosition { get; } // 0x00000001804B5F70-0x00000001804B5FC0 
	
		// Nested types
		[NullableContext] // 0x0000000180015700-0x0000000180015720
		private class LineInfoAnnotation // TypeDefIndex: 5503
		{
			// Fields
			internal readonly int LineNumber; // 0x10
			internal readonly int LinePosition; // 0x14
	
			// Constructors
			public LineInfoAnnotation(int lineNumber, int linePosition); // 0x000000018078F450-0x000000018078F490
		}
	
		// Constructors
		internal JToken(); // 0x00000001802650F0-0x0000000180265100
		static JToken(); // 0x00000001804B80F0-0x00000001804B83D0
	
		// Methods
		internal abstract JToken CloneToken();
		public virtual JEnumerable<JToken> Children(); // 0x00000001804B5AC0-0x00000001804B5B20
		public void Remove(); // 0x00000001804B63A0-0x00000001804B6420
		public void Replace(JToken value); // 0x00000001804B6420-0x00000001804B64A0
		public abstract void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters);
		public override string ToString(); // 0x00000001804B7DA0-0x00000001804B7E80
		public string ToString(Formatting formatting, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x00000001804B7E80-0x00000001804B8010
		private static JValue EnsureValue(JToken value); // 0x00000001804B5BD0-0x00000001804B5D00
		private static string GetType(JToken token); // 0x00000001804B5DC0-0x00000001804B5EE0
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable); // 0x00000001804B8010-0x00000001804B80F0
		public static explicit operator bool(JToken value); // 0x00000001804B9530-0x00000001804B9840
		public static explicit operator DateTimeOffset(JToken value); // 0x00000001804BCF20-0x00000001804BD280
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator bool?(JToken value); // 0x00000001804BE430-0x00000001804BE750
		public static explicit operator long(JToken value); // 0x00000001804BB310-0x00000001804BB5F0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator DateTime?(JToken value); // 0x00000001804B9840-0x00000001804B9B50
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator DateTimeOffset?(JToken value); // 0x00000001804BC250-0x00000001804BC600
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator decimal?(JToken value); // 0x00000001804BEDF0-0x00000001804BF170
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator double?(JToken value); // 0x00000001804BBF10-0x00000001804BC250
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator char?(JToken value); // 0x00000001804BBBF0-0x00000001804BBF10
		public static explicit operator int(JToken value); // 0x00000001804BA4C0-0x00000001804BA7A0
		public static explicit operator short(JToken value); // 0x00000001804BA7A0-0x00000001804BAA80
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator ushort(JToken value); // 0x00000001804BDE70-0x00000001804BE150
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator char(JToken value); // 0x00000001804BE150-0x00000001804BE430
		public static explicit operator byte(JToken value); // 0x00000001804B8930-0x00000001804B8C10
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator sbyte(JToken value); // 0x00000001804BF490-0x00000001804BF770
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator int?(JToken value); // 0x00000001804BDB50-0x00000001804BDE70
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator short?(JToken value); // 0x00000001804BA1A0-0x00000001804BA4C0
		[CLSCompliant] // 0x0000000180016AE0-0x0000000180016B20
		[NullableContext] // 0x0000000180016AE0-0x0000000180016B20
		public static explicit operator ushort?(JToken value); // 0x00000001804BCC00-0x00000001804BCF20
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator byte?(JToken value); // 0x00000001804BF170-0x00000001804BF490
		[CLSCompliant] // 0x0000000180016B90-0x0000000180016BD0
		[NullableContext] // 0x0000000180016B90-0x0000000180016BD0
		public static explicit operator sbyte?(JToken value); // 0x00000001804BB5F0-0x00000001804BB910
		public static explicit operator DateTime(JToken value); // 0x00000001804BAA80-0x00000001804BAD50
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator long?(JToken value); // 0x00000001804B8F10-0x00000001804B9250
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator float?(JToken value); // 0x00000001804BC600-0x00000001804BC920
		public static explicit operator decimal(JToken value); // 0x00000001804BD280-0x00000001804BD590
		[CLSCompliant] // 0x0000000180016AE0-0x0000000180016B20
		[NullableContext] // 0x0000000180016AE0-0x0000000180016B20
		public static explicit operator uint?(JToken value); // 0x00000001804B9E80-0x00000001804BA1A0
		[CLSCompliant] // 0x0000000180016AE0-0x0000000180016B20
		[NullableContext] // 0x0000000180016AE0-0x0000000180016B20
		public static explicit operator ulong?(JToken value); // 0x00000001804BAFD0-0x00000001804BB310
		public static explicit operator double(JToken value); // 0x00000001804B9250-0x00000001804B9530
		public static explicit operator float(JToken value); // 0x00000001804BC920-0x00000001804BCC00
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator string(JToken value); // 0x00000001804B9B50-0x00000001804B9E80
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator uint(JToken value); // 0x00000001804BB910-0x00000001804BBBF0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public static explicit operator ulong(JToken value); // 0x00000001804BD590-0x00000001804BD870
		public static explicit operator Guid(JToken value); // 0x00000001804BE750-0x00000001804BEA60
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator Guid?(JToken value); // 0x00000001804BEA60-0x00000001804BEDF0
		public static explicit operator TimeSpan(JToken value); // 0x00000001804BD870-0x00000001804BDB50
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator TimeSpan?(JToken value); // 0x00000001804B8C10-0x00000001804B8F10
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static explicit operator Uri(JToken value); // 0x00000001804BAD50-0x00000001804BAFD0
		private static BigInteger ToBigInteger(JToken value); // 0x00000001804B6930-0x00000001804B6B60
		private static BigInteger? ToBigIntegerNullable(JToken value); // 0x00000001804B66D0-0x00000001804B6930
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001804B6670-0x00000001804B66B0
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator(); // 0x00000001804B6610-0x00000001804B6670
		public JsonReader CreateReader(); // 0x00000001804B5B20-0x00000001804B5BB0
		public object ToObject(System.Type objectType); // 0x00000001804B6C80-0x00000001804B7DA0
		public object ToObject(System.Type objectType, JsonSerializer jsonSerializer); // 0x00000001804B6B60-0x00000001804B6C80
		public static JToken ReadFrom(JsonReader reader); // 0x00000001804B5FC0-0x00000001804B6020
		public static JToken ReadFrom(JsonReader reader, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonLoadSettings settings); // 0x00000001804B6020-0x00000001804B63A0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings); // 0x00000001804B6520-0x00000001804B6610
		internal void SetLineInfo(int lineNumber, int linePosition); // 0x00000001804B64A0-0x00000001804B6520
		bool IJsonLineInfo.HasLineInfo(); // 0x00000001804B5EE0-0x00000001804B5F20
		protected virtual DynamicMetaObject GetMetaObject(Expression parameter); // 0x00000001804B5D00-0x00000001804B5DC0
		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter); // 0x00000001804B66B0-0x00000001804B66D0
		object ICloneable.Clone(); // 0x00000001804B5BB0-0x00000001804B5BD0
		public JToken DeepClone(); // 0x00000001804B5BB0-0x00000001804B5BD0
		public void AddAnnotation(object annotation); // 0x00000001804B5810-0x00000001804B5AC0
		public T Annotation<T>()
			where T : class;
	}
}
