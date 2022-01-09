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
	public class JTokenWriter : JsonWriter // TypeDefIndex: 7112
	{
		// Fields
		private JContainer _token; // 0x60
		private JContainer _parent; // 0x68
		private JValue _value; // 0x70
		private JToken _current; // 0x78
	
		// Properties
		public JToken Token { get; } // 0x000000018041C290-0x000000018041C2A0 
	
		// Constructors
		public JTokenWriter(); // 0x000000018041C230-0x000000018041C290
	
		// Methods
		public override void Close(); // 0x000000018041B280-0x000000018041B290
		public override void WriteStartObject(); // 0x000000018041B670-0x000000018041B700
		private void AddParent(JContainer container); // 0x000000018041B030-0x000000018041B080
		private void RemoveParent(); // 0x000000018041B290-0x000000018041B2F0
		public override void WriteStartArray(); // 0x000000018041B550-0x000000018041B5E0
		public override void WriteStartConstructor(string name); // 0x000000018041B5E0-0x000000018041B670
		protected override void WriteEnd(JsonToken token); // 0x000000018041B290-0x000000018041B2F0
		public override void WritePropertyName(string name); // 0x000000018041B3E0-0x000000018041B4D0
		private void AddValue(object value, JsonToken token); // 0x000000018041B080-0x000000018041B160
		internal void AddValue(JValue value, JsonToken token); // 0x000000018041B160-0x000000018041B280
		public override void WriteNull(); // 0x000000018041B3B0-0x000000018041B3E0
		public override void WriteUndefined(); // 0x000000018041B930-0x000000018041B960
		public override void WriteRaw(string json); // 0x000000018041B4D0-0x000000018041B550
		public override void WriteComment(string text); // 0x000000018041B2F0-0x000000018041B3B0
		public override void WriteValue(string value); // 0x000000018041BAA0-0x000000018041BAE0
		public override void WriteValue(int value); // 0x000000018041BA30-0x000000018041BAA0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(uint value); // 0x000000018041BFA0-0x000000018041C010
		public override void WriteValue(long value); // 0x000000018041BEC0-0x000000018041BF30
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(ulong value); // 0x000000018041BE50-0x000000018041BEC0
		public override void WriteValue(float value); // 0x000000018041BF30-0x000000018041BFA0
		public override void WriteValue(double value); // 0x000000018041C010-0x000000018041C080
		public override void WriteValue(bool value); // 0x000000018041BDE0-0x000000018041BE50
		public override void WriteValue(short value); // 0x000000018041BC70-0x000000018041BCE0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(ushort value); // 0x000000018041C1C0-0x000000018041C230
		public override void WriteValue(char value); // 0x000000018041B960-0x000000018041B9F0
		public override void WriteValue(byte value); // 0x000000018041BC00-0x000000018041BC70
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(sbyte value); // 0x000000018041BB90-0x000000018041BC00
		public override void WriteValue(decimal value); // 0x000000018041C140-0x000000018041C1C0
		public override void WriteValue(DateTime value); // 0x000000018041C080-0x000000018041C140
		public override void WriteValue(DateTimeOffset value); // 0x000000018041BD60-0x000000018041BDE0
		public override void WriteValue(byte[] value); // 0x000000018041BB50-0x000000018041BB90
		public override void WriteValue(TimeSpan value); // 0x000000018041BAE0-0x000000018041BB50
		public override void WriteValue(Guid value); // 0x000000018041BCE0-0x000000018041BD60
		public override void WriteValue(Uri value); // 0x000000018041B9F0-0x000000018041BA30
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments); // 0x000000018041B700-0x000000018041B930
	}
}
