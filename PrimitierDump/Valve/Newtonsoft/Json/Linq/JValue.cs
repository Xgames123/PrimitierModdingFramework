/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Linq
{
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible // TypeDefIndex: 7113
	{
		// Fields
		private JTokenType _valueType; // 0x30
		private object _value; // 0x38
	
		// Properties
		public override bool HasValues { get; } // 0x0000000180295620-0x0000000180295630 
		public override JTokenType Type { get; } // 0x00000001802DFC30-0x00000001802DFC40 
		public object Value { get; } // 0x0000000180268FE0-0x0000000180268FF0 
	
		// Constructors
		internal JValue(object value, JTokenType type); // 0x000000018041EB00-0x000000018041EB80
		public JValue(JValue other); // 0x000000018041EB80-0x000000018041EC60
		public JValue(object value); // 0x000000018041EC60-0x000000018041ECE0
	
		// Methods
		internal static int Compare(JTokenType valueType, object objA, object objB); // 0x000000018041C4C0-0x000000018041CF30
		private static int CompareFloat(object objA, object objB); // 0x000000018041C3A0-0x000000018041C4A0
		internal override JToken CloneToken(); // 0x000000018041C2A0-0x000000018041C3A0
		public static JValue CreateComment(string value); // 0x000000018041CF30-0x000000018041CFD0
		public static JValue CreateNull(); // 0x000000018041CFD0-0x000000018041D060
		public static JValue CreateUndefined(); // 0x000000018041D060-0x000000018041D0F0
		private static JTokenType GetValueType(JTokenType? current, object value); // 0x000000018041D2A0-0x000000018041D730
		private static JTokenType GetStringValueType(JTokenType? current); // 0x000000018041D240-0x000000018041D2A0
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x000000018041E070-0x000000018041EB00
		private static bool ValuesEquals(JValue v1, JValue v2); // 0x000000018041E020-0x000000018041E070
		public bool Equals(JValue other); // 0x000000018041D0F0-0x000000018041D140
		public override bool Equals(object obj); // 0x000000018041D140-0x000000018041D220
		public override int GetHashCode(); // 0x000000018041D220-0x000000018041D240
		public override string ToString(); // 0x000000018041DFC0-0x000000018041E020
		public string ToString(IFormatProvider formatProvider); // 0x000000018041DE20-0x000000018041DEE0
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018041DEE0-0x000000018041DFC0
		int IComparable.CompareTo(object obj); // 0x000000018041D730-0x000000018041D850
		public int CompareTo(JValue obj); // 0x000000018041C4A0-0x000000018041C4C0
		TypeCode IConvertible.GetTypeCode(); // 0x000000018041D850-0x000000018041D8C0
		bool IConvertible.ToBoolean(IFormatProvider provider); // 0x000000018041D8C0-0x000000018041D920
		char IConvertible.ToChar(IFormatProvider provider); // 0x000000018041D980-0x000000018041D9E0
		sbyte IConvertible.ToSByte(IFormatProvider provider); // 0x000000018041DC30-0x000000018041DC90
		byte IConvertible.ToByte(IFormatProvider provider); // 0x000000018041D920-0x000000018041D980
		short IConvertible.ToInt16(IFormatProvider provider); // 0x000000018041DB10-0x000000018041DB70
		ushort IConvertible.ToUInt16(IFormatProvider provider); // 0x000000018041DD00-0x000000018041DD60
		int IConvertible.ToInt32(IFormatProvider provider); // 0x000000018041DB70-0x000000018041DBD0
		uint IConvertible.ToUInt32(IFormatProvider provider); // 0x000000018041DD60-0x000000018041DDC0
		long IConvertible.ToInt64(IFormatProvider provider); // 0x000000018041DBD0-0x000000018041DC30
		ulong IConvertible.ToUInt64(IFormatProvider provider); // 0x000000018041DDC0-0x000000018041DE20
		float IConvertible.ToSingle(IFormatProvider provider); // 0x000000018041DC90-0x000000018041DCF0
		double IConvertible.ToDouble(IFormatProvider provider); // 0x000000018041DAB0-0x000000018041DB10
		decimal IConvertible.ToDecimal(IFormatProvider provider); // 0x000000018041DA40-0x000000018041DAB0
		DateTime IConvertible.ToDateTime(IFormatProvider provider); // 0x000000018041D9E0-0x000000018041DA40
		object IConvertible.ToType(System.Type conversionType, IFormatProvider provider); // 0x000000018041DCF0-0x000000018041DD00
	}
}
