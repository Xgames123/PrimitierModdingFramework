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
	public static class VRMSpringUtility // TypeDefIndex: 8103
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 8101
		{
			// Fields
			public List<VRMSpringBoneColliderGroup> colliders; // 0x10
			public List<Transform> nodes; // 0x18
			public Func<VRMSpringBoneColliderGroup, int> __9__5; // 0x20
			public Func<Transform, int> __9__7; // 0x28
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal int _ExportSecondary_b__5(VRMSpringBoneColliderGroup x); // 0x000000018054DEC0-0x000000018054DF20
			internal int _ExportSecondary_b__7(Transform x); // 0x000000018054DF20-0x000000018054DF80
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 8102
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, VRMSpringBoneColliderGroup> __9__0_0; // 0x08
			public static Func<VRMSpringBoneColliderGroup, bool> __9__0_1; // 0x10
			public static Func<VRMSpringBoneColliderGroup.SphereCollider, glTF_VRM_SecondaryAnimationCollider> __9__0_2; // 0x18
			public static Func<Transform, IEnumerable<VRMSpringBone>> __9__0_3; // 0x20
			public static Func<VRMSpringBone, bool> __9__0_4; // 0x28
			public static Func<int, bool> __9__0_6; // 0x30
			public static Func<glTF_VRM_SecondaryAnimationCollider, VRMSpringBoneColliderGroup.SphereCollider> __9__1_0; // 0x38
	
			// Constructors
			static __c(); // 0x00000001805504A0-0x0000000180550500
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal VRMSpringBoneColliderGroup _ExportSecondary_b__0_0(Transform x); // 0x000000018054D860-0x000000018054D8B0
			internal bool _ExportSecondary_b__0_1(VRMSpringBoneColliderGroup x); // 0x000000018054D8B0-0x000000018054D910
			internal glTF_VRM_SecondaryAnimationCollider _ExportSecondary_b__0_2(VRMSpringBoneColliderGroup.SphereCollider x); // 0x000000018054D910-0x000000018054D990
			internal IEnumerable<VRMSpringBone> _ExportSecondary_b__0_3(Transform x); // 0x000000018054D990-0x000000018054D9E0
			internal bool _ExportSecondary_b__0_4(VRMSpringBone x); // 0x000000018054D9E0-0x000000018054DA40
			internal bool _ExportSecondary_b__0_6(int x); // 0x000000018054DA40-0x000000018054DA50
			internal VRMSpringBoneColliderGroup.SphereCollider _LoadSecondary_b__1_0(glTF_VRM_SecondaryAnimationCollider x); // 0x000000018054DCC0-0x000000018054DD40
		}
	
		// Methods
		public static void ExportSecondary(Transform root, List<Transform> nodes, Action<glTF_VRM_SecondaryAnimationColliderGroup> addSecondaryColliderGroup, Action<glTF_VRM_SecondaryAnimationGroup> addSecondaryGroup); // 0x0000000180553960-0x0000000180554580
		public static void LoadSecondary(Transform root, List<Transform> nodes, glTF_VRM_SecondaryAnimation secondaryAnimation); // 0x0000000180554580-0x00000001805550E0
	}
}
