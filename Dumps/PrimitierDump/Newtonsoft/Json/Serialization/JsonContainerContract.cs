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
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x0000000180015050-0x0000000180015090
	[NullableContext] // 0x0000000180015050-0x0000000180015090
	public class JsonContainerContract : JsonContract // TypeDefIndex: 5448
	{
		// Fields
		private JsonContract _itemContract; // 0x90
		private JsonContract _finalItemContract; // 0x98
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonConverter _ItemConverter_k__BackingField; // 0xA0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool? _ItemIsReference_k__BackingField; // 0xA8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ReferenceLoopHandling? _ItemReferenceLoopHandling_k__BackingField; // 0xAC
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private TypeNameHandling? _ItemTypeNameHandling_k__BackingField; // 0xB4
	
		// Properties
		internal JsonContract ItemContract { get; set; } // 0x00000001802AFA60-0x00000001802AFA70 0x00000001804212B0-0x0000000180421310
		internal JsonContract FinalItemContract { get; } // 0x00000001802AFA90-0x00000001802AFAA0 
		public JsonConverter ItemConverter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803FD790-0x00000001803FD7A0 0x0000000180421310-0x0000000180421320
		public bool? ItemIsReference { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421280-0x0000000180421290 0x0000000180421320-0x0000000180421330
		public ReferenceLoopHandling? ItemReferenceLoopHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180421290-0x00000001804212A0 0x0000000180421330-0x0000000180421340
		public TypeNameHandling? ItemTypeNameHandling { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001804212A0-0x00000001804212B0 0x0000000180421340-0x0000000180421350
	
		// Constructors
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal JsonContainerContract(System.Type underlyingType); // 0x00000001804C5C00-0x00000001804C5D40
	}
}
