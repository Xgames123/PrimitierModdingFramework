/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public static class BvhExtensions // TypeDefIndex: 5970
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 5968
		{
			// Fields
			public Channel[] order; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Quaternion _GetEulerToRotation_b__1(float x, float y, float z); // 0x00000001812BD7F0-0x00000001812BD9B0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5969
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Channel, bool> __9__0_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001812BDDB0-0x00000001812BDE10
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetEulerToRotation_b__0_0(Channel x); // 0x00000001812BD1D0-0x00000001812BD1F0
		}
	
		// Extension methods
		public static Func<float, float, float, Quaternion> GetEulerToRotation(this BvhNode bvh); // 0x00000001812AD9E0-0x00000001812ADBB0
		public static Vector3 ToVector3(this Single3 s3); // 0x00000001812ADBB0-0x00000001812ADBF0
		public static Vector3 ToXReversedVector3(this Single3 s3); // 0x0000000180BC6230-0x0000000180BC6270
	}
}
