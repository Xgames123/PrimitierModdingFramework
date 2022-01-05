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
	public static class V3Tools // TypeDefIndex: 8294
	{
		// Methods
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x000000018071B1C0-0x000000018071B2B0
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x000000018071B650-0x000000018071B6E0
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight); // 0x000000018071B100-0x000000018071B1C0
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight); // 0x000000018071B000-0x000000018071B100
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed); // 0x000000018071ABC0-0x000000018071ADC0
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue); // 0x000000018071ADC0-0x000000018071B000
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint); // 0x000000018071B2B0-0x000000018071B450
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal); // 0x000000018071B450-0x000000018071B650
	}
}
