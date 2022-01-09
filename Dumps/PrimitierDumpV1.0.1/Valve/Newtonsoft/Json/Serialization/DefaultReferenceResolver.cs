/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 7046
	{
		// Fields
		private int _referenceCount; // 0x10
	
		// Constructors
		public DefaultReferenceResolver(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		private BidirectionalDictionary<string, object> GetMappings(object context); // 0x00000001803929A0-0x0000000180392B90
		public object ResolveReference(object context, string reference); // 0x0000000180392D10-0x0000000180392DA0
		public string GetReference(object context, object value); // 0x0000000180392B90-0x0000000180392C90
		public void AddReference(object context, string reference, object value); // 0x0000000180392920-0x00000001803929A0
		public bool IsReferenced(object context, object value); // 0x0000000180392C90-0x0000000180392D10
	}
}
