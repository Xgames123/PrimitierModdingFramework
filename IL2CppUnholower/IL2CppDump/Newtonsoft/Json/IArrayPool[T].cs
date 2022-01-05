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

namespace Newtonsoft.Json
{
	[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
	public interface IArrayPool<T> // TypeDefIndex: 5303
	{
		// Methods
		T[] Rent(int minimumLength);
		void Return([Nullable] /* 0x00000001800167E0-0x0000000180016840 */ T[] array);
	}
}
