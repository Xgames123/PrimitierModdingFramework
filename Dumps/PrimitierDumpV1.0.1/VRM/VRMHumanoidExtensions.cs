/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniHumanoid;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public static class VRMHumanoidExtensions // TypeDefIndex: 8006
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 8003
		{
			// Fields
			public VRMBone key; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _SetNodeIndex_b__0(glTF_VRM_HumanoidBone x); // 0x000000018054DF80-0x000000018054DFE0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 8004
		{
			// Fields
			public BoneLimit x; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Apply_b__1(Transform y); // 0x000000018054E9C0-0x000000018054EA00
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_1 // TypeDefIndex: 8005
		{
			// Fields
			public VRMBone key; // 0x10
	
			// Constructors
			public __c__DisplayClass1_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Apply_b__0(glTF_VRM_HumanoidBone y); // 0x000000018054DF80-0x000000018054DFE0
		}
	
		// Extension methods
		public static void SetNodeIndex(this glTF_VRM_Humanoid self, HumanBodyBones _key, int node); // 0x00000001803444F0-0x00000001803446D0
		public static void Apply(this glTF_VRM_Humanoid self, AvatarDescription desc, List<Transform> nodes); // 0x00000001803441D0-0x00000001803444F0
		public static AvatarDescription ToDescription(this glTF_VRM_Humanoid self, List<Transform> nodes); // 0x00000001803446D0-0x0000000180344A20
	}
}
