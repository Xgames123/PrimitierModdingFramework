/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class VelocityVectorPidController // TypeDefIndex: 8652
{
	// Fields
	private float kp; // 0x10
	private float ki; // 0x14
	private float kd; // 0x18
	private Vector3 prevError; // 0x1C
	private Vector3 prevDerivative; // 0x28
	private Vector3 prevU; // 0x34

	// Constructors
	public VelocityVectorPidController(float kp, float ki, float kd); // 0x0000000180487820-0x0000000180487870

	// Methods
	private Vector3 CalculateDeltaU(Vector3 error, float deltaTime); // 0x0000000180B5D260-0x0000000180B5D3F0
	public Vector3 CalculateU(Vector3 error, float deltaTime, Vector3 minU, Vector3 maxU); // 0x0000000180B5D3F0-0x0000000180B5D660
}

