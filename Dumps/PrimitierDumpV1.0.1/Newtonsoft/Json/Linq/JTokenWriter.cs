/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Linq
{
	[Nullable] // 0x0000000180015050-0x0000000180015090
	[NullableContext] // 0x0000000180015050-0x0000000180015090
	public class JTokenWriter : JsonWriter // TypeDefIndex: 5507
	{
		// Fields
		private JContainer _token; // 0x60
		private JContainer _parent; // 0x68
		private JValue _value; // 0x70
		private JToken _current; // 0x78
	
		// Properties
		public JToken Token { get; } // 0x000000018041C290-0x000000018041C2A0 
	
		// Constructors
		public JTokenWriter(); // 0x00000001804B57B0-0x00000001804B5810
	
		// Methods
		public override void Close(); // 0x00000001804B4120-0x00000001804B4130
		public override void WriteStartObject(); // 0x00000001804B4570-0x00000001804B45E0
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		private void AddParent(JContainer container); // 0x00000001804B3F60-0x00000001804B4000
		private void RemoveParent(); // 0x00000001804B4130-0x00000001804B4190
		public override void WriteStartArray(); // 0x00000001804B4480-0x00000001804B44F0
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public override void WriteStartConstructor(string name); // 0x00000001804B44F0-0x00000001804B4570
		protected override void WriteEnd(JsonToken token); // 0x00000001804B4130-0x00000001804B4190
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public override void WritePropertyName(string name); // 0x00000001804B4270-0x00000001804B43C0
		private void AddValue(object value, JsonToken token); // 0x00000001804B4000-0x00000001804B4080
		internal void AddValue(JValue value, JsonToken token); // 0x00000001804B4080-0x00000001804B4120
		public override void WriteValue(object value); // 0x00000001804B4DF0-0x00000001804B4E80
		public override void WriteNull(); // 0x00000001804B41D0-0x00000001804B4270
		public override void WriteUndefined(); // 0x00000001804B4810-0x00000001804B48B0
		public override void WriteRaw(string json); // 0x00000001804B43C0-0x00000001804B4480
		public override void WriteComment(string text); // 0x00000001804B4190-0x00000001804B41D0
		public override void WriteValue(string value); // 0x00000001804B4F30-0x00000001804B4FB0
		public override void WriteValue(int value); // 0x00000001804B4E80-0x00000001804B4F30
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(uint value); // 0x00000001804B5380-0x00000001804B5430
		public override void WriteValue(long value); // 0x00000001804B4A30-0x00000001804B4AF0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(ulong value); // 0x00000001804B4D30-0x00000001804B4DF0
		public override void WriteValue(float value); // 0x00000001804B48B0-0x00000001804B4970
		public override void WriteValue(double value); // 0x00000001804B4C70-0x00000001804B4D30
		public override void WriteValue(bool value); // 0x00000001804B4BB0-0x00000001804B4C70
		public override void WriteValue(short value); // 0x00000001804B56F0-0x00000001804B57B0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(ushort value); // 0x00000001804B4970-0x00000001804B4A30
		public override void WriteValue(char value); // 0x00000001804B50F0-0x00000001804B51D0
		public override void WriteValue(byte value); // 0x00000001804B4AF0-0x00000001804B4BB0
		[CLSCompliant] // 0x0000000180016A60-0x0000000180016A80
		public override void WriteValue(sbyte value); // 0x00000001804B5630-0x00000001804B56F0
		public override void WriteValue(decimal value); // 0x00000001804B5430-0x00000001804B54F0
		public override void WriteValue(DateTime value); // 0x00000001804B5290-0x00000001804B5380
		public override void WriteValue(DateTimeOffset value); // 0x00000001804B54F0-0x00000001804B55B0
		public override void WriteValue(byte[] value); // 0x00000001804B4FB0-0x00000001804B5030
		public override void WriteValue(TimeSpan value); // 0x00000001804B51D0-0x00000001804B5290
		public override void WriteValue(Guid value); // 0x00000001804B5030-0x00000001804B50F0
		public override void WriteValue(Uri value); // 0x00000001804B55B0-0x00000001804B5630
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments); // 0x00000001804B45E0-0x00000001804B4810
	}
}
