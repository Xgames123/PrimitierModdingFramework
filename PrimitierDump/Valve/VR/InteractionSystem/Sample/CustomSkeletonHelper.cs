/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class CustomSkeletonHelper : MonoBehaviour // TypeDefIndex: 7521
	{
		// Fields
		public Retargetable wrist; // 0x18
		public Finger[] fingers; // 0x20
		public Thumb[] thumbs; // 0x28
	
		// Nested types
		public enum MirrorType // TypeDefIndex: 7517
		{
			None = 0,
			LeftToRight = 1,
			RightToLeft = 2
		}
	
		[Serializable]
		public class Retargetable // TypeDefIndex: 7518
		{
			// Fields
			public Transform source; // 0x10
			public Transform destination; // 0x18
	
			// Constructors
			public Retargetable(Transform source, Transform destination); // 0x000000018028A110-0x000000018028A150
		}
	
		[Serializable]
		public class Thumb // TypeDefIndex: 7519
		{
			// Fields
			public Retargetable metacarpal; // 0x10
			public Retargetable middle; // 0x18
			public Retargetable distal; // 0x20
			public Transform aux; // 0x28
	
			// Constructors
			public Thumb(Retargetable metacarpal, Retargetable middle, Retargetable distal, Transform aux); // 0x0000000180296340-0x00000001802963A0
		}
	
		[Serializable]
		public class Finger // TypeDefIndex: 7520
		{
			// Fields
			public Retargetable metacarpal; // 0x10
			public Retargetable proximal; // 0x18
			public Retargetable middle; // 0x20
			public Retargetable distal; // 0x28
			public Transform aux; // 0x30
	
			// Constructors
			public Finger(Retargetable metacarpal, Retargetable proximal, Retargetable middle, Retargetable distal, Transform aux); // 0x000000018028F630-0x000000018028F690
		}
	
		// Constructors
		public CustomSkeletonHelper(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Update(); // 0x000000018058FA90-0x000000018058FE40
	}
}
