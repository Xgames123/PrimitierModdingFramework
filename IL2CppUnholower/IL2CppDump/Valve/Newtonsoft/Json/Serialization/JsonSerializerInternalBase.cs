/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal abstract class JsonSerializerInternalBase // TypeDefIndex: 7075
	{
		// Fields
		private ErrorContext _currentErrorContext; // 0x10
		private BidirectionalDictionary<string, object> _mappings; // 0x18
		internal readonly JsonSerializer Serializer; // 0x20
		internal readonly ITraceWriter TraceWriter; // 0x28
		protected JsonSerializerProxy InternalSerializer; // 0x30
	
		// Properties
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; } // 0x000000018042BD20-0x000000018042BE20 
	
		// Nested types
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 7074
		{
			// Constructors
			public ReferenceEqualsEqualityComparer(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x000000018078F490-0x000000018078F4A0
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x000000018078F4A0-0x000000018078F4B0
		}
	
		// Constructors
		protected JsonSerializerInternalBase(JsonSerializer serializer); // 0x000000018042BCA0-0x000000018042BD20
	
		// Methods
		private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error); // 0x000000018042B7F0-0x000000018042B8F0
		protected void ClearErrorContext(); // 0x000000018042B780-0x000000018042B7F0
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex); // 0x000000018042B8F0-0x000000018042BCA0
	}
}
