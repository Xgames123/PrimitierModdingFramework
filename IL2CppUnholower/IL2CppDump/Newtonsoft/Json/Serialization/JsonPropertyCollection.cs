/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x00000001800154F0-0x0000000180015560
	[NullableContext] // 0x00000001800154F0-0x0000000180015560
	public class JsonPropertyCollection : KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty> // TypeDefIndex: 5465
	{
		// Fields
		private readonly System.Type _type; // 0x38
		private readonly List<JsonProperty> _list; // 0x40
	
		// Constructors
		public JsonPropertyCollection(System.Type type); // 0x0000000180501640-0x00000001805017B0
	
		// Methods
		protected override string GetKeyForItem(JsonProperty item); // 0x0000000180425E80-0x0000000180425EA0
		public void AddProperty(JsonProperty property); // 0x0000000180501040-0x0000000180501360
		public JsonProperty GetClosestMatchProperty(string propertyName); // 0x0000000180501360-0x00000001805013A0
		private bool TryGetValue(string key, [Nullable] /* 0x0000000180015560-0x00000001800155A0 */ [NotNullWhen] /* 0x0000000180015560-0x00000001800155A0 */ out JsonProperty item); // 0x0000000180501550-0x0000000180501640
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType); // 0x00000001805013A0-0x0000000180501550
	}
}
