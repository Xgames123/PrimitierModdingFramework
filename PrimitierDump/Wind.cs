/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Wind : MonoBehaviour // TypeDefIndex: 8635
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float maxSpeed; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float maxAngleSpeed; // 0x1C
	private static float angle; // 0x00
	private static Vector3 velocity; // 0x04
	private static float seed; // 0x10

	// Constructors
	public Wind(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180B5F8E0-0x0000000180B5F940
	private void FixedUpdate(); // 0x0000000180B5F320-0x0000000180B5F540
	public static Vector3 GetVelocity(Vector3 pos); // 0x0000000180B5F540-0x0000000180B5F740
	private void OnDrawGizmosSelected(); // 0x0000000180B5F740-0x0000000180B5F8E0
}

