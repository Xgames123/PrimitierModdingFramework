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
	public struct Skeleton // TypeDefIndex: 5978
	{
		// Fields
		private Dictionary<HumanBodyBones, int> m_indexMap; // 0x00
	
		// Properties
		public Dictionary<HumanBodyBones, int> Bones { get; } // 0x00000001802B6C10-0x00000001802B6C20 
	
		// Methods
		public int GetBoneIndex(HumanBodyBones bone); // 0x00000001812BB5F0-0x00000001812BB660
		public static Skeleton Estimate(Transform hips); // 0x00000001812BB580-0x00000001812BB5F0
		public void Set(HumanBodyBones bone, IList<IBone> bones, IBone b); // 0x00000001812BB710-0x00000001812BB840
		public void Set(HumanBodyBones bone, int index, string name); // 0x00000001812BB660-0x00000001812BB710
	}
}
