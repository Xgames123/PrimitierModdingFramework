/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public class JsonPropertyCollection : KeyedCollection<string, Valve.Newtonsoft.Json.Serialization.JsonProperty> // TypeDefIndex: 7073
	{
		// Fields
		private readonly System.Type _type; // 0x38
		private readonly List<JsonProperty> _list; // 0x40
	
		// Constructors
		public JsonPropertyCollection(System.Type type); // 0x0000000180426140-0x00000001804262B0
	
		// Methods
		protected override string GetKeyForItem(JsonProperty item); // 0x0000000180425E80-0x0000000180425EA0
		public void AddProperty(JsonProperty property); // 0x0000000180425BC0-0x0000000180425E40
		public JsonProperty GetClosestMatchProperty(string propertyName); // 0x0000000180425E40-0x0000000180425E80
		private bool TryGetValue(string key, out JsonProperty item); // 0x0000000180426050-0x0000000180426140
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType); // 0x0000000180425EA0-0x0000000180426050
	}
}
