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

namespace Valve.Newtonsoft.Json.Linq
{
	[DefaultMember] // 0x00000001800239A0-0x00000001800239D0
	internal class JPropertyKeyedCollection : Collection<Valve.Newtonsoft.Json.Linq.JToken> // TypeDefIndex: 7105
	{
		// Fields
		private static readonly IEqualityComparer<string> Comparer; // 0x00
		private Dictionary<string, JToken> _dictionary; // 0x20
	
		// Properties
		public ICollection<string> Keys { get; } // 0x00000001803997F0-0x0000000180399840 
	
		// Constructors
		public JPropertyKeyedCollection(); // 0x0000000180399770-0x00000001803997F0
		static JPropertyKeyedCollection(); // 0x00000001803996B0-0x0000000180399770
	
		// Methods
		private void AddKey(string key, JToken item); // 0x0000000180398F10-0x0000000180398F80
		protected override void ClearItems(); // 0x0000000180398F80-0x0000000180398FE0
		private void EnsureDictionary(); // 0x0000000180398FE0-0x00000001803990A0
		private string GetKeyForItem(JToken item); // 0x00000001803990A0-0x0000000180399160
		protected override void InsertItem(int index, JToken item); // 0x0000000180399210-0x00000001803992D0
		protected override void RemoveItem(int index); // 0x00000001803992D0-0x00000001803993A0
		private void RemoveKey(string key); // 0x00000001803993A0-0x00000001803993F0
		protected override void SetItem(int index, JToken item); // 0x00000001803993F0-0x0000000180399630
		public bool TryGetValue(string key, out JToken value); // 0x0000000180399630-0x00000001803996B0
		public int IndexOfReference(JToken t); // 0x0000000180399160-0x0000000180399210
	}
}
