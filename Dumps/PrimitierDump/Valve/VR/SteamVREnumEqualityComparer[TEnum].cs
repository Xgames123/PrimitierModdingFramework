/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	internal struct SteamVREnumEqualityComparer<TEnum> : IEqualityComparer<TEnum> // TypeDefIndex: 7335
		where TEnum : struct
	{
		// Nested types
		private static class BoxAvoidance // TypeDefIndex: 7334
		{
			// Fields
			private static readonly Func<TEnum, int> _wrapper;
	
			// Constructors
			static BoxAvoidance();
	
			// Methods
			public static int ToInt(TEnum enu);
		}
	
		// Methods
		public bool Equals(TEnum firstEnum, TEnum secondEnum);
		public int GetHashCode(TEnum firstEnum);
	}
}
