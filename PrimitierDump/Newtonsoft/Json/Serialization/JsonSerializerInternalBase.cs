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
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal abstract class JsonSerializerInternalBase // TypeDefIndex: 5467
	{
		// Fields
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private ErrorContext _currentErrorContext; // 0x10
		[Nullable] // 0x0000000180015600-0x0000000180015660
		private BidirectionalDictionary<string, object> _mappings; // 0x18
		internal readonly JsonSerializer Serializer; // 0x20
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		internal readonly ITraceWriter TraceWriter; // 0x28
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		protected JsonSerializerProxy InternalSerializer; // 0x30
	
		// Properties
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; } // 0x00000001805075B0-0x00000001805076B0 
	
		// Nested types
		[Nullable] // 0x0000000180015680-0x00000001800156A0
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 5466
		{
			// Constructors
			public ReferenceEqualsEqualityComparer(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x000000018078F490-0x000000018078F4A0
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x000000018078F4A0-0x000000018078F4B0
		}
	
		// Constructors
		protected JsonSerializerInternalBase(JsonSerializer serializer); // 0x0000000180507530-0x00000001805075B0
	
		// Methods
		protected NullValueHandling ResolvedNullValueHandling([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonObjectContract containerContract, JsonProperty property); // 0x0000000180507490-0x0000000180507530
		private ErrorContext GetErrorContext([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object currentObject, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object member, string path, Exception error); // 0x0000000180506FC0-0x00000001805070C0
		protected void ClearErrorContext(); // 0x0000000180506F50-0x0000000180506FC0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ string path, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ Exception ex); // 0x00000001805070C0-0x0000000180507490
	}
}
