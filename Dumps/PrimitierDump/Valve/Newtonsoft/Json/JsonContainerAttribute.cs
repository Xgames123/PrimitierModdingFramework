/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json.Serialization;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json
{
	[AttributeUsage] // 0x0000000180016870-0x00000001800168A0
	public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 6943
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private System.Type _ItemConverterType_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private object[] _ItemConverterParameters_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private NamingStrategy _NamingStrategyInstance_k__BackingField; // 0x20
		internal bool? _isReference; // 0x28
		internal bool? _itemIsReference; // 0x2A
		internal ReferenceLoopHandling? _itemReferenceLoopHandling; // 0x2C
		internal TypeNameHandling? _itemTypeNameHandling; // 0x34
		private System.Type _namingStrategyType; // 0x40
		private object[] _namingStrategyParameters; // 0x48
	
		// Properties
		public System.Type ItemConverterType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268FC0-0x0000000180268FD0 
		public object[] ItemConverterParameters { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		public System.Type NamingStrategyType { get; } // 0x0000000180268310-0x0000000180268320 
		public object[] NamingStrategyParameters { get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
		internal NamingStrategy NamingStrategyInstance { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
	}
}
