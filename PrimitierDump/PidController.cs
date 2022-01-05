/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class PidController // TypeDefIndex: 8649
{
	// Fields
	private float kp; // 0x10
	private float ki; // 0x14
	private float kd; // 0x18
	private float integral; // 0x1C
	private float prevError; // 0x20

	// Constructors
	public PidController(float kp, float ki, float kd); // 0x0000000180487820-0x0000000180487870

	// Methods
	public float CalculateU(float error, float deltaTime, float minU, float maxU); // 0x0000000180487760-0x0000000180487820
}

