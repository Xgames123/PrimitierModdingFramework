/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	public static class QuaTools // TypeDefIndex: 8290
	{
		// Methods
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x0000000180779F60-0x0000000180779FD0
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x000000018077A220-0x000000018077A290
		public static Quaternion LinearBlend(Quaternion q, float weight); // 0x0000000180779FD0-0x000000018077A070
		public static Quaternion SphericalBlend(Quaternion q, float weight); // 0x000000018077A290-0x000000018077A330
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis); // 0x0000000180779B10-0x0000000180779C60
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation); // 0x000000018077A1A0-0x000000018077A220
		public static Quaternion FromToRotation(Quaternion from, Quaternion to); // 0x0000000180779C60-0x0000000180779D10
		public static Vector3 GetAxis(Vector3 v); // 0x0000000180779D10-0x0000000180779F60
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing); // 0x0000000180779920-0x0000000180779B10
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing); // 0x00000001807797F0-0x0000000180779920
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis); // 0x000000018077A070-0x000000018077A1A0
	}
}
