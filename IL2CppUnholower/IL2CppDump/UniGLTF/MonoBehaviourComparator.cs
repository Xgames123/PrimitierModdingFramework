/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class MonoBehaviourComparator // TypeDefIndex: 5865
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5864
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform[], Transform[], bool> __9__0_0; // 0x08
			public static Func<MeshFilter[], MeshFilter[], bool> __9__0_1; // 0x10
			public static Func<MeshRenderer[], MeshRenderer[], bool> __9__0_2; // 0x18
			public static Func<SkinnedMeshRenderer[], SkinnedMeshRenderer[], bool> __9__0_3; // 0x20
	
			// Constructors
			static __c(); // 0x00000001806E6D30-0x00000001806E6D90
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _AssertAreEquals_b__0_0(Transform[] x, Transform[] y); // 0x00000001806E4470-0x00000001806E44D0
			internal bool _AssertAreEquals_b__0_1(MeshFilter[] x, MeshFilter[] y); // 0x00000001806E44D0-0x00000001806E4530
			internal bool _AssertAreEquals_b__0_2(MeshRenderer[] x, MeshRenderer[] y); // 0x00000001806E4530-0x00000001806E4590
			internal bool _AssertAreEquals_b__0_3(SkinnedMeshRenderer[] x, SkinnedMeshRenderer[] y); // 0x00000001806E4590-0x00000001806E45F0
		}
	
		// Methods
		public static bool AssertAreEquals(GameObject l, GameObject r); // 0x0000000180BBEB10-0x0000000180BBEF30
		public static bool AssertAreEquals<T>(GameObject l, GameObject r, Func<T[], T[], bool> pred)
			where T : Component;
		public static bool AssertAreEquals(Transform l, Transform r); // 0x0000000180BBE9C0-0x0000000180BBEB10
		public static bool AssertAreEquals(MeshFilter l, MeshFilter r); // 0x0000000180BBE940-0x0000000180BBE980
		public static bool AssertAreEquals(MeshRenderer l, MeshRenderer r); // 0x0000000180BBE900-0x0000000180BBE940
		public static bool AssertAreEquals(SkinnedMeshRenderer l, SkinnedMeshRenderer r); // 0x0000000180BBE980-0x0000000180BBE9C0
		public static bool AssetAreEquals(Texture2D l, Texture2D r); // 0x0000000180BBEF30-0x0000000180BBEF70
	}
}
