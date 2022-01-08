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

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public abstract class NamingStrategy // TypeDefIndex: 5479
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _ProcessDictionaryKeys_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _ProcessExtensionDataNames_k__BackingField; // 0x11
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _OverrideSpecifiedNames_k__BackingField; // 0x12
	
		// Properties
		public bool ProcessDictionaryKeys { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802A2940-0x00000001802A2950 
		public bool ProcessExtensionDataNames { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180424330-0x0000000180424340 
		public bool OverrideSpecifiedNames { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180689B00-0x0000000180689B10 
	
		// Constructors
		protected NamingStrategy(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public virtual string GetPropertyName(string name, bool hasSpecifiedName); // 0x0000000180689AE0-0x0000000180689B00
		public virtual string GetExtensionDataName(string name); // 0x0000000180689A00-0x0000000180689A20
		public virtual string GetDictionaryKey(string key); // 0x00000001806899E0-0x0000000180689A00
		protected abstract string ResolvePropertyName(string name);
		public override int GetHashCode(); // 0x0000000180689A20-0x0000000180689AE0
		public override bool Equals(object obj); // 0x00000001806898B0-0x00000001806899E0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		protected bool Equals(NamingStrategy other); // 0x00000001806897E0-0x00000001806898B0
	}
}
