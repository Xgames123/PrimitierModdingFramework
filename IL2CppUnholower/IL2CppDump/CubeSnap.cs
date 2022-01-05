/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public static class CubeSnap // TypeDefIndex: 8598
{
	// Fields
	private static readonly float snapAngleRange; // 0x00
	private static readonly float snapDistanceRange; // 0x04
	private static Collider[] colBuffer; // 0x08

	// Nested types
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private struct __c__DisplayClass3_0 // TypeDefIndex: 8596
	{
		// Fields
		public Transform free; // 0x00
		public Vector3 initialParentPos; // 0x08
		public Quaternion initialParentRot; // 0x14
	}

	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class __c__DisplayClass3_1 // TypeDefIndex: 8597
	{
		// Fields
		public Vector3 lockedScale; // 0x10
		public int i; // 0x1C
		public Converter<float, float> __9__1; // 0x20

		// Constructors
		public __c__DisplayClass3_1(); // 0x00000001802650F0-0x0000000180265100

		// Methods
		internal float _Snap_b__1(float pos); // 0x0000000180888800-0x0000000180888830
	}

	// Constructors
	static CubeSnap(); // 0x0000000180547260-0x00000001805472E0

	// Methods
	public static void Snap(Transform free, Transform locked, Vector3 contactPos, bool lockedIsGround); // 0x0000000180545FA0-0x0000000180547080
	private static int SearchSnapDirectionIndex(Vector3 reference, Vector3[] snapDirections); // 0x0000000180545E80-0x0000000180545FA0
	private static void RotateAround(Transform transform, Vector3 point, Quaternion rot); // 0x0000000180545D00-0x0000000180545E80
	private static Vector3 SwapVector(Vector3 vector, int forwardSnapIndex, int upwardSnapIndex); // 0x0000000180547080-0x00000001805471E0
	private static bool CheckOverlap(Transform cubeTransform); // 0x0000000180545840-0x0000000180545D00
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	internal static void _Snap_g__CancelSnap_3_0(ref __c__DisplayClass3_0 param_0000fa93); // 0x00000001805471E0-0x0000000180547260
}

