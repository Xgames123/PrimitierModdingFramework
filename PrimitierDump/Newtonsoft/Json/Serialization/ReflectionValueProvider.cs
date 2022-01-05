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
	public class ReflectionValueProvider : IValueProvider // TypeDefIndex: 5483
	{
		// Fields
		private readonly MemberInfo _memberInfo; // 0x10
	
		// Constructors
		public ReflectionValueProvider(MemberInfo memberInfo); // 0x000000018078F8D0-0x000000018078F970
	
		// Methods
		public void SetValue(object target, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value); // 0x000000018078F760-0x000000018078F8D0
		public object GetValue(object target); // 0x000000018078F4B0-0x000000018078F760
	}
}
