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

namespace Newtonsoft.Json.Linq
{
	[DefaultMember] // 0x0000000180016580-0x0000000180016610
	[Nullable] // 0x0000000180016580-0x0000000180016610
	[NullableContext] // 0x0000000180016580-0x0000000180016610
	internal class JPropertyKeyedCollection : Collection<Newtonsoft.Json.Linq.JToken> // TypeDefIndex: 5500
	{
		// Fields
		private static readonly IEqualityComparer<string> Comparer; // 0x00
		[Nullable] // 0x00000001800166C0-0x0000000180016720
		private Dictionary<string, JToken> _dictionary; // 0x20
	
		// Properties
		public ICollection<string> Keys { get; } // 0x00000001804B1DD0-0x00000001804B1E20 
	
		// Constructors
		public JPropertyKeyedCollection(); // 0x00000001804B1D50-0x00000001804B1DD0
		static JPropertyKeyedCollection(); // 0x00000001804B1C90-0x00000001804B1D50
	
		// Methods
		private void AddKey(string key, JToken item); // 0x00000001804B14F0-0x00000001804B1560
		protected override void ClearItems(); // 0x00000001804B1560-0x00000001804B15C0
		private void EnsureDictionary(); // 0x00000001804B15C0-0x00000001804B1680
		private string GetKeyForItem(JToken item); // 0x00000001804B1680-0x00000001804B1740
		protected override void InsertItem(int index, JToken item); // 0x00000001804B17F0-0x00000001804B18B0
		protected override void RemoveItem(int index); // 0x00000001804B18B0-0x00000001804B1980
		private void RemoveKey(string key); // 0x00000001804B1980-0x00000001804B19D0
		protected override void SetItem(int index, JToken item); // 0x00000001804B19D0-0x00000001804B1C10
		public bool TryGetValue(string key, [NotNullWhen] /* 0x00000001800157C0-0x0000000180015800 */ [Nullable] /* 0x00000001800157C0-0x0000000180015800 */ out JToken value); // 0x00000001804B1C10-0x00000001804B1C90
		public int IndexOfReference(JToken t); // 0x00000001804B1740-0x00000001804B17F0
	}
}
