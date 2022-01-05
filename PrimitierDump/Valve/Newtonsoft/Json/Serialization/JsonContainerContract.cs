/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public class JsonContainerContract : JsonContract // TypeDefIndex: 7057
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
		internal JsonContainerContract(System.Type underlyingType); // 0x0000000180421180-0x0000000180421280
	}
}
