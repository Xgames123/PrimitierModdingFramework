/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	[Nullable] // 0x0000000180015CC0-0x0000000180015D20
	[NullableContext] // 0x0000000180015CC0-0x0000000180015D20
	public class JConstructor : JContainer // TypeDefIndex: 5489
	{
		// Fields
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private string _name; // 0x50
		private readonly List<JToken> _values; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001802BF820-0x00000001802BF890 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public string Name { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x00000001802BC110-0x00000001802BC120 
		public override JTokenType Type { get; } // 0x00000001802DFC40-0x00000001802DFC50 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override JToken this[object key] { get => default; set {} } // 0x00000001804AC3C0-0x00000001804AC520 0x00000001804AC520-0x00000001804AC690
	
		// Constructors
		public JConstructor(JConstructor other); // 0x00000001804AC1C0-0x00000001804AC250
		public JConstructor(string name); // 0x00000001804AC250-0x00000001804AC3C0
	
		// Methods
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		internal override int IndexOfItem(JToken item); // 0x00000001804ABDE0-0x00000001804ABE40
		internal override JToken CloneToken(); // 0x00000001804ABD20-0x00000001804ABDE0
		public override void WriteTo(JsonWriter writer, params /* 0x0000000180014D50-0x0000000180014D60 */ JsonConverter[] converters); // 0x00000001804AC0A0-0x00000001804AC1C0
		public static JConstructor Load(JsonReader reader, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonLoadSettings settings); // 0x00000001804ABE40-0x00000001804AC0A0
	}
}
