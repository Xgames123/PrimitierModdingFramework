/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public static class Matrix4x4Extensions // TypeDefIndex: 8073
	{
		// Extension methods
		public static void CalcYawPitch(this Matrix4x4 m, Vector3 target, out float yaw, out float pitch); // 0x000000018033BBA0-0x000000018033BFA0
		public static Quaternion YawPitchRotation(this Matrix4x4 m, float yaw, float pitch); // 0x000000018033C170-0x000000018033C290
		public static Matrix4x4 RotationToWorldAxis(this Matrix4x4 m); // 0x000000018033BFA0-0x000000018033C170
	}
}
