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
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 5437
	{
		// Fields
		private int _referenceCount; // 0x10
	
		// Constructors
		public DefaultReferenceResolver(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		private BidirectionalDictionary<string, object> GetMappings(object context); // 0x00000001803D9830-0x00000001803D9960
		public object ResolveReference(object context, string reference); // 0x00000001803D9AE0-0x00000001803D9B70
		public string GetReference(object context, object value); // 0x00000001803D9960-0x00000001803D9A60
		public void AddReference(object context, string reference, object value); // 0x00000001803D97B0-0x00000001803D9830
		public bool IsReferenced(object context, object value); // 0x00000001803D9A60-0x00000001803D9AE0
	}
}
