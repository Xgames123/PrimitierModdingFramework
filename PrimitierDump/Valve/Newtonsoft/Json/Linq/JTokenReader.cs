/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Linq
{
	public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 7110
	{
		// Fields
		private readonly JToken _root; // 0x78
		private string _initialPath; // 0x80
		private JToken _parent; // 0x88
		private JToken _current; // 0x90
	
		// Properties
		public JToken CurrentToken { get; } // 0x00000001802AFA60-0x00000001802AFA70 
		int IJsonLineInfo.LineNumber { get; } // 0x000000018041AD00-0x000000018041AD60 
		int IJsonLineInfo.LinePosition { get; } // 0x000000018041AD60-0x000000018041ADC0 
		public override string Path { get; } // 0x000000018041AE30-0x000000018041B030 
	
		// Constructors
		public JTokenReader(JToken token); // 0x000000018041ADC0-0x000000018041AE30
	
		// Methods
		public override bool Read(); // 0x000000018041A4B0-0x000000018041A5E0
		private bool ReadOver(JToken t); // 0x000000018041A380-0x000000018041A480
		private bool ReadToEnd(); // 0x000000018041A480-0x000000018041A4B0
		private JsonToken? GetEndToken(JContainer c); // 0x000000018041A190-0x000000018041A300
		private bool ReadInto(JContainer c); // 0x000000018041A300-0x000000018041A380
		private bool SetEnd(JContainer c); // 0x000000018041A600-0x000000018041A7D0
		private void SetToken(JToken token); // 0x000000018041A7D0-0x000000018041ACA0
		private string SafeToString(object value); // 0x000000018041A5E0-0x000000018041A600
		bool IJsonLineInfo.HasLineInfo(); // 0x000000018041ACA0-0x000000018041AD00
	}
}
