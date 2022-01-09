/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public static class RotationLimitUtilities // TypeDefIndex: 8420
	{
		// Methods
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle); // 0x00000001807152E0-0x0000000180715680
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis); // 0x0000000180714E40-0x0000000180714F10
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit); // 0x0000000180714F10-0x00000001807152E0
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit); // 0x0000000180715680-0x00000001807158A0
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit); // 0x00000001807158A0-0x0000000180715A80
	}
}
