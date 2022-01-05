/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class VelocityPidController // TypeDefIndex: 8651
{
	// Fields
	private float kp; // 0x10
	private float ki; // 0x14
	private float kd; // 0x18
	private float prevError; // 0x1C
	private float prevDerivative; // 0x20
	private float prevU; // 0x24

	// Constructors
	public VelocityPidController(float kp, float ki, float kd); // 0x0000000180487820-0x0000000180487870

	// Methods
	private float CalculateDeltaU(float error, float deltaTime); // 0x0000000180B5D1A0-0x0000000180B5D1E0
	public float CalculateU(float error, float deltaTime, float minU, float maxU); // 0x0000000180B5D1E0-0x0000000180B5D260
}

