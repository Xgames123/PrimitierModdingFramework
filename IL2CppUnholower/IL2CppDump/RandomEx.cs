/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class RandomEx // TypeDefIndex: 8663
{
	// Fields
	private UnityEngine.Random.State state; // 0x10

	// Properties
	public float Value { get; } // 0x0000000180B47080-0x0000000180B47100 

	// Constructors
	public RandomEx(int seed); // 0x0000000180B47010-0x0000000180B47080

	// Methods
	public void InitState(int seed); // 0x0000000180B46DD0-0x0000000180B46E40
	public int Range(int min, int max); // 0x0000000180B46F80-0x0000000180B47010
	public float Range(float min, float max); // 0x0000000180B46EE0-0x0000000180B46F80
	public float PseudoND(float min, float max); // 0x0000000180B46E40-0x0000000180B46EE0
}

