/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public abstract class JContainer : JToken, IList<JToken>, IBindingList // TypeDefIndex: 5490
	{
		// Fields
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		internal ListChangedEventHandler _listChanged; // 0x30
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		internal NotifyCollectionChangedEventHandler _collectionChanged; // 0x38
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private object _syncRoot; // 0x40
		private bool _busy; // 0x48
	
		// Properties
		protected abstract IList<JToken> ChildrenTokens { get; }
		public override bool HasValues { get; } // 0x00000001804AEFF0-0x00000001804AF050 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override JToken First { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x00000001804AEF60-0x00000001804AEFF0 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override JToken Last { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x00000001804AF050-0x00000001804AF0E0 
		JToken IList<Newtonsoft.Json.Linq.JToken>.this[int index] { get => default; set {} } // 0x00000001804ABA10-0x00000001804ABA30 0x00000001804ABD00-0x00000001804ABD20
		bool ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
		bool IList.IsFixedSize { get; } // 0x0000000180295620-0x0000000180295630 
		bool IList.IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
		object IList.this[int index] { get => default; set {} } // 0x00000001804ABA10-0x00000001804ABA30 0x00000001804AEB10-0x00000001804AEB50
		public int Count { get; } // 0x00000001804AEF00-0x00000001804AEF60 
		object ICollection.SyncRoot { get; } // 0x00000001804AE940-0x00000001804AE9B0 
	
		// Constructors
		internal JContainer(); // 0x00000001804AEEA0-0x00000001804AEF00
		internal JContainer(JContainer other); // 0x00000001804AECB0-0x00000001804AEEA0
	
		// Methods
		internal void CheckReentrancy(); // 0x00000001804ACA10-0x00000001804ACAE0
		protected virtual void OnListChanged(ListChangedEventArgs e); // 0x00000001804AD7C0-0x00000001804AD830
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e); // 0x00000001804AD750-0x00000001804AD7C0
		public override JEnumerable<JToken> Children(); // 0x00000001804ACAE0-0x00000001804ACB40
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal bool IsMultiContent([NotNull] /* 0x0000000180014D50-0x0000000180014D60 */ object content); // 0x00000001804AD5B0-0x00000001804AD690
		internal JToken EnsureParentToken([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JToken item, bool skipParentCheck); // 0x00000001804AD170-0x00000001804AD210
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal abstract int IndexOfItem(JToken item);
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck); // 0x00000001804AD340-0x00000001804AD5B0
		internal virtual void RemoveItemAt(int index); // 0x00000001804AE270-0x00000001804AE580
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal virtual bool RemoveItem(JToken item); // 0x00000001804AE580-0x00000001804AE5D0
		internal virtual JToken GetItem(int index); // 0x00000001804AD2D0-0x00000001804AD340
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal virtual void SetItem(int index, JToken item); // 0x00000001804AE620-0x00000001804AE940
		internal virtual void ClearItems(); // 0x00000001804ACB40-0x00000001804ACDD0
		internal virtual void ReplaceItem(JToken existing, JToken replacement); // 0x00000001804AE5D0-0x00000001804AE620
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal virtual bool ContainsItem(JToken item); // 0x00000001804ACDD0-0x00000001804ACDF0
		internal virtual void CopyItemsTo(Array array, int arrayIndex); // 0x00000001804ACDF0-0x00000001804AD0C0
		internal static bool IsTokenUnchanged(JToken currentValue, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JToken newValue); // 0x00000001804AD690-0x00000001804AD750
		internal virtual void ValidateToken(JToken o, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JToken existing); // 0x00000001804AEB50-0x00000001804AECB0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public virtual void Add(object content); // 0x00000001804AC990-0x00000001804ACA10
		internal void AddAndSkipParentCheck(JToken token); // 0x00000001804AC690-0x00000001804AC710
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal void AddInternal(int index, object content, bool skipParentCheck); // 0x00000001804AC710-0x00000001804AC990
		internal static JToken CreateFromContent([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object content); // 0x00000001804AD0C0-0x00000001804AD170
		public void RemoveAll(); // 0x00000001804AB2C0-0x00000001804AB2E0
		internal void ReadTokenFrom(JsonReader reader, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonLoadSettings options); // 0x00000001804AE070-0x00000001804AE270
		internal void ReadContentFrom(JsonReader r, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonLoadSettings settings); // 0x00000001804AD830-0x00000001804ADD90
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private static JProperty ReadProperty([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JContainer parent); // 0x00000001804ADD90-0x00000001804AE070
		int IList<JToken>.IndexOf(JToken item); // 0x00000001804AB490-0x00000001804AB4B0
		void IList<JToken>.Insert(int index, JToken item); // 0x00000001804AB4B0-0x00000001804AB4E0
		void IList<JToken>.RemoveAt(int index); // 0x0000000180394700-0x0000000180394720
		void ICollection<JToken>.Add(JToken item); // 0x00000001804AB2A0-0x00000001804AB2C0
		void ICollection<JToken>.Clear(); // 0x00000001804AB2C0-0x00000001804AB2E0
		bool ICollection<JToken>.Contains(JToken item); // 0x00000001804AB390-0x00000001804AB3B0
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex); // 0x00000001804AB3B0-0x00000001804AB3D0
		bool ICollection<JToken>.Remove(JToken item); // 0x00000001804AB6E0-0x00000001804AB700
		private JToken EnsureValue(object value); // 0x00000001804AD210-0x00000001804AD2D0
		int IList.Add(object value); // 0x00000001804AE9B0-0x00000001804AEA30
		void IList.Clear(); // 0x00000001804AB2C0-0x00000001804AB2E0
		bool IList.Contains(object value); // 0x00000001804AEA30-0x00000001804AEA60
		int IList.IndexOf(object value); // 0x00000001804AEA60-0x00000001804AEA90
		void IList.Insert(int index, object value); // 0x00000001804AEA90-0x00000001804AEAE0
		void IList.Remove(object value); // 0x00000001804AEAE0-0x00000001804AEB10
		void IList.RemoveAt(int index); // 0x0000000180394700-0x0000000180394720
		void ICollection.CopyTo(Array array, int index); // 0x00000001804AB3B0-0x00000001804AB3D0
	}
}
