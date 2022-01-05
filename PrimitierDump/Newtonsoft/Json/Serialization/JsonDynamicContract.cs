/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class JsonDynamicContract : JsonContainerContract // TypeDefIndex: 5458
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly JsonPropertyCollection _Properties_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180019FD0-0x000000018001A040
		[Nullable] // 0x0000000180019FD0-0x000000018001A040
		private Func<string, string> _PropertyNameResolver_k__BackingField; // 0xC8
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters; // 0xD0
		[Nullable] // 0x000000018001A040-0x000000018001A0A0
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters; // 0xD8
	
		// Properties
		public JsonPropertyCollection Properties { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268300-0x0000000180268310 
		[Nullable] // 0x000000018001A100-0x000000018001A160
		public Func<string, string> PropertyNameResolver { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018031E0A0-0x000000018031E0B0 0x000000018031EC40-0x000000018031EC50
	
		// Constructors
		public JsonDynamicContract(System.Type underlyingType); // 0x00000001804C8DD0-0x00000001804C8F80
	
		// Methods
		private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name); // 0x00000001804C8970-0x00000001804C8A90
		private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name); // 0x00000001804C8A90-0x00000001804C8BB0
		internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ out object value); // 0x00000001804C8BB0-0x00000001804C8CC0
		internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value); // 0x00000001804C8CC0-0x00000001804C8DD0
	}
}
