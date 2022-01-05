/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Slime : MonoBehaviour, ICubeBehavior // TypeDefIndex: 8615
{
	// Fields
	private CubeDriver driver; // 0x18
	private CubeBase cubeBase; // 0x20
	private int frame; // 0x28
	private float jumpTimer; // 0x2C
	private bool isInheritable; // 0x30
	private float forceMlp; // 0x34
	private Vector3 fastestColPosition; // 0x38
	private static readonly float referenceVolume; // 0x00
	private static readonly int updateInterval; // 0x04
	private static readonly float searchRadius; // 0x08
	private static readonly float jumpPower; // 0x0C
	private static readonly float eatJumpAngle; // 0x10
	private static readonly float torque; // 0x14
	private static readonly float jumpCoolTime; // 0x18
	private static readonly float forceMlpExp; // 0x1C
	private static readonly float recoveryMlp; // 0x20
	private static readonly float speedThreshold; // 0x24
	private static readonly float collisionSearchRadius; // 0x28
	private static readonly List<Substance> edibleSubstances; // 0x30

	// Constructors
	public Slime(); // 0x0000000180265240-0x0000000180265250
	static Slime(); // 0x0000000180B536F0-0x0000000180B538D0

	// Methods
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180B53150-0x0000000180B531C0
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180B52E30-0x0000000180B53150
	private void Start(); // 0x0000000180B53670-0x0000000180B536F0
	private void OnScaleChanged(); // 0x0000000180B531C0-0x0000000180B532D0
	private void FixedUpdate(); // 0x0000000180B52CC0-0x0000000180B52E30
	private void SparseUpdate(); // 0x0000000180B532D0-0x0000000180B53670
}

