/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public static class VRMBoneNormalizer // TypeDefIndex: 8089
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 8084
		{
			// Fields
			public GameObject go; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Avatar _Execute_b__0(GameObject _src, GameObject dst, Dictionary<Transform, Transform> boneMap); // 0x000000018054EA40-0x000000018054F120
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_1 // TypeDefIndex: 8085
		{
			// Fields
			public Animator src; // 0x10
			public Dictionary<Transform, Transform> boneMap; // 0x18
	
			// Constructors
			public __c__DisplayClass1_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal __f__AnonymousType1<HumanBodyBones, Transform> _Execute_b__2(HumanBodyBones x); // 0x000000018054F120-0x000000018054F1B0
			internal bool _Execute_b__4(__f__AnonymousType1<HumanBodyBones, Transform> x); // 0x000000018054F1B0-0x000000018054F220
			internal Transform _Execute_b__6(__f__AnonymousType1<HumanBodyBones, Transform> x); // 0x000000018054F220-0x000000018054F290
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 8086
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<HumanBodyBones, bool> __9__1_1; // 0x08
			public static Func<__f__AnonymousType1<HumanBodyBones, Transform>, bool> __9__1_3; // 0x10
			public static Func<__f__AnonymousType1<HumanBodyBones, Transform>, HumanBodyBones> __9__1_5; // 0x18
	
			// Constructors
			static __c(); // 0x0000000180550680-0x00000001805506E0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Execute_b__1_1(HumanBodyBones x); // 0x000000018054D7A0-0x000000018054D7B0
			internal bool _Execute_b__1_3(__f__AnonymousType1<HumanBodyBones, Transform> x); // 0x000000018054D7B0-0x000000018054D820
			internal HumanBodyBones _Execute_b__1_5(__f__AnonymousType1<HumanBodyBones, Transform> x); // 0x000000018054D820-0x000000018054D860
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 8087
		{
			// Fields
			public Dictionary<Transform, Transform> map; // 0x10
			public Func<Transform, Transform> __9__1; // 0x18
			public Func<VRMSpringBoneColliderGroup, VRMSpringBoneColliderGroup> __9__2; // 0x20
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Transform _CopyVRMComponents_b__1(Transform x); // 0x000000018054F370-0x000000018054F3D0
			internal VRMSpringBoneColliderGroup _CopyVRMComponents_b__2(VRMSpringBoneColliderGroup x); // 0x000000018054F3D0-0x000000018054F460
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_1 // TypeDefIndex: 8088
		{
			// Fields
			public VRMSpringBoneColliderGroup src; // 0x10
			public Transform dst; // 0x18
	
			// Constructors
			public __c__DisplayClass2_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal VRMSpringBoneColliderGroup.SphereCollider _CopyVRMComponents_b__0(VRMSpringBoneColliderGroup.SphereCollider y); // 0x000000018054F700-0x000000018054F900
		}
	
		// Methods
		public static void EnforceTPose(GameObject go); // 0x00000001803401F0-0x0000000180340430
		public static GameObject Execute(GameObject go, bool forceTPose); // 0x0000000180340430-0x0000000180340660
		private static void CopyVRMComponents(GameObject go, GameObject root, Dictionary<Transform, Transform> map); // 0x000000018033F630-0x00000001803401F0
	}
}
