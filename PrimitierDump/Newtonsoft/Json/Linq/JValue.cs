/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Linq
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible // TypeDefIndex: 5509
	{
		// Fields
		private JTokenType _valueType; // 0x30
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private object _value; // 0x38
	
		// Properties
		public override bool HasValues { get; } // 0x0000000180295620-0x0000000180295630 
		public override JTokenType Type { get; } // 0x00000001802DFC30-0x00000001802DFC40 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public object Value { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ set; } // 0x0000000180268FE0-0x0000000180268FF0 0x00000001804C2850-0x00000001804C2940
	
		// Nested types
		[Nullable] // 0x0000000180016F50-0x0000000180016FB0
		private class JValueDynamicProxy : DynamicProxy<JValue> // TypeDefIndex: 5508
		{
			// Constructors
			public JValueDynamicProxy(); // 0x000000018078F410-0x000000018078F450
		}
	
		// Constructors
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal JValue(object value, JTokenType type); // 0x00000001804C2600-0x00000001804C2680
		public JValue(JValue other); // 0x00000001804C2680-0x00000001804C2760
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public JValue(string value); // 0x00000001804C2760-0x00000001804C27D0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public JValue(object value); // 0x00000001804C27D0-0x00000001804C2850
	
		// Methods
		private static int CompareBigInteger(BigInteger i1, object i2); // 0x00000001804BF890-0x00000001804BFB80
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal static int Compare(JTokenType valueType, object objA, object objB); // 0x00000001804BFCB0-0x00000001804C0890
		private static int CompareFloat(object objA, object objB); // 0x00000001804BFB80-0x00000001804BFC80
		internal override JToken CloneToken(); // 0x00000001804BF830-0x00000001804BF890
		public static JValue CreateComment([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value); // 0x00000001804C0890-0x00000001804C0930
		public static JValue CreateNull(); // 0x00000001804C0930-0x00000001804C09C0
		public static JValue CreateUndefined(); // 0x00000001804C09C0-0x00000001804C0A50
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private static JTokenType GetValueType(JTokenType? current, object value); // 0x00000001804C0C80-0x00000001804C1130
		private static JTokenType GetStringValueType(JTokenType? current); // 0x00000001804C0C20-0x00000001804C0C80
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x00000001804C1B10-0x00000001804C2600
		private static bool ValuesEquals(JValue v1, JValue v2); // 0x00000001804C1AC0-0x00000001804C1B10
		public bool Equals([AllowNull] /* 0x0000000180014D50-0x0000000180014D60 */ JValue other); // 0x00000001804C0B20-0x00000001804C0B70
		public override bool Equals(object obj); // 0x00000001804C0A50-0x00000001804C0B20
		public override int GetHashCode(); // 0x000000018041D220-0x000000018041D240
		public override string ToString(); // 0x00000001804C17D0-0x00000001804C1830
		public string ToString(IFormatProvider formatProvider); // 0x00000001804C1980-0x00000001804C1AC0
		public string ToString([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string format, IFormatProvider formatProvider); // 0x00000001804C1830-0x00000001804C1980
		protected override DynamicMetaObject GetMetaObject(Expression parameter); // 0x00000001804C0B70-0x00000001804C0C20
		int IComparable.CompareTo(object obj); // 0x00000001804C1130-0x00000001804C1200
		public int CompareTo(JValue obj); // 0x00000001804BFC80-0x00000001804BFCB0
		TypeCode IConvertible.GetTypeCode(); // 0x00000001804C1200-0x00000001804C1270
		bool IConvertible.ToBoolean(IFormatProvider provider); // 0x00000001804C1270-0x00000001804C12D0
		char IConvertible.ToChar(IFormatProvider provider); // 0x00000001804C1330-0x00000001804C1390
		sbyte IConvertible.ToSByte(IFormatProvider provider); // 0x00000001804C15E0-0x00000001804C1640
		byte IConvertible.ToByte(IFormatProvider provider); // 0x00000001804C12D0-0x00000001804C1330
		short IConvertible.ToInt16(IFormatProvider provider); // 0x00000001804C14C0-0x00000001804C1520
		ushort IConvertible.ToUInt16(IFormatProvider provider); // 0x00000001804C16B0-0x00000001804C1710
		int IConvertible.ToInt32(IFormatProvider provider); // 0x00000001804C1520-0x00000001804C1580
		uint IConvertible.ToUInt32(IFormatProvider provider); // 0x00000001804C1710-0x00000001804C1770
		long IConvertible.ToInt64(IFormatProvider provider); // 0x00000001804C1580-0x00000001804C15E0
		ulong IConvertible.ToUInt64(IFormatProvider provider); // 0x00000001804C1770-0x00000001804C17D0
		float IConvertible.ToSingle(IFormatProvider provider); // 0x00000001804C1640-0x00000001804C16A0
		double IConvertible.ToDouble(IFormatProvider provider); // 0x00000001804C1460-0x00000001804C14C0
		decimal IConvertible.ToDecimal(IFormatProvider provider); // 0x00000001804C13F0-0x00000001804C1460
		DateTime IConvertible.ToDateTime(IFormatProvider provider); // 0x00000001804C1390-0x00000001804C13F0
		object IConvertible.ToType(System.Type conversionType, IFormatProvider provider); // 0x00000001804C16A0-0x00000001804C16B0
	}
}
