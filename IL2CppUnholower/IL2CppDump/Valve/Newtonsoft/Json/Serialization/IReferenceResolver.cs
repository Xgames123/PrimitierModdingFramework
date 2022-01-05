/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public interface IReferenceResolver // TypeDefIndex: 7053
	{
		// Methods
		object ResolveReference(object context, string reference);
		string GetReference(object context, object value);
		bool IsReferenced(object context, object value);
		void AddReference(object context, string reference, object value);
	}
}
