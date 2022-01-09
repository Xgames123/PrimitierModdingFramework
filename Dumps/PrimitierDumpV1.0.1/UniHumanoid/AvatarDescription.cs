/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	[Serializable]
	public class AvatarDescription : ScriptableObject // TypeDefIndex: 5937
	{
		// Fields
		public float armStretch; // 0x18
		public float legStretch; // 0x1C
		public float upperArmTwist; // 0x20
		public float lowerArmTwist; // 0x24
		public float upperLegTwist; // 0x28
		public float lowerLegTwist; // 0x2C
		public float feetSpacing; // 0x30
		public bool hasTranslationDoF; // 0x34
		public BoneLimit[] human; // 0x38
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5935
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, Transform> __9__11_0; // 0x08
			public static Func<Transform, Vector3> __9__11_1; // 0x10
			public static Func<KeyValuePair<HumanBodyBones, Transform>, BoneLimit> __9__16_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001812BDCF0-0x00000001812BDD50
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Transform _CreateAvatarAndSetup_b__11_0(Transform x); // 0x00000001802D5FD0-0x00000001802D5FE0
			internal Vector3 _CreateAvatarAndSetup_b__11_1(Transform x); // 0x00000001812BCF00-0x00000001812BCF40
			internal BoneLimit _SetHumanBones_b__16_0(KeyValuePair<HumanBodyBones, Transform> x); // 0x00000001812BD6F0-0x00000001812BD7B0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 5936
		{
			// Fields
			public Transform[] boneTransforms; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal KeyValuePair<HumanBodyBones, Transform> _Create_b__0(KeyValuePair<HumanBodyBones, int> x); // 0x00000001812BD9B0-0x00000001812BDA60
		}
	
		// Constructors
		public AvatarDescription(); // 0x00000001812AB320-0x00000001812AB360
	
		// Methods
		public HumanDescription ToHumanDescription(Transform root); // 0x00000001812AAF30-0x00000001812AB320
		public Avatar CreateAvatar(Transform root); // 0x00000001812AA8B0-0x00000001812AA950
		public Avatar CreateAvatarAndSetup(Transform root); // 0x00000001812AA340-0x00000001812AA8B0
		public static AvatarDescription CreateFrom(HumanDescription description); // 0x00000001812AA950-0x00000001812AAAE0
		public static AvatarDescription Create(AvatarDescription src = null); // 0x00000001812AAAE0-0x00000001812AAC10
		public static AvatarDescription Create(Transform[] boneTransforms, Skeleton skeleton); // 0x00000001812AAD00-0x00000001812AADE0
		public static AvatarDescription Create(IEnumerable<KeyValuePair<HumanBodyBones, Transform>> skeleton); // 0x00000001812AAC10-0x00000001812AAD00
		public void SetHumanBones(IEnumerable<KeyValuePair<HumanBodyBones, Transform>> skeleton); // 0x00000001812AADE0-0x00000001812AAF30
	}
}
