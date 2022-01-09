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
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json
{
	[AttributeUsage] // 0x00000001800168D0-0x0000000180016930
	[Nullable] // 0x00000001800168D0-0x0000000180016930
	[NullableContext] // 0x00000001800168D0-0x0000000180016930
	public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 5307
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private System.Type _ItemConverterType_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180016930-0x00000001800169A0
		[Nullable] // 0x0000000180016930-0x00000001800169A0
		private object[] _ItemConverterParameters_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private NamingStrategy _NamingStrategyInstance_k__BackingField; // 0x20
		internal bool? _isReference; // 0x28
		internal bool? _itemIsReference; // 0x2A
		internal ReferenceLoopHandling? _itemReferenceLoopHandling; // 0x2C
		internal TypeNameHandling? _itemTypeNameHandling; // 0x34
		private System.Type _namingStrategyType; // 0x40
		[Nullable] // 0x00000001800169A0-0x0000000180016A00
		private object[] _namingStrategyParameters; // 0x48
	
		// Properties
		public System.Type ItemConverterType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268FC0-0x0000000180268FD0 
		[Nullable] // 0x0000000180016A00-0x0000000180016A60
		public object[] ItemConverterParameters { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		public System.Type NamingStrategyType { get; } // 0x0000000180268310-0x0000000180268320 
		[Nullable] // 0x0000000180016A80-0x0000000180016AE0
		public object[] NamingStrategyParameters { get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
		internal NamingStrategy NamingStrategyInstance { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
	}
}
