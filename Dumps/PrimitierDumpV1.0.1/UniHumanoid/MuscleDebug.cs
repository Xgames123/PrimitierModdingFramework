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
	public class MuscleDebug : MonoBehaviour // TypeDefIndex: 5976
	{
		// Fields
		private HumanPoseHandler m_handler; // 0x18
		public HumanPose m_pose; // 0x20
		public Vector3 BodyPosition; // 0x48
		public Muscle[] Muscles; // 0x58
	
		// Nested types
		[Serializable]
		public struct Muscle // TypeDefIndex: 5974
		{
			// Fields
			public int Index; // 0x00
			public string Name; // 0x08
			public float Value; // 0x10
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5975
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, int, Muscle> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001812BDD50-0x00000001812BDDB0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Muscle _OnEnable_b__6_0(string x, int i); // 0x00000001812BD3E0-0x00000001812BD420
		}
	
		// Constructors
		public MuscleDebug(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private Avatar GetAvatar(); // 0x00000001812B90C0-0x00000001812B9240
		private void OnEnable(); // 0x00000001812B9240-0x00000001812B9570
		private void OnDisable(); // 0x0000000180265310-0x0000000180265320
		private void Update(); // 0x00000001812B9570-0x00000001812B9620
	}
}
