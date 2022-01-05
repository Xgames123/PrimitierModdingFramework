/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Plant : MonoBehaviour // TypeDefIndex: 8645
{
	// Fields
	private float targetLength; // 0x18
	private Vector3 initialScale; // 0x1C
	private float branchAngle; // 0x28
	public float nutrient; // 0x2C
	private CubeConnector cubeConnector; // 0x30

	// Constructors
	public Plant(); // 0x0000000180488100-0x0000000180488110

	// Methods
	private void Start(); // 0x0000000180488060-0x0000000180488100
	private void FixedUpdate(); // 0x0000000180487870-0x0000000180487E70
	private void GenerateSprout(Vector3 pos, Quaternion rot); // 0x0000000180487E70-0x0000000180488060
}

