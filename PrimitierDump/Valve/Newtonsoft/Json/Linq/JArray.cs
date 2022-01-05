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
	public class JArray : JContainer, IList<JToken> // TypeDefIndex: 7096
	{
		// Fields
		private readonly List<JToken> _values; // 0x40
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x0000000180268310-0x0000000180268320 
		public override JTokenType Type { get; } // 0x0000000180394DB0-0x0000000180394DC0 
		public JToken this[int index] { get => default; set {} } // 0x0000000180394D90-0x0000000180394DB0 0x0000000180394DC0-0x0000000180394DE0
		public bool IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
	
		// Constructors
		public JArray(); // 0x0000000180394C60-0x0000000180394D10
		public JArray(JArray other); // 0x0000000180394D10-0x0000000180394D90
		public JArray(object content); // 0x0000000180394B90-0x0000000180394C60
	
		// Methods
		internal override JToken CloneToken(); // 0x0000000180394650-0x0000000180394700
		public static JArray Load(JsonReader reader, JsonLoadSettings settings); // 0x0000000180394840-0x0000000180394A40
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x0000000180394A80-0x0000000180394B90
		internal override int IndexOfItem(JToken item); // 0x00000001803947A0-0x00000001803947F0
		public int IndexOf(JToken item); // 0x00000001803947F0-0x0000000180394810
		public void Insert(int index, JToken item); // 0x0000000180394810-0x0000000180394840
		public void RemoveAt(int index); // 0x0000000180394A40-0x0000000180394A60
		public IEnumerator<JToken> GetEnumerator(); // 0x0000000180394740-0x00000001803947A0
		public void Add(JToken item); // 0x0000000180394610-0x0000000180394630
		public void Clear(); // 0x0000000180394630-0x0000000180394650
		public bool Contains(JToken item); // 0x0000000180394700-0x0000000180394720
		public void CopyTo(JToken[] array, int arrayIndex); // 0x0000000180394720-0x0000000180394740
		public bool Remove(JToken item); // 0x0000000180394A60-0x0000000180394A80
	}
}
