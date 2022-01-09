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
	public class HandPoseModifier : IPoseModifier // TypeDefIndex: 5927
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private HandPose _LeftHandPose_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private HandPose _RightHandPose_k__BackingField; // 0x18
		private int LeftThumb1Stretched; // 0x20
		private int LeftThumb2Stretched; // 0x24
		private int LeftThumb3Stretched; // 0x28
		private int LeftIndex1Stretched; // 0x2C
		private int LeftIndex2Stretched; // 0x30
		private int LeftIndex3Stretched; // 0x34
		private int LeftMiddle1Stretched; // 0x38
		private int LeftMiddle2Stretched; // 0x3C
		private int LeftMiddle3Stretched; // 0x40
		private int LeftRing1Stretched; // 0x44
		private int LeftRing2Stretched; // 0x48
		private int LeftRing3Stretched; // 0x4C
		private int LeftLittle1Stretched; // 0x50
		private int LeftLittle2Stretched; // 0x54
		private int LeftLittle3Stretched; // 0x58
		private int LeftThumbSpread; // 0x5C
		private int LeftIndexSpread; // 0x60
		private int LeftMiddleSpread; // 0x64
		private int LeftRingSpread; // 0x68
		private int LeftLittleSpread; // 0x6C
		private int RightThumb1Stretched; // 0x70
		private int RightThumb2Stretched; // 0x74
		private int RightThumb3Stretched; // 0x78
		private int RightIndex1Stretched; // 0x7C
		private int RightIndex2Stretched; // 0x80
		private int RightIndex3Stretched; // 0x84
		private int RightMiddle1Stretched; // 0x88
		private int RightMiddle2Stretched; // 0x8C
		private int RightMiddle3Stretched; // 0x90
		private int RightRing1Stretched; // 0x94
		private int RightRing2Stretched; // 0x98
		private int RightRing3Stretched; // 0x9C
		private int RightLittle1Stretched; // 0xA0
		private int RightLittle2Stretched; // 0xA4
		private int RightLittle3Stretched; // 0xA8
		private int RightThumbSpread; // 0xAC
		private int RightIndexSpread; // 0xB0
		private int RightMiddleSpread; // 0xB4
		private int RightRingSpread; // 0xB8
		private int RightLittleSpread; // 0xBC
	
		// Properties
		public HandPose LeftHandPose { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public HandPose RightHandPose { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
	
		// Nested types
		public class HandPose // TypeDefIndex: 5926
		{
			// Fields
			public float ThumbStretch; // 0x10
			public float ThumbSpread; // 0x14
			public float IndexStretch; // 0x18
			public float IndexSpread; // 0x1C
			public float MiddleStretch; // 0x20
			public float MiddleSpread; // 0x24
			public float RingStretch; // 0x28
			public float RingSpread; // 0x2C
			public float LittleStretch; // 0x30
			public float LittleSpread; // 0x34
	
			// Properties
			[Obsolete] // 0x000000018004DC60-0x000000018004DC90
			public float ThumbStrech { get; set; } // 0x000000018036C100-0x000000018036C110 0x000000018036C190-0x000000018036C1A0
			[Obsolete] // 0x000000018004DC90-0x000000018004DCC0
			public float IndexStrech { get; set; } // 0x0000000180304A20-0x0000000180304A30 0x0000000180304A30-0x0000000180304A40
			[Obsolete] // 0x000000018004DCC0-0x000000018004DCF0
			public float MiddleStrech { get; set; } // 0x00000001803374D0-0x00000001803374E0 0x00000001803374E0-0x00000001803374F0
			[Obsolete] // 0x000000018004DCF0-0x000000018004DD20
			public float RingStrech { get; set; } // 0x000000018036B100-0x000000018036B110 0x000000018036B600-0x000000018036B610
			[Obsolete] // 0x000000018004DD20-0x000000018004DD50
			public float LittleStrech { get; set; } // 0x00000001803496C0-0x00000001803496D0 0x000000018036B200-0x000000018036B210
	
			// Constructors
			public HandPose(); // 0x00000001802650F0-0x0000000180265100
		}
	
		// Constructors
		public HandPoseModifier(); // 0x00000001812B5160-0x00000001812B58B0
	
		// Methods
		public void Modify(ref HumanPose pose); // 0x00000001812B4750-0x00000001812B5160
	}
}
