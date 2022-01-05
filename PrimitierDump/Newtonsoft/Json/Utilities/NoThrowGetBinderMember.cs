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

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal class NoThrowGetBinderMember : GetMemberBinder // TypeDefIndex: 5372
	{
		// Fields
		private readonly GetMemberBinder _innerBinder; // 0x28
	
		// Constructors
		public NoThrowGetBinderMember(GetMemberBinder innerBinder); // 0x0000000180689E10-0x0000000180689E50
	
		// Methods
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion); // 0x0000000180689C90-0x0000000180689E10
	}
}
