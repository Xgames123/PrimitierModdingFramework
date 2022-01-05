/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class SciFiLightFlicker : MonoBehaviour // TypeDefIndex: 8556
{
	// Fields
	public string waveFunction; // 0x18
	public float startValue; // 0x20
	public float amplitude; // 0x24
	public float phase; // 0x28
	public float frequency; // 0x2C
	private Color originalColor; // 0x30

	// Constructors
	public SciFiLightFlicker(); // 0x0000000180B500B0-0x0000000180B50100

	// Methods
	private void Start(); // 0x0000000180B4FFB0-0x0000000180B50010
	private void Update(); // 0x0000000180B50010-0x0000000180B500B0
	private float EvalWave(); // 0x0000000180B4FDE0-0x0000000180B4FFB0
}

