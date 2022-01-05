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
	public static class BvhAnimation // TypeDefIndex: 5964
	{
		// Nested types
		private class CurveSet // TypeDefIndex: 5963
		{
			// Fields
			private BvhNode Node; // 0x10
			private Func<float, float, float, Quaternion> EulerToRotation; // 0x18
			public ChannelCurve PositionX; // 0x20
			public ChannelCurve PositionY; // 0x28
			public ChannelCurve PositionZ; // 0x30
			public ChannelCurve RotationX; // 0x38
			public ChannelCurve RotationY; // 0x40
			public ChannelCurve RotationZ; // 0x48
	
			// Constructors
			public CurveSet(BvhNode node); // 0x00000001802A9A60-0x00000001802A9A90
	
			// Methods
			public Vector3 GetPosition(int i); // 0x00000001812B38D0-0x00000001812B3980
			public Quaternion GetRotation(int i); // 0x00000001812B3980-0x00000001812B3C60
			private static void AddCurve(Bvh bvh, AnimationClip clip, ChannelCurve ch, float scaling); // 0x00000001812B3300-0x00000001812B34C0
			public void AddCurves(Bvh bvh, AnimationClip clip, float scaling); // 0x00000001812B34C0-0x00000001812B38D0
		}
	
		// Methods
		public static AnimationClip CreateAnimationClip(Bvh bvh, float scaling); // 0x00000001812ACCA0-0x00000001812AD270
	}
}
