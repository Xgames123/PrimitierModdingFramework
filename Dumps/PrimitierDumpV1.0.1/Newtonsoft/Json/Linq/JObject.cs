/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Linq
{
	[Nullable] // 0x0000000180015CC0-0x0000000180015D20
	[NullableContext] // 0x0000000180015CC0-0x0000000180015D20
	public class JObject : JContainer, IDictionary<string, JToken>, ICustomTypeDescriptor // TypeDefIndex: 5495
	{
		// Fields
		private readonly JPropertyKeyedCollection _properties; // 0x50
		[CompilerGenerated] // 0x0000000180015E50-0x0000000180015E80
		[Nullable] // 0x0000000180015E50-0x0000000180015E80
		private PropertyChangedEventHandler PropertyChanged; // 0x58
		[CompilerGenerated] // 0x0000000180015E50-0x0000000180015E80
		[Nullable] // 0x0000000180015E50-0x0000000180015E80
		private PropertyChangingEventHandler PropertyChanging; // 0x60
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001802BC110-0x00000001802BC120 
		public override JTokenType Type { get; } // 0x0000000180398E30-0x0000000180398E40 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override JToken this[object key] { get => default; set {} } // 0x00000001804B0EA0-0x00000001804B0FD0 0x00000001804B10C0-0x00000001804B1200
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public JToken this[string propertyName] { get => default; set {} } // 0x00000001804B0E20-0x00000001804B0EA0 0x00000001804B0FD0-0x00000001804B10C0
		ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; } // 0x00000001804B02E0-0x00000001804B0340 
		[Nullable] // 0x0000000180016050-0x00000001800160B0
		ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; } // 0x00000001804B0340-0x00000001804B0380 
		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
	
		// Nested types
		[Nullable] // 0x00000001800160B0-0x0000000180016110
		private class JObjectDynamicProxy : DynamicProxy<JObject> // TypeDefIndex: 5493
		{
			// Nested types
			[Serializable]
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private sealed class __c // TypeDefIndex: 5492
			{
				// Fields
				[Nullable] // 0x0000000180015680-0x00000001800156A0
				public static readonly __c __9; // 0x00
				[Nullable] // 0x0000000180015680-0x00000001800156A0
				public static Func<JProperty, string> __9__2_0; // 0x08
	
				// Constructors
				static __c(); // 0x0000000180797A30-0x0000000180797A90
				public __c(); // 0x00000001802650F0-0x0000000180265100
	
				// Methods
				[NullableContext] // 0x0000000180015700-0x0000000180015720
				internal string _GetDynamicMemberNames_b__2_0(JProperty p); // 0x0000000180795A10-0x0000000180795A30
			}
	
			// Constructors
			public JObjectDynamicProxy(); // 0x000000018078F1B0-0x000000018078F1F0
	
			// Methods
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance); // 0x000000018078F070-0x000000018078F1B0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetEnumerator_d__63 : IEnumerator<KeyValuePair<string, JToken>> // TypeDefIndex: 5494
		{
			// Fields
			private int __1__state; // 0x10
			[Nullable] // 0x0000000180016110-0x0000000180016170
			private KeyValuePair<string, JToken> __2__current; // 0x18
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public JObject __4__this; // 0x28
			[Nullable] // 0x0000000180016170-0x00000001800161D0
			private IEnumerator<JToken> __7__wrap1; // 0x30
	
			// Properties
			KeyValuePair<string, JToken> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001807956F0-0x0000000180795740 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetEnumerator_d__63(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180795740-0x00000001807957D0
			private bool MoveNext(); // 0x0000000180795420-0x00000001807956B0
			private void __m__Finally1(); // 0x00000001807957D0-0x0000000180795820
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001807956B0-0x00000001807956F0
		}
	
		// Constructors
		public JObject(); // 0x00000001804B0D80-0x00000001804B0E20
		public JObject(JObject other); // 0x00000001804B0D10-0x00000001804B0D80
	
		// Methods
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override int IndexOfItem(JToken item); // 0x00000001804AF330-0x00000001804AF410
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override void InsertItem(int index, JToken item, bool skipParentCheck); // 0x00000001804AF410-0x00000001804AF480
		internal override void ValidateToken(JToken o, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JToken existing); // 0x00000001804B08C0-0x00000001804B0C00
		internal void InternalPropertyChanged(JProperty childProperty); // 0x00000001804AF480-0x00000001804AF5C0
		internal void InternalPropertyChanging(JProperty childProperty); // 0x00000001804AF5C0-0x00000001804AF5F0
		internal override JToken CloneToken(); // 0x00000001804AF170-0x00000001804AF210
		public IEnumerable<JProperty> Properties(); // 0x00000001804AFA70-0x00000001804AFAB0
		public JProperty Property(string name, StringComparison comparison); // 0x00000001804AFAB0-0x00000001804AFC50
		public static JObject Load(JsonReader reader, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonLoadSettings settings); // 0x00000001804AF5F0-0x00000001804AF810
		public static JObject Parse(string json); // 0x00000001804AFA60-0x00000001804AFA70
		public static JObject Parse(string json, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonLoadSettings settings); // 0x00000001804AF930-0x00000001804AFA60
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x00000001804B0C00-0x00000001804B0D10
		public void Add(string propertyName, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JToken value); // 0x00000001804AF0E0-0x00000001804AF170
		public bool Remove(string propertyName); // 0x00000001804AFC50-0x00000001804AFCE0
		public bool TryGetValue(string propertyName, [Nullable] /* 0x0000000180015560-0x00000001800155A0 */ [NotNullWhen] /* 0x0000000180015560-0x00000001800155A0 */ out JToken value); // 0x00000001804B0870-0x00000001804B08C0
		void ICollection<KeyValuePair<string, JToken>>.Add([Nullable] /* 0x0000000180015E80-0x0000000180015EE0 */ KeyValuePair<string, JToken> item); // 0x00000001804AFCE0-0x00000001804AFD70
		void ICollection<KeyValuePair<string, JToken>>.Clear(); // 0x00000001804AB2C0-0x00000001804AB2E0
		bool ICollection<KeyValuePair<string, JToken>>.Contains([Nullable] /* 0x0000000180015EE0-0x0000000180015F40 */ KeyValuePair<string, JToken> item); // 0x00000001804AFD70-0x00000001804AFDF0
		void ICollection<KeyValuePair<string, JToken>>.CopyTo([Nullable] /* 0x0000000180015F40-0x0000000180015FA0 */ KeyValuePair<string, JToken>[] array, int arrayIndex); // 0x00000001804AFDF0-0x00000001804B0170
		bool ICollection<KeyValuePair<string, JToken>>.Remove([Nullable] /* 0x0000000180015FA0-0x0000000180016000 */ KeyValuePair<string, JToken> item); // 0x00000001804B0170-0x00000001804B02E0
		[IteratorStateMachine] // 0x0000000180016000-0x0000000180016050
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator(); // 0x00000001804AF210-0x00000001804AF280
		protected virtual void OnPropertyChanged(string propertyName); // 0x00000001804AF810-0x00000001804AF8A0
		protected virtual void OnPropertyChanging(string propertyName); // 0x00000001804AF8A0-0x00000001804AF930
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(); // 0x00000001804B0430-0x00000001804B04E0
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes); // 0x00000001804B04E0-0x00000001804B07E0
		AttributeCollection ICustomTypeDescriptor.GetAttributes(); // 0x00000001804B0380-0x00000001804B03E0
		TypeConverter ICustomTypeDescriptor.GetConverter(); // 0x00000001804B03E0-0x00000001804B0430
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd); // 0x00000001804B07E0-0x00000001804B0870
		protected override DynamicMetaObject GetMetaObject(Expression parameter); // 0x00000001804AF280-0x00000001804AF330
	}
}
