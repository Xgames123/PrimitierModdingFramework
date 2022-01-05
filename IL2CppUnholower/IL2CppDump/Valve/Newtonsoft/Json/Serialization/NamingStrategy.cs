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
	public abstract class NamingStrategy // TypeDefIndex: 7087
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _ProcessDictionaryKeys_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _OverrideSpecifiedNames_k__BackingField; // 0x11
	
		// Properties
		public bool ProcessDictionaryKeys { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802A2940-0x00000001802A2950 
		public bool OverrideSpecifiedNames { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180424330-0x0000000180424340 
	
		// Methods
		public virtual string GetPropertyName(string name, bool hasSpecifiedName); // 0x0000000180877930-0x0000000180877950
		public virtual string GetDictionaryKey(string key); // 0x0000000180877910-0x0000000180877930
		protected abstract string ResolvePropertyName(string name);
	}
}
