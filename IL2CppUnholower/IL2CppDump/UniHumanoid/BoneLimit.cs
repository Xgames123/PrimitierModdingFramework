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
	[Serializable]
	public struct BoneLimit // TypeDefIndex: 5934
	{
		// Fields
		public HumanBodyBones humanBone; // 0x00
		public string boneName; // 0x08
		public bool useDefaultValues; // 0x10
		public Vector3 min; // 0x14
		public Vector3 max; // 0x20
		public Vector3 center; // 0x2C
		public float axisLength; // 0x38
		private static string[] cashedHumanTraitBoneName; // 0x00
	
		// Constructors
		static BoneLimit(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public static BoneLimit From(HumanBone bone); // 0x00000001812AB420-0x00000001812AB660
		public static string ToHumanBoneName(HumanBodyBones b); // 0x00000001812AB660-0x00000001812AB870
		public HumanBone ToHumanBone(); // 0x00000001812AB870-0x00000001812ABA20
	}
}
