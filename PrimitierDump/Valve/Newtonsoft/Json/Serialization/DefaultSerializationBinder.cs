/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 7048
	{
		// Fields
		internal static readonly DefaultSerializationBinder Instance; // 0x00
		private readonly ThreadSafeStore<TypeNameKey, System.Type> _typeCache; // 0x10
	
		// Nested types
		internal struct TypeNameKey : IEquatable<TypeNameKey> // TypeDefIndex: 7047
		{
			// Fields
			internal readonly string AssemblyName; // 0x00
			internal readonly string TypeName; // 0x08
	
			// Constructors
			public TypeNameKey(string assemblyName, string typeName); // 0x0000000180494FD0-0x0000000180494FE0
	
			// Methods
			public override int GetHashCode(); // 0x0000000180880CD0-0x0000000180880D40
			public override bool Equals(object obj); // 0x0000000180880C20-0x0000000180880CD0
			public bool Equals(TypeNameKey other); // 0x0000000180549F90-0x0000000180549FE0
		}
	
		// Constructors
		public DefaultSerializationBinder(); // 0x0000000180393230-0x0000000180393300
		static DefaultSerializationBinder(); // 0x0000000180393130-0x0000000180393230
	
		// Methods
		private static System.Type GetTypeFromTypeNameKey(TypeNameKey typeNameKey); // 0x0000000180392E40-0x0000000180393130
		public override System.Type BindToType(string assemblyName, string typeName); // 0x0000000180392DA0-0x0000000180392E40
	}
}
