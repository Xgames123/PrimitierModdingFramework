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
	public class BoneMapping : MonoBehaviour // TypeDefIndex: 5940
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public GameObject[] Bones; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public AvatarDescription Description; // 0x20
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5939
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<GameObject, int, __f__AnonymousType0<int, GameObject>> __9__5_0; // 0x08
			public static Func<__f__AnonymousType0<int, GameObject>, bool> __9__5_1; // 0x10
			public static Func<__f__AnonymousType0<int, GameObject>, HumanBodyBones> __9__5_2; // 0x18
			public static Func<__f__AnonymousType0<int, GameObject>, Transform> __9__5_3; // 0x20
			public static Func<GameObject, int, __f__AnonymousType0<int, GameObject>> __9__6_0; // 0x28
			public static Func<__f__AnonymousType0<int, GameObject>, bool> __9__6_1; // 0x30
			public static Func<__f__AnonymousType0<int, GameObject>, HumanBodyBones> __9__6_2; // 0x38
			public static Func<__f__AnonymousType0<int, GameObject>, Transform> __9__6_3; // 0x40
			public static Func<GameObject, bool> __9__7_0; // 0x48
	
			// Constructors
			static __c(); // 0x00000001812BDE10-0x00000001812BDE70
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal __f__AnonymousType0<int, GameObject> _EnsureTPose_b__5_0(GameObject x, int i); // 0x00000001812BD050-0x00000001812BD0D0
			internal bool _EnsureTPose_b__5_1(__f__AnonymousType0<int, GameObject> x); // 0x00000001812BD0D0-0x00000001812BD140
			internal HumanBodyBones _EnsureTPose_b__5_2(__f__AnonymousType0<int, GameObject> x); // 0x00000001812BD140-0x00000001812BD180
			internal Transform _EnsureTPose_b__5_3(__f__AnonymousType0<int, GameObject> x); // 0x00000001812BD180-0x00000001812BD1D0
			internal __f__AnonymousType0<int, GameObject> _SetBonesToDescription_b__6_0(GameObject x, int i); // 0x00000001812BD570-0x00000001812BD5F0
			internal bool _SetBonesToDescription_b__6_1(__f__AnonymousType0<int, GameObject> x); // 0x00000001812BD5F0-0x00000001812BD660
			internal HumanBodyBones _SetBonesToDescription_b__6_2(__f__AnonymousType0<int, GameObject> x); // 0x00000001812BD660-0x00000001812BD6A0
			internal Transform _SetBonesToDescription_b__6_3(__f__AnonymousType0<int, GameObject> x); // 0x00000001812BD6A0-0x00000001812BD6F0
			internal bool _Awake_b__7_0(GameObject x); // 0x00000001812BCEA0-0x00000001812BCF00
		}
	
		// Constructors
		public BoneMapping(); // 0x00000001812ACC50-0x00000001812ACCA0
	
		// Methods
		private void Reset(); // 0x00000001812AC860-0x00000001812AC870
		private void GetBones(); // 0x00000001812AC250-0x00000001812AC5B0
		public void GuessBoneMapping(); // 0x00000001812AC5B0-0x00000001812AC860
		public void EnsureTPose(); // 0x00000001812ABB60-0x00000001812AC250
		public static void SetBonesToDescription(BoneMapping mapping, AvatarDescription description); // 0x00000001812AC870-0x00000001812ACC50
		private void Awake(); // 0x00000001812ABA20-0x00000001812ABB60
	}
}
