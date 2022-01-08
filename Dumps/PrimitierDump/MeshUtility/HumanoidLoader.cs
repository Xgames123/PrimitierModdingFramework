/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace MeshUtility
{
	public static class HumanoidLoader // TypeDefIndex: 5657
	{
		// Fields
		private static readonly Dictionary<HumanBodyBones, string> s_humanTranitBoneNameMap; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5656
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, SkeletonBone> __9__0_0; // 0x08
			public static Func<ValueTuple<Transform, HumanBodyBones>, HumanBone> __9__0_1; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180D58D30-0x0000000180D58D90
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal SkeletonBone _LoadHumanoidAvatar_b__0_0(Transform x); // 0x0000000180D56BF0-0x0000000180D56C80
			internal HumanBone _LoadHumanoidAvatar_b__0_1(ValueTuple<Transform, HumanBodyBones> x); // 0x0000000180D56C80-0x0000000180D56E00
			internal HumanBodyBones _.cctor_b__4_0(string x); // 0x0000000180D57010-0x0000000180D57070
			internal string _.cctor_b__4_1(string x); // 0x00000001802D5FD0-0x00000001802D5FE0
		}
	
		// Constructors
		static HumanoidLoader(); // 0x0000000180D20560-0x0000000180D206D0
	
		// Methods
		public static Avatar LoadHumanoidAvatar(Transform root, IEnumerable<ValueTuple<Transform, HumanBodyBones>> boneMap); // 0x0000000180D20070-0x0000000180D20430
		private static HumanBodyBones TraitToHumanBone(string x); // 0x0000000180D20430-0x0000000180D20560
	
		// Extension methods
		private static SkeletonBone ToSkeletonBone(this Transform t); // 0x0000000180346130-0x0000000180346210
	}
}
