/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class VectorPidController // TypeDefIndex: 8650
{
	// Fields
	private float kp; // 0x10
	private float ki; // 0x14
	private float kd; // 0x18
	private Vector3 integral; // 0x1C
	private Vector3 prevError; // 0x28

	// Constructors
	public VectorPidController(float kp, float ki, float kd); // 0x0000000180487820-0x0000000180487870

	// Methods
	public Vector3 CalculateU(Vector3 error, float deltaTime, Vector3 minU, Vector3 maxU); // 0x0000000180B5CE70-0x0000000180B5D1A0
}

