/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
	[Nullable] // 0x0000000180015C60-0x0000000180015CC0
	[NullableContext] // 0x0000000180015C60-0x0000000180015CC0
	public class JArray : JContainer, IList<JToken> // TypeDefIndex: 5488
	{
		// Fields
		private readonly List<JToken> _values; // 0x50
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001802BC110-0x00000001802BC120 
		public override JTokenType Type { get; } // 0x0000000180394DB0-0x0000000180394DC0 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override JToken this[object key] { get => default; set {} } // 0x00000001804ABA30-0x00000001804ABB90 0x00000001804ABB90-0x00000001804ABD00
		public JToken this[int index] { get => default; set {} } // 0x00000001804ABA10-0x00000001804ABA30 0x00000001804ABD00-0x00000001804ABD20
		public bool IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
	
		// Constructors
		public JArray(); // 0x00000001804AB960-0x00000001804ABA10
		public JArray(JArray other); // 0x00000001804AB810-0x00000001804AB890
		public JArray(object content); // 0x00000001804AB890-0x00000001804AB960
	
		// Methods
		internal override JToken CloneToken(); // 0x00000001804AB2E0-0x00000001804AB390
		public static JArray Load(JsonReader reader, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonLoadSettings settings); // 0x00000001804AB4E0-0x00000001804AB6E0
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x00000001804AB700-0x00000001804AB810
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override int IndexOfItem(JToken item); // 0x00000001804AB430-0x00000001804AB490
		public int IndexOf(JToken item); // 0x00000001804AB490-0x00000001804AB4B0
		public void Insert(int index, JToken item); // 0x00000001804AB4B0-0x00000001804AB4E0
		public void RemoveAt(int index); // 0x0000000180394700-0x0000000180394720
		public IEnumerator<JToken> GetEnumerator(); // 0x00000001804AB3D0-0x00000001804AB430
		public void Add(JToken item); // 0x00000001804AB2A0-0x00000001804AB2C0
		public void Clear(); // 0x00000001804AB2C0-0x00000001804AB2E0
		public bool Contains(JToken item); // 0x00000001804AB390-0x00000001804AB3B0
		public void CopyTo(JToken[] array, int arrayIndex); // 0x00000001804AB3B0-0x00000001804AB3D0
		public bool Remove(JToken item); // 0x00000001804AB6E0-0x00000001804AB700
	}
}
