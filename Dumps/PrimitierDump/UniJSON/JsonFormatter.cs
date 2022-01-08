/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public class JsonFormatter : IFormatter // TypeDefIndex: 5601
	{
		// Fields
		private IStore m_w; // 0x10
		private Stack<Context> m_stack; // 0x18
		private string m_indent; // 0x20
		private string m_colon; // 0x28
		private static Utf8String s_null; // 0x00
		private static Utf8String s_true; // 0x10
		private static Utf8String s_false; // 0x20
	
		// Properties
		protected IStore Store { get; } // 0x0000000180268FC0-0x0000000180268FD0 
	
		// Nested types
		private enum Current // TypeDefIndex: 5598
		{
			ROOT = 0,
			ARRAY = 1,
			OBJECT = 2
		}
	
		private class Context // TypeDefIndex: 5599
		{
			// Fields
			public Current Current; // 0x10
			public int Count; // 0x14
	
			// Constructors
			public Context(Current current); // 0x0000000180D50430-0x0000000180D50460
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5600
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<int, char> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000180D58C10-0x0000000180D58C70
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal char _.ctor_b__10_0(int x); // 0x00000001805713A0-0x00000001805713B0
		}
	
		// Constructors
		public JsonFormatter(int indent = 0 /* Metadata: 0x003A18ED */); // 0x0000000180D26B60-0x0000000180D26BD0
		public JsonFormatter(IStore w, int indent = 0 /* Metadata: 0x003A18F1 */); // 0x0000000180D26BD0-0x0000000180D26E20
		static JsonFormatter(); // 0x0000000180D26A70-0x0000000180D26B60
	
		// Methods
		private void Indent(); // 0x0000000180D259F0-0x0000000180D25B40
		public override string ToString(); // 0x0000000180D25E30-0x0000000180D25ED0
		public IStore GetStore(); // 0x0000000180268FC0-0x0000000180268FD0
		public void Clear(); // 0x0000000180D25580-0x0000000180D25650
		protected void CommaCheck(bool isKey = false /* Metadata: 0x003A18F5 */); // 0x0000000180D25650-0x0000000180D25830
		public void Null(); // 0x0000000180D25C30-0x0000000180D25D50
		public void BeginList(int _ = 0 /* Metadata: 0x003A18F6 */); // 0x0000000180D25400-0x0000000180D254C0
		public void EndList(); // 0x0000000180D25830-0x0000000180D25910
		public void BeginMap(int _ = 0 /* Metadata: 0x003A18FA */); // 0x0000000180D254C0-0x0000000180D25580
		public void EndMap(); // 0x0000000180D25910-0x0000000180D259F0
		public void Key(Utf8String key); // 0x0000000180D25B40-0x0000000180D25C30
		public void Value(string x); // 0x0000000180D26200-0x0000000180D262F0
		public void Value(Utf8String key); // 0x0000000180D268A0-0x0000000180D26940
		private void _Value(Utf8String key, bool isKey); // 0x0000000180D269B0-0x0000000180D26A70
		public void Value(bool x); // 0x0000000180D262F0-0x0000000180D26440
		public void Value(sbyte x); // 0x0000000180D26940-0x0000000180D269B0
		public void Value(short x); // 0x0000000180D266F0-0x0000000180D26760
		public void Value(int x); // 0x0000000180D26500-0x0000000180D26570
		public void Value(long x); // 0x0000000180D25FF0-0x0000000180D26060
		public void Value(byte x); // 0x0000000180D26060-0x0000000180D260D0
		public void Value(ushort x); // 0x0000000180D26760-0x0000000180D267D0
		public void Value(uint x); // 0x0000000180D26190-0x0000000180D26200
		public void Value(ulong x); // 0x0000000180D267D0-0x0000000180D26840
		public void Value(float x); // 0x0000000180D26440-0x0000000180D26500
		public void Value(double x); // 0x0000000180D260D0-0x0000000180D26190
		public void Value(ArraySegment<byte> x); // 0x0000000180D25ED0-0x0000000180D25FF0
		public void Raw(ArraySegment<byte> x); // 0x0000000180D25D50-0x0000000180D25E30
		public void Value(DateTimeOffset x); // 0x0000000180D26840-0x0000000180D268A0
		public void Value(JsonNode node); // 0x0000000180D26570-0x0000000180D266F0
	}
}
