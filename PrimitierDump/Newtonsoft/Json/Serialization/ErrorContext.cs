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
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class ErrorContext // TypeDefIndex: 5439
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Traced_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly Exception _Error_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180017450-0x0000000180017480
		[Nullable] // 0x0000000180017450-0x0000000180017480
		private readonly object _OriginalObject_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180017450-0x0000000180017480
		[Nullable] // 0x0000000180017450-0x0000000180017480
		private readonly object _Member_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly string _Path_k__BackingField; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Handled_k__BackingField; // 0x38
	
		// Properties
		internal bool Traced { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802A2940-0x00000001802A2950 0x00000001802A29C0-0x00000001802A29D0
		public Exception Error { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		public bool Handled { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018030F460-0x000000018030F470 
	
		// Constructors
		internal ErrorContext([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object originalObject, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object member, string path, Exception error); // 0x0000000180393C40-0x0000000180393CA0
	}
}
