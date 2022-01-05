/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5505
	{
		// Fields
		private readonly JToken _root; // 0x78
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private string _initialPath; // 0x80
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private JToken _parent; // 0x88
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private JToken _current; // 0x90
	
		// Properties
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public JToken CurrentToken { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x00000001802AFA60-0x00000001802AFA70 
		int IJsonLineInfo.LineNumber { get; } // 0x00000001804B3280-0x00000001804B32E0 
		int IJsonLineInfo.LinePosition { get; } // 0x00000001804B32E0-0x00000001804B3340 
		public override string Path { get; } // 0x00000001804B3E70-0x00000001804B3F60 
	
		// Constructors
		public JTokenReader(JToken token); // 0x00000001804B3E10-0x00000001804B3E70
	
		// Methods
		public override bool Read(); // 0x00000001804B34D0-0x00000001804B3610
		private bool ReadOver(JToken t); // 0x00000001804B33C0-0x00000001804B34B0
		private bool ReadToEnd(); // 0x00000001804B34B0-0x00000001804B34D0
		private JsonToken? GetEndToken(JContainer c); // 0x00000001804B30B0-0x00000001804B3220
		private bool ReadInto(JContainer c); // 0x00000001804B3340-0x00000001804B33C0
		private bool SetEnd(JContainer c); // 0x00000001804B3610-0x00000001804B37D0
		private void SetToken(JToken token); // 0x00000001804B37D0-0x00000001804B3E10
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private string SafeToString(object value); // 0x000000018041A5E0-0x000000018041A600
		bool IJsonLineInfo.HasLineInfo(); // 0x00000001804B3220-0x00000001804B3280
	}
}
