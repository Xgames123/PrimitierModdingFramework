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
	public class BvhSkeletonEstimator : ISkeletonDetector // TypeDefIndex: 5983
	{
		// Nested types
		private struct Arm // TypeDefIndex: 5980
		{
			// Fields
			public IBone Shoulder; // 0x00
			public IBone UpperArm; // 0x08
			public IBone LowerArm; // 0x10
			public IBone Hand; // 0x18
		}
	
		private struct Leg // TypeDefIndex: 5981
		{
			// Fields
			public IBone UpperLeg; // 0x00
			public IBone LowerLeg; // 0x08
			public IBone Foot; // 0x10
			public IBone Toes; // 0x18
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5982
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IBone, bool> __9__0_0; // 0x08
			public static Func<IBone, IBone, IBone> __9__2_0; // 0x10
			public static Func<IBone, IBone, IBone> __9__2_1; // 0x18
			public static Func<IBone, IBone, IBone> __9__2_2; // 0x20
			public static Func<IBone, IBone, IBone> __9__3_0; // 0x28
			public static Func<IBone, IBone, IBone> __9__3_1; // 0x30
			public static Func<IBone, IBone, IBone> __9__3_2; // 0x38
			public static Func<IBone, bool> __9__7_0; // 0x40
			public static Func<IBone, bool> __9__8_0; // 0x48
			public static Func<IBone, bool> __9__8_1; // 0x50
			public static Func<BvhBone, IBone> __9__9_0; // 0x58
			public static Func<BvhBone, IBone> __9__10_0; // 0x60
	
			// Constructors
			static __c(); // 0x00000001812BDC90-0x00000001812BDCF0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetRoot_b__0_0(IBone x); // 0x00000001812BD390-0x00000001812BD3E0
			internal IBone _GetSpineAndHips_b__2_0(IBone l, IBone r); // 0x00000001812BD270-0x00000001812BD2D0
			internal IBone _GetSpineAndHips_b__2_1(IBone l, IBone r); // 0x00000001812BD2D0-0x00000001812BD330
			internal IBone _GetSpineAndHips_b__2_2(IBone l, IBone r); // 0x00000001812BD330-0x00000001812BD390
			internal IBone _GetNeckAndArms_b__3_0(IBone l, IBone r); // 0x00000001812BD270-0x00000001812BD2D0
			internal IBone _GetNeckAndArms_b__3_1(IBone l, IBone r); // 0x00000001812BD2D0-0x00000001812BD330
			internal IBone _GetNeckAndArms_b__3_2(IBone l, IBone r); // 0x00000001812BD330-0x00000001812BD390
			internal bool _GetLeg_b__7_0(IBone x); // 0x00000001812BD1F0-0x00000001812BD270
			internal bool _Detect_b__8_0(IBone x); // 0x00000001812BCF40-0x00000001812BCFC0
			internal bool _Detect_b__8_1(IBone x); // 0x00000001812BCFC0-0x00000001812BD050
			internal IBone _Detect_b__9_0(BvhBone x); // 0x00000001802D5FD0-0x00000001802D5FE0
			internal IBone _Detect_b__10_0(BvhBone x); // 0x00000001802D5FD0-0x00000001802D5FE0
		}
	
		// Constructors
		public BvhSkeletonEstimator(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		private static IBone GetRoot(IList<IBone> bones); // 0x00000001812B0B30-0x00000001812B0CD0
		private static IBone SelectBone(Func<IBone, IBone, IBone> selector, IList<IBone> bones); // 0x00000001812B1040-0x00000001812B1260
		private static void GetSpineAndHips(IBone hips, out IBone spine, out IBone leg_L, out IBone leg_R); // 0x00000001812B0CD0-0x00000001812B1040
		private static void GetNeckAndArms(IBone chest, out IBone neck, out IBone arm_L, out IBone arm_R); // 0x00000001812B07C0-0x00000001812B0B30
		private Arm GetArm(IBone shoulder); // 0x00000001812B0340-0x00000001812B04B0
		private Leg GetLeg(IBone leg); // 0x00000001812B04B0-0x00000001812B07C0
		public Skeleton Detect(IList<IBone> bones); // 0x00000001812AF6F0-0x00000001812B0340
		public Skeleton Detect(Bvh bvh); // 0x00000001812AF470-0x00000001812AF6F0
		public Skeleton Detect(Transform t); // 0x00000001812AF200-0x00000001812AF470
	}
}
