/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Linq
{
	public class JObject : JContainer, IDictionary<string, JToken> // TypeDefIndex: 7101
	{
		// Fields
		private readonly JPropertyKeyedCollection _properties; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private PropertyChangedEventHandler PropertyChanged; // 0x48
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x0000000180268310-0x0000000180268320 
		public override JTokenType Type { get; } // 0x0000000180398E30-0x0000000180398E40 
		public JToken this[string propertyName] { get => default; set {} } // 0x0000000180398DB0-0x0000000180398E30 0x0000000180398E40-0x0000000180398F10
		ICollection<string> System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.Keys { get; } // 0x0000000180398760-0x00000001803987C0 
		ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Valve.Newtonsoft.Json.Linq.JToken>.Values { get; } // 0x00000001803987C0-0x0000000180398800 
		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetEnumerator_d__55 : IEnumerator<KeyValuePair<string, JToken>> // TypeDefIndex: 7100
		{
			// Fields
			private int __1__state; // 0x10
			private KeyValuePair<string, JToken> __2__current; // 0x18
			public JObject __4__this; // 0x28
			private IEnumerator<JToken> __7__wrap1; // 0x30
	
			// Properties
			KeyValuePair<string, JToken> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Valve.Newtonsoft.Json.Linq.JToken>>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180881050-0x00000001808810A0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetEnumerator_d__55(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001808810A0-0x0000000180881130
			private bool MoveNext(); // 0x0000000180880D80-0x0000000180881010
			private void __m__Finally1(); // 0x0000000180881130-0x0000000180881180
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180881010-0x0000000180881050
		}
	
		// Constructors
		public JObject(); // 0x0000000180398CA0-0x0000000180398D40
		public JObject(JObject other); // 0x0000000180398D40-0x0000000180398DB0
	
		// Methods
		internal override int IndexOfItem(JToken item); // 0x0000000180397BB0-0x0000000180397C70
		internal override void InsertItem(int index, JToken item, bool skipParentCheck); // 0x0000000180397C70-0x0000000180397CE0
		internal override void ValidateToken(JToken o, JToken existing); // 0x0000000180398850-0x0000000180398B90
		internal void InternalPropertyChanged(JProperty childProperty); // 0x0000000180397CE0-0x0000000180397D10
		internal void InternalPropertyChanging(JProperty childProperty); // 0x0000000180265310-0x0000000180265320
		internal override JToken CloneToken(); // 0x0000000180397AA0-0x0000000180397B40
		public JProperty Property(string name); // 0x0000000180397FC0-0x00000001803980D0
		public static JObject Load(JsonReader reader, JsonLoadSettings settings); // 0x0000000180397D10-0x0000000180397F30
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x0000000180398B90-0x0000000180398CA0
		public void Add(string propertyName, JToken value); // 0x0000000180397A10-0x0000000180397AA0
		public bool Remove(string propertyName); // 0x00000001803980D0-0x0000000180398160
		public bool TryGetValue(string propertyName, out JToken value); // 0x0000000180398800-0x0000000180398850
		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item); // 0x0000000180398160-0x00000001803981F0
		void ICollection<KeyValuePair<string, JToken>>.Clear(); // 0x0000000180394630-0x0000000180394650
		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item); // 0x00000001803981F0-0x0000000180398270
		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex); // 0x0000000180398270-0x00000001803985F0
		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item); // 0x00000001803985F0-0x0000000180398760
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator(); // 0x0000000180397B40-0x0000000180397BB0
		protected virtual void OnPropertyChanged(string propertyName); // 0x0000000180397F30-0x0000000180397FC0
	}
}
