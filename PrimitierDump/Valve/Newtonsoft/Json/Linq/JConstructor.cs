/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class JConstructor : JContainer // TypeDefIndex: 7097
	{
		// Fields
		private string _name; // 0x40
		private readonly List<JToken> _values; // 0x48
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
		public string Name { get; } // 0x0000000180268310-0x0000000180268320 
		public override JTokenType Type { get; } // 0x00000001802DFC40-0x00000001802DFC50 
	
		// Constructors
		public JConstructor(JConstructor other); // 0x00000001803954C0-0x0000000180395550
		public JConstructor(string name); // 0x0000000180395350-0x00000001803954C0
	
		// Methods
		internal override int IndexOfItem(JToken item); // 0x0000000180394EA0-0x0000000180394EF0
		internal override JToken CloneToken(); // 0x0000000180394DE0-0x0000000180394EA0
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x0000000180395150-0x0000000180395350
		public static JConstructor Load(JsonReader reader, JsonLoadSettings settings); // 0x0000000180394EF0-0x0000000180395150
	}
}
