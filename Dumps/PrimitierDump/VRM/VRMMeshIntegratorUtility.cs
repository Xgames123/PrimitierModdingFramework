/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MeshUtility;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public static class VRMMeshIntegratorUtility // TypeDefIndex: 8092
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 8090
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MeshIntegrationResult, bool> __9__0_0; // 0x08
			public static Func<SkinnedMeshRenderer, SkinnedMeshRenderer> __9__2_1; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180550560-0x00000001805505C0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _IntegrateRuntime_b__0_0(MeshIntegrationResult x); // 0x000000018054DB90-0x000000018054DC00
			internal SkinnedMeshRenderer _FollowBlendshapeRendererChange_b__2_1(SkinnedMeshRenderer x); // 0x00000001802D5FD0-0x00000001802D5FE0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 8091
		{
			// Fields
			public GameObject root; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _FollowBlendshapeRendererChange_b__0(SkinnedMeshRenderer x); // 0x000000018054F460-0x000000018054F4B0
		}
	
		// Methods
		public static bool IntegrateRuntime(GameObject vrmRootObject); // 0x000000018034DC20-0x000000018034E300
		public static List<MeshIntegrationResult> Integrate(GameObject root, List<BlendShapeClip> blendshapeClips); // 0x000000018034E300-0x000000018034E480
		private static void FollowBlendshapeRendererChange(List<BlendShapeClip> clips, MeshIntegrationResult result, GameObject root); // 0x000000018034D6F0-0x000000018034DC20
	}
}
