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
	public abstract class JContainer : JToken, IList<JToken>, IList // TypeDefIndex: 7098
	{
		// Fields
		private object _syncRoot; // 0x30
		private bool _busy; // 0x38
	
		// Properties
		protected abstract IList<JToken> ChildrenTokens { get; }
		public override bool HasValues { get; } // 0x0000000180397920-0x0000000180397980 
		public override JToken First { get; } // 0x0000000180397890-0x0000000180397920 
		public override JToken Last { get; } // 0x0000000180397980-0x0000000180397A10 
		JToken IList<Valve.Newtonsoft.Json.Linq.JToken>.this[int index] { get => default; set {} } // 0x0000000180394D90-0x0000000180394DB0 0x0000000180394DC0-0x0000000180394DE0
		bool ICollection<Valve.Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
		bool IList.IsFixedSize { get; } // 0x0000000180295620-0x0000000180295630 
		bool IList.IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
		object IList.this[int index] { get => default; set {} } // 0x0000000180394D90-0x0000000180394DB0 0x0000000180397440-0x0000000180397480
		public int Count { get; } // 0x0000000180397830-0x0000000180397890 
		object ICollection.SyncRoot { get; } // 0x0000000180397270-0x00000001803972E0 
	
		// Constructors
		internal JContainer(); // 0x00000001803975E0-0x0000000180397640
		internal JContainer(JContainer other); // 0x0000000180397640-0x0000000180397830
	
		// Methods
		internal void CheckReentrancy(); // 0x00000001803958D0-0x00000001803959A0
		public override JEnumerable<JToken> Children(); // 0x00000001803959A0-0x0000000180395A00
		internal bool IsMultiContent(object content); // 0x0000000180396320-0x0000000180396400
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck); // 0x0000000180395F80-0x0000000180396020
		internal abstract int IndexOfItem(JToken item);
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck); // 0x0000000180396150-0x0000000180396320
		internal virtual void RemoveItemAt(int index); // 0x0000000180396D40-0x0000000180396F50
		internal virtual bool RemoveItem(JToken item); // 0x0000000180396F50-0x0000000180396FA0
		internal virtual JToken GetItem(int index); // 0x00000001803960E0-0x0000000180396150
		internal virtual void SetItem(int index, JToken item); // 0x0000000180396FF0-0x0000000180397270
		internal virtual void ClearItems(); // 0x0000000180395A00-0x0000000180395BE0
		internal virtual void ReplaceItem(JToken existing, JToken replacement); // 0x0000000180396FA0-0x0000000180396FF0
		internal virtual bool ContainsItem(JToken item); // 0x0000000180395BE0-0x0000000180395C00
		internal virtual void CopyItemsTo(Array array, int arrayIndex); // 0x0000000180395C00-0x0000000180395ED0
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue); // 0x0000000180396400-0x00000001803964E0
		internal virtual void ValidateToken(JToken o, JToken existing); // 0x0000000180397480-0x00000001803975E0
		public virtual void Add(object content); // 0x0000000180395850-0x00000001803958D0
		internal void AddAndSkipParentCheck(JToken token); // 0x0000000180395550-0x00000001803955D0
		internal void AddInternal(int index, object content, bool skipParentCheck); // 0x00000001803955D0-0x0000000180395850
		internal static JToken CreateFromContent(object content); // 0x0000000180395ED0-0x0000000180395F80
		public void RemoveAll(); // 0x0000000180394630-0x0000000180394650
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options); // 0x0000000180396B40-0x0000000180396D40
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings); // 0x00000001803964E0-0x0000000180396B40
		int IList<JToken>.IndexOf(JToken item); // 0x00000001803947F0-0x0000000180394810
		void IList<JToken>.Insert(int index, JToken item); // 0x0000000180394810-0x0000000180394840
		void IList<JToken>.RemoveAt(int index); // 0x0000000180394A40-0x0000000180394A60
		void ICollection<JToken>.Add(JToken item); // 0x0000000180394610-0x0000000180394630
		void ICollection<JToken>.Clear(); // 0x0000000180394630-0x0000000180394650
		bool ICollection<JToken>.Contains(JToken item); // 0x0000000180394700-0x0000000180394720
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex); // 0x0000000180394720-0x0000000180394740
		bool ICollection<JToken>.Remove(JToken item); // 0x0000000180394A60-0x0000000180394A80
		private JToken EnsureValue(object value); // 0x0000000180396020-0x00000001803960E0
		int IList.Add(object value); // 0x00000001803972E0-0x0000000180397360
		void IList.Clear(); // 0x0000000180394630-0x0000000180394650
		bool IList.Contains(object value); // 0x0000000180397360-0x0000000180397390
		int IList.IndexOf(object value); // 0x0000000180397390-0x00000001803973C0
		void IList.Insert(int index, object value); // 0x00000001803973C0-0x0000000180397410
		void IList.Remove(object value); // 0x0000000180397410-0x0000000180397440
		void IList.RemoveAt(int index); // 0x0000000180394A40-0x0000000180394A60
		void ICollection.CopyTo(Array array, int index); // 0x0000000180394720-0x0000000180394740
	}
}
