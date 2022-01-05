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
	internal struct ResolverContractKey : IEquatable<Valve.Newtonsoft.Json.Serialization.ResolverContractKey> // TypeDefIndex: 7034
	{
		// Fields
		private readonly System.Type _resolverType; // 0x00
		private readonly System.Type _contractType; // 0x08
	
		// Constructors
		public ResolverContractKey(System.Type resolverType, System.Type contractType); // 0x0000000180494FD0-0x0000000180494FE0
	
		// Methods
		public override int GetHashCode(); // 0x000000018087E7B0-0x000000018087E810
		public override bool Equals(object obj); // 0x000000018087E6F0-0x000000018087E790
		public bool Equals(ResolverContractKey other); // 0x000000018087E790-0x000000018087E7B0
	}
}
